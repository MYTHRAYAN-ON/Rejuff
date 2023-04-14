using Rejuff.BO;
using Rejuff.Models;
using Rejuff.Services;
using Rejuff.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Rejuff.ViewModels
{
    public class MainPageViewModel:MainPageModel
    {
        LocalDatabase localDatabase = new LocalDatabase();
        INavigation navigation;

        public MainPageViewModel(INavigation navigation)
        {
            try
            {
                this.navigation = navigation;
                InitiateScreen();
            }
            catch(Exception ex)
            {
                ExceptionHandling.LogExceptions(ex.ToString());
            }
        }

        private void InitiateScreen()
        {
            try
            {
                PikcupBtnCmd = new Command(PickupButtonTapped);
                var stuffList = new List<StuffBO>();
                stuffList.Add(new StuffBO { stuffID = "1", stuffName = "News Paper", stuffIcon = "https://www.historic-newspapers.co.uk/app/uploads/2019/07/Old-Newspapers.jpg", stuffPrice = "Rs.9/Kg" });
                stuffList.Add(new StuffBO { stuffID = "1", stuffName = "News Paper", stuffIcon = "https://www.historic-newspapers.co.uk/app/uploads/2019/07/Old-Newspapers.jpg", stuffPrice = "Rs.9/Kg" });
                stuffList.Add(new StuffBO { stuffID = "1", stuffName = "News Paper", stuffIcon = "https://www.historic-newspapers.co.uk/app/uploads/2019/07/Old-Newspapers.jpg", stuffPrice = "Rs.9/Kg" });
                stuffList.Add(new StuffBO { stuffID = "1", stuffName = "News Paper", stuffIcon = "https://www.historic-newspapers.co.uk/app/uploads/2019/07/Old-Newspapers.jpg", stuffPrice = "Rs.9/Kg" });
                stuffList.Add(new StuffBO { stuffID = "1", stuffName = "News Paper", stuffIcon = "https://www.historic-newspapers.co.uk/app/uploads/2019/07/Old-Newspapers.jpg", stuffPrice = "Rs.9/Kg" });
                stuffList.Add(new StuffBO { stuffID = "1", stuffName = "News Paper", stuffIcon = "https://www.historic-newspapers.co.uk/app/uploads/2019/07/Old-Newspapers.jpg", stuffPrice = "Rs.9/Kg" });
                stuffList.Add(new StuffBO { stuffID = "1", stuffName = "News Paper", stuffIcon = "https://www.historic-newspapers.co.uk/app/uploads/2019/07/Old-Newspapers.jpg", stuffPrice = "Rs.9/Kg" });
                stuffList.Add(new StuffBO { stuffID = "1", stuffName = "News Paper", stuffIcon = "https://www.historic-newspapers.co.uk/app/uploads/2019/07/Old-Newspapers.jpg", stuffPrice = "Rs.9/Kg" });
                stuffList.Add(new StuffBO { stuffID = "1", stuffName = "News Paper", stuffIcon = "https://www.historic-newspapers.co.uk/app/uploads/2019/07/Old-Newspapers.jpg", stuffPrice = "Rs.9/Kg" });
                stuffList.Add(new StuffBO { stuffID = "1", stuffName = "News Paper", stuffIcon = "https://www.historic-newspapers.co.uk/app/uploads/2019/07/Old-Newspapers.jpg", stuffPrice = "Rs.9/Kg" });
                stuffList.Add(new StuffBO { stuffID = "1", stuffName = "News Paper", stuffIcon = "https://www.historic-newspapers.co.uk/app/uploads/2019/07/Old-Newspapers.jpg", stuffPrice = "Rs.9/Kg" });
                stuffList.Add(new StuffBO { stuffID = "1", stuffName = "News Paper", stuffIcon = "https://www.historic-newspapers.co.uk/app/uploads/2019/07/Old-Newspapers.jpg", stuffPrice = "Rs.9/Kg" });
                stuffList.Add(new StuffBO { stuffID = "1", stuffName = "News Paper", stuffIcon = "https://www.historic-newspapers.co.uk/app/uploads/2019/07/Old-Newspapers.jpg", stuffPrice = "Rs.9/Kg" });
                stuffList.Add(new StuffBO { stuffID = "1", stuffName = "News Paper", stuffIcon = "https://www.historic-newspapers.co.uk/app/uploads/2019/07/Old-Newspapers.jpg", stuffPrice = "Rs.9/Kg" });
                stuffList.Add(new StuffBO { stuffID = "1", stuffName = "News Paper", stuffIcon = "https://www.historic-newspapers.co.uk/app/uploads/2019/07/Old-Newspapers.jpg", stuffPrice = "Rs.9/Kg" });
                stuffList.Add(new StuffBO { stuffID = "1", stuffName = "News Paper", stuffIcon = "https://www.historic-newspapers.co.uk/app/uploads/2019/07/Old-Newspapers.jpg", stuffPrice = "Rs.9/Kg" });
                stuffList.Add(new StuffBO { stuffID = "1", stuffName = "News Paper", stuffIcon = "https://www.historic-newspapers.co.uk/app/uploads/2019/07/Old-Newspapers.jpg", stuffPrice = "Rs.9/Kg" });
                stuffList.Add(new StuffBO { stuffID = "1", stuffName = "News Paper", stuffIcon = "https://www.historic-newspapers.co.uk/app/uploads/2019/07/Old-Newspapers.jpg", stuffPrice = "Rs.9/Kg" });
                stuffList.Add(new StuffBO { stuffID = "1", stuffName = "News Paper", stuffIcon = "https://www.historic-newspapers.co.uk/app/uploads/2019/07/Old-Newspapers.jpg", stuffPrice = "Rs.9/Kg" });
                stuffList.Add(new StuffBO { stuffID = "1", stuffName = "News Paper", stuffIcon = "https://www.historic-newspapers.co.uk/app/uploads/2019/07/Old-Newspapers.jpg", stuffPrice = "Rs.9/Kg" });

                StuffList = stuffList;
            }
            catch (Exception ex)
            {
                ExceptionHandling.LogExceptions(ex.ToString());
            }
        }

        private void PickupButtonTapped(object obj)
        {
            try
            {
                navigation.PushAsync(new PickupSchedulePage());
            }
            catch (Exception ex)
            {
                ExceptionHandling.LogExceptions(ex.ToString());
            }
        }
    }
}
