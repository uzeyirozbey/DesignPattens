using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesign
{
    public class Creater
    {
        DatabaseFactory _databaseFactory;
        Connection _connection;
        Command _command;
        public Creater(DatabaseFactory databaseFactory)
        {
            _databaseFactory = databaseFactory;
            _connection = _databaseFactory.CreateConnection();
            _command = _databaseFactory.CreateCommand();
            Start();
        }

        void Start()
        {
            if(_connection.State == "Open")
            {
                _connection.Connect();
                _command.Execute("select * from denem");
                _connection.Disconnet();
            }
        }
    }
}
