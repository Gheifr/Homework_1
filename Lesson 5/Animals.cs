using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5
{
    public class Animals
    {
        private string _name;

        public Animals(string name)
        {
            _name = name;
        }
        public virtual void Eat(Feed food)
        {

        }

        public  string GetAnimalName()
        {
            return _name;
        }
    }
}
