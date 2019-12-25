using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesign
{
    class MySqlCommand : Command
    {
        public override void Execute(string query) => Console.WriteLine("MySqlCommand sorgusu çalıştırıldı.");
    }
}
