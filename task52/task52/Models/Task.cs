using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace task52.Models
{
    public class Task
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Subtask Subtask { get; set; }
        public Category Category { get; set; }
        public bool Check { get; set; }
        public DateTime Date { get; set; }
    }
}