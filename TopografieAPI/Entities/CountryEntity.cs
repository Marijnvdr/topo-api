using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TopografieAPI.Entities
{
    [Table("Countries")]
    public class CountryEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CountryId { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Name_nl { get; set; }

        [Required]
        [StringLength(5)]
        public string Region { get; set; }

        [Required]
        [StringLength(5)]
        public string SubRegion { get; set; }

        [Required]
        [StringLength(5)]
        public string Code { get; set; }
    }
}