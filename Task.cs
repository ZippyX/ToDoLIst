using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleToDoList
{

    public class Task
    {
        public string HeadLine { get; set; }
        public string Description { get; set; }
        public bool Perform { get; set; }

        public Task(string headline, string description)
        {
            HeadLine = headline;
            Description = description;
        }

    }
}
