using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace C3L4_Training
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Persons> listOfPersons = new List<Persons>();

            Persons pers1 = new Persons("1", "Name 1", "Surname 1");
            Persons pers2 = new Persons("2", "Name 2", "Surname 2");
            Persons pers3 = new Persons("3", "Name 3", "Surname 3");
            Persons pers4 = new Persons("4", "Name 4", "Surname 4");

            listOfPersons.Add(pers1);
            listOfPersons.Add(pers2);
            listOfPersons.Add(pers3);
            listOfPersons.Add(pers4);

            string filePath = @"D:\Learning_stuff\C3L4\testDBforlist.txt";

            using (var file = File.Open(filePath, FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {

            }



            using (var writer = new StreamWriter(filePath))
            {
                foreach (var item in listOfPersons)
                {
                    writer.WriteLine(item.ToString());
                }
            }

            using(var file = File.OpenRead(filePath))
            using (var reader = new StreamReader(file))
            {
                List<Persons> updatedListOfPersons = new List<Persons>();
                string line;
                int lineCount = 1;

                while ((line = reader.ReadLine()) != null)
                {
                    var newData = line.Split(',');
                    updatedListOfPersons.Add (new Persons(newData[0], newData[1], newData[2]));
                    lineCount++;
                }
            }


            //var someOne = new Persons("1", "Ivan", "Ivanov");
            //string filePath = @"D:\Learning_stuff\C3L4\testDB.txt";


            //using (var writer = new StreamWriter(filePath))
            //{
            //    writer.Write(someOne.ToString());
            //}

            //Persons someOnesClone;
            //using (var reader = new StreamReader(filePath))
            //{

            //    var newData = reader.ReadToEnd().Split();

            //    someOnesClone = new Persons(newData[0], newData[1], newData[2]);
            //}
            //Console.WriteLine($"New clone is: {someOnesClone.ToString()}");
            //Console.ReadKey();
        }
    }
}
