using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP.NotificationContext
{
    public abstract class Notifiable
    {
        public List<Notification> Notificatios { get; set; }

        public Notifiable()
        {
            Notificatios = new List<Notification>();
        }


        public void AddNotification(Notification notification)
        {
            Notificatios.Add(notification);
        }

        public void AddNotification(IEnumerable<Notification> notifications)
        {
            Notificatios.AddRange(notifications);
        }

        public bool IsInvalid => Notificatios.Any();


    }
}