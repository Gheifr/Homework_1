using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5
{
    public class Horse : Animals
    {
        public Horse(string name) : base(name)
        {
        }

        public override void Eat(Feed food)
        {
            base.Eat(food);
        }
    }
}
