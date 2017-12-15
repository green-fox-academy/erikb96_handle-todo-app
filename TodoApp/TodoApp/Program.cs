using System;
using System.IO;

namespace TodoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            My obj = new My();
          

            if (obj.ValidateArguments(args) == false)
            {
                obj.ListValidApplicationArgumentsToConsole();
                return;
            }

           // Console.WriteLine(args[0]);


            if (args[0]== "-l")  //-l   Lists all the tasks
            {
                obj.ListAllTasks();
                return;
            }

            if (args[0] == "-a") // -a   Adds a new task
            {
                /*

                try
                {
                    obj.AddNewTask(args[1]);
                }
                catch
                {
                    Console.WriteLine("Unable to add: no task provided");
                }

                return;
                */

               

                if(args.Length < 2)
                {
                    Console.WriteLine("Unable to add: no task provided");

                    return;
                }

                obj.AddNewTask(args[1]);
                return;
               
            } 

            if (args[0] == "-r") // -r   Removes a task
            {
                if (args.Length < 2)
                {
                    Console.WriteLine("Unable to remove: no index provided");

                    return;
                }
                obj.RemoveTask(int.Parse(args[1]));
                return;
            }


            if (args[0] == "-c") //-c   Completes a task
            {
                obj.CompleteTask();
                return;
            }

            return;

          


            string userinput = (Console.ReadLine());

            if (userinput == "l")
            {

            }
        }
    }
}
