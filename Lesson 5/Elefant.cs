using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5
{
    public class Elefant : Animals
    {
        
        private int _requiredCallories = 15000;

        public Elefant(string name) : base(name)
        {
        }

        public override void Eat(Feed food)
        {

            if (food.Callories < _requiredCallories)
                Console.WriteLine("Elefant needs more food!");
            //base.Eat(food);
        }

       
    }
}
