using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C3L3
{
    class Program
    {
        static void Main(string[] args)
        {
            var watcherItem = new WatchingClass();
            var senderItem = new Nums();

            senderItem.ProcessEnteredNums +=watcherItem.WatchEvent;
            senderItem.DoSomething();
        }
    }
}
