using Rejuff.BO;
using Rejuff.ViewModels;
using System.Collections.Generic;
using System.Windows.Input;

namespace Rejuff.Models
{
    public class MainPageModel : BaseViewModel
    {
        public ICommand RefreshCommand { get; set; }
        public ICommand PikcupBtnCmd { get; set; }

        bool _IsRefreshing;

        public IEnumerable<StuffBO> _StuffList = new List<StuffBO>();

        public bool IsRefreshing
        {
            get { return _IsRefreshing; }
            set { SetProperty(ref _IsRefreshing, value); }
        }

        public IEnumerable<StuffBO> StuffList
        {
            get { return _StuffList; }
            set { SetProperty(ref _StuffList, value); }
        }
    }
}
