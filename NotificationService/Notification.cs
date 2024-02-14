using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationService
{
    internal class Notification
    {
        private readonly string _serviceName;
        public Notification(string serviceName)
        {
            _serviceName = serviceName;
        }

        public void OnUserAction(object sender ,UserEventArgs e)
        {
            Console.WriteLine($"{_serviceName}: User {e.UserAction} - {e.UserId} - {e.UserName}");
        }
    }
}
