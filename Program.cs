//Jennifer Jimenez
//ISM 


using System;
using System.Linq.Expressions;

namespace Iteration_Statements___Project_2a
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an Interger Value between 1 and 25 to execute an interative statement:");

            try
            {
                string input = Console.ReadLine();

                int value_input = int.Parse(input);

                if ((value_input > 0) && (value_input <= 25))
                {
                    Console.WriteLine("Executing a For Loop!");
                    Console.WriteLine("The For Loop will iterate" + " " + value_input.ToString() + " " + "times.");

                    for (int i = 0; i < value_input; i++)
                    {
                        Console.WriteLine("The value of the variable i in this iteration is: " + i.ToString());
                    }
                    Console.WriteLine("Press any key to exit program...");
                    Console.ReadKey(true); 
                }
                else
                {
                    Console.WriteLine("Please enter an integer value between 1 and 25, then try running the program again...");
                    Console.WriteLine("Press any key to exit the program ...");
                    Console.ReadKey(true);
                }
            }
           
            catch
            {
                Console.WriteLine("Please enter an integer value and try running the program again...");
                Console.WriteLine("Press any key to exit the program ...");
                Console.ReadKey(true);
            }
        }
    }
}
