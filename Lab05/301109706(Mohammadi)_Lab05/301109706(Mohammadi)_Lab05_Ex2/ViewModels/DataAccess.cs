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
        public void submitNewBook(string iSBN, string title, int editionNum, string copyright, string[] authors)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BooksDB")))
            {
                connection.Query<Titles>($"insert into Titles (ISBN,Title,EditionNumber,Copyright) values ('{ iSBN }', '{ title }', '{ editionNum }', '{ copyright }');");
                
            }

            List<string> names = new List<string>();
            for (int i = 0; i < authors.Length; i++)
            {
                try
                {
                    names.Add(authors[i] + " " + authors[i + 1]);
                    using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BooksDB")))
                    {
                        connection.Query<Titles>($"insert into Authors (FirstName, LastName) values ('{authors[i]}', '{authors[i + 1]}');");
                        i++;
                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine(e);
                }
            }

            List<int> authorIdNumbers = new List<int>();
            foreach(string name in names)
            {
                string fname = name.Split(' ')[0];
                string lname = name.Split(' ')[1];
                List<Authors> list = new List<Authors>();
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BooksDB")))
                {
                    list = connection.Query<Authors>($"select AuthorID from Authors where FirstName ='{ fname }' and LastName ='{ lname }';").ToList();


                    foreach(Authors entry in list)
                    {
                        connection.Query<Titles>($"insert into AuthorISBN (AuthorID,ISBN) values ('{ entry.AuthorID }', '{ iSBN }');");
                    }
                }
            }

        }

        public List<Titles> GetAllBooks()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BooksDB")))
            {
                return connection.Query<Titles>("select c.Title, a.FirstName, a.LastName from Authors a join AuthorISBN b on a.AuthorID = b.AuthorID join Titles c on b.ISBN = c.ISBN group by c.title, a.FirstName, a.LastName order by c.Title asc;").ToList();

            }
        }
    }
}
