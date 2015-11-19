using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace task52.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Task> Tasks { get; set; }

        public Category()
        {
            Tasks=new List<Task>();
        }
    }
}