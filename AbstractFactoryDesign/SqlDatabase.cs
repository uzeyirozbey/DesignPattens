using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesign
{
    public class SqlDatabase : DatabaseFactory
    {
        public override Command CreateCommand() => new SqlCommand();
        public override Connection CreateConnection() => new SqlConnection();
    }
}
