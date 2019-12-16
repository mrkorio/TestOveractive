using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestOveractive.Entities
{
    public class Permiso
    {   
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required(ErrorMessage = "Por favor ingrese el nombre del empleado.")]
        public string NombreEmpleado { get; set; }
        [Required(ErrorMessage = "Por favor ingrese el apellido del empleado.")]
        public string ApellidosEmpleado { get; set; }
        [Required(ErrorMessage = "Por favor ingrese el tipo de permiso.")]
        [ForeignKey("TipoPermisoId")]
        public int TipoPermisoId { get; set; }
        [Required(ErrorMessage = "Por favor ingrese la fecha.")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]      
        public DateTime Fecha { get; set; }
        

    }
}
