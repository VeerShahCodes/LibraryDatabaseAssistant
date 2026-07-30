using Microsoft.AspNetCore.Mvc;
using Library.Models;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System;
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

        [HttpGet("GetAvailableBooksByLibrary")]
        public ActionResult GetAvailableBooksByLibrary(int library_id)
        {
            return Ok(sql.GetAvailableBooksByLibrary(library_id));
        }

        [HttpGet("GetBookById")]
        public ActionResult GetBookById(int book_id)
        {
            if (sql.GetBookByID(book_id, out string title, out string author, out string genre))
            {
                Book book = new Book(book_id, title, genre, author);
                return Ok(book);
            }
            else
            {
                return BadRequest();
            }

        }

        [HttpPost("CheckoutBook")]
        public ActionResult CheckoutBook(int book_id, int member_id, int library_id)
        {
            if(sql.CheckoutBook(book_id, library_id, member_id, out object id))
            {
                return Ok(new MemberLibraryBook((int)id, member_id, book_id, library_id, DateTime.Now));
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpGet("GetCheckedOutBooksByLibrary")]
        public ActionResult GetCheckedOutBooksByLibrary(int library_id)
        {
            return Ok(sql.GetCheckedOutBooksByLibrary(library_id));
        }

        [HttpGet("GetCheckedOutBooksByMember")]
        public ActionResult GetCheckedOutBooksByMember(int member_id)
        {
            return Ok(sql.GetCheckedOutBooksByMember(member_id));
        }

        [HttpGet("GetMemberById")]
        public ActionResult GetMemberById(int member_id)
        {
            if (sql.GetMemberInfoByID(member_id, out string name))
            {
                return Ok(new Member(member_id, name));
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpGet("GetLibraryById")]
        public ActionResult GetLibraryById(int library_id)
        {
            if (sql.GetLibraryByID(library_id, out string location))
            {
                return Ok(new Models.Library(library_id, location));
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPost("ReturnBook")]
        public ActionResult ReturnBook(int member_id, int book_id, int library_id, int mlbId)
        {
            if (sql.ReturnBook(member_id, book_id, library_id, mlbId, out int id, out int quantity))
            {
                return Ok(new LibraryBook(id, book_id, library_id, quantity));
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
