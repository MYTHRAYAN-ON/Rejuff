using Rejuff.Services;
using Rejuff.Views;
using System;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Rejuff
{
    public partial class App : Application
    {
        LocalDatabase localDatabase = new LocalDatabase();

        public App()
        {
            try
            {
                InitializeComponent();
                InitializeApplication();
            }
            catch(Exception ex)
            {
                ExceptionHandling.LogExceptions(ex.ToString());
            }
        }

        private void InitializeApplication()
        {
            try
            {
                AppTheme appTheme = AppInfo.RequestedTheme;
                var userProfile = localDatabase.ReadUserProfile();
                if (userProfile == null)
                {
                    //MainPage = new NavigationPage(new LogInPage());
                    MainPage = new NavigationPage(new MainPage());
                }
                else
                {
                    MainPage = new NavigationPage(new MainPage());
                }
            }
            catch (Exception ex)
            {
                ExceptionHandling.LogExceptions(ex.ToString());
            }
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
