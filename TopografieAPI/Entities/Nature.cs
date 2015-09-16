using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TopografieAPI.Entities
{
    [Table("NatureElements")]
    public class Nature
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NatureId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int Category { get; set; }
    }
}