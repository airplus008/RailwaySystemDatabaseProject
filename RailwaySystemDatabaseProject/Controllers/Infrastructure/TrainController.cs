using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RailwaySystemDatabaseProject.Models;
using RailwaySystemDatabaseProject.DatabaseManager;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RailwaySystemDatabaseProject.Controllers.Infrastructure
{
    [Route("[controller]")]
    [ApiController]
    public class TrainController : Controller
    {
        [HttpGet("hello")]
        public string hello()
        {
           
            return "hello";
        }
        // GET: /train/{id}
        [HttpGet("{id}")]
        public string GetById(string id)
        {
            return "";
        }

        [HttpPost]
        public string CreateNewTrain([FromBody] Train train)
        {
            
            try{
                using(var context = new DatabaseManager.MyContext())
                {
                    var trains = context.Trains.ToList();
                    return trains[0].ID;
                }

            }
            catch(Exception e)
            {
                return e.ToString();
            }

            //var succeed = db.Insertable(train).ExecuteCommandIdentityIntoEntity();
            //return succeed;

           
        }
    }
}
