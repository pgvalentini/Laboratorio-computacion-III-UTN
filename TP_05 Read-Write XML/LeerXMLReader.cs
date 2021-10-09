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
    public static class LeerXMLReader
    {
        public static void Leer()
        {
            string xml = LeerXML();
            Console.Write(xml);
            Console.WriteLine("Presione enter para continuar");
            Console.ReadLine();
        }

        private static string LeerXML()
        {
            string resultado = "";
            string path = Directory.GetCurrentDirectory();
            path = path.Replace("bin\\Debug", "");

            using (XmlReader reader = XmlReader.Create(path + "miXMLEmpleados.xml"))
            {
                while (reader.Read())
                {
                    if (reader.IsStartElement())
                    {
                        switch (reader.Name)
                        {
                            case "empleados":
                                resultado += "Start <empleados> element." + "\n";
                                break;
                            case "listado":
                                resultado += "Start <listado> element." + "\n";
                                break;
                            case "empleado":
                                resultado += "Start <empleado> element." + "\n";
                                break;
                            case "id":
                                if (reader.Read())
                                {
                                    resultado += " Id: " + reader.Value.Trim() + "\n";
                                }
                                break;
                            case "nombreCompleto":
                                if (reader.Read())
                                {
                                    resultado += " Nombre Completo: " + reader.Value.Trim() + "\n";
                                }
                                break;
                            case "cuil":
                                if (reader.Read())
                                {
                                    resultado += " Cuil: " + reader.Value.Trim() + "\n";
                                }
                                break;

                            case "sector":
                                resultado += "Sector: \n";
                                string attDenominacion = reader["denominacion"];
                                if (attDenominacion != null)
                                {
                                    resultado += "  Denominacion: " + attDenominacion + "\n";
                                }
                                string attID = reader["id"];
                                if (attID != null)
                                {
                                    resultado += "  Id: " + attID + "\n";
                                }
                                string attValorSemaforo = reader["valorSemaforo"];
                                if (attValorSemaforo != null)
                                {
                                    resultado += "  Valor Semaforo: " + attValorSemaforo + "\n";
                                }
                                string attColorSemaforo = reader["colorSemaforo"];
                                if (attColorSemaforo != null)
                                {
                                    resultado += "  Color Semaforo: " + attColorSemaforo + "\n";
                                }
                                break;

                            case "cupoAsignado":
                                if (reader.Read())
                                {
                                    resultado += " Cupo Asignado: " + reader.Value.Trim() + "\n";
                                }
                                break;
                            case "cupoConsumido":
                                if (reader.Read())
                                {
                                    resultado += " Cupo Consumido: " + reader.Value.Trim() + "\n\n\n";
                                }
                                break;


                            case "subsectores":
                                if (reader.Read())
                                {
                                    resultado += " Subsectores: " + reader.Value.Trim() + "\n";
                                }
                                break;
                            case "totalCupoAsignadoSector":
                                if (reader.Read())
                                {
                                    resultado += " Total Cupo Asignado Sector: " + reader.Value.Trim() + "\n";
                                }
                                break;
                            case "totalCupoConsumidoSector":
                                if (reader.Read())
                                {
                                    resultado += " Total Cupo Consumido Sector: " + reader.Value.Trim() + "\n";
                                }
                                break;
                            case "valorDial":
                                if (reader.Read())
                                {
                                    resultado += " Valor Dial: " + reader.Value.Trim() + "\n";
                                }
                                break;
                        }
                    }
                }
                reader.Close();
            }

            
            return resultado;
        }
    }
}
