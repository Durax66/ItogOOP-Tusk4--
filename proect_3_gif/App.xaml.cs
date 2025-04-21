using Microsoft.EntityFrameworkCore.Infrastructure;
using proect_3_gif.Model;
using System.Configuration;
using System.Data;
using System.Windows;

namespace proect_3_gif
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            DatabaseFacade facade = new DatabaseFacade(new UserDataContext());
            facade.EnsureCreated();
        }
    }

}
