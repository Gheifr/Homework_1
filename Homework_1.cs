using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;

            string strMsg = "Hi dude!" + (char)10;

            strMsg += "Please select the task from list below:" + (char)10; 
            strMsg += "1. Task No 1" + (char)10;
            strMsg += "2. Task No 2" + (char)10;
            strMsg += "3. Task No 3" + (char)10;
            strMsg += "4. Task No 4" + (char)10;
            strMsg += "5. Task No 5" + (char)10;
            strMsg += "6. Task No 6" + (char)10;
            strMsg += "7. Task No 7" + (char)10;
            strMsg += "8. Task No 8" + (char)10;

            Console.WriteLine(strMsg);

            int intChoice = int.Parse(Console.ReadLine());

            switch (intChoice)
            {
                case 1:
                    Console.WriteLine("" + (char)10 + "Enter numbers" );

                    Console.WriteLine("A = " );
                    a = double.Parse(Console.ReadLine());

                    Console.WriteLine("" + (char)10 + "B = ");
                    b = double.Parse(Console.ReadLine());

                    Console.WriteLine("" + (char)10 + "Result of this task is:" + (char)10 + task_1(a,b) + (char)10 + (char)10 + "Press any key to exit...");
                    Console.ReadKey();
                    break;
                case 2:
                    Console.WriteLine("" + (char)10 + "Enter numbers");

                    Console.WriteLine("A = ");
                    a = double.Parse(Console.ReadLine());

                    Console.WriteLine("" + (char)10 + "B = ");
                    b = double.Parse(Console.ReadLine());

                    Console.WriteLine("" + (char)10 + "C = ");
                    c = double.Parse(Console.ReadLine());

                    Console.WriteLine("" + (char)10 + "Result of this task is:" + (char)10 + task_2(a, b,c) + (char)10 + (char)10 + "Press any key to exit...");
                    Console.ReadKey();
                    break;
                case 3:
                    Console.WriteLine("" + (char)10 + "Enter numbers");

                    Console.WriteLine("A = ");
                    a = double.Parse(Console.ReadLine());

                    Console.WriteLine("" + (char)10 + "B = ");
                    b = double.Parse(Console.ReadLine());

                    Console.WriteLine("" + (char)10 + "C = ");
                    c = double.Parse(Console.ReadLine());

                    Console.WriteLine("" + (char)10 + "Result of this task is:" + (char)10 + task_3(a, b, c) + (char)10 + (char)10 + "Press any key to exit...");
                    Console.ReadKey();
                    break;

            }

            double task_1(double A, double B)
            {
                if (A!=B)
                {
                    if (A < B) return -1;
                        return 1;
                }
                return 0;
            }


            double task_2(double A, double B, double C)
            {
                if (C != 0)
                {
                    if (C < 0) return 1;
                    return A+B;
                }
                return A;
            }

            double task_3(double A, double B, double C)
            {
                 if (B <2 && B >=-2) return Math.Pow(A,2);
                    return Math.Pow(A + C,2);        
            }


        }
    }
}
