namespace Core_Performance_Monitor
{
    internal class GraphicsInformation
    {
        public string GPUName { get; set; }
        public string GPUDriverVersion { get; set; }

        public GraphicsInformation(string name, string driverVersion)
        {
            GPUName = name;
            GPUDriverVersion = driverVersion;
        }
    }
}
