using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.IO;

namespace Lab3TP5
{
    public static class EscribirXML
    {
        public static void CrearDocumentoXML()
        {
            try
            {
                XElement empleados = new XElement("empleados");

                XElement listado = new XElement("listado");
                XElement empleado = new XElement("empleado");
                XElement id = new XElement("id", "4884");
                empleado.Add(id);
                XElement nombreCompleto = new XElement("nombreCompleto", "Rodriguez, Victor");
                empleado.Add(nombreCompleto);
                XElement cuil = new XElement("cuil", "20103180326");
                empleado.Add(cuil);
                XElement sector = new XElement("sector");  
                XAttribute colorSemaforo = new XAttribute("colorSemaforo", "VERDE");
                sector.Add(colorSemaforo);
                XAttribute valorSemaforo = new XAttribute("valorSemaforo", "130.13");
                sector.Add(valorSemaforo);
                XAttribute idSector = new XAttribute("id", "137");
                sector.Add(idSector);
                XAttribute denominacion = new XAttribute("denominacion", "Gerencia Recursos Humanos");
                sector.Add(denominacion);
                empleado.Add(sector);
                XElement cupoAsignado = new XElement("cupoAsignado", "1837.15");
                empleado.Add(cupoAsignado);
                XElement cupoConsumido = new XElement("cupoConsumido", "658.02");
                empleado.Add(cupoConsumido);
                listado.Add(empleado);

                empleado = new XElement("empleado");
                id = new XElement("id", "1225");
                empleado.Add(id);
                nombreCompleto = new XElement("nombreCompleto", "Sanchez, Juan Ignacio");
                empleado.Add(nombreCompleto);
                cuil = new XElement("cuil", "20271265817");
                empleado.Add(cuil);
                sector = new XElement("sector");   
                colorSemaforo = new XAttribute("colorSemaforo", "ROJO");
                sector.Add(colorSemaforo);
                valorSemaforo = new XAttribute("valorSemaforo", "130.13");
                sector.Add(valorSemaforo);
                idSector = new XAttribute("id", "44");
                sector.Add(idSector);
                denominacion = new XAttribute("denominacion", "Gerencia Operativa");
                sector.Add(denominacion);
                empleado.Add(sector);
                cupoAsignado = new XElement("cupoAsignado", "750.87");
                empleado.Add(cupoAsignado);
                cupoConsumido = new XElement("cupoConsumido", "625.46");
                empleado.Add(cupoConsumido);
                listado.Add(empleado);

                empleados.Add(listado);

                XElement subsectores = new XElement("subsectores", "5");
                empleados.Add(subsectores);

                XElement totalCupoAsignadoSector = new XElement("totalCupoAsignadoSector", "4217.21");
                empleados.Add(totalCupoAsignadoSector);

                XElement totalCupoConsumidoSector = new XElement("totalCupoConsumidoSector", "1405.88");
                empleados.Add(totalCupoConsumidoSector);

                XElement valorDial = new XElement("valorDial", "33.34");
                empleados.Add(valorDial);

                XDeclaration declaration = new XDeclaration("1.0", "utf-8", "yes");
                XComment comentario = new XComment("Empleados");
                XDocument miXML = new XDocument(declaration, comentario, empleados);


                string path = Directory.GetCurrentDirectory();
                path = path.Replace("bin\\Debug", "");
                string archivoXML = path + "miXMLEmpleados.xml";
                miXML.Save(@archivoXML);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
