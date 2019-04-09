using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5
{
    public class Program //Zoo
    {
        public static void Main(string[] args)
        {
            var elephant = new Elefant("Old Elephant");
            var bird = new Bird("Black Bird");

            var employee = new Employee(32,"Mike");

            var plant = new Plants();
            var birdAviary = new Aviary();
            var elephantAviary = new Aviary();

            var visitor = new Visitor(15,"Ivan");


            birdAviary.PLacePlant(plant);
            birdAviary.PlaceAnimal(bird);

            elephantAviary.PlaceAnimal(elephant);

            Console.WriteLine(birdAviary.GetStatus());
            Console.WriteLine(elephantAviary.GetStatus());

            employee.FeedAnimal(elephant);
            employee.FeedAnimal(bird);

            visitor.Observe(elephant);
            visitor.Observe(bird);

            Console.ReadKey();

        }
    }
}
