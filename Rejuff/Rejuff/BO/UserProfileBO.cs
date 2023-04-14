using System;
using System.Collections.Generic;
using System.Text;

namespace Rejuff.BO
{
    public class UserProfileBO
    {
        public string userID { get; set; }
        public string userName { get; set; }
        public string userMobileNumber { get; set; }
        public string userAlternateMobileNumber { get; set; }
        public string userAddress { get; set; }
        public bool isCurrentScheduled { get; set; }
    }
}
