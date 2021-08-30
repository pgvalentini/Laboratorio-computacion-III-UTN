using System;
using System.Collections.Generic;

namespace TP_02
{
    class Program
    {
        static void Main(string[] args)
        {
            ejercicioB1();
            ejercicioB2();
            ejercicioC1();
            ejercicioC2();
            ejercicioD();

        }

        private static void ejercicioB1()
        {
            Fraccion fra = new Fraccion();
            int num1, num2, den1, den2;
            Console.WriteLine("Ingrese un númerador");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese un denominador");
            den1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese un segundo númerador");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese un segundo denominador");
            den2 = Convert.ToInt32(Console.ReadLine());

            if (den1 == 0 || den2 == 0)
            {
                throw new FraccionException();
            }
            else
            {
                Console.WriteLine("La suma de las dos fracciones es: " + fra.Sumar(num1, num2, den1, den2));
                Console.WriteLine("La resta de las dos fracciones es: " + fra.Restar(num1, num2, den1, den2));
                Console.WriteLine("La multiplicación de las dos fracciones es: " + fra.Multiplicar(num1, num2, den1, den2));
                Console.WriteLine("La división de las dos fracciones es: " + fra.Dividir(num1, num2, den1, den2));
            }
        }
        private static void ejercicioB2()
        {
            Console.WriteLine("Ingrese una cadena");
            string cadena1 = Console.ReadLine();
            Console.WriteLine("Ingrese una segunda cadena");
            string cadena2 = Console.ReadLine();
            if (cadena2.Length < cadena1.Length)
            {
                if (cadena1.Contains(cadena2))
                {
                    Console.WriteLine("Encontrado");
                }
                else
                {
                    Console.WriteLine("No encontrado");
                }
            }
            else
            {
                Console.WriteLine("La segunda cadena no puede ser mayor a la primera");
            }
        }
        private static void ejercicioC1()
        {
            int fila, columna;
            Console.WriteLine("Ingrese el número de fila");
            fila = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el número de columna");
            columna = Convert.ToInt32(Console.ReadLine());
            int[,] matriz = new int[fila,columna];
            int suma = fila + columna;
            for (int i = 0; i < fila; i++)
            {
                for (int j = 0; j < columna; j++)
                {
                    if ((i+j)==suma)
                    {
                        matriz[i, j] = suma;
                    }
                    else
                    {
                        matriz[i, j] = 0;
                    }
                }
            }
            for (int i = 0; i < fila; i++)
            {
                for (int j = 0; j < columna; j++)
                {
                    Console.WriteLine(matriz[i, j]);
                }
            }

        }
        private static void ejercicioC2()
        {
            Console.WriteLine("Ingrese una cadena de números separados por ,");
            string cadena = Console.ReadLine();
            string[] nuevoArreglo = cadena.Split(',');
            int suma=0;
            for (int i = 0; i < nuevoArreglo.Length; i++)
            {
                suma =+ Convert.ToInt32(nuevoArreglo[i]);
            }
            Console.WriteLine("La suma de los elementos es: "+suma);
        }
        private static void ejercicioD()
        {
            List<Figura> figuras = new List<Figura>
            {
                new Rectangulo(),
                new Circulo(),
                new Triangulo()
            };

            foreach (Figura figura in figuras)
            {
                figura.Dibujar();
            }
        }
    static void ejecutarHiloCincoSeg()
        {
            Console.WriteLine("HILO EJECUTADO 5");
        }
        static void ejecutarHiloDiezSeg()
        {
            Console.WriteLine("HILO EJECUTADO 10");
        }
    }
}
