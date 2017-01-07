using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeTest.Models
{
    [Table("Student")]
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(80)]
        [StringLength(80)]
        [Display(Name = "Student Name")]
        public string StudentName { get; set; }

        [Required]
        [MaxLength(80)]
        [StringLength(80)]
        [Display(Name = "Student Surname")]
        public string StudentSurname { get; set; }

        [Required]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime DOB { get; set; }

        public decimal? GPA { get; set; }
    }
}