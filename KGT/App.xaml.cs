using System.Windows;

namespace KGT
{
    public partial class App : Application
    {
        //Hier gehts los!!
        void App_Startup(object sender, StartupEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
        }
    }
}
