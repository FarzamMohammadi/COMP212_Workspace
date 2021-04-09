using _301109706_Mohammadi__Lab05_Ex2.Models.Books.db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;

namespace _301109706_Mohammadi__Lab05_Ex2.ViewModels
{
    public class DataAccess
    {
        public List<Authors> GetAuthor(string lastName)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BooksDB")))
            {
                return connection.Query<Authors>($"select * from Authors where LastName = '{ lastName }'").ToList();

            }
        }
    }
}
