using Microsoft.AspNetCore.Mvc;
using Library.Models;
using System.Data;
namespace Library.Controllers
{



    [ApiController]
    [Route("[controller]")]
    public class LibraryController : ControllerBase
    {
        SQL sql = new SQL("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"\\\\GMRDC1\\Folder Redirection\\Veer.Shah\\Documents\\Visual Studio 2022\\Projects\\SQLAPIs\\Library\\DB\\Database1.mdf\";Integrated Security=True");

        [HttpPost("AddBookToSystem")]
        public ActionResult AddBookToSystem(string title, string author, string genre)
        {
            object id = -1;
            if(sql.AddBookToSystem(title, author, genre, out id))
            {
                int intId = (int)id;

                return Ok(new Book(intId, title, author, genre));
            }

            return BadRequest();
        }

        [HttpPost("RegisterNewLibrary")]
        public ActionResult RegisterNewLibrary(string location)
        {
            if(sql.RegisterNewLibrary(location, out object id))
            {
               

                return Ok(new Models.Library((int)id, location));
            }
            return BadRequest();
        }

        [HttpPost("RegisterMember")]
        public ActionResult RegisterMember(string name)
        {
            if(sql.RegisterMember(name, out object id))
            {
            

                return Ok(new Member((int)id, name));
            }
            return BadRequest();
        }

        [HttpPost("AddBookToLibrary")]
        public ActionResult AddBookToLibrary(int library_id, int book_id)
        {
            if(sql.AddBookToLibrary(library_id, book_id, out object id, out object quantity))
            {
                int intId = (int)id;
                int intQuantity = (int)quantity;

                return Ok(new LibraryBook(intId, library_id, book_id, intQuantity));
            }
            return BadRequest();
        }

        [HttpGet("GetLibraryBookInfo")]
        public ActionResult GetLibraryBookInfo(int library_id, int book_id)
        {
            if(sql.GetLibraryBookInfo(library_id, book_id, out LibraryBook book))
            {
                return Ok(book);
            }
            return BadRequest();
        }

        [HttpGet("GetLibraries")]
        public ActionResult GetLibraries()
        {
            return Ok(sql.GetLibraries());
        }

        [HttpGet("GetMembers")]
        public ActionResult GetMembers()
        {
            return Ok(sql.GetMembers());
        }


        [HttpGet("GetBooks")]
        public ActionResult GetBooks()
        {
            return Ok(sql.GetBooks());
        }
        
    }
}
