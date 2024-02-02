namespace MyStoreWinApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>x`
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfig()uration.
            ApplicationConfiguration.Initialize();

            Application.Run(new frmLogin());
        }
    }
}