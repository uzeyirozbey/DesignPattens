﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesign
{
    public abstract class Command
    {
        public abstract void Execute(string query);
    }
}
