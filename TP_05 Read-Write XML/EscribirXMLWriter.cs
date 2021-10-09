using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.IO;
using System.Xml;

namespace Lab3TP5
{
    public static class EscribirXMLWriter
    {
        public static void CrearDocumentoXML()
        {
            string path = Directory.GetCurrentDirectory();
            path = path.Replace("bin\\Debug", "");
            EscribirXML(path);
        }

        public static void EscribirXML(string ruta)
        {
            XmlTextWriter myXmlTextWriter = new XmlTextWriter(ruta + "miXMLEmpleadosWriter.xml", null);
            myXmlTextWriter.Formatting = Formatting.Indented;
            myXmlTextWriter.WriteStartDocument(false);
            myXmlTextWriter.WriteComment("");

            myXmlTextWriter.WriteStartElement("empleados");
            myXmlTextWriter.WriteStartElement("listado");
            
            myXmlTextWriter.WriteStartElement("empleado");
            myXmlTextWriter.WriteElementString("id", "4884");
            myXmlTextWriter.WriteElementString("nombreCompleto", "Rodriguez, Victor");
            myXmlTextWriter.WriteElementString("cuil", "20103180326");

            myXmlTextWriter.WriteStartElement("sector", null);
            myXmlTextWriter.WriteAttributeString("colorSemaforo", "VERDE");
            myXmlTextWriter.WriteAttributeString("valorSemaforo", "130.13");
            myXmlTextWriter.WriteAttributeString("id", "137");
            myXmlTextWriter.WriteAttributeString("denominacion", "Gerencia Recursos Humanos");
            myXmlTextWriter.WriteEndElement();

            myXmlTextWriter.WriteElementString("cupoAsignado", "1837.15");
            myXmlTextWriter.WriteElementString("cupoConsumido", "658.02");
            myXmlTextWriter.WriteEndElement();

            myXmlTextWriter.Flush();

            myXmlTextWriter.WriteStartElement("empleado");
            myXmlTextWriter.WriteElementString("id", "1225");
            myXmlTextWriter.WriteElementString("nombreCompleto", "Sanchez, Juan Ignacio");
            myXmlTextWriter.WriteElementString("cuil", "20271265817");

            myXmlTextWriter.WriteStartElement("sector", null);
            myXmlTextWriter.WriteAttributeString("colorSemaforo", "ROJO");
            myXmlTextWriter.WriteAttributeString("valorSemaforo", "130.13");
            myXmlTextWriter.WriteAttributeString("id", "44");
            myXmlTextWriter.WriteAttributeString("denominacion", "Gerencia Operativa");
            myXmlTextWriter.WriteEndElement();

            myXmlTextWriter.WriteElementString("cupoAsignado", "750.87");
            myXmlTextWriter.WriteElementString("cupoConsumido", "625.46");
            myXmlTextWriter.WriteEndElement();

            myXmlTextWriter.Flush();

            myXmlTextWriter.WriteEndElement();

            myXmlTextWriter.WriteElementString("subsectores", "5");
            myXmlTextWriter.WriteElementString("totalCupoAsignadoSector", "4217.21");
            myXmlTextWriter.WriteElementString("totalCupoConsumidoSector", "1405.88");
            myXmlTextWriter.WriteElementString("valorDial", "33.34");

            myXmlTextWriter.WriteEndElement();

            myXmlTextWriter.Flush();
            myXmlTextWriter.Close();
        }
    }
}
