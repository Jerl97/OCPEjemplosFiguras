using System;
using System.Collections.Generic;
using System.Text;
namespace OCPConsole.Refactorizacion
{
    internal class Esfera : IArea
    {
        public int Radio { get; internal set; }

        public double Area()
        {
            return 4 * Math.PI * Radio * Radio;
        }
    }
}