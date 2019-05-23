using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C3L4
{
    class FIleExample
    {
        private string _filePath = @"D:\Learning_stuff\C3L4\txt.txt";

        public void WriteToFile(string message)
        {
            //using (var file = File.Open(_filePath, FileMode.Open, FileAccess.ReadWrite))
            //{
            //    file.Write(Encoding.ASCII.GetBytes(message), 0, int.MaxValue);
            //}
            using (var stream = new StreamWriter(_filePath))
            {
                stream.Write(message);
            }

        }

        public void ReadFromFile()
        {
            string result = null;
            using (var stream = new StreamReader(_filePath))
            {
                result = stream.ReadToEnd();
            }
        }


    }
}
