using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace DespensaBarrial.BD.Datos
{
    public abstract class EntityBase
    {

        [Key]

        [Required]

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]//autoincremental

        public int Id { get; set; }

        // [DisplayFormat]

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? FechaCreacion { get; set; }


    }
}
