using Library.Models;
using Microsoft.AspNetCore.Mvc;

namespace Library.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LibraryController : ControllerBase
    {
        SQL sql = new SQL("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"\\\\GMRDC1\\Folder Redirection\\Veer.Shah\\Documents\\Visual Studio 2022\\Projects\\SQLAPIs\\Library\\DB\\Database1.mdf\";Integrated Security=True");

        [HttpGet("GetMessage")]
        public string Message()
        {
            return "Hello World!";
        }

        [HttpPost("SignUp")]
        public ActionResult SignUpMember(string username, string password)
        {
            object id;
            if(sql.RegisterMember(username, password, 1, out id))
            {
                return Ok(new Member((int)id, username, password, 0, 1));
            }
            return BadRequest();
        
        }

        [HttpGet("Login")]
        public ActionResult Login(string username, string password)
        {
            object id;
            if (sql.Login(username, password, out id))
            {
                return Ok(new Member((int)id, username, password, 0, 1));
            }
            return BadRequest();
        }

        [HttpPost("RegisterLibrary")]
        public ActionResult RegisterLibrary(string location)
        {
            object id;
            if(sql.RegisterNewLibrary(location, out id))
            {
                return Ok(new Models.Library((int)id, location));
            }
            return BadRequest();
        }

        [HttpPost("AddAuthor")]
        public ActionResult AddAuthor(string name)
        {
            object id;
            if(sql.AddAuthor(name, out id))
            {
                return Ok(new Author((int)id, name));
            }
            return BadRequest();
        }

        [HttpPost("AddGenre")]
        public ActionResult AddGenre(string name)
        {
            object id;
            if(sql.AddGenre(name, out id))
            {
                return Ok(new Genre((int)id, name));
            }
            return BadRequest();
        }

        [HttpPost("AddBook")]
        public ActionResult AddBook(string title,  string description)
        {
            object id;
            if(sql.AddBookToSystem(title, description, out id))
            {
                return Ok(new Book((int)id, title, description));
            }
            return BadRequest();
        }

        [HttpPost("AddBooksToGenres")]
        public ActionResult AddBooksToGenres(int bookID, int genreID)
        {
            object id;
            if(sql.AddBooksToGenres(bookID, genreID, out id))
            {
                return Ok(new BooksToGenres((int)id, bookID, genreID));
            }
            return BadRequest();
        }

        [HttpPost("AddBooksToAuthors")]
        public ActionResult AddBooksToAuthors(int bookID, int authorID)
        {
            object id;
            if(sql.AddBooksToAuthors(bookID, authorID, out id))
            {
                return Ok(new BooksToAuthors((int)id, bookID, authorID));
            }
            return BadRequest();
        }

        [HttpPost("AddSeries")]
        public ActionResult AddSeries(string name)
        {
            object id;
            if(sql.AddSeries(name, out id))
            {
                return Ok(new Series((int)id, name));
            }
            return BadRequest();
        }

        [HttpPost("AddBooksToSeries")]
        public ActionResult AddBooksToSeries(int bookID, int seriesID)
        {
            object id;
            if(sql.AddBooksToSeries(bookID, seriesID, out id))
            {
                return Ok(new BooksToSeries((int)id, bookID, seriesID));
            }
            return BadRequest();
        }

        [HttpPost("AddAuthorsToSeries")] 
        public ActionResult AddAuthorsToSeries(int authorID, int seriesID)
        {
            object id;
            if (sql.AddAuthorsToSeries(authorID, seriesID, out id))
            {
                return Ok(new AuthorsToSeries((int)id, authorID, seriesID));
            }
            return BadRequest();
        }


    }
}