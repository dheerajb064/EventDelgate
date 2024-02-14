using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationService
{
    public enum UserActionType
    {
        Added ,
        Updated ,
        Removed
    }

    internal class UserEventArgs : EventArgs
    {
        public UserEventArgs(string userName ,string userId ,UserActionType userAction)
        {
            UserName = userName;
            UserId = userId;
            UserAction = userAction;
        }
        public string UserName { get; set; }
        public string UserId { get; set; }
        public UserActionType UserAction { get; set; }
    }
}
