using System;
using System.Collections.Generic;
using System.Text;

namespace OCPConsole.Refactorizacion
{
    internal class Circulo : Figura, IArea
    {
        public double Radio { get; internal set; }
        public double Area()
        {
            return Math.PI * Math.Pow(this.Radio, 2);
        }
    }
}
