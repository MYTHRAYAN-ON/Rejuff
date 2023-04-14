using System;
using Xamarin.Essentials;

namespace Rejuff.Services
{
    public class NetworkConnectivity
    {
        static bool IsInternetAvailable = false;
        public static bool IsNetworkAvailable()
        {
            try
            {
                var current = Connectivity.NetworkAccess;
                if (current == NetworkAccess.Internet)
                {
                    IsInternetAvailable = true;
                }
                else
                {
                    IsInternetAvailable = false;
                }
            }
            catch (Exception ex)
            {
                ExceptionHandling.LogExceptions(ex.ToString());
            }
            return IsInternetAvailable;
        }
    }
}
