using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDelegates
{
    public delegate void Print(string param);
    class Base
    {
        public string Name { get; set; }

        public void Output(string _name, Print method)
        {
            method(this.Name);
        }
    }
}
