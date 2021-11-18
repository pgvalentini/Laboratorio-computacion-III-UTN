using Lab3Practico4ReadWriteFiles;
using Lab3Practico6Json.ModeloUsuarios;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static Lab3Practico6Json.ModeloUsuarios.ModeloUsuarios;

namespace Lab3Practico6Json.Controlador
{
    class ControladorUsers
    {

        public void LeerJSONFromURL(string url)
        {
            
            //Uso la clase WebClient que pasa la url a string
            WebClient wc = new WebClient();
            //con el método DownLoadString
            string usuariosJson = wc.DownloadString(url);

            var usuarios = JsonConvert.DeserializeObject<Users>(usuariosJson);
            var us = usuarios.results;
            
            foreach (Result res in us)
            {
                Console.WriteLine("First Name: " + res.name.first);
                Console.WriteLine("Last Name: " + res.name.last);
                Console.WriteLine("Username: " + res.login.username);
                Console.WriteLine("Password: " + res.login.password);
                Console.WriteLine("-----------------------------");
            }


        }


        public void LeerJSONFromURL2(string url)
        {

            //Uso la clase WebClient que pasa la url a string
            WebClient wc = new WebClient();
            //con el método DownLoadString
            var usuariosJson = wc.DownloadString(url);

            var usuarios = JsonConvert.DeserializeObject<List<Result>>(usuariosJson);


            foreach (Result res in usuarios)
            {
                Console.WriteLine("First Name: " + res.name.first);
                Console.WriteLine("Last Name: " + res.name.last);
                Console.WriteLine("Username: " + res.login.username);
                Console.WriteLine("Password: " + res.login.password);
                Console.WriteLine("-----------------------------");
            }


        }
    }
}
