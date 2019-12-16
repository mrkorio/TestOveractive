using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TestOveractive.Entities
{
    public class TipoPermiso
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Descripcion { get; set; }

    }
}
