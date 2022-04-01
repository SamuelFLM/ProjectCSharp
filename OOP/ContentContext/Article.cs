using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OOP.NotificationContext;

namespace OOP.ContentContext
{
    public class Article : Content
    {
        // public IList<Notification> Notification { get; set; }

        public Article(string title, string url)
        : base(title, url)
        {

        }
    }
}