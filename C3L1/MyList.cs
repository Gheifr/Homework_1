using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C3L1
{

    public class MyList <T>
    {
        public MyList()
        {
          
        }

        private T[] items = new T[0];


        public void addItem(T item)
        {
            Array.Resize(ref items, items.Count() + 1);
            items[items.Count() - 1] = item;
        }

        public void removeItem(T item)
        {
            items[Array.IndexOf(items, item)] = items[items.Count() - 1];
            Array.Resize(ref items, items.Count() - 1);
        }

        public IEnumerable<T> getItems()
        {
            return items;
        }
    }


}
