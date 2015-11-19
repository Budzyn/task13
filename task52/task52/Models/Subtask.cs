using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace task52.Models
{
    public class Subtask
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Check { get; set; }

        public ICollection<Task> Tasks { get; set; }

        public Subtask()
        {
            Tasks=new List<Task>();
        }
    }
}