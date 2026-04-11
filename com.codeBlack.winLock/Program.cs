namespace com.codeBlack.winLock
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfig1uration.
            ApplicationConfiguration.Initialize();


            
            using (LoginForm newSession = new LoginForm())
            {
                foreach (var process in System.Diagnostics.Process.GetProcessesByName("explorer"))
                {
                    newSession.KillExplorerAndKeepItDead();
                }
                if (newSession.ShowDialog() == DialogResult.OK)
                {
                    Application.Run(new WinLock(newSession.username, newSession.role, newSession.authFilePath));

                }
            }
            
        }
    }
}