
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RailwaySystemDatabaseProject.Models;

namespace RailwaySystemDatabaseProject.DatabaseManager
{
    public class Base
    {
        public static SqlSugarClient GetInstance()
        {
            SqlSugarClient db = new SqlSugarClient(new ConnectionConfig() { ConnectionString = Config.ConnectionString, DbType = DbType.Oracle, IsAutoCloseConnection = true,InitKeyType = InitKeyType.Attribute
             });
         

            return db;
        }
    }
}
