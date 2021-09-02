using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace apiMarcaje.Models
{
    public class Usuario
    {
        [Key]
        public int Id_usuario { get; set; }

        public string Nombre_completo { get; set; }

        public string Departamento { get; set; }

        public string Correo { get; set; }

        public string Contraseña { get; set; }



    }
}
