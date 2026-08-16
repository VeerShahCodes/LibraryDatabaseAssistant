using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Xml.Linq;
using Library.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding;
namespace Frontend
{
    public class API
    {
        //public async Task AddBookToSystem(string title, string author, string genre)
        //{
            
        //    using (WebClient client = new WebClient())
        //    {   
                
        //        try
        //        {
        //            client.Headers[HttpRequestHeader.ContentType] = "application/json";
        //            string result = await client.UploadStringTaskAsync($"http://localhost:5062/Library/AddBookToSystem?title={title}&author={author}&genre={genre}", title);                    
        //            Console.WriteLine($"Response from API: {result}");
        //        }
        //        catch (WebException exception)
        //        {
        //            Console.WriteLine($"Error: {exception.Message}");
        //        }
        //    }

        //}

        //public async Task RegisterMember(string name)
        //{
        //    using (WebClient client = new WebClient())
        //    {
        //        try
        //        {
        //            client.Headers[HttpRequestHeader.ContentType] = "application/json";
        //            string result = await client.UploadStringTaskAsync($"http://localhost:5062/Library/RegisterMember?name={name}", name);
        //            Console.WriteLine($"Response from API: {result}");
        //        }
        //        catch (WebException exception)
        //        {
        //            Console.WriteLine($"Error: {exception.Message}");
        //        }
        //    }
        //}

        public async Task RegisterLibrary(string location)
        {
            using (WebClient client = new WebClient())
            {
                try
                {
                    client.Headers[HttpRequestHeader.ContentType] = "application/json";
                    string result = await client.UploadStringTaskAsync($"http://localhost:5062/Library/RegisterNewLibrary?location={location}", location);
                    Console.WriteLine($"Response from API: {result}");
                }
                catch(WebException exception) 
                {
                    Console.WriteLine($"Error: {exception.Message}");
                }
            }
        }

        public async Task<List<Library.Models.Library>> GetLibraries()
        {
            using (WebClient client = new WebClient())
            {
                try
                {
                    string result = await client.DownloadStringTaskAsync($"http://localhost:5062/Library/GetLibraries?");
                    List<Library.Models.Library> libraries = JsonSerializer.Deserialize<List<Library.Models.Library>>(result);
                    Console.WriteLine($"response from api: {result}");
                    return libraries;
                }
                catch (WebException exception)
                {
                    Console.WriteLine($"Error: {exception.Message}");
                    return null;
                }
            }
        }

        public async Task<List<Member>> GetMembers()
        {
            using (WebClient client = new WebClient())
            {
                try
                {
                    string result = await client.DownloadStringTaskAsync($"http://localhost:5062/Library/GetMembers?");
                    List<Member> members = JsonSerializer.Deserialize<List<Member>>(result);
                    Console.WriteLine($"response from api: {result}");
                    return members;
                }
                catch (WebException exception)
                {
                    Console.WriteLine($"Error: {exception.Message}");
                    return null;
                }
            }
        }

        public async Task<List<Book>> GetBooks()
        {
            using (WebClient client = new WebClient())
            {
                try
                {
                    string result = await client.DownloadStringTaskAsync($"http://localhost:5062/Library/GetBooks?");
                    List<Book> books = JsonSerializer.Deserialize<List<Book>>(result);
                    Console.WriteLine($"reponse from api: {result}");
                    return books;
                }
                catch (WebException exception)
                {
                    Console.WriteLine($"Error: {exception.Message}");
                    return null;
                }
            }
        }

        //public async Task AddBookToLibrary(int book_id, int library_id)
        //{

        //    using (WebClient client = new WebClient())
        //    {
        //        try
        //        {
        //            client.Headers[HttpRequestHeader.ContentType] = "application/json";
        //            string result = await client.UploadStringTaskAsync($"http://localhost:5062/Library/AddBookToLibrary?library_id={library_id}&book_id={book_id}", ".");
        //            Console.WriteLine($"Response from API: {result}");
        //        }
        //        catch (WebException exception)
        //        {
        //            Console.WriteLine($"Error: {exception.Message}");
        //        }
        //    }
        //}

        //public async Task<List<LibraryBook>> GetAvailableBooksByLibrary(int library_id)
        //{
        //    using (WebClient client = new WebClient())
        //    {
        //        List<LibraryBook> books = new List<LibraryBook>();
        //        try
        //        {
        //            string result = await client.DownloadStringTaskAsync($"http://localhost:5062/Library/GetAvailableBooksByLibrary?library_id={library_id}");
        //            books = JsonSerializer.Deserialize<List<LibraryBook>>(result);
        //            Console.WriteLine($"reponse from api: {result}");
        //            return books;
        //        }
        //        catch
        //        {
        //            Console.WriteLine("Error: Unable to get available books from library.");
        //        }
        //        return books;
        //    }
        //}

        public async Task<Book> GetBookById(int book_id)
        {
            using (WebClient client = new WebClient())
            {
                try
                {
                    string result = await client.DownloadStringTaskAsync($"http://localhost:5062/Library/GetBookById?book_id={book_id}");
                    Book book = JsonSerializer.Deserialize<Book>(result);
                    Console.WriteLine($"reponse from api: {result}");
                    return book;

                }
                catch
                {
                    Console.WriteLine("Error: Unable to retrieve book by ID.");
                }
   
            }
            return null;
        }

        //public async Task CheckoutBook(int member_id, int book_id, int library_id)
        //{
        //    using (WebClient client = new WebClient())
        //    {
        //        try
        //        {
        //            client.Headers[HttpRequestHeader.ContentType] = "application/json";
        //            string result = await client.UploadStringTaskAsync($"http://localhost:5062/Library/CheckoutBook?book_id={book_id}&member_id={member_id}&library_id={library_id}", "a");
        //            Console.WriteLine($"Response from API: {result}");
        //        }
        //        catch (WebException exception)
        //        {
        //            Console.WriteLine($"Error: {exception.Message}");
        //        }
        //    }
        //}

        //public async Task<List<MemberLibraryBook>> GetCheckedOutBooksByLibrary(int library_id)
        //{
        //    List<MemberLibraryBook> checkedOutBooks = new List<MemberLibraryBook>();

        //    using (WebClient client = new WebClient())
        //    {
        //        try
        //        {
        //            string result = await client.DownloadStringTaskAsync($"http://localhost:5062/Library/GetCheckedOutBooksByLibrary?library_id={library_id}");
        //            checkedOutBooks = JsonSerializer.Deserialize<List<MemberLibraryBook>>(result);
        //            Console.WriteLine($"reponse from api: {result}");
        //            return checkedOutBooks;
        //        }
        //        catch
        //        {
        //            Console.WriteLine("Error: Unable to retrieve checked out books.");
        //        }
        //    }

        //    return checkedOutBooks;
        //}

        public async Task<Member> GetMemberById(int member_id)
        {
            using (WebClient client = new WebClient())
            {
                try
                {
                    string result = await client.DownloadStringTaskAsync($"http://localhost:5062/Library/GetMemberById?member_id={member_id}");
                    Member member = JsonSerializer.Deserialize<Member>(result);
                    Console.WriteLine($"reponse from api: {result}");
                    return member;
                }
                catch
                {
                    Console.WriteLine("Error: Unable to retrieve member by ID.");
                }

            }
            return null;
        }

        public async Task<Library.Models.Library> GetLibraryById(int library_id)
        {
            using (WebClient client = new WebClient())
            {
                try
                {
                    string result = await client.DownloadStringTaskAsync($"http://localhost:5062/Library/GetLibraryById?library_id={library_id}");
                    Library.Models.Library library = JsonSerializer.Deserialize<Library.Models.Library>(result);
                    Console.WriteLine($"reponse from api: {result}");
                    return library;
                }
                catch
                {
                    Console.WriteLine("Error: Unable to retrieve library by ID.");
                }
            }
            return null;
        }

        //public async Task<List<MemberLibraryBook>> GetCheckedOutBooksByMember(int member_id)
        //{
        //    List<MemberLibraryBook> checkedOutBooks = new List<MemberLibraryBook>();

        //    using (WebClient client = new WebClient())
        //    {
        //        try
        //        {
        //            string result = await client.DownloadStringTaskAsync($"http://localhost:5062/Library/GetCheckedOutBooksByMember?member_id={member_id}");
        //            checkedOutBooks = JsonSerializer.Deserialize<List<MemberLibraryBook>>(result);
        //            Console.WriteLine($"reponse from api: {result}");
        //            return checkedOutBooks;
        //        }
        //        catch
        //        {
        //            Console.WriteLine("Error: Unable to retrieve checked out books.");
        //        }
        //    }

        //    return checkedOutBooks;
        //}

        //public async Task ReturnBook(int member_id, int book_id, int library_id, int mlbId)
        //{
        //    using (WebClient client = new WebClient())
        //    {
        //        try
        //        {
        //            client.Headers[HttpRequestHeader.ContentType] = "application/json";
        //            string result = await client.UploadStringTaskAsync($"http://localhost:5062/Library/ReturnBook?member_id={member_id}&book_id={book_id}&library_id={library_id}&mlbId={mlbId}", "a");
        //            Console.WriteLine($"Response from API: {result}");
        //        }
        //        catch (WebException exception)
        //        {
        //            Console.WriteLine($"Error: {exception.Message}");
        //        }
        //    }
        //}
    }
}
