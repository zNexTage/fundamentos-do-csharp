using CrudAuthor.Entities;
using System.Data.Common;

namespace CrudAuthor.Repositories
{
    internal class AuthorRepository
    {
        private readonly DbConnection connection;
        private readonly DbCommand command;

        public AuthorRepository(DbConnection connection, DbCommand command)
        {
            this.connection = connection;
            this.command = command;
            this.command.Connection = connection;
        }

        public List<Author> GetAuthors()
        {
            List<Author> authors = new List<Author>();

            string queryCommand = "SELECT * FROM authors";

            this.command.CommandText = queryCommand;
            DbDataReader reader = this.command.ExecuteReader();            

            while (reader.Read())
            {
                int id = Convert.ToInt32(reader["id"].ToString());
                string name = reader["name"].ToString();
                string description = reader["description"].ToString();

                Author author = new Author(id, name, description);

                authors.Add(author);
            }

            return authors;
        }
    }
}
