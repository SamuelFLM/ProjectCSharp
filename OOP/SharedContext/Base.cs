using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OOP.NotificationContext;

namespace OOP.SharedContext
{
    public abstract class Base : Notifiable
    {
        public Base()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
    }
}