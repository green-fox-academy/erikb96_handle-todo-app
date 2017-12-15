using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TodoApp
{
    class My
    {
        private string path=@"TaskList.txt";

        public bool ValidateArguments(string[] args)
        {
          // return (args.Length == 0);

            if (args.Length == 0)
            {                
                return false;           
            }
            return true;

        }

        public void ListValidApplicationArgumentsToConsole()
        {
            Console.WriteLine("Command Line Todo application");
            Console.WriteLine("=============================");
            Console.WriteLine();
            Console.WriteLine("Command line arguments:");
            Console.WriteLine(" -l\tLists all the tasks");
            Console.WriteLine(" -a\tAdds a new task");
            Console.WriteLine(" -r\tRemoves an task");
            Console.WriteLine(" -c\tCompletes an task");

        }

        /* ListAllTasks
         * Given the terminal opened in the project directory
        And the file where you store your data
And a task with the description Walk the dog stored in the file
And a task with the description Buy milk stored in the file
And a task with the description Do homework stored in the file
When the application is ran with -l argument
Then it should print the tasks that are stored in the file
And it should add numbers before each

1 - Walk the dog
2 - Buy milk
3 - Do homework
         */

        public void ListAllTasks()
        {



            if (!File.Exists(path))
            {
                AddNewTask("Walk the dog");
                AddNewTask("Buy milk");
                AddNewTask("Do homework");
            }



            string[] readText = File.ReadAllLines(path);
            for (int i = 0; i < readText.Length; i++)
            {
                Console.WriteLine(i+1 +  " - " + readText[i]);
                // 
            }
                                          

        }

        public void AddNewTask(string task)
        {

            File.AppendAllText(path, task+ Environment.NewLine);
           

        }

       

        public void RemoveTask(int index)
        {
            string[] readText = File.ReadAllLines(path);

            File.Delete(path);

            for (int i = 0; i < readText.Length; i++){
                if (i + 1 != index){
                    AddNewTask(readText[i]);
                }
            
             }

            /*
            
            index = 2

            i = 1

            i+1 == index  <- ezt akarom kihagyni

             
             */

            /*
             0
             1
             2
             3             
             */

        }

        public void CompleteTask()
        {

        }
    }
}
