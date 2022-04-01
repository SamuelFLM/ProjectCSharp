using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OOP.NotificationContext;
using OOP.SharedContext;

namespace OOP.ContentContext
{
    public class CareerItem : Base
    {
        public CareerItem(int order, string title, string description, Course course)
        {
            Order = order;
            Title = title;
            Description = description;
            Course = course;

            //Customização de expection
            if (course == null)
                AddNotification(new Notification("Course", "Curso inválido"));

        }

        public int Order { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Course Course { get; set; }
    }
}