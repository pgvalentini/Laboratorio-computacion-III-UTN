using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP9Lab3Pt2
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<Empleado> empleados = new List<Empleado>() {
                 new Empleado() { Id = 1, Nombre = "Juan", Apellido = "Perez", Domicilio = "Salta 314",
                Localidad = "Ciudad", Salario = 30000, DiasInasistencia = 0 } ,
                 new Empleado() { Id = 2, Nombre = "Pedro", Apellido = "Hernandez", Domicilio = "San " +
                "Martin 456", Localidad = "Ciudad", Salario = 36000, DiasInasistencia = 1 } ,
                 new Empleado() { Id = 3, Nombre = "Jose", Apellido = "Chatruc", Domicilio = "Lavalle "+
                "789", Localidad = "Lujan", Salario = 28000, DiasInasistencia = 12 } ,
                 new Empleado() { Id = 4, Nombre = "Carlos" , Apellido = "Alonso", Domicilio = "Rioja "+
                "14", Localidad = "Guaymallen", Salario = 45000, DiasInasistencia = 5 } ,
                 new Empleado() { Id = 5, Nombre = "Claudio" , Apellido = "Ahumada", Domicilio = "Lima "+
                "125", Localidad = "Tupungato", Salario = 38000, DiasInasistencia = 0 } ,
                 new Empleado() { Id = 5, Nombre = "Sebastian" , Apellido = "Tobar", Domicilio = "Rawson "+
                "123", Localidad = "Lujan", Salario = 42000, DiasInasistencia = 2 } ,
                 new Empleado() { Id = 5, Nombre = "Javier" , Apellido = "Puebla", Domicilio = "Italia "+
                "987", Localidad = "Ciudad", Salario = 33000, DiasInasistencia = 4 } ,
                 new Empleado() { Id = 5, Nombre = "Fabian" , Apellido = "Gilar", Domicilio = "Las Viñas "+
                "987", Localidad = "Guaymallen", Salario = 38000, DiasInasistencia = 0 } ,
                 new Empleado() { Id = 5, Nombre = "Victor" , Apellido = "Pereira", Domicilio = "25 de "+
                "Mayo 654", Localidad = "Tupungato", Salario = 37000, DiasInasistencia = 8 } ,
                 new Empleado() { Id = 5, Nombre = "Nelson" , Apellido = "Piquet", Domicilio = "Peru "+
                "987", Localidad = "Ciudad", Salario = 36000, DiasInasistencia = 3 }};


            List<Empleado> empleadosCiudad = (from empleado in empleados where empleado.Localidad == "Ciudad" select empleado).ToList();
            Console.WriteLine("Empleados de ciudad");
            foreach (var empleado in empleadosCiudad) Console.WriteLine($"{empleado.Nombre} {empleado.Apellido}");
            Console.WriteLine("---------------------------------------");
            
            List<Empleado> empleadosInicioA = (from empleado in empleados where empleado.Apellido.StartsWith("A") select empleado).ToList();
            Console.WriteLine("Empleados con apellidos iniciados en A");
            foreach (var empleado in empleadosInicioA) Console.WriteLine($"{empleado.Nombre} {empleado.Apellido}");
            Console.WriteLine("---------------------------------------");

            List<Empleado> empleadosSinInasistencia = (from empleado in empleados where empleado.DiasInasistencia == 0 select empleado).ToList();
            Console.WriteLine("Empleados sin inasistencias");
            foreach (var empleado in empleadosSinInasistencia) Console.WriteLine($"{empleado.Nombre} {empleado.Apellido}");
            Console.WriteLine("---------------------------------------");

            List<Empleado> empleadosCiudadSalarioMayor = (from empleado in empleados where empleado.Localidad == "Ciudad" && empleado.Salario > 35000 select empleado).ToList();
            Console.WriteLine("Empleados de ciudad con salario mayor a 35000");
            foreach (var empleado in empleadosCiudadSalarioMayor) Console.WriteLine($"{empleado.Nombre} {empleado.Apellido}");
            Console.WriteLine("---------------------------------------");

            List<Empleado> empleadosInasistenciaSalarioMenor = (from empleado in empleados where empleado.DiasInasistencia > 0 || empleado.Salario < 30000 select empleado).ToList();
            Console.WriteLine("Empleados con inasistencia o con salario menor a 35000");
            foreach (var empleado in empleadosInasistenciaSalarioMenor) Console.WriteLine($"{empleado.Nombre} {empleado.Apellido}");
            Console.WriteLine("---------------------------------------");

            List<Empleado> empleadosNombreFinalN= (from empleado in empleados where empleado.Nombre.EndsWith("n") select empleado).ToList();
            Console.WriteLine("Empleados con nombres finalizados en n");
            foreach (var empleado in empleadosNombreFinalN) Console.WriteLine($"{empleado.Nombre} {empleado.Apellido}");
            Console.WriteLine("---------------------------------------");

            List<Empleado> empleadosSalarioAscendente = (from empleado in empleados orderby empleado.Salario ascending select empleado).ToList();
            Console.WriteLine("Empleados ordenados por salario en orden ascendente");
            foreach (var empleado in empleadosSalarioAscendente) Console.WriteLine($"{empleado.Nombre} {empleado.Apellido}");
            Console.WriteLine("---------------------------------------");

            List<Empleado> empleadosInasistenciaDescendente = (from empleado in empleados orderby empleado.DiasInasistencia descending select empleado).ToList();
            Console.WriteLine("Empleados ordenados por salario en orden ascendente");
            foreach (var empleado in empleadosInasistenciaDescendente) Console.WriteLine($"{empleado.Nombre} {empleado.Apellido}");
            Console.WriteLine("---------------------------------------");

            var empleadosLocalidad = from empleado in empleados group empleado by empleado.Localidad;
            Console.WriteLine("Empleados ordenados por Localidad");
            foreach(var empleadoGroup in empleadosLocalidad)
 {
                Console.WriteLine(empleadoGroup.Key);
                foreach (var empleado in empleadoGroup)
                {
                    Console.WriteLine(" {0}", $"{empleado.Nombre} {empleado.Apellido}");
                }
            }
            Console.WriteLine("---------------------------------------");

            List<int> empleadosSalario = (from empleado in empleados select empleado.Salario).ToList();
            var salarios = empleadosSalario.Count();
            var maxSalario = empleadosSalario.Max();
            var salarioPromedio = empleadosSalario.Average();
            var primerSalario = empleadosSalario.First();
            Console.WriteLine("Total de salarios: " + salarios +
                              "\nMáximo salario: " + maxSalario +
                              "\nPromedio de los salarios: " + salarioPromedio +
                              "\nPrimer salario retornado: " + primerSalario + "\n");
            Console.WriteLine("---------------------------------------");
        }
    }
}
