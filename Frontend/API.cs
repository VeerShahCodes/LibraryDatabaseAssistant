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
        public void AddBookToSystem(string title, string author, string genre)
        {
            using (WebClient client = new WebClient())
            {
                try
                {
                    client.Headers[HttpRequestHeader.ContentType] = "application/json";
                    string result = client.UploadString($"http://localhost:5062/Library/AddBookToSystem?title={title}&author={author}&genre={genre}", title);
                    Console.WriteLine($"Response from API: {result}");
                }
                catch (WebException exception)
                {
                    Console.WriteLine($"Error: {exception.Message}");
                }
            }

        }

        public void RegisterMember(string name)
        {
            using (WebClient client = new WebClient())
            {
                try
                {
                    client.Headers[HttpRequestHeader.ContentType] = "application/json";
                    string result = client.UploadString($"http://localhost:5062/Library/RegisterMember?name={name}", name);
                    Console.WriteLine($"Response from API: {result}");
                }
                catch (WebException exception)
                {
                    Console.WriteLine($"Error: {exception.Message}");
                }
            }
        }

        public void RegisterLibrary(string location)
        {
            using (WebClient client = new WebClient())
            {
                try
                {
                    client.Headers[HttpRequestHeader.ContentType] = "application/json";
                    string result = client.UploadString($"http://localhost:5062/Library/RegisterNewLibrary?location={location}", location);
                    Console.WriteLine($"Response from API: {result}");
                }
                catch(WebException exception) 
                {
                    Console.WriteLine($"Error: {exception.Message}");
                }
            }
        }

        public List<Library.Models.Library> GetLibraries()
        {
            using (WebClient client = new WebClient())
            {
                try
                {
                    string result = client.DownloadString($"http://localhost:5062/Library/GetLibraries?");
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

        public List<Member> GetMembers()
        {
            using (WebClient client = new WebClient())
            {
                try
                {
                    string result = client.DownloadString($"http://localhost:5062/Library/GetMembers?");
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
    }
}
