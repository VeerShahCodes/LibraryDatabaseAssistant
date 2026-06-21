using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

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
    }
}
