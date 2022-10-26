namespace RockPaperScissorsLizardSpock
{
    public static class Program
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
            Application.Run(new RPSLS());

            //Random computer = new Random();
            //bool gameLoop = true;
            //int userPoints = 0;
            //int computerPoints = 0;

            //while (gameLoop)
            //{
                
            //}
        }
    }
}