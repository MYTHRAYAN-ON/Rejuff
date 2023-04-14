using Rejuff.Services;
using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;
using System;
using Xamarin.Forms.Xaml;

namespace Rejuff.Views.CustomPopup
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Popup_NoInternet : PopupPage
    {
        public event EventHandler<bool> IsInternetBack;

        public Popup_NoInternet()
        {
            try
            {
                InitializeComponent();
            }
            catch(Exception ex)
            {
                ExceptionHandling.LogExceptions(ex.ToString());
            }
        }

        private async void TryAgain_Clicked(object sender, EventArgs e)
        {
            try
            {
                if (NetworkConnectivity.IsNetworkAvailable())
                {
                    await PopupNavigation.Instance.PopAsync();
                    IsInternetBack?.Invoke(this, true);
                }
            }
            catch (Exception ex)
            {
                ExceptionHandling.LogExceptions(ex.ToString());
            }
        }
    }
}