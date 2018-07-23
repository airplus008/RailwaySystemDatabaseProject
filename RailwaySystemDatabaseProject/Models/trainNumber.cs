using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Linq.Expressions;

namespace RailwaySystemDatabaseProject.Models
{

    public enum DirectionEnum
    {
        Up = 0,
        Down = 1
       
    }
  

    public class TrainNumber
    {
        
        public string trainNumber { get; set; }

     
        public TrainTypeEnum type { get; set; }

  
        public DirectionEnum direction { get; set; }

    }
}
