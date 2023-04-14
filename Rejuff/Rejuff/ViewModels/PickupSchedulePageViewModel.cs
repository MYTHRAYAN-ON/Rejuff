using Rejuff.Models;
using Rejuff.Services;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Rejuff.ViewModels
{
    public class PickupSchedulePageViewModel: PickupSchedulePageModel
    {
        LocalDatabase localDatabase = new LocalDatabase();
        INavigation navigation;
        bool IsTimeSlot1Tapped = false, IsTimeSlot2Tapped = false, IsTimeSlot3Tapped = false, IsTimeSlot4Tapped = false;

        public PickupSchedulePageViewModel(INavigation navigation)
        {
            try
            {
                this.navigation = navigation;
                InitiateScreen();
            }
            catch (Exception ex)
            {
                ExceptionHandling.LogExceptions(ex.ToString());
            }
        }

        private void InitiateScreen()
        {
            try
            {
                TimeSlot1Cmd = new Command(TimeSlot1Tapped);
                TimeSlot2Cmd = new Command(TimeSlot2Tapped);
                TimeSlot3Cmd = new Command(TimeSlot3Tapped);
                TimeSlot4Cmd = new Command(TimeSlot4Tapped);
                SchedulePikcupBtnCmd = new Command(SchedulePikcupBtnTapped);
                UserAddress= "195/22, No.2 Kumaran Street, Opp. Singamethai, Ammapet Main Road, Salem - 636 001.";
                MinPickupDate =DateTime.Now.Date;
                TimeSlot1FrameColor = "#BABABA";
                TimeSlot2FrameColor = "#BABABA";
                TimeSlot3FrameColor = "#BABABA";
                TimeSlot4FrameColor = "#BABABA";
                TimeSlot1TextColor = "737373";
                TimeSlot2TextColor = "737373";
                TimeSlot3TextColor = "737373";
                TimeSlot4TextColor = "737373";
            }
            catch (Exception ex)
            {
                ExceptionHandling.LogExceptions(ex.ToString());
            }
        }

        private void TimeSlot1Tapped(object obj)
        {
            try
            {
                if(!IsTimeSlot1Tapped)
                {
                    IsTimeSlot1Tapped = true;
                    TimeSlot1FrameColor = "#00E3A3";
                    TimeSlot1TextColor = "000000";
                }
                else
                {
                    IsTimeSlot1Tapped = false;
                    TimeSlot1FrameColor = "#BABABA";
                    TimeSlot1TextColor = "737373";
                }
            }
            catch (Exception ex)
            {
                ExceptionHandling.LogExceptions(ex.ToString());
            }
        }

        private void TimeSlot2Tapped(object obj)
        {
            try
            {
                if (!IsTimeSlot2Tapped)
                {
                    IsTimeSlot2Tapped = true;
                    TimeSlot2FrameColor = "#00E3A3";
                    TimeSlot2TextColor = "000000";
                }
                else
                {
                    IsTimeSlot2Tapped = false;
                    TimeSlot2FrameColor = "#BABABA";
                    TimeSlot2TextColor = "737373";
                }
            }
            catch (Exception ex)
            {
                ExceptionHandling.LogExceptions(ex.ToString());
            }
        }
        
        private void TimeSlot3Tapped(object obj)
        {
            try
            {
                if (!IsTimeSlot3Tapped)
                {
                    IsTimeSlot3Tapped = true;
                    TimeSlot3FrameColor = "#00E3A3";
                    TimeSlot3TextColor = "000000";
                }
                else
                {
                    IsTimeSlot3Tapped = false;
                    TimeSlot3FrameColor = "#BABABA";
                    TimeSlot3TextColor = "737373";
                }
            }
            catch (Exception ex)
            {
                ExceptionHandling.LogExceptions(ex.ToString());
            }
        }

        private void TimeSlot4Tapped(object obj)
        {
            try
            {
                if (!IsTimeSlot4Tapped)
                {
                    IsTimeSlot4Tapped = true;
                    TimeSlot4FrameColor = "#00E3A3";
                    TimeSlot4TextColor = "000000";
                }
                else
                {
                    IsTimeSlot4Tapped = false;
                    TimeSlot4FrameColor = "#BABABA";
                    TimeSlot4TextColor = "737373";
                }
            }
            catch (Exception ex)
            {
                ExceptionHandling.LogExceptions(ex.ToString());
            }
        }

        private void SchedulePikcupBtnTapped(object obj)
        {
            try
            {
                var pickupDate = PickupDate.Date.ToString("dd-MM-yyyy");
            }
            catch (Exception ex)
            {
                ExceptionHandling.LogExceptions(ex.ToString());
            }
        }
    }
}
