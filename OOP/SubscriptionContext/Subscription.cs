using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OOP.SharedContext;

namespace OOP.SubscriptionContext
{
    public class Subscription : Base
    {
        public Plan Plan { get; set; }

        public DateTime? EndDate { get; set; }

        public bool IsInactive => EndDate <= DateTime.Now;



    }
}