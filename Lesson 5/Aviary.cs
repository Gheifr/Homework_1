using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5
{
    public class Aviary
    {
        private Animals _animal;
        private Plants _plant;

        public void PlaceAnimal(Animals animal)
        {
            _animal = animal;
        }

        public void PLacePlant(Plants plant)
        {
            _plant = plant;
        }

        public string GetStatus()
        {
            if (_animal != null && _plant != null)
                return "Animal and plant present";
            if (_animal != null)
                return "Animal is inside";
            if (_plant != null)
                return "Plant is here";
            return "Empty";
        }
    }
}
