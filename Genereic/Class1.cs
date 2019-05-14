using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genereic
{
    public class Class1
    {
        public void Do() 
        {
            var stringList = new List<int>();
            var sorter = new GenericSorter<List<int>, int>();
        }   

    }
}
