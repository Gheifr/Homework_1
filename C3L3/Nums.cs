using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace C3L3
{
    class Nums : IMyEvent
    {
        private int a;
        private int b;

        public void DoSomething()
        {
            if (SetVars())
                ProcessEnteredNums?.Invoke(a,b);
        }
    private bool SetVars()
        {
            try
            {
                Console.WriteLine("Enter number 1");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter number 2");
                b = int.Parse(Console.ReadLine());
                return true;
            }
            catch (Exception e)
            {
                if (e != null)
                {
                    //handle exeption
                }
            }
                return false;
        }

    public event NumsEntered ProcessEnteredNums;
    }
}
