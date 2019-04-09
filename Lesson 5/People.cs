using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5
{
    public class People
    {
        public int Age { get; private set; }
        public string Name { get; private set; }

        public People(int age, string name)
        {
            Age = age;
            Name = name;
        }

        public virtual void GoToTheZoo()
        {
            Console.WriteLine("I'm going to the zoo!");
        }
    }
}
