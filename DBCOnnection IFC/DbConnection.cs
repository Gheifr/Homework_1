using System;
using System.Collections.Generic;
using System.Text;

namespace DBCOnnection_IFC
{
    public abstract class DbConnection : IDbConnection
    {
        public string Name;
        public string ConnectionType;

        public string GetConnectionType()
        {
            return this.ConnectionType;
        }
        public void Connect(DbConnection DbConnectionName, bool Type)
        {
            switch (Type)
            {
                case (true):
                Console.WriteLine("Connecting to Local DB " + DbConnectionName.Name);
                    break;
                case (false):      
                Console.WriteLine("Connecting to Remote DB " + DbConnectionName.Name);
                    break;
                }
        }

        public void Disconnect(DbConnection DbConnectionName, bool Type)
        {
            switch (Type)
            {
                case (true):
                    Console.WriteLine("Disconnecting from Local DB " + DbConnectionName.Name);
                    break;
                case (false):
                    Console.WriteLine("Disconnecting from Remote DB " + DbConnectionName.Name);
                    break;
            }
        }

        public DbConnection(string name, string connectionType)
        {
            Name = name;
            ConnectionType = connectionType;
        }

    }
}
