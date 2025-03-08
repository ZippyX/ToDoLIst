using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleToDoList
{
    class Start
    {
        static int userAction { get; set; }
        static void Main(string[] args)
        {
            TaskStorage taskStorage = new TaskStorage();
            Greeting();
            while (true)
            {
                userAction = int.Parse(Console.ReadLine());
                switch (userAction)
                {
                    case 1:
                        taskStorage.AppendTask(GetTask());
                        ClearAction();
                        Greeting();
                        break;
                    case 2:
                        Console.WriteLine("Введите название задачи, которую хотите удалить");
                        taskStorage.RemoveTask(Console.ReadLine());
                        ClearAction();
                        Greeting();
                        break;
                    case 3:
                        taskStorage.PrintTasks();
                        Console.WriteLine("Если вы хотите вернуться на главную страницу,введите любой символ");
                        BackToMain();
                        break;
                }
                    
            }
        }
        static Task GetTask()
        {
            Console.WriteLine("Введите заголовок");
            string headline = Console.ReadLine();
            Console.WriteLine("Введите описание");
            string description =  Console.ReadLine();
            return new Task(headline, description);
        }
        static void Greeting()
        {
            Console.WriteLine("Добро пожаловать в консольный TO DO LIST, Анон");
            Console.WriteLine("1) Добавить задачу");
            Console.WriteLine("2) Удалить задачу");
            Console.WriteLine("3) Просмотреть задачи");
            Console.WriteLine("4) Редактировать задачу");
            Console.WriteLine("Введите число от 1 до 5");
        }

        static void ClearAction()
        {
            userAction = 0;
            Console.Clear();
        }
        static void BackToMain()
        {
            if (Console.ReadKey() != null)
            {
                ClearAction();
                Greeting();
            }    
        }
    }
}
