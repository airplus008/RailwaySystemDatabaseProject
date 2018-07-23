using System;
using System.Collections.Generic;

using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace RailwaySystemDatabaseProject.Models
{

    [Table("crewTable")]
    public class Crew
    {
        [Key]
        [Column(TypeName = "varchar(20)")]
        [Required]
        public string crewID { get; set; }

        [Column(TypeName = "int(3)")]
        [Required]
        public int numberOfPeople { get; set; }

        [Column(TypeName = "varchar(25)")]
        [Required]
        public string chiefOfCrew { get; set; }

        [Column(TypeName = "varchar(25)")]
        [Required]
        public string mainDriver { get; set; }

        [Column(TypeName = "varchar(25)")]
        [Required]
        public string viceDriver { get; set; }

        public List<Staff> staff { get; set; }

    }
}
