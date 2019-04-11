using System;
using System.Collections.Generic;
using System.Text;

namespace DBCOnnection_IFC
{
    public abstract class DbConnection : IDbConnection
    {
        void IDbConnection.Connect(string DbAdress)
        {

        }
        

        void IDbConnection.Disconnect(string DbConnection)
        {
           
        }
    }
}
