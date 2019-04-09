using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5
{
    public class Visitor : People
    {
        public Visitor(int age, string name) : base(age, name)
        {
        }

        public void Observe(Animals animal)
        {
            Console.WriteLine("Observing " + animal.GetAnimalName());
        }
    }
}
