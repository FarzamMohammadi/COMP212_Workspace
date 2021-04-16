using _301109706_Mohammadi__Test2.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _301109706_Mohammadi__Test2.Data
{
    class DataAccess
    {
        //Combo Box Fruit
        public List<Fruit> GetAllFruits()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("dddDB")))
            {
                return connection.Query<Fruit>("select * from Fruits where FruitId<5;").ToList();

            }
        }
        //Combo Box Planets
        public List<Planet> GetAllPlanets()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("dddDB")))
            {
                return connection.Query<Planet>("select * from Planets where PlanetId<3;").ToList();

            }
        }

        //To Display Initial Data For DataGrid 1
        public List<Fruit> GetUserAddedFruits()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("dddDB")))
            {
                return connection.Query<Fruit>("select * from Fruits where FruitId>4;").ToList();

            }
        }
        //To Display Initial Data For DataGrid 2
        public List<Planet> GetUserAddedPlanets()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("dddDB")))
            {
                return connection.Query<Planet>("select * from Planets where PlanetId>2;").ToList();

            }
        }

        //To Display Initial Data For DataGrid 1
        public List<Fruit> InsertFruit(string name, string color)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("dddDB")))
            {
                return connection.Query<Fruit>($"insert into Fruits (Name, Color) values('{name}', '{color}');").ToList();

            }
        }
        //To Display Initial Data For DataGrid 2
        public List<Planet> InsertPlanet(string name, string color)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("dddDB")))
            {
                return connection.Query<Planet>($"insert into Planets (Name2, Color2) values('{name}', '{color}');").ToList();

            }
        }


        //Linq Project QS
        public List<Fruit> GetAllFruitsOverID()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("dddDB")))
            {
                return connection.Query<Fruit>($"select Name from Fruits where FruitId>4;").ToList();

            }
        }

        //Linq Filter QS
        public List<Fruit> GetAllFruitsWithColor(string color)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("dddDB")))
            {
                return connection.Query<Fruit>($"select Name from Fruits where Color ='{color}' and FruitId>4;").ToList();

            }
        }

        //Linq Order ASC QS
        public List<Fruit> GetAllFruitsASC()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("dddDB")))
            {
                return connection.Query<Fruit>($"select Name from Fruits where FruitId>4 order by Name asc;").ToList();

            }
        }

        //Linq Order ASC QS
        public List<PlanetAndFruit> GetAllJoinByColor()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("dddDB")))
            {
                return connection.Query<PlanetAndFruit>($"select a.Name, b.Name2 from Fruits a join Planets b on a.Color=b.Color2 where a.FruitId>4 and b.PlanetId>2;").ToList();
            }
        }

        //Delete Row From Fruits Table
        public void RemoveFriut(int fruitID)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("dddDB")))
            {
                connection.Query<Fruit>($"delete from Fruits where FruitId='{fruitID}'");

            }
        }

        //Delete Row From Planets Table
        public void RemovePlanet(int planetID)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("dddDB")))
            {
                connection.Query<Planet>($"delete from Planets where PlanetId='{planetID}'");

            }
        }

        //Deletes All User Created Rows / Back To Original Values
        public void ClearAllUserCreatedRows()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("dddDB")))
            {
                connection.Query<Planet>("delete from Fruits where FruitId>4;");
                connection.Query<Planet>("delete from Planets where PlanetId>2;");

            }
        }


    }
}
