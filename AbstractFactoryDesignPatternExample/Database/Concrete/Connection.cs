using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactoryDesignPatternExample.Database.Abstract;
using AbstractFactoryDesignPatternExample.Enums;

namespace AbstractFactoryDesignPatternExample.Database.Concrete
{
    internal class Connection : AbstractConnection
    {
        public override ConnectionState State { get; set; }
        public override string ConnectionString { get => _connectionString; set => _connectionString = value; }
        string _connectionString;

        public Connection() { }
        public Connection(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public override bool Connect()
        {
            State = ConnectionState.Open;
            return true;
        }
        public override bool Disconnect()
        {
            State = ConnectionState.Close;
            return true;
        }
    }
}
