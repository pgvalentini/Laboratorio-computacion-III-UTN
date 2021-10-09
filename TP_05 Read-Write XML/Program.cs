using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3TP5
{
    class Program
    {
        static void Main(string[] args)
        {
            EscribirXML.CrearDocumentoXML();

            EscribirXMLWriter.CrearDocumentoXML();

            LeerXML.Leer();

            LeerXMLReader.Leer();
        }
    }
}
