using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Linq.Expressions;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace RailwaySystemDatabaseProject.Models
{

    public enum GenderEnum
    {
        Male = 0,
        Female = 1

    }
    public enum TypeOfWorkEnum
    {
        Steward =1,
        Driver,
        Conductor,
        Repairman,
        Treasurer,
        Porter,
        Supercargo//押运人
    }
    public enum PositionEnum
    {
        Primary=1,
        Secondary=2,
        Senior
    }

    [Table("staffTable")]
    public class Staff
    {
        [Key]

        public string ID { get; set; }
       
        public string name { get; set; }

        public GenderEnum gender { get; set; }

        public string IDCardNumber { get; set; }

        public TypeOfWorkEnum typeOfWork {get; set; }
        public PositionEnum position { get; set; }

    }
}
