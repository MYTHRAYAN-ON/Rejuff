using Rejuff.Services;
using Rejuff.ViewModels;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Rejuff.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PickupSchedulePage : ContentPage
    {
        PickupSchedulePageViewModel pickupSchedulePageViewModel;

        public PickupSchedulePage()
        {
            try
            {
                InitializeComponent();
                BindingContext = pickupSchedulePageViewModel = new PickupSchedulePageViewModel(Navigation);
            }
            catch (Exception ex)
            {
                ExceptionHandling.LogExceptions(ex.ToString());
            }
        }
    }
}