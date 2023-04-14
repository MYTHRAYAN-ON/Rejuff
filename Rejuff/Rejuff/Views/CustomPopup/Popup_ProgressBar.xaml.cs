using Rejuff.Services;
using Rg.Plugins.Popup.Pages;
using System;
using Xamarin.Forms.Xaml;

namespace Rejuff.Views.CustomPopup
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Popup_ProgressBar : PopupPage
    {
        public Popup_ProgressBar()
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
    }
}