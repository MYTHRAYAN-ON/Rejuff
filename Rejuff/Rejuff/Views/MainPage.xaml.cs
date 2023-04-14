using Rejuff.Services;
using Rejuff.ViewModels;
using System;
using Xamarin.Forms;

namespace Rejuff.Views
{
    public partial class MainPage : ContentPage
    {
        MainPageViewModel mainPageViewModel;

        public MainPage()
        {
            try
            {
                InitializeComponent();
                BindingContext = mainPageViewModel = new MainPageViewModel(Navigation);
            }
            catch (Exception ex)
            {
                ExceptionHandling.LogExceptions(ex.ToString());
            }
        } 
    }
}
