using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5
{
    public class Employee : People
    {
        private int _availableMoney;
        public Employee(int age, string name) : base(age, name)
        {
        }

        public void FeedAnimal(Animals animal)
        {

        }

        public void CleanAviary(Aviary aviary)
        {

        }

        public void ReceivePayment(int sallary)
        {
            _availableMoney += sallary;
        }
    }
}
