﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_02
{
    class Rectangulo : Figura 
    {
        public override void Dibujar()
        {
            Console.WriteLine("Dibuja Rectangulo");
            base.Dibujar();
        }
    }
}
