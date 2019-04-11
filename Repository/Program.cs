using DBCOnnection_IFC;
using System;

namespace DBCOnnection_IFC
{
    class Program
    {
        static void Main(string[] args)
        {
            LocalDBConnection remoteCon = new LocalDBConnection("LocalCon", "Local");

            Console.WriteLine(remoteCon.GetConnectionType());
        }
    }
}
