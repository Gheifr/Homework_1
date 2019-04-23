using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_9
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.Write(CheckPalindrome(Console.ReadLine()));

            Console.WriteLine("Enter A");
            int A = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter B");
            int B = int.Parse(Console.ReadLine());
            
            Console.WriteLine($"A = {A}\nB = {B}");
           
            A = A + B;
            B = A - B;
            A = A - B;

            Console.WriteLine($"A: {A}; B: {B}");
            Console.ReadKey();
        
        }

        public static bool CheckPalindrome(string text)
        {
            if (text == null)
                return false;

            string test = text.ToLower();

            test = test.Trim();

                for (int i=0;i< test.Length;i++)
                {
                    if (test[i] != test[test.Length - i - 1])
                        return false; 
                }
                return true;

        }

    }
}
