using System;

namespace Calculator
{
    internal class Program
    {
        static void info()
        {

            Console.WriteLine("Enter the action to be performed");
            Console.WriteLine("Press 1 for Addition");
            Console.WriteLine("Press 2 for Subtraction");
            Console.WriteLine("Press 3 for Multiplication");
            Console.WriteLine("Press 4 for Division \n");

        }

        static void Main(string[] args)
        {




            do
            {
                info();



                int action = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter 1st num");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter 2nd num");
                int num2 = Convert.ToInt32(Console.ReadLine());
                int result = 0;

                switch (action)
                {

                    case 1:
                        {
                            result = num1 + num2;
                            Console.WriteLine("The result is {0}", result);
                            break;

                        }

                    case 2:
                        {
                            result = num1 - num2;
                            Console.WriteLine("The result is {0}", result);
                            break;

                        }

                    case 3:
                        {
                            result = num1 * num2;
                            Console.WriteLine("The result is {0}", result);
                            break;

                        }

                    case 4:
                        {
                            result = num1 / num2;
                            if (num1 == 0 || num2 == 0)
                            {
                                Console.WriteLine("Division is not accepted by zero ");

                            }
                            else
                            {
                                Console.WriteLine("The result is {0}", result);
                            }

                            break;

                        }

                    default:
                        Console.WriteLine("Wrong action!! try again");
                        break;




                }



                Console.WriteLine("Press any key to continue or prees e  then enter to Shut Down...");



            }



            while (Console.ReadKey().Key != ConsoleKey.E);



            Console.ReadLine();
        }
    }
}
