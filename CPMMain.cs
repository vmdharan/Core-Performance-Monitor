using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Core_Performance_Monitor
{
    public partial class CPMMain : Form
    {
        [DllImport("dwmapi.dll")]
        private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);

        private const int DWMWA_USE_IMMERSIVE_DARK_MODE = 20;
        internal static bool Enable_DWMWA_USE_IMMERSIVE_DARK_MODE(IntPtr handle)
        {
            int enableDarkMode = 1;
            return DwmSetWindowAttribute(handle, DWMWA_USE_IMMERSIVE_DARK_MODE, ref enableDarkMode, sizeof(int)) == 0;
        }

        private const string APP_VERSION = "1.0.0";

        SystemInfo systemInfo = new SystemInfo();
        CacheInformation? caches;
        MemoryInformation? memory;
        ProcessorInformation? processorInformation;
        DeviceInformation? deviceInformation;
        ChronoInformation? chronoInformation;
        List<GraphicsInformation> graphicsInformation = new List<GraphicsInformation>();

        private const int BITMAP_WIDTH = 193;
        private const int BITMAP_HEIGHT = 88;
        private const int PEN_WIDTH = 1;
        private const int ELLIPSE_SIZE = 1;

        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        private const string REFRESH_FREQUENCY_1 = "1 second";
        private const string REFRESH_FREQUENCY_2 = "2 second";
        private const string REFRESH_FREQUENCY_5 = "5 second";
        private const string REFRESH_FREQUENCY_10 = "10 second";

        List<int> memoryUsage = new List<int>();
        float memoryUsagePct = 0.0f;

        List<int> cpuUsage = new List<int>();
        float cpuUsagePct = 0.0f;

        private Color PERFORMANCE_GRAPH_PEN_COLOR = Color.LightCyan;
        private Color MEMORY_GRAPH_PEN_COLOR = Color.Goldenrod;

        private Pen performanceGraphPen;
        private Pen memoryGraphPen;

        Bitmap performanceGraphBitmap = new Bitmap(BITMAP_WIDTH, BITMAP_HEIGHT);
        Bitmap memoryGraphBitmap = new Bitmap(BITMAP_WIDTH, BITMAP_HEIGHT);

        List<Rectangle> rectsPerformance;
        List<Rectangle> rectsMemory;

        private const double GRAPH_SIZE_THRESHOLD = (BITMAP_WIDTH * 1.0 / PEN_WIDTH);

        public CPMMain()
        {
            InitializeComponent();

            // Set the application version
            this.Text += " v" + APP_VERSION;

            // Set the titlebar theme.
            Enable_DWMWA_USE_IMMERSIVE_DARK_MODE(Handle);

            // Set the refresh frequencies.
            cbRefreshFrequency.Items.AddRange(new string[]
            {
                REFRESH_FREQUENCY_1,
                REFRESH_FREQUENCY_2,
                REFRESH_FREQUENCY_5,
                REFRESH_FREQUENCY_10
            });
            cbRefreshFrequency.SelectedIndex = 0;

            // Initialise pen and colour for graphs.
            performanceGraphPen = new Pen(PERFORMANCE_GRAPH_PEN_COLOR, PEN_WIDTH);
            memoryGraphPen = new Pen(MEMORY_GRAPH_PEN_COLOR, PEN_WIDTH);

            // Update statistics every tick.
            timer.Tick += new EventHandler(RefreshStatistics);
            timer.Interval = 1000;
            timer.Start();

            pbPerformanceGraph.Image = performanceGraphBitmap;
            pbMemoryGraph.Image = memoryGraphBitmap;

            rectsPerformance = new List<Rectangle>();
            rectsMemory = new List<Rectangle>();

            Initialise();
        }

        private void Initialise()
        {
            Task t1 = Task.Run(() => RetrieveDeviceInformation());
            Task t2 = Task.Run(() => RetrieveCacheInformation());
            Task t3 = Task.Run(() => RetrieveProcessorInformation());
            Task t4 = Task.Run(() => RetrieveGraphicsInformation());

            Task tLoading = Task.WhenAll([t1, t2, t3, t4]);
            try
            {
                tLoading.Wait();
            } catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            UpdateDeviceInformation();
            UpdateCacheInformation();
            UpdateProcessorInformation();
            UpdateGraphicsInformation();
        }

        private async void RefreshStatistics(object? sender, EventArgs e)
        {
            await Task.Run(() => RetrieveProcessorPerformanceCounter());
            await Task.Run(() => RetrieveMemoryInformation());
            await Task.Run(() => RetrieveChronoInformation());

            UpdatePerformancePanelInformation();
            UpdateMemoryInformation();
            UpdateChronoInformation();

            RenderPerformanceGraph();
            RenderMemoryGraph();

            GC.Collect();
        }

        private int ConvertPercentageToImageDimensions(int source)
        {
            int result = (int)(BITMAP_HEIGHT - (source / 100.0 * BITMAP_HEIGHT));

            return result;
        }

        private void RenderGraph(Bitmap bitmap, PictureBox pictureBox, List<int> sourceList, List<Rectangle> rects, Pen pen)
        {
            Graphics g1 = Graphics.FromImage(bitmap);
            g1.Clear(Color.FromArgb(0, 30, 71, 104));
            pictureBox.Image = bitmap;

            int NUMBER_OF_ENTRIES = sourceList.Count;
            int STARTING_POINT = BITMAP_WIDTH - ELLIPSE_SIZE * NUMBER_OF_ENTRIES;

            rects.Clear();
            for (int i = 0; i < sourceList.Count; i++)
            {
                int y = ConvertPercentageToImageDimensions(sourceList[i]);
                rects.Add(new Rectangle(STARTING_POINT + i * ELLIPSE_SIZE, y, ELLIPSE_SIZE, BITMAP_HEIGHT - y - ELLIPSE_SIZE));
            }

            using (Graphics g = Graphics.FromImage(bitmap))
            {
                foreach (Rectangle rectangle in rects)
                {
                    g.DrawEllipse(pen, rectangle);
                }
            }
        }

        private void RenderPerformanceGraph()
        {
            RenderGraph(performanceGraphBitmap, pbPerformanceGraph, cpuUsage, rectsPerformance, performanceGraphPen);
        }

        private void RenderMemoryGraph()
        {
            RenderGraph(memoryGraphBitmap, pbMemoryGraph, memoryUsage, rectsMemory, memoryGraphPen);
        }

        private void RetrieveGraphicsInformation()
        {
            graphicsInformation = systemInfo.GetGraphicsInformation();
        }

        private void RetrieveCacheInformation()
        {
            caches = systemInfo.GetCacheInformation(); 
        }

        private void RetrieveMemoryInformation()
        {
            memory = systemInfo.GetMemoryInformation();

            // Get information on the available system memory.
            try
            {
                using(PerformanceCounter availableMemoryPerformanceCounter = new PerformanceCounter("Memory", "Available MBytes"))
                {
                    ulong availableMemory = (ulong)availableMemoryPerformanceCounter.NextValue();

                    // Update the memory usage percentage.
                    if ((availableMemory > 0) && (memory.TotalMemory > 0))
                    {
                        memoryUsagePct = (((memory.TotalMemory - availableMemory) * 1.0f / memory.TotalMemory) * 100.0f);
                        memoryUsage.Add((int)memoryUsagePct);

                        // Pop element if greater than size threshold.
                        if (memoryUsage.Count > GRAPH_SIZE_THRESHOLD)
                        {
                            memoryUsage.RemoveAt(0);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void RetrieveDeviceInformation()
        {
            deviceInformation = systemInfo.GetDeviceInformation();
        }

        private void RetrieveProcessorInformation()
        {
            processorInformation = systemInfo.GetProcessorInformation();
        }

        private void RetrieveProcessorPerformanceCounter()
        {
            try
            {
                using (PerformanceCounter processorTimePerformanceCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total"))
                {
                    processorTimePerformanceCounter.NextValue();
                    Thread.Sleep(1000);
                    cpuUsagePct = processorTimePerformanceCounter.NextValue() * 1.0f;
                    cpuUsage.Add((int)cpuUsagePct);

                    // Pop element if greater than size threshold.
                    if (cpuUsage.Count > GRAPH_SIZE_THRESHOLD)
                    {
                        cpuUsage.RemoveAt(0);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void RetrieveChronoInformation()
        {
            var info = systemInfo.GetChronoInformation();
            if (chronoInformation == null)
            {
                chronoInformation = info;
            }
            else
            {
                chronoInformation.LocalDateTime = info.LocalDateTime;
            }
        }

        private void UpdateGraphicsInformation()
        {
            if(graphicsInformation == null)
            {
                return;
            }

            if(graphicsInformation.Count > 0)
            {
                lblGraphics1Value.Text = graphicsInformation[0].GPUName;
                lblGraphics1Driver.Text = graphicsInformation[0].GPUDriverVersion;

                if(graphicsInformation.Count > 1)
                {
                    lblGraphics2Value.Text = graphicsInformation[1].GPUName;
                    lblGraphics2Driver.Text = graphicsInformation[1].GPUDriverVersion;
                }
            }
            
        }

        private void UpdateCacheInformation()
        {
            if(caches == null)
            {
                return;
            }

            lblL1CacheSize.Text = caches.L1CacheSize.ToString() + " " + caches.L1SizeUnits;
            lblL2CacheSize.Text = caches.L2CacheSize.ToString() + " " + caches.L2SizeUnits;
            lblL3CacheSize.Text = caches.L3CacheSize.ToString() + " " + caches.L3SizeUnits;
        }

        private void UpdateMemoryInformation()
        {
            if (memory == null)
            {
                return;
            }

            lblFreeMemorySize.Text = memory.FreeMemory.ToString() + " " + memory.FreeMemorySizeUnits;
            lblTotalMemorySize.Text = memory.TotalMemory.ToString() + " " + memory.TotalMemorySizeUnits;
            lblFreeVirtualMemorySize.Text = memory.FreeVirtualMemory.ToString() + " " + memory.FreeVirtualMemorySizeUnits;
            lblTotalVirtualMemorySize.Text = memory.TotalVirtualMemory.ToString() + " " + memory.TotalVirtualMemorySizeUnits;
            lblFreeSpacePagingSize.Text = memory.FreeSpacePaging.ToString() + " " + memory.FreeSpacePagingSizeUnits;
            lblSizeStoredPagingSize.Text = memory.SizeStoredPaging.ToString() + " " + memory.SizeStoredPagingSizeUnits;
        }

        private void UpdateDeviceInformation()
        {
            if (deviceInformation == null)
            {
                return;
            }

            lblDeviceNameValue.Text = deviceInformation.DeviceName;
            lblOperatingSystemValue.Text = deviceInformation.OperatingSystem;
            lblOSVersionValue.Text = deviceInformation.OSVersion;
        }

        private void UpdateProcessorInformation() 
        {
            if (processorInformation == null)
            {
                return;
            }

            lblProcessorTypeValue.Text = processorInformation.ProcessorType.ToString();
            lblPhysicalCoresValue.Text = processorInformation.PhysicalCores.ToString();
            lblLogicalCoresValue.Text = processorInformation.LogicalCores.ToString();
        }

        private void UpdateChronoInformation() 
        {
            if (chronoInformation == null)
            {
                return;
            }

            lblLastBootTimeValue.Text = chronoInformation.LastBootUpTime;
            lblLocalDateTimeValue.Text = chronoInformation.LocalDateTime;
        }

        private void UpdatePerformancePanelInformation()
        {
            lblCPUUsageValue.Text = "CPU: " + cpuUsagePct.ToString("#0.00") + "%";
            lblMemoryUsageValue.Text = "Mem: " + memoryUsagePct.ToString("#0.00") + "%";
        }

        private void notifyIconCPM_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                Show();
                this.WindowState = FormWindowState.Normal;
                notifyIconCPM.Visible = false;
            }
        }

        private void CPMMain_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                notifyIconCPM.Visible = true;
            }
        }

        private void cbRefreshFrequency_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(chronoInformation == null) 
            { 
                return; 
            }

            if (cbRefreshFrequency.Text.Equals(REFRESH_FREQUENCY_1))
            {
                chronoInformation.RefreshFrequency = 1000;
            }
            else if (cbRefreshFrequency.Text.Equals(REFRESH_FREQUENCY_2))
            {
                chronoInformation.RefreshFrequency = 2000;
            }
            else if (cbRefreshFrequency.Text.Equals(REFRESH_FREQUENCY_5))
            {
                chronoInformation.RefreshFrequency = 5000;
            }
            else if (cbRefreshFrequency.Text.Equals(REFRESH_FREQUENCY_10))
            {
                chronoInformation.RefreshFrequency = 10000;
            }

            timer.Stop();
            timer.Interval = chronoInformation.RefreshFrequency;
            timer.Start();
        }
    }
}
