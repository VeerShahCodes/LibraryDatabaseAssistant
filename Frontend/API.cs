using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Xml.Linq;
using Library.Models;
namespace Frontend
{
    public class API
    {
        public async Task AddBookToSystem(string title, string author, string genre)
        {
            
            using (WebClient client = new WebClient())
            {   
                
                try
                {
                    client.Headers[HttpRequestHeader.ContentType] = "application/json";
                    string result = await client.UploadStringTaskAsync($"http://localhost:5062/Library/AddBookToSystem?title={title}&author={author}&genre={genre}", title);                    
                    Console.WriteLine($"Response from API: {result}");
                }
                catch (WebException exception)
                {
                    Console.WriteLine($"Error: {exception.Message}");
                }
            }

        }

        public async Task RegisterMember(string name)
        {
            using (WebClient client = new WebClient())
            {
                try
                {
                    client.Headers[HttpRequestHeader.ContentType] = "application/json";
                    string result = await client.UploadStringTaskAsync($"http://localhost:5062/Library/RegisterMember?name={name}", name);
                    Console.WriteLine($"Response from API: {result}");
                }
                catch (WebException exception)
                {
                    Console.WriteLine($"Error: {exception.Message}");
                }
            }
        }

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

        public async Task AddBookToLibrary(int book_id, int library_id)
        {

            using (WebClient client = new WebClient())
            {
                try
                {
                    client.Headers[HttpRequestHeader.ContentType] = "application/json";
                    string result = await client.UploadStringTaskAsync($"http://localhost:5062/Library/AddBookToLibrary?library_id={library_id}&book_id={book_id}", ".");
                    Console.WriteLine($"Response from API: {result}");
                }
                catch (WebException exception)
                {
                    Console.WriteLine($"Error: {exception.Message}");
                }
            }
        }
    }
}
