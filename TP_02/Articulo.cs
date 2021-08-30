using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_02
{
    class Articulo
    {
        public string codigo { get; set; }
        public double StockTotal { get; set; }
        public double StrockMinimo { get; set; }
        public Deposito Deposito { get; set; }

    }
}
