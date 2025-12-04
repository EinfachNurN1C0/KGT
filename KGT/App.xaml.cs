using System.Windows;

namespace KGT
{
    public partial class App : Application
    {
        //Hier gehts los!!
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var KGT = new MainWindow();
            KGT.Show();
        }
    }
}
