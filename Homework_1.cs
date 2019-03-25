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
            string strMsg = "Hi dude!" + (char)10;

            strMsg += "Please select the task from list below:"+(char)10;
            strMsg += "1. Task No 1"+(char)10;
            strMsg += "2. Task No 2"+(char)10;
            strMsg += "3. Task No 3"+(char)10;
            strMsg += "4. Task No 4"+(char)10;
            strMsg += "5. Task No 5"+(char)10;
            strMsg += "6. Task No 6"+(char)10;
            strMsg += "7. Task No 7"+(char)10;
            strMsg += "8. Task No 8"+(char)10;
            
            Console.WriteLine(strMsg);
            Console.ReadKey();



        }
    }
}
