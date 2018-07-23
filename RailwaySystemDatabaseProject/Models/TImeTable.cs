using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Linq.Expressions;

namespace RailwaySystemDatabaseProject.Models
{
    public enum ConditionEnum
    {
        Invaliad = 0,
        Valiad = 1

    }


    public class TimeTable
    {
        
        public DateTime date { get; set; }

        public string trainNumber { get; set; }

        public int stationOrder { get; set; }
        public DateTime departureDate { get; set; }

        public string stationID { get; set; }
        public string platformNum { get; set; }
        public DateTime arriveTime { get; set; }
        public DateTime leaveTime { get; set; }
        public DateTime duration{ get; set; }
        public ConditionEnum condition { get; set; }
        public int remainingSeatsNumber { get; set; }
        public string crewID { get; set; }
       

    }
}
