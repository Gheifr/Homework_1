using System;
using System.Collections.Generic;
using System.Text;

namespace DBCOnnection_IFC
{
    public class RemoteDBConnection : DbConnection
    {
        public RemoteDBConnection(string name, string connectionType) : base(name, connectionType)
        {
        }
    }
}
