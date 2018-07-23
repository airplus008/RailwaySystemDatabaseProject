using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;

using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RailwaySystemDatabaseProject.Models
{
    public enum TrainTypeEnum
    {
        G=0, 
        D=1,
        K=2
    }

    public enum TrainFreightTypeEnum
    {
        Freight = 0,
        Passenger = 1,
        Combination = 2
    }
    public enum TrainRunningSituationEnum
    {
        Maintenance = 0,
        Running = 1,
    }


    public class Train
    {
       
        [Key]
        [Column(TypeName = "varchar(10)")]
        public string ID { get; set; }

        [Column(TypeName = "int(1)")]
        [Required]
        public TrainTypeEnum trainType { get; set; }

        [Column(TypeName = "int(1)")]
        public TrainFreightTypeEnum trainFreightType { get; set; }

        [Column(TypeName = "int(1)")]
        [Required]
        public TrainRunningSituationEnum trainRunningSituatio { get; set; }

    }
}
