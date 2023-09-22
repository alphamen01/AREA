using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AREA.Models
{
    [Table("Cliente", Schema = "mantenimiento")]
    public class Cliente
    {
        [Key]
        [Display(Name = "id_cliente")]
        public int id_cliente { get; set; }

        [Display(Name = "nombre")]
        public string nombre { get; set; }

        [Display(Name = "direccion")]
        public string direccion { get; set; }

        [Display(Name = "telefono")]
        public  string telefono { get; set; }

        
        public ICollection<Area> Areas { get; set; }

    }
}
