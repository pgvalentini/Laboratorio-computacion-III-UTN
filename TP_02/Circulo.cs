using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_02
{
    class Circulo : Figura
    {
        public override void Dibujar()
        {
            Console.WriteLine("Dibuja Circulo");
            base.Dibujar();
        }
    }
}
