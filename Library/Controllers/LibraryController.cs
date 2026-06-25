using Microsoft.AspNetCore.Mvc;
using Library.Models;
using System.Data;
namespace Library.Controllers
{



    [ApiController]
    [Route("[controller]")]
    public class LibraryController : ControllerBase
    {
        SQL sql = new SQL("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\shahv\\source\\repos\\LibraryDatabaseAssistant\\DB\\Database1.mdf;Integrated Security=True");

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
                int intId = (int)id;

                return Ok(new Models.Library(intId, location));
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

        
    }
}
