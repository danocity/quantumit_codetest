using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeTest.Models
{
    [Table("Class")]
    public class Class
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(80)]
        [StringLength(80)]
        [Display(Name = "Class Name")]
        public string ClassName { get; set; }

        [Required]
        [MaxLength(100)]
        [StringLength(100)]
        public string Teacher { get; set; }
    }
}