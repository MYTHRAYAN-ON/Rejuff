using Rejuff.BO;
using Rejuff.ViewModels;
using System;
using System.Collections.Generic;
using System.Windows.Input;

namespace Rejuff.Models
{
    public class PickupSchedulePageModel:BaseViewModel
    {
        public ICommand ChangeAddressBtnCmd { get; set; }
        public ICommand TimeSlot1Cmd { get; set; }
        public ICommand TimeSlot2Cmd { get; set; }
        public ICommand TimeSlot3Cmd { get; set; }
        public ICommand TimeSlot4Cmd { get; set; }
        public ICommand SchedulePikcupBtnCmd { get; set; }

        string _UserAddress;
        DateTime _PickupDate;
        DateTime _MinPickupDate;
        string _TimeSlot1FrameColor;
        string _TimeSlot2FrameColor;
        string _TimeSlot3FrameColor;
        string _TimeSlot4FrameColor;
        string _TimeSlot1TextColor;
        string _TimeSlot2TextColor;
        string _TimeSlot3TextColor;
        string _TimeSlot4TextColor;

        public string UserAddress
        {
            get { return _UserAddress; }
            set { SetProperty(ref _UserAddress, value); }
        }
        
        public DateTime PickupDate
        {
            get { return _PickupDate; }
            set { SetProperty(ref _PickupDate, value); }
        }
        
        public DateTime MinPickupDate
        {
            get { return _MinPickupDate; }
            set { SetProperty(ref _MinPickupDate, value); }
        }
        
        public string TimeSlot1FrameColor
        {
            get { return _TimeSlot1FrameColor; }
            set { SetProperty(ref _TimeSlot1FrameColor, value); }
        }
        
        public string TimeSlot2FrameColor
        {
            get { return _TimeSlot2FrameColor; }
            set { SetProperty(ref _TimeSlot2FrameColor, value); }
        }
        
        public string TimeSlot3FrameColor
        {
            get { return _TimeSlot3FrameColor; }
            set { SetProperty(ref _TimeSlot3FrameColor, value); }
        }
        
        public string TimeSlot4FrameColor
        {
            get { return _TimeSlot4FrameColor; }
            set { SetProperty(ref _TimeSlot4FrameColor, value); }
        }
        
        public string TimeSlot1TextColor
        {
            get { return _TimeSlot1TextColor; }
            set { SetProperty(ref _TimeSlot1TextColor, value); }
        }
        
        public string TimeSlot2TextColor
        {
            get { return _TimeSlot2TextColor; }
            set { SetProperty(ref _TimeSlot2TextColor, value); }
        }
        
        public string TimeSlot3TextColor
        {
            get { return _TimeSlot3TextColor; }
            set { SetProperty(ref _TimeSlot3TextColor, value); }
        }
        
        public string TimeSlot4TextColor
        {
            get { return _TimeSlot4TextColor; }
            set { SetProperty(ref _TimeSlot4TextColor, value); }
        }
    }
}
