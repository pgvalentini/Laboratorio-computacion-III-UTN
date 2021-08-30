using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_02
{
    public class Fraccion
    {
        public string Sumar(int num1, int num2, int den1, int den2)
        {
            int num = (num1 * den2 + den1 * num2);
            int den = (den1 * den2);
            string fraccion = num + "/" + den;
            return fraccion;
        }
        public string Restar(int num1, int num2, int den1, int den2)
        {
            int num = (num1 * den2 - den1 * num2);
            int den = (den1 * den2);
            string fraccion = num + "/" + den;
            return fraccion;
        }

        public string Multiplicar(int num1, int num2, int den1, int den2)
        {
            int num = (num1 * num2);
            int den = (den1 * den2);
            string fraccion = num + "/" + den;
            return fraccion;
        }

        public string Dividir(int num1, int num2, int den1, int den2)
        {
            int num = (num1 * den2);
            int den = (den1 * num2);
            string fraccion = num + "/" + den;
            return fraccion;
        }
    }
}
