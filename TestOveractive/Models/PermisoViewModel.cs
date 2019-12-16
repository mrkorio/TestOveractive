using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestOveractive.Models
{
    public class PermisoViewModel
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Por favor ingrese el nombre del empleado.")]
        public string NombreEmpleado { get; set; }
        [Required(ErrorMessage = "Por favor ingrese el apellido del empleado.")]
        public string ApellidosEmpleado { get; set; }
        [Required(ErrorMessage = "Por favor ingrese el tipo de permiso.")]
        public int? TipoPermisoId { get; set; }
        [Required(ErrorMessage = "Por favor ingrese la fecha.")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime Fecha { get; set; }

    }
}
