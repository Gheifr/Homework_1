using System;
using System.Collections.Generic;
using System.Text;

namespace DBCOnnection_IFC
{
    public class LocalDBConnection : DbConnection
    {
        public LocalDBConnection(string name, string connectionType) : base(name, connectionType)
        {
        }
    }
}
