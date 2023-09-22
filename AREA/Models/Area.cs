using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AREA.Models
{
    [Table("Area", Schema = "mantenimiento")]
    public class Area
    {
        [Key]
        [Display(Name = "id_area")]
        public int id_area { get; set; }

        [Display(Name = "descripcion")]
        public string descripcion { get; set; }

        [Display(Name = "id_cliente")]
        public int id_cliente { get; set; }

        [Display(Name = "enu_estado_registro")]
        public  Char enu_estado_registro { get; set; }

        [Display(Name = "usuario_creacion")]
        public string? usuario_creacion { get; set; }

        [Display(Name = "fecha_creacion")]
        public DateTime? fecha_creacion { get; set; }

        [Display(Name = "usuario_modificacion")]
        public string? usuario_modificacion{ get; set; }

        [Display(Name = "fecha_modificacion")]
        public DateTime? fecha_modificacion { get; set; }

        [ForeignKey("id_cliente")]
        public Cliente ClienteFK { get; set; }

    }
}
