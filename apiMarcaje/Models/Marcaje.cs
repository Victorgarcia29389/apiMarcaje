using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace apiMarcaje.Models
{
    public class Marcaje
    {
        [Key]
        public int Id_marcaje { get; set; }

        public int Id_usuario { get; set; }

        public DateTime Fecharegistro { get; set; }


    }
}
