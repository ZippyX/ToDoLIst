using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleToDoList
{
    public class TaskStorage
    {
        private List<Task> TaskList = new List<Task>();

        public void AppendTask(Task task)
        {
            TaskList.Add(task);
        }
        public void RemoveTask(string taskHeadLine)
        {
            for (int i = 0; i < TaskList.Count; i++)
            {
                if (TaskList[i].HeadLine == taskHeadLine)
                {
                    TaskList.Remove(TaskList[i]);
                }

            }
        }
        public void PrintTasks()
        {
            for (int i = 0; i < TaskList.Count; i++)
            {
                var task = TaskList[i];
                Console.WriteLine(task.HeadLine.ToUpper());
                Console.WriteLine(task.Description);
            }
                
        }

    }
}
