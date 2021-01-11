using System;
using System.Collections.Generic;
using System.Text;

namespace OCPConsole.Refactorizacion
{
    internal class Cuadrado:IArea
    {
        public double Lado { get; internal set; }
        public double Area()
        {
            return Math.Pow(this.Lado, 2);
        }
    }
}
