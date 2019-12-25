using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesign
{
    public abstract class  Connection
    {
        public abstract bool Connect();
        public abstract bool Disconnet();
        public abstract string State { get; }
    }
}
