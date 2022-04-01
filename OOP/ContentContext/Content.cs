using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OOP.SharedContext;

namespace OOP.ContentContext
{
    public abstract class Content : Base
    {

        public Content(string title, string url)
        {
            Id = Guid.NewGuid();
            Title = title;
            Url = url;
        }
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }


    }
}