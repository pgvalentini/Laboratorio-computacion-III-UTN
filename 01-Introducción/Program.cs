using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Introducción
{
    class Program
    {
        static void Main(string[] args)
        {
            punto01();
            punto02();
            punto03();
            punto04();
            punto05();
            Console.WriteLine("ingrese un número");
            int recursion = int.Parse(Console.ReadLine());
            punto06(recursion);
            cadenas();
        }

        private static void cadenas()
        {
            string texto1 = "Lo invisible es esencial a los ojos";
            string texto2 = "Somos los negros de Asunción";
            string texto3;
            string texto4 = "MAYUSCULA";
            string texto5 = "minuscula";

            int cantidad = texto1.Length;
            Console.WriteLine(cantidad);

            bool esverdadero = texto2.Contains("negros");
            Console.WriteLine(esverdadero);

        }

        private static void punto06(int num)
        {
            if (num > 1000000)
            {
                Console.WriteLine(num);
            }   
            if (num>1)
            {
                num = num * num;
                punto06(num);
            }
        }


        private static void punto05()
        {
            int horae, horas, mine, mins;
            Console.WriteLine("Hora de entrada");
            horae = int.Parse(Console.ReadLine());
            Console.WriteLine("Minuto de entrada");
            mine = int.Parse(Console.ReadLine());
            Console.WriteLine("Hora salida");
            horas = int.Parse(Console.ReadLine());
            Console.WriteLine("Minuto salida");
            mins = int.Parse(Console.ReadLine());

            if (horas<horae)
            {
                Console.WriteLine("Error no puede ser mayor");
                punto05();
            }

            if ((((horas-horae)*60)+mins-mine) > (8*60))
            {
                Console.WriteLine("Error no puede ser mayor a 8");
                punto05();
            }
            int resul;
            resul = ((horas - horae) * 60 + mins - mine) * 10;
            Console.WriteLine(resul);
        }


        private static void punto04()
        {
            Console.WriteLine("Ingrese un numero");
            decimal dec1, dec2;
            dec1= Decimal.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese segundo numero");
            dec2 = Decimal.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese operación a realizar: 1. suma, 2. Resta, 3. Multiplicación, 4. División, 5. Módulo ");
            int operac = int.Parse(Console.ReadLine());
            switch (operac)
            {
                case 1:
                    Console.WriteLine(sumar(dec1, dec2));
                    break;
                case 2:
                    Console.WriteLine(restar(dec1, dec2));
                    break;
                case 3:
                    Console.WriteLine(multiplicar(dec1, dec2));
                    break;
                case 4:
                    Console.WriteLine(dividir(dec1, dec2));
                    break;
                case 5:
                    Console.WriteLine(modulo(dec1, dec2));
                    break;             
            }
        }

        private static decimal sumar(decimal num1, decimal num2) => num1 + num2;
        private static decimal restar(decimal num1, decimal num2) => num1 - num2;
        private static decimal multiplicar(decimal num1, decimal num2) => num1 * num2;
        private static decimal dividir(decimal num1, decimal num2)
        {
            try
            {
                if (num2!=0)
                {
                    return num1 / num2;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Error");
                
            }
            return 0;
        }
        
        private static decimal modulo(decimal num1, decimal num2) => num1 % num2;

        private static bool esPar(int numero) => numero % 2 == 0;
        
        private static void punto03()
        {
            Console.WriteLine("Ingrese un número");
            if (esPar(int.Parse(Console.ReadLine())))
            {
                Console.WriteLine("Es par");
            }
            else
            {
                Console.WriteLine("Es impar");
            }
        }

        private static void punto02()
        {
            /*Número aleatorio 0 a 100*/
            Random r = new Random();
            int aleatorio = r.Next(0, 100);
            int seleccion;
            Boolean correcto = true;
            do
            {
                Console.WriteLine("Diga un número");
                seleccion = int.Parse(Console.ReadLine());
                if (seleccion == aleatorio)
                {
                    correcto = false;
                    Console.WriteLine("Correcto");
                }
                else if (seleccion > aleatorio)
                {
                    Console.WriteLine("El número es menor");
                }
                else
                {
                    Console.WriteLine("El número es mayor");
                }

            } while (correcto);
        }

        private static void punto01()
        {
            /*Muestra los números del 1 al 100 (ambos incluidos) divisibles entre 2 y 5. Utiliza las
            iteraciones for, while, do/while para resolver el mismo problema.*/

            Console.WriteLine("Números divisibles por 2 y 5 son:");
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0 || i % 5 == 0)
                {
                    Console.WriteLine("Con for el número es: " + i);
                }
            }

            int num = 1;
            while (num <= 100)
            {
                if (num % 2 == 0 || num % 5 == 0)
                {
                    Console.WriteLine("Con while el número es: " + num);
                }
                num++;
            }

            int num2 = 1;
            do
            {
                if (num2 % 2 == 0 || num2 % 5 == 0)
                {
                    Console.WriteLine("Con do/while el número es: " + num2);
                }
                num2++;
            } while (num2 <= 100);
        }
    }
}
