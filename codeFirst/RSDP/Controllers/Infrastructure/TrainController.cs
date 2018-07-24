using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RailwaySystemDatabaseProject.Models;

namespace RailwaySystemDatabaseProject.Controllers
{
    [Route("Train")]
    public class TrainController : ApiController
    {
        //train post
        [HttpPost]
        public string Create(Train train)
        {
            using (var ctx = new OracleDbContext())
            {
                try
                {
                    ctx.Trains.Add(train);
                    ctx.SaveChanges();
                }
                catch (Exception e)
                {
                    return e.ToString();
                }

            }
            return "OK";
        }

        //train/count get
        [Route("Train/Count")]
        public int Count()
        {
            using (var ctx = new OracleDbContext())
            { 
                var count=ctx.Trains.Count();
                return count;
            }
           
        }
    }
}
