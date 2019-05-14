using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genereic
{
    class GenericSorter <T,V> where T:IEnumerable<V> where V: IComparable /*new()*/
    {
        public IEnumerable<V>  Sort(T collection)
        {
            //V something = new V();
            return Enumerable.Empty<V>();
        }

    }
}
