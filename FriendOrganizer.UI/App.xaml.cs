using System.Windows;
using Autofac;
using FriendOrganizer.UI.Data;
using FriendOrganizer.UI.Startup;
using FriendOrganizer.UI.ViewModel;

namespace FriendOrganizer.UI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            var bootstrapper = new Bootstrapper();
            var container = bootstrapper.Bootstrap();

            // this in place of old
            var mainWindow = container.Resolve<MainWindow>();
            mainWindow.Show();

            /* OLD
            var mainWindow = new MainWindow(
                new MainViewModel(
                    new FriendDataService()));
            mainWindow.Show();
        */
        }
    }
}
