using System;
using System.Collections.Generic;
using System.Text;

namespace DBCOnnection_IFC
{
    public interface IDbConnection
    {
        void Connect(DbConnection DbConnectionName, bool Type);

        void Disconnect(DbConnection DbConnectionName, bool Type);
    }
}
