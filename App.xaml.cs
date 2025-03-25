using System.Windows;
using Application = System.Windows.Application;


namespace GlobeScheduler___Software_2
{

    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            var loginWindow = new LoginPage();
            loginWindow.ShowDialog();
        }

    }
}
