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
        private static string url = "http://gutenberg-library.ggquinones.c9users.io/";
        private static WebRequest request;

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

        public static Library GetUserLibraryById(int userid)
        {
            request = WebRequest.Create(url + "GetUserLib?userid=" + userid);
            request.ContentType = "application/json; charset=utf-8";
            string result;
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            using (var sr = new StreamReader(response.GetResponseStream()))
            {
                result = sr.ReadToEnd();
            }
            result = result.Substring(8).TrimEnd('}');
            Console.WriteLine(result);
            JArray array = JArray.Parse(result);
            List<Book> books = new List<Book>();
            foreach (JObject obj in array.Children<JObject>())
            {
                int id = (int)obj["bookid"];
                string title = (string)obj["title"];
                string author = (string)obj["author"];
                string subject = (string)obj["subject"];/*
                EpubBook epubBook = GetEpubBookById(id);
                Image cover = Book.GetCoverFromEpub(epubBook);
                List<string> pages = Book.GetPagesFromEpub(epubBook);
                Book book = new Book(id, title, author, subject, cover, pages);
                books.Add(book);*/
                Book book = new Book(id, title, author, subject);
                books.Add(book);
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
