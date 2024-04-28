using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AR100621_Guia8.Models
{
    public class Contacto
    {
        public int idContacto { get; set; }
        public string Nombres { get; set; } 
        public string Apellidos { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
    }
}