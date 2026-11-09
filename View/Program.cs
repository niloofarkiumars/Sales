namespace View
{
    /// <summary>
    /// Defines the application entry point and initializes the main window.
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// Starts the Windows Forms application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}