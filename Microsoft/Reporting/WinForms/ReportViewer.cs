namespace Microsoft.Reporting.WinForms
{
    internal class ReportViewer
    {
        public ReportViewer()
        {
        }

        public Point Location { get; internal set; }
        public string Name { get; internal set; }
        public object ServerReport { get; internal set; }
    }
}