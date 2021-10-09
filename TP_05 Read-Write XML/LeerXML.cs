using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml;
using System.IO;

namespace Lab3TP5
{
    public static class LeerXML
    {
        public static void Leer()
        {
            string xml = LecturaXML();
            Console.Write(xml);
            Console.WriteLine("Presione enter para continuar");
            Console.ReadLine();
        }

        public static string LecturaXML()
        {
            string resultado = "";
            string path = Directory.GetCurrentDirectory();
            path = path.Replace("bin\\Debug", "");

            try
            {

                XmlDocument xDoc = new XmlDocument();
                xDoc.Load(path + "miXMLEmpleados.xml");
                XmlNodeList empleados = xDoc.GetElementsByTagName("empleados");
                XmlNodeList listado = ((XmlElement)empleados[0]).GetElementsByTagName("empleado");

                foreach (XmlElement nodo in listado)
                {

                    int i = 0;

                    XmlNodeList nId =
                    nodo.GetElementsByTagName("id");

                    XmlNodeList nNombreCompleto =
                    nodo.GetElementsByTagName("nombreCompleto");

                    XmlNodeList nCuil =
                    nodo.GetElementsByTagName("cuil");

                    XmlNodeList nSector =
                    nodo.GetElementsByTagName("sector");

                    string denominacion = null;
                    string id = null;
                    string valorSemaforo = null;
                    string colorSemaforo = null;

                    foreach (XmlElement item in nSector)
                    {
                        denominacion = item.GetAttribute("denominacion");
                        id = item.GetAttribute("id");
                        valorSemaforo = item.GetAttribute("valorSemaforo");
                        colorSemaforo = item.GetAttribute("colorSemaforo");
                    }

                    /*if (denominacion != null && denominacion != "")
                    {
                        resultado += denominacion;
                    }*/

                    XmlNodeList nCupoAsignado =
                    nodo.GetElementsByTagName("cupoAsignado");

                    XmlNodeList nCupoConsumido =
                    nodo.GetElementsByTagName("cupoConsumido");
                    

                    resultado += "ID: " + nId[i].InnerText + " \n" +
                        "Nombre Completo: " + nNombreCompleto[i].InnerText + " \n" +
                        "CUIL: " + nCuil[i].InnerText + " \n" +
                        "Sector: " + nSector[i].InnerText + " \n" +
                        "Denominación: " + denominacion + " \n" +
                        "ID: " + id + " \n" +
                        "Valor Semáforo: " + valorSemaforo + " \n" +
                        "Color Semáforo: " + colorSemaforo + " \n" +
                        "Cupo Asignado: " + nCupoAsignado[i].InnerText + " \n" +
                        "Cupo Consumido: " + nCupoConsumido[i++].InnerText + "\n\n\n";

                }

                XmlNodeList nSubsectores =
                    xDoc.GetElementsByTagName("subsectores");

                XmlNodeList nTotalCupoAsignadoSector =
                    xDoc.GetElementsByTagName("totalCupoAsignadoSector");

                XmlNodeList nTotalCupoConsumidoSector =
                    xDoc.GetElementsByTagName("totalCupoConsumidoSector");

                XmlNodeList nValorDial =
                    xDoc.GetElementsByTagName("valorDial");

                resultado += "Subsectores: " + nSubsectores[0].InnerText + " \n" +
                    "Total Cupo Asignado Sector: " + nTotalCupoAsignadoSector[0].InnerText + " \n" +
                    "Total Cupo Consumido Sector: " + nTotalCupoConsumidoSector[0].InnerText + " \n" +
                    "Valor Dial: " + nValorDial[0].InnerText + "\n\n";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            return resultado;

        }
    }
}
