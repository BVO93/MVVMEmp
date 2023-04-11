using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using FriendOrganizer.UI.Data;
using FriendOrganizer.UI.ViewModel;

namespace FriendOrganizer.UI.Startup
{
    public class Bootstrapper
    {
        // The autofac does dependency injection. Automatically makes the correct contructors for calling certain methods.
        // You register what to return when a certain type is asked.

        public IContainer Bootstrap()
        {

            var builder = new ContainerBuilder();
            // Can also be used to resolve other types
            // So when main is needed. Just return main
            builder.RegisterType<MainWindow>().AsSelf();
            builder.RegisterType<MainViewModel>().AsSelf();

            // When an IFriendDataService is needed, you have to create a FriendDataService class
            builder.RegisterType<FriendDataService>().As<IFriendDataService>();

            return builder.Build();

        }
    }
}

