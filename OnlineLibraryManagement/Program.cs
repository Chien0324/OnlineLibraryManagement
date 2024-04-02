namespace OnlineLibraryManagement
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
            if (Appdata.isLogin)
            {
                if (Appdata.role == Appdata.ROLE_Reader)
                {
                    Application.Run(new Reader());
                }
                else
                {
                    Application.Run(new Librarian());
                }
            }
        }
    }
}