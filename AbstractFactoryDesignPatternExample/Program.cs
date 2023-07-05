using AbstractFactoryDesignPatternExample.Database.Factory;
using AbstractFactoryDesignPatternExample.Database.Factory.ConcreteFactories;

namespace AbstractFactoryExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DatabaseCreator databaseCreator = new DatabaseCreator();
            var mssqlDatabase = databaseCreator.CreateDatabase(new MSSQL_Factory());
            var mysqlDatabase = databaseCreator.CreateDatabase(new MYSQL_Factory());
            var oracleDatabase = databaseCreator.CreateDatabase(new ORACLE_Factory());
        }
    }
}