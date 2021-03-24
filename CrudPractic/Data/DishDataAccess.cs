using CrudPractic.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudPractic.Data
{
    public class DishDataAccess
    {
        public List<Dish> GetAll()
        {
            using (var connection = new SqlConnection())
            {
                connection.ConnectionString = "Sever = (localdb)\\mssqllocaldb; Database = FluentAPI; Trusted_Connection = true;";
                connection.Open();
                var sql = "select * from Dihes";
                return connection.Query<Dish>(sql).ToList();
            }
        }
        public void Add(Dish dish)
        {
            using (var connection = new SqlConnection())
            {
                connection.ConnectionString = "Sever = (localdb)\\mssqllocaldb; Database = FluentAPI; Trusted_Connection = true;";
                connection.Execute("insert into Dishes(Id, Name) values (@Id, @Name)", dish);       
            }
        }
    }
}
