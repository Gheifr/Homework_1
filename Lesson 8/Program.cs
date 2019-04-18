using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//exceptions//
namespace Lesson_8
{
    class Program
    {
        static void Main(string[] args)
            
        {
            try
            {
                File.Open(@"C:\file.txt", FileMode.Open);
            }
            catch
            {
                throw;
            }
            finally


            {
                //code that will be executed almost always ;) 
                //fail-fast type of application - app will crash at the time of exception at once - catch and finally will not work-out at all
            }
        }
    }
}
