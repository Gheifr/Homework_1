using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5
{
    public class giraffe : Animals
    {
        public giraffe(string name) : base(name)
        {
        }

        public override void Eat(Feed food)
        {
            base.Eat(food);
        }
    }
}
