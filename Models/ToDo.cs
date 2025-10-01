using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp.Models
{
    public class ToDo
    {
        private static int id = 0;
        public int ID { get; set; } = getID();
        public string Title { get; set; } = "";
        public DateTime Deadline { get; set; } = DateTime.Now;
        public bool Done { get; set; } = false;

        private static int getID() => id++;

        public ToDo() { }
        public ToDo(string title, DateTime deadline, bool done)
        {
            Title = title;
            Deadline = deadline;
            Done = done;
        }
    }
}
