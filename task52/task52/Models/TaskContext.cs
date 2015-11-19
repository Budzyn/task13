using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace task52.Models
{
    public class TaskContext:DbContext
    {
        public TaskContext() : base("TaskAndSubtask")
        {
            
        }
        public DbSet<Task> Tasks { get; set; }
        public DbSet<Subtask> Subtasks { get; set; }
        public DbSet<Category> Categories { get; set; } 
    }
}