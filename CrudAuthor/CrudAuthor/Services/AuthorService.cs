using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using CrudAuthor.Entities;
using CrudAuthor.Repositories;

namespace CrudAuthor.Services
{
    internal class AuthorService
    {
        public List<Author> GetAuthors()
        {
            MySqlConnection connection = new MySqlConnection("Server=localhost;Database=db_crudson;User Id=root;Password=M@joka19;");

            connection.Open();

            AuthorRepository repository = new AuthorRepository(connection, new MySqlCommand());

            return repository.GetAuthors();
        }
    }
}
