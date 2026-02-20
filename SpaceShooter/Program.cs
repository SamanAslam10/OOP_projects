using System.Media;

namespace SpaceShooter
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        { 
            ApplicationConfiguration.Initialize();
            Application.Run(new SpaceShooterUI());

            SpaceShooterUI spaceShooter = new SpaceShooterUI();
            spaceShooter.Show();

        }
    }
}