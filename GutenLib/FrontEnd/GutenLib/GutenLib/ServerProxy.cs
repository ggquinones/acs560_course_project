using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using VersOne.Epub;

namespace GutenLib
{
    public static class ServerProxy
    {
        private static string url = "http://project560-ggquinones.c9users.io/";
        private static WebRequest request;

        public static bool AddBookToUserLibrary(int userid, int bookid)
        {
            bool bookAdded = false;
            request = WebRequest.Create(url + "AddToUserBooks?userid=" + userid + "&bookid=" + bookid);
            request.ContentType = "application/x-www-form-urlencoded";
            try
            {
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Console.WriteLine(response.StatusDescription);
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    Console.WriteLine("status code ok");
                    bookAdded = true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("status code not ok");
                Console.WriteLine(e.Message);
            }
            return bookAdded;
        }

        public static bool RemoveBookFromUserLibrary(int userid, int bookid)
        {
            bool bookRemoved = false;
            request = WebRequest.Create(url + "DeleteFromUserLib?userid=" + userid + "&bookid=" + bookid);
            request.ContentType = "application/x-www-form-urlencoded";
            try
            {
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Console.WriteLine(response.StatusDescription);
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    bookRemoved = true;
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return bookRemoved;
        }

        public static Library GetGutenLibrary()
        {
            request = WebRequest.Create(url + "GutenLib");
            request.ContentType = "application/json; charset=utf-8";
            string result;
            List<Book> books = new List<Book>();
            try
            {
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                using (var sr = new StreamReader(response.GetResponseStream()))
                {
                    result = sr.ReadToEnd();
                }
                result = result.Substring(8).TrimEnd('}');
                JArray array = JArray.Parse(result);
                foreach (JObject obj in array.Children<JObject>())
                {
                    int id = (int)obj["bookid"];
                    string title = (string)obj["title"];
                    string author = (string)obj["author"];
                    string subject = (string)obj["subject"];
                    string url = (string)obj["viewlink"];
                    Book book = new Book(id, title, author, subject, url);
                    books.Add(book);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return new Library(books);
        }

        public static bool UsernameExistsInDB(string username)
        {
            bool userExists = false;
            request = WebRequest.Create(url + "ValidateUser?username=" + username);
            try
            {
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Console.WriteLine(response.StatusDescription);
                if(response.StatusCode == HttpStatusCode.OK)
                {
                    userExists = true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return userExists;
        }

        public static bool AddUserToDB(string username, string password)
        {
            bool addedSuccessfully = false;
            request = WebRequest.Create(url + "AddUser?username=" + username + "&pwd=" + password);
            try
            {
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Console.WriteLine(response.StatusDescription);

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    addedSuccessfully = true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return addedSuccessfully;
        }

        public static int ValidateUser(string username, string password)
        {
            int user_id = -1;       // -1 indicates user does not exist
            request = WebRequest.Create(url + "ValidateLogin?username=" + username + "&pwd=" + password);
            try
            {
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Console.WriteLine(response.StatusDescription);

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    // Get the stream associated with the response.
                    Stream receiveStream = response.GetResponseStream();

                    // Pipes the stream to a higher level stream reader with the required encoding format. 
                    StreamReader readStream = new StreamReader(receiveStream, Encoding.UTF8);

                    string stream = readStream.ReadToEnd();
                    user_id = int.Parse(stream);
                    response.Close();
                    readStream.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return user_id;
        }

        // depcrecated
        public static EpubBook GetEpubBookById(int bookid)
        {
            EpubBook epubBook = null;
            request = WebRequest.Create(url + "GetBookFile?bookid=" + bookid);
            //request.ContentType = "application/x-www-form-urlencoded";
            
            try
            {
                WebResponse response = request.GetResponse();
                Console.WriteLine(((HttpWebResponse)response).StatusDescription);

                if (response != null)
                {
                    Stream remoteStream = response.GetResponseStream();
                    using (var memoryStream = new MemoryStream())
                    {
                        remoteStream.CopyTo(memoryStream);
                        response.Close();
                        File.WriteAllBytes("temp.epub", memoryStream.ToArray());
                    }
                    epubBook = EpubReader.ReadBook("temp.epub");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return epubBook;
        }

        public static Library GetUserLibrary(int userid, Library gutenLibrary)
        {
            request = WebRequest.Create(url + "GetUserLib?userid=" + userid);
            request.ContentType = "application/json; charset=utf-8";
            string result;
            List<Book> books = new List<Book>();
            try
            {
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                using (var sr = new StreamReader(response.GetResponseStream()))
                {
                    result = sr.ReadToEnd();
                }
                result = result.Substring(8).TrimEnd('}');
                Console.WriteLine(result);
                JArray array = JArray.Parse(result);
                foreach (JObject obj in array.Children<JObject>())
                {
                    int id = (int)obj["bookid"];
                    string datetime = (string)obj["lastread"];
                    int size = gutenLibrary.Count;
                    for(int i = 0; i < size; i++)
                    {
                        Book tempBook = gutenLibrary.GetBook(i);
                        if(tempBook.Id == id)
                        {
                            books.Add(new Book(id, tempBook.Title, tempBook.Author, tempBook.Subject, tempBook.Url, datetime));
                        }
                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
            return new Library(books);
        }

        /* async methods
        private static HttpClient client = new HttpClient();

        private static async Task<Byte[]> LoadBookAsync(string path)
        {
            Byte[] content = null;
            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                content = await response.Content.ReadAsByteArrayAsync();
            }
            return content;
        }

        public static async Task<EpubBook> GetBookById(int bookid)
        {
            client.BaseAddress = new Uri(url);
            client.DefaultRequestHeaders.Accept.Clear();

            try
            {
                Byte[] file;
                file = await LoadBookAsync("GetBook?bookid=" + bookid);
                File.WriteAllBytes("copy.epub", file);
                Console.WriteLine("book " + bookid + " saved as epub file");
                EpubBook book = await EpubReader.ReadBookAsync("copy.epub");
                Console.WriteLine("EpubBook object created");
                return book;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public static async Task<Library> GetUserLibraryById(int userid)
        {
            string result = null;
            client.BaseAddress = new Uri(url);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = client.GetAsync("GetUserLib?userid=" + userid).Result;
            if (response.IsSuccessStatusCode)
            {
                result = response.Content.ReadAsStringAsync().Result;
                result = result.Substring(8).TrimEnd('}');
                Console.WriteLine(result);
                JArray array = JArray.Parse(result);
                List<Book> books = new List<Book>();
                foreach(JObject obj in array.Children<JObject>())
                {
                    int id = (int)obj["bookid"];
                    string title = (string)obj["title"];
                    string author = (string)obj["author"];
                    string subject = (string)obj["subject"];
                    EpubBook epubBook = await GetBookById(id);
                    Image cover = Book.GetCoverFromEpub(epubBook);
                    List<string> pages = Book.GetPagesFromEpub(epubBook);
                    Book book = new Book(id, title, author, subject, cover, pages);
                    books.Add(book);
                }
                return new Library(books);
            }
            return null;
        }
        */

    }
}
