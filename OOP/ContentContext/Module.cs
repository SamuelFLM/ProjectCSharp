using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OOP.SharedContext;

namespace OOP.ContentContext
{
    public class Module : Base
    {
        public Module()
        {
            Lectures = new List<Lecture>();
        }
        public int Order { get; private set; }
        public string Title { get; set; }
        public IList<Lecture> Lectures { get; set; }
    }
}