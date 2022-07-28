using CrudAuthor.Entities;
using CrudAuthor.Services;

namespace CrudAuthor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AuthorService service = new AuthorService();

            List<Author> authors = service.GetAuthors();
            

            listAuthors.DataSource = authors;
            listAuthors.DisplayMember = "name";
            listAuthors.ValueMember = "id";
        }
    }
}