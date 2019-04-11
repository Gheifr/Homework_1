using System;
using System.Collections.Generic;
using System.Text;

namespace DBCOnnection_IFC
{
    public interface IDbConnection
    {
        void Connect(string DbAdress);
        void Disconnect(string DbConnection);
    }
}
