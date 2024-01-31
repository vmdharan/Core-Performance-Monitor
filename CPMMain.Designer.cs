namespace Core_Performance_Monitor
{
    partial class CPMMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CPMMain));
            panelCache = new Panel();
            lblL3CacheSize = new Label();
            lblL2CacheSize = new Label();
            lblL1CacheSize = new Label();
            lblL3Cache = new Label();
            lblL2Cache = new Label();
            lblL1Cache = new Label();
            panelMemory = new Panel();
            lblSizeStoredPagingSize = new Label();
            lblSizeStoredPaging = new Label();
            lblTotalVirtualMemorySize = new Label();
            lblFreeVirtualMemorySize = new Label();
            lblTotalVirtualMemory = new Label();
            lblFreeVirtualMemory = new Label();
            lblFreeSpacePagingSize = new Label();
            lblTotalMemorySize = new Label();
            lblFreeMemorySize = new Label();
            lblFreeSpacePaging = new Label();
            lblTotalMemory = new Label();
            lblFreeMemory = new Label();
            notifyIconCPM = new NotifyIcon(components);
            panelDevice = new Panel();
            lblOSVersionValue = new Label();
            lblOSVersion = new Label();
            lblOperatingSystemValue = new Label();
            lblOperatingSystem = new Label();
            lblDeviceNameValue = new Label();
            lblDeviceName = new Label();
            panelProcessor = new Panel();
            lblLogicalCoresValue = new Label();
            lblLogicalCores = new Label();
            lblPhysicalCoresValue = new Label();
            lblPhysicalCores = new Label();
            lblProcessorTypeValue = new Label();
            lblProcessorType = new Label();
            panelChrono = new Panel();
            cbRefreshFrequency = new ComboBox();
            lblRefreshFrequency = new Label();
            lblLocalDateTimeValue = new Label();
            lblLocalDateTime = new Label();
            lblLastBootTimeValue = new Label();
            lblLastBootTime = new Label();
            panelPerformance = new Panel();
            lblMemoryUsageValue = new Label();
            lblCPUUsageValue = new Label();
            pbMemoryGraph = new PictureBox();
            pbPerformanceGraph = new PictureBox();
            pnlGraphics = new Panel();
            lblGraphics2Driver = new Label();
            lblGraphics1Driver = new Label();
            lblGraphics2Value = new Label();
            lblGraphics1Value = new Label();
            lblGraphics2 = new Label();
            lblGraphics1 = new Label();
            panelCache.SuspendLayout();
            panelMemory.SuspendLayout();
            panelDevice.SuspendLayout();
            panelProcessor.SuspendLayout();
            panelChrono.SuspendLayout();
            panelPerformance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbMemoryGraph).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPerformanceGraph).BeginInit();
            pnlGraphics.SuspendLayout();
            SuspendLayout();
            // 
            // panelCache
            // 
            panelCache.BackColor = Color.FromArgb(13, 126, 136);
            panelCache.Controls.Add(lblL3CacheSize);
            panelCache.Controls.Add(lblL2CacheSize);
            panelCache.Controls.Add(lblL1CacheSize);
            panelCache.Controls.Add(lblL3Cache);
            panelCache.Controls.Add(lblL2Cache);
            panelCache.Controls.Add(lblL1Cache);
            panelCache.ForeColor = SystemColors.Control;
            panelCache.Location = new Point(12, 323);
            panelCache.Name = "panelCache";
            panelCache.Size = new Size(199, 115);
            panelCache.TabIndex = 1;
            // 
            // lblL3CacheSize
            // 
            lblL3CacheSize.AutoSize = true;
            lblL3CacheSize.Location = new Point(115, 79);
            lblL3CacheSize.Name = "lblL3CacheSize";
            lblL3CacheSize.Size = new Size(27, 20);
            lblL3CacheSize.TabIndex = 5;
            lblL3CacheSize.Text = "---";
            // 
            // lblL2CacheSize
            // 
            lblL2CacheSize.AutoSize = true;
            lblL2CacheSize.Location = new Point(115, 45);
            lblL2CacheSize.Name = "lblL2CacheSize";
            lblL2CacheSize.Size = new Size(27, 20);
            lblL2CacheSize.TabIndex = 4;
            lblL2CacheSize.Text = "---";
            // 
            // lblL1CacheSize
            // 
            lblL1CacheSize.AutoSize = true;
            lblL1CacheSize.Location = new Point(115, 11);
            lblL1CacheSize.Name = "lblL1CacheSize";
            lblL1CacheSize.Size = new Size(27, 20);
            lblL1CacheSize.TabIndex = 3;
            lblL1CacheSize.Text = "---";
            // 
            // lblL3Cache
            // 
            lblL3Cache.AutoSize = true;
            lblL3Cache.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblL3Cache.Location = new Point(15, 79);
            lblL3Cache.Name = "lblL3Cache";
            lblL3Cache.Size = new Size(67, 20);
            lblL3Cache.TabIndex = 2;
            lblL3Cache.Text = "L3 cache";
            // 
            // lblL2Cache
            // 
            lblL2Cache.AutoSize = true;
            lblL2Cache.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblL2Cache.Location = new Point(15, 45);
            lblL2Cache.Name = "lblL2Cache";
            lblL2Cache.Size = new Size(67, 20);
            lblL2Cache.TabIndex = 1;
            lblL2Cache.Text = "L2 cache";
            // 
            // lblL1Cache
            // 
            lblL1Cache.AutoSize = true;
            lblL1Cache.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblL1Cache.Location = new Point(15, 11);
            lblL1Cache.Name = "lblL1Cache";
            lblL1Cache.Size = new Size(65, 20);
            lblL1Cache.TabIndex = 0;
            lblL1Cache.Text = "L1 cache";
            // 
            // panelMemory
            // 
            panelMemory.BackColor = Color.DarkSlateGray;
            panelMemory.Controls.Add(lblSizeStoredPagingSize);
            panelMemory.Controls.Add(lblSizeStoredPaging);
            panelMemory.Controls.Add(lblTotalVirtualMemorySize);
            panelMemory.Controls.Add(lblFreeVirtualMemorySize);
            panelMemory.Controls.Add(lblTotalVirtualMemory);
            panelMemory.Controls.Add(lblFreeVirtualMemory);
            panelMemory.Controls.Add(lblFreeSpacePagingSize);
            panelMemory.Controls.Add(lblTotalMemorySize);
            panelMemory.Controls.Add(lblFreeMemorySize);
            panelMemory.Controls.Add(lblFreeSpacePaging);
            panelMemory.Controls.Add(lblTotalMemory);
            panelMemory.Controls.Add(lblFreeMemory);
            panelMemory.ForeColor = SystemColors.Control;
            panelMemory.Location = new Point(217, 323);
            panelMemory.Name = "panelMemory";
            panelMemory.Size = new Size(553, 115);
            panelMemory.TabIndex = 2;
            // 
            // lblSizeStoredPagingSize
            // 
            lblSizeStoredPagingSize.AutoSize = true;
            lblSizeStoredPagingSize.Location = new Point(451, 79);
            lblSizeStoredPagingSize.Name = "lblSizeStoredPagingSize";
            lblSizeStoredPagingSize.Size = new Size(27, 20);
            lblSizeStoredPagingSize.TabIndex = 11;
            lblSizeStoredPagingSize.Text = "---";
            // 
            // lblSizeStoredPaging
            // 
            lblSizeStoredPaging.AutoSize = true;
            lblSizeStoredPaging.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSizeStoredPaging.Location = new Point(272, 79);
            lblSizeStoredPaging.Name = "lblSizeStoredPaging";
            lblSizeStoredPaging.Size = new Size(145, 20);
            lblSizeStoredPaging.TabIndex = 10;
            lblSizeStoredPaging.Text = "Size stored (paging)";
            // 
            // lblTotalVirtualMemorySize
            // 
            lblTotalVirtualMemorySize.AutoSize = true;
            lblTotalVirtualMemorySize.Location = new Point(451, 45);
            lblTotalVirtualMemorySize.Name = "lblTotalVirtualMemorySize";
            lblTotalVirtualMemorySize.Size = new Size(27, 20);
            lblTotalVirtualMemorySize.TabIndex = 9;
            lblTotalVirtualMemorySize.Text = "---";
            // 
            // lblFreeVirtualMemorySize
            // 
            lblFreeVirtualMemorySize.AutoSize = true;
            lblFreeVirtualMemorySize.Location = new Point(451, 11);
            lblFreeVirtualMemorySize.Name = "lblFreeVirtualMemorySize";
            lblFreeVirtualMemorySize.Size = new Size(27, 20);
            lblFreeVirtualMemorySize.TabIndex = 8;
            lblFreeVirtualMemorySize.Text = "---";
            // 
            // lblTotalVirtualMemory
            // 
            lblTotalVirtualMemory.AutoSize = true;
            lblTotalVirtualMemory.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalVirtualMemory.Location = new Point(272, 45);
            lblTotalVirtualMemory.Name = "lblTotalVirtualMemory";
            lblTotalVirtualMemory.Size = new Size(155, 20);
            lblTotalVirtualMemory.TabIndex = 7;
            lblTotalVirtualMemory.Text = "Total Virtual Memory";
            // 
            // lblFreeVirtualMemory
            // 
            lblFreeVirtualMemory.AutoSize = true;
            lblFreeVirtualMemory.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFreeVirtualMemory.Location = new Point(272, 13);
            lblFreeVirtualMemory.Name = "lblFreeVirtualMemory";
            lblFreeVirtualMemory.Size = new Size(152, 20);
            lblFreeVirtualMemory.TabIndex = 6;
            lblFreeVirtualMemory.Text = "Free Virtual Memory";
            // 
            // lblFreeSpacePagingSize
            // 
            lblFreeSpacePagingSize.AutoSize = true;
            lblFreeSpacePagingSize.Location = new Point(169, 79);
            lblFreeSpacePagingSize.Name = "lblFreeSpacePagingSize";
            lblFreeSpacePagingSize.Size = new Size(27, 20);
            lblFreeSpacePagingSize.TabIndex = 5;
            lblFreeSpacePagingSize.Text = "---";
            // 
            // lblTotalMemorySize
            // 
            lblTotalMemorySize.AutoSize = true;
            lblTotalMemorySize.Location = new Point(169, 45);
            lblTotalMemorySize.Name = "lblTotalMemorySize";
            lblTotalMemorySize.Size = new Size(27, 20);
            lblTotalMemorySize.TabIndex = 4;
            lblTotalMemorySize.Text = "---";
            // 
            // lblFreeMemorySize
            // 
            lblFreeMemorySize.AutoSize = true;
            lblFreeMemorySize.Location = new Point(169, 11);
            lblFreeMemorySize.Name = "lblFreeMemorySize";
            lblFreeMemorySize.Size = new Size(27, 20);
            lblFreeMemorySize.TabIndex = 3;
            lblFreeMemorySize.Text = "---";
            // 
            // lblFreeSpacePaging
            // 
            lblFreeSpacePaging.AutoSize = true;
            lblFreeSpacePaging.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFreeSpacePaging.Location = new Point(12, 79);
            lblFreeSpacePaging.Name = "lblFreeSpacePaging";
            lblFreeSpacePaging.Size = new Size(145, 20);
            lblFreeSpacePaging.TabIndex = 2;
            lblFreeSpacePaging.Text = "Free Space (paging)";
            // 
            // lblTotalMemory
            // 
            lblTotalMemory.AutoSize = true;
            lblTotalMemory.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalMemory.Location = new Point(12, 45);
            lblTotalMemory.Name = "lblTotalMemory";
            lblTotalMemory.Size = new Size(105, 20);
            lblTotalMemory.TabIndex = 1;
            lblTotalMemory.Text = "Total Memory";
            // 
            // lblFreeMemory
            // 
            lblFreeMemory.AutoSize = true;
            lblFreeMemory.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFreeMemory.Location = new Point(12, 11);
            lblFreeMemory.Name = "lblFreeMemory";
            lblFreeMemory.Size = new Size(102, 20);
            lblFreeMemory.TabIndex = 0;
            lblFreeMemory.Text = "Free Memory";
            // 
            // notifyIconCPM
            // 
            notifyIconCPM.Icon = (Icon)resources.GetObject("notifyIconCPM.Icon");
            notifyIconCPM.Text = "Core Performance Monitor";
            notifyIconCPM.MouseDoubleClick += notifyIconCPM_MouseDoubleClick;
            // 
            // panelDevice
            // 
            panelDevice.BackColor = Color.FromArgb(24, 122, 175);
            panelDevice.Controls.Add(lblOSVersionValue);
            panelDevice.Controls.Add(lblOSVersion);
            panelDevice.Controls.Add(lblOperatingSystemValue);
            panelDevice.Controls.Add(lblOperatingSystem);
            panelDevice.Controls.Add(lblDeviceNameValue);
            panelDevice.Controls.Add(lblDeviceName);
            panelDevice.ForeColor = SystemColors.Control;
            panelDevice.Location = new Point(12, 12);
            panelDevice.Name = "panelDevice";
            panelDevice.Size = new Size(306, 109);
            panelDevice.TabIndex = 3;
            // 
            // lblOSVersionValue
            // 
            lblOSVersionValue.AutoSize = true;
            lblOSVersionValue.Location = new Point(140, 44);
            lblOSVersionValue.Name = "lblOSVersionValue";
            lblOSVersionValue.Size = new Size(27, 20);
            lblOSVersionValue.TabIndex = 5;
            lblOSVersionValue.Text = "---";
            // 
            // lblOSVersion
            // 
            lblOSVersion.AutoSize = true;
            lblOSVersion.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOSVersion.Location = new Point(15, 44);
            lblOSVersion.Name = "lblOSVersion";
            lblOSVersion.Size = new Size(82, 20);
            lblOSVersion.TabIndex = 4;
            lblOSVersion.Text = "OS version";
            // 
            // lblOperatingSystemValue
            // 
            lblOperatingSystemValue.AutoSize = true;
            lblOperatingSystemValue.Location = new Point(70, 14);
            lblOperatingSystemValue.Name = "lblOperatingSystemValue";
            lblOperatingSystemValue.Size = new Size(27, 20);
            lblOperatingSystemValue.TabIndex = 3;
            lblOperatingSystemValue.Text = "---";
            // 
            // lblOperatingSystem
            // 
            lblOperatingSystem.AutoSize = true;
            lblOperatingSystem.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOperatingSystem.Location = new Point(15, 14);
            lblOperatingSystem.Name = "lblOperatingSystem";
            lblOperatingSystem.Size = new Size(28, 20);
            lblOperatingSystem.TabIndex = 2;
            lblOperatingSystem.Text = "OS";
            // 
            // lblDeviceNameValue
            // 
            lblDeviceNameValue.AutoSize = true;
            lblDeviceNameValue.Location = new Point(140, 75);
            lblDeviceNameValue.Name = "lblDeviceNameValue";
            lblDeviceNameValue.Size = new Size(27, 20);
            lblDeviceNameValue.TabIndex = 1;
            lblDeviceNameValue.Text = "---";
            // 
            // lblDeviceName
            // 
            lblDeviceName.AutoSize = true;
            lblDeviceName.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDeviceName.Location = new Point(15, 75);
            lblDeviceName.Name = "lblDeviceName";
            lblDeviceName.Size = new Size(100, 20);
            lblDeviceName.TabIndex = 0;
            lblDeviceName.Text = "Device Name";
            // 
            // panelProcessor
            // 
            panelProcessor.BackColor = Color.FromArgb(77, 166, 112);
            panelProcessor.Controls.Add(lblLogicalCoresValue);
            panelProcessor.Controls.Add(lblLogicalCores);
            panelProcessor.Controls.Add(lblPhysicalCoresValue);
            panelProcessor.Controls.Add(lblPhysicalCores);
            panelProcessor.Controls.Add(lblProcessorTypeValue);
            panelProcessor.Controls.Add(lblProcessorType);
            panelProcessor.Location = new Point(324, 12);
            panelProcessor.Name = "panelProcessor";
            panelProcessor.Size = new Size(446, 109);
            panelProcessor.TabIndex = 4;
            // 
            // lblLogicalCoresValue
            // 
            lblLogicalCoresValue.AutoSize = true;
            lblLogicalCoresValue.ForeColor = SystemColors.Control;
            lblLogicalCoresValue.Location = new Point(367, 75);
            lblLogicalCoresValue.Name = "lblLogicalCoresValue";
            lblLogicalCoresValue.Size = new Size(27, 20);
            lblLogicalCoresValue.TabIndex = 5;
            lblLogicalCoresValue.Text = "---";
            // 
            // lblLogicalCores
            // 
            lblLogicalCores.AutoSize = true;
            lblLogicalCores.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogicalCores.ForeColor = SystemColors.Control;
            lblLogicalCores.Location = new Point(253, 75);
            lblLogicalCores.Name = "lblLogicalCores";
            lblLogicalCores.Size = new Size(97, 20);
            lblLogicalCores.TabIndex = 4;
            lblLogicalCores.Text = "Logical cores";
            // 
            // lblPhysicalCoresValue
            // 
            lblPhysicalCoresValue.AutoSize = true;
            lblPhysicalCoresValue.ForeColor = SystemColors.Control;
            lblPhysicalCoresValue.Location = new Point(143, 75);
            lblPhysicalCoresValue.Name = "lblPhysicalCoresValue";
            lblPhysicalCoresValue.Size = new Size(27, 20);
            lblPhysicalCoresValue.TabIndex = 3;
            lblPhysicalCoresValue.Text = "---";
            // 
            // lblPhysicalCores
            // 
            lblPhysicalCores.AutoSize = true;
            lblPhysicalCores.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPhysicalCores.ForeColor = SystemColors.Control;
            lblPhysicalCores.Location = new Point(14, 75);
            lblPhysicalCores.Name = "lblPhysicalCores";
            lblPhysicalCores.Size = new Size(104, 20);
            lblPhysicalCores.TabIndex = 2;
            lblPhysicalCores.Text = "Physical cores";
            // 
            // lblProcessorTypeValue
            // 
            lblProcessorTypeValue.AutoSize = true;
            lblProcessorTypeValue.ForeColor = SystemColors.Control;
            lblProcessorTypeValue.Location = new Point(26, 44);
            lblProcessorTypeValue.Name = "lblProcessorTypeValue";
            lblProcessorTypeValue.Size = new Size(27, 20);
            lblProcessorTypeValue.TabIndex = 1;
            lblProcessorTypeValue.Text = "---";
            // 
            // lblProcessorType
            // 
            lblProcessorType.AutoSize = true;
            lblProcessorType.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProcessorType.ForeColor = SystemColors.Control;
            lblProcessorType.Location = new Point(14, 14);
            lblProcessorType.Name = "lblProcessorType";
            lblProcessorType.Size = new Size(111, 20);
            lblProcessorType.TabIndex = 0;
            lblProcessorType.Text = "Processor Type";
            // 
            // panelChrono
            // 
            panelChrono.BackColor = Color.FromArgb(105, 169, 103);
            panelChrono.Controls.Add(cbRefreshFrequency);
            panelChrono.Controls.Add(lblRefreshFrequency);
            panelChrono.Controls.Add(lblLocalDateTimeValue);
            panelChrono.Controls.Add(lblLocalDateTime);
            panelChrono.Controls.Add(lblLastBootTimeValue);
            panelChrono.Controls.Add(lblLastBootTime);
            panelChrono.Location = new Point(12, 127);
            panelChrono.Name = "panelChrono";
            panelChrono.Size = new Size(199, 190);
            panelChrono.TabIndex = 5;
            // 
            // cbRefreshFrequency
            // 
            cbRefreshFrequency.DropDownStyle = ComboBoxStyle.DropDownList;
            cbRefreshFrequency.FormattingEnabled = true;
            cbRefreshFrequency.Location = new Point(19, 143);
            cbRefreshFrequency.Name = "cbRefreshFrequency";
            cbRefreshFrequency.Size = new Size(151, 28);
            cbRefreshFrequency.TabIndex = 5;
            cbRefreshFrequency.SelectedIndexChanged += cbRefreshFrequency_SelectedIndexChanged;
            // 
            // lblRefreshFrequency
            // 
            lblRefreshFrequency.AutoSize = true;
            lblRefreshFrequency.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRefreshFrequency.ForeColor = SystemColors.Control;
            lblRefreshFrequency.Location = new Point(15, 111);
            lblRefreshFrequency.Name = "lblRefreshFrequency";
            lblRefreshFrequency.Size = new Size(133, 20);
            lblRefreshFrequency.TabIndex = 4;
            lblRefreshFrequency.Text = "Refresh frequency";
            // 
            // lblLocalDateTimeValue
            // 
            lblLocalDateTimeValue.AutoSize = true;
            lblLocalDateTimeValue.ForeColor = SystemColors.Control;
            lblLocalDateTimeValue.Location = new Point(30, 81);
            lblLocalDateTimeValue.Name = "lblLocalDateTimeValue";
            lblLocalDateTimeValue.Size = new Size(27, 20);
            lblLocalDateTimeValue.TabIndex = 3;
            lblLocalDateTimeValue.Text = "---";
            // 
            // lblLocalDateTime
            // 
            lblLocalDateTime.AutoSize = true;
            lblLocalDateTime.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLocalDateTime.ForeColor = SystemColors.Control;
            lblLocalDateTime.Location = new Point(15, 61);
            lblLocalDateTime.Name = "lblLocalDateTime";
            lblLocalDateTime.Size = new Size(112, 20);
            lblLocalDateTime.TabIndex = 2;
            lblLocalDateTime.Text = "Local date time";
            // 
            // lblLastBootTimeValue
            // 
            lblLastBootTimeValue.AutoSize = true;
            lblLastBootTimeValue.ForeColor = SystemColors.Control;
            lblLastBootTimeValue.Location = new Point(30, 31);
            lblLastBootTimeValue.Name = "lblLastBootTimeValue";
            lblLastBootTimeValue.Size = new Size(27, 20);
            lblLastBootTimeValue.TabIndex = 1;
            lblLastBootTimeValue.Text = "---";
            // 
            // lblLastBootTime
            // 
            lblLastBootTime.AutoSize = true;
            lblLastBootTime.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLastBootTime.ForeColor = SystemColors.Control;
            lblLastBootTime.Location = new Point(15, 11);
            lblLastBootTime.Name = "lblLastBootTime";
            lblLastBootTime.Size = new Size(105, 20);
            lblLastBootTime.TabIndex = 0;
            lblLastBootTime.Text = "Last Boot time";
            // 
            // panelPerformance
            // 
            panelPerformance.BackColor = Color.FromArgb(77, 120, 147);
            panelPerformance.Controls.Add(lblMemoryUsageValue);
            panelPerformance.Controls.Add(lblCPUUsageValue);
            panelPerformance.Controls.Add(pbMemoryGraph);
            panelPerformance.Controls.Add(pbPerformanceGraph);
            panelPerformance.Location = new Point(571, 127);
            panelPerformance.Name = "panelPerformance";
            panelPerformance.Size = new Size(199, 190);
            panelPerformance.TabIndex = 6;
            // 
            // lblMemoryUsageValue
            // 
            lblMemoryUsageValue.AutoSize = true;
            lblMemoryUsageValue.BackColor = Color.FromArgb(77, 120, 147);
            lblMemoryUsageValue.ForeColor = SystemColors.Control;
            lblMemoryUsageValue.Location = new Point(16, 104);
            lblMemoryUsageValue.Name = "lblMemoryUsageValue";
            lblMemoryUsageValue.Size = new Size(27, 20);
            lblMemoryUsageValue.TabIndex = 3;
            lblMemoryUsageValue.Text = "---";
            // 
            // lblCPUUsageValue
            // 
            lblCPUUsageValue.AutoSize = true;
            lblCPUUsageValue.BackColor = Color.FromArgb(77, 120, 147);
            lblCPUUsageValue.ForeColor = SystemColors.Control;
            lblCPUUsageValue.Location = new Point(16, 9);
            lblCPUUsageValue.Name = "lblCPUUsageValue";
            lblCPUUsageValue.Size = new Size(27, 20);
            lblCPUUsageValue.TabIndex = 2;
            lblCPUUsageValue.Text = "---";
            // 
            // pbMemoryGraph
            // 
            pbMemoryGraph.BackColor = Color.FromArgb(30, 71, 104);
            pbMemoryGraph.Location = new Point(3, 97);
            pbMemoryGraph.Name = "pbMemoryGraph";
            pbMemoryGraph.Size = new Size(193, 88);
            pbMemoryGraph.TabIndex = 1;
            pbMemoryGraph.TabStop = false;
            // 
            // pbPerformanceGraph
            // 
            pbPerformanceGraph.BackColor = Color.FromArgb(30, 71, 104);
            pbPerformanceGraph.Location = new Point(3, 3);
            pbPerformanceGraph.Name = "pbPerformanceGraph";
            pbPerformanceGraph.Size = new Size(193, 88);
            pbPerformanceGraph.TabIndex = 0;
            pbPerformanceGraph.TabStop = false;
            // 
            // pnlGraphics
            // 
            pnlGraphics.BackColor = Color.FromArgb(91, 119, 140);
            pnlGraphics.Controls.Add(lblGraphics2Driver);
            pnlGraphics.Controls.Add(lblGraphics1Driver);
            pnlGraphics.Controls.Add(lblGraphics2Value);
            pnlGraphics.Controls.Add(lblGraphics1Value);
            pnlGraphics.Controls.Add(lblGraphics2);
            pnlGraphics.Controls.Add(lblGraphics1);
            pnlGraphics.Location = new Point(217, 127);
            pnlGraphics.Name = "pnlGraphics";
            pnlGraphics.Size = new Size(348, 190);
            pnlGraphics.TabIndex = 7;
            // 
            // lblGraphics2Driver
            // 
            lblGraphics2Driver.AutoSize = true;
            lblGraphics2Driver.ForeColor = SystemColors.Control;
            lblGraphics2Driver.Location = new Point(24, 154);
            lblGraphics2Driver.Name = "lblGraphics2Driver";
            lblGraphics2Driver.Size = new Size(27, 20);
            lblGraphics2Driver.TabIndex = 5;
            lblGraphics2Driver.Text = "---";
            // 
            // lblGraphics1Driver
            // 
            lblGraphics1Driver.AutoSize = true;
            lblGraphics1Driver.ForeColor = SystemColors.Control;
            lblGraphics1Driver.Location = new Point(24, 51);
            lblGraphics1Driver.Name = "lblGraphics1Driver";
            lblGraphics1Driver.Size = new Size(27, 20);
            lblGraphics1Driver.TabIndex = 4;
            lblGraphics1Driver.Text = "---";
            // 
            // lblGraphics2Value
            // 
            lblGraphics2Value.AutoSize = true;
            lblGraphics2Value.ForeColor = SystemColors.Control;
            lblGraphics2Value.Location = new Point(24, 134);
            lblGraphics2Value.Name = "lblGraphics2Value";
            lblGraphics2Value.Size = new Size(27, 20);
            lblGraphics2Value.TabIndex = 3;
            lblGraphics2Value.Text = "---";
            // 
            // lblGraphics1Value
            // 
            lblGraphics1Value.AutoSize = true;
            lblGraphics1Value.ForeColor = SystemColors.Control;
            lblGraphics1Value.Location = new Point(24, 31);
            lblGraphics1Value.Name = "lblGraphics1Value";
            lblGraphics1Value.Size = new Size(27, 20);
            lblGraphics1Value.TabIndex = 2;
            lblGraphics1Value.Text = "---";
            // 
            // lblGraphics2
            // 
            lblGraphics2.AutoSize = true;
            lblGraphics2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGraphics2.ForeColor = SystemColors.Control;
            lblGraphics2.Location = new Point(12, 111);
            lblGraphics2.Name = "lblGraphics2";
            lblGraphics2.Size = new Size(128, 20);
            lblGraphics2.TabIndex = 1;
            lblGraphics2.Text = "Graphics device 2";
            // 
            // lblGraphics1
            // 
            lblGraphics1.AutoSize = true;
            lblGraphics1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGraphics1.ForeColor = SystemColors.Control;
            lblGraphics1.Location = new Point(12, 11);
            lblGraphics1.Name = "lblGraphics1";
            lblGraphics1.Size = new Size(126, 20);
            lblGraphics1.TabIndex = 0;
            lblGraphics1.Text = "Graphics device 1";
            // 
            // CPMMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 26, 26);
            ClientSize = new Size(782, 450);
            Controls.Add(pnlGraphics);
            Controls.Add(panelPerformance);
            Controls.Add(panelChrono);
            Controls.Add(panelProcessor);
            Controls.Add(panelDevice);
            Controls.Add(panelMemory);
            Controls.Add(panelCache);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "CPMMain";
            Text = "Core Performance Monitor";
            Resize += CPMMain_Resize;
            panelCache.ResumeLayout(false);
            panelCache.PerformLayout();
            panelMemory.ResumeLayout(false);
            panelMemory.PerformLayout();
            panelDevice.ResumeLayout(false);
            panelDevice.PerformLayout();
            panelProcessor.ResumeLayout(false);
            panelProcessor.PerformLayout();
            panelChrono.ResumeLayout(false);
            panelChrono.PerformLayout();
            panelPerformance.ResumeLayout(false);
            panelPerformance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbMemoryGraph).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPerformanceGraph).EndInit();
            pnlGraphics.ResumeLayout(false);
            pnlGraphics.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelCache;
        private Label lblL2Cache;
        private Label lblL1Cache;
        private Label lblL3CacheSize;
        private Label lblL2CacheSize;
        private Label lblL1CacheSize;
        private Label lblL3Cache;
        private Panel panelMemory;
        private Label lblTotalMemory;
        private Label lblFreeMemory;
        private Label lblFreeSpacePaging;
        private Label lblFreeSpacePagingSize;
        private Label lblTotalMemorySize;
        private Label lblFreeMemorySize;
        private Label lblTotalVirtualMemorySize;
        private Label lblFreeVirtualMemorySize;
        private Label lblTotalVirtualMemory;
        private Label lblFreeVirtualMemory;
        private Label lblSizeStoredPaging;
        private Label lblSizeStoredPagingSize;
        private NotifyIcon notifyIconCPM;
        private Panel panelDevice;
        private Label lblOSVersionValue;
        private Label lblOSVersion;
        private Label lblOperatingSystemValue;
        private Label lblOperatingSystem;
        private Label lblDeviceNameValue;
        private Label lblDeviceName;
        private Panel panelProcessor;
        private Label lblProcessorTypeValue;
        private Label lblProcessorType;
        private Label lblLogicalCoresValue;
        private Label lblLogicalCores;
        private Label lblPhysicalCoresValue;
        private Label lblPhysicalCores;
        private Panel panelChrono;
        private Label lblLastBootTime;
        private Label lblLocalDateTimeValue;
        private Label lblLocalDateTime;
        private Label lblLastBootTimeValue;
        private Label lblRefreshFrequency;
        private ComboBox cbRefreshFrequency;
        private Panel panelPerformance;
        private PictureBox pbPerformanceGraph;
        private PictureBox pbMemoryGraph;
        private Label lblMemoryUsageValue;
        private Label lblCPUUsageValue;
        private Panel pnlGraphics;
        private Label lblGraphics1;
        private Label lblGraphics1Value;
        private Label lblGraphics2;
        private Label lblGraphics2Value;
        private Label lblGraphics2Driver;
        private Label lblGraphics1Driver;
    }
}
