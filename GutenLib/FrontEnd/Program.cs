/* 
using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace FrontEnd2
{   
    class Program
    {
         static HttpClient client = new HttpClient();
         static void Main()
        {
            client.BaseAddress = new Uri("http://gutenberg-library-ggquinones.c9users.io/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/epub+zip"));
            HttpResponseMessage response =  client.GetAsync("/getBook/?file=PAP.epub");
            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("Something received!");
            }

        }  

    }

}
*/

using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using VersOne.Epub;
using System.Collections.Generic;
namespace HttpClientSample
{
    
    class Program
    {
        static HttpClient client = new HttpClient();

        static async Task<Byte[]> GetBookAsync(int bookid)
        {
            
            string bookPath = "getBook?bookid="+bookid;
            Byte[] content = null;
            HttpResponseMessage response = await client.GetAsync(bookPath);
            if (response.IsSuccessStatusCode)
            {
                content = await response.Content.ReadAsByteArrayAsync();
            }
            return content;
        }

        static async Task SaveBookAsync()
        {
            client.BaseAddress = new Uri("http://gutenberg-library-ggquinones.c9users.io/");
            client.DefaultRequestHeaders.Accept.Clear();
            Byte[] file = await GetBookAsync(1);
            File.WriteAllBytes("copy.epub", file);

            Console.WriteLine("File saved");

        }

        static async Task GetUserLibAsync(int userid)
        {
            client.BaseAddress = new Uri("http://gutenberg-library-ggquinones.c9users.io/");
            client.DefaultRequestHeaders.Accept.Clear();
            string bookPath = "GetUserLib?userid="+userid;
            HttpResponseMessage response = await client.GetAsync(bookPath);
            
            string libJSON="";
            if (response.IsSuccessStatusCode)
            {
                 libJSON= await response.Content.ReadAsStringAsync();
            }
            
            Console.WriteLine(libJSON);            
        }

        static void Main()
        {
            GetUserLibAsync(1).Wait();
        }

        /*static async Task RunAsync()
        {
            client.BaseAddress = new Uri("http://gutenberg-library-ggquinones.c9users.io/");
            client.DefaultRequestHeaders.Accept.Clear();
            //client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/zip"));

            try
            {     
                Byte [] file;
                file = await LoadBookAsync("getBook?file=Frankenstein.epub");
                File.WriteAllBytes("copy.epub", file);
                Console.WriteLine("File saved");
                EpubBook book = await EpubReader.ReadBookAsync("copy.epub");
                Console.WriteLine("epub made");
                string title = book.Title;
                string author = book.Author;
                List<EpubChapter> chapters = book.Chapters;

                Console.WriteLine(title+" by "+author+" was downloaded!");
                string chps = "";
                foreach(EpubChapter chp in chapters)
                {
                    chps += chp.Title +"\n";
                }   
                Console.WriteLine(chps); 
                byte[] coverImageContent = book.CoverImage;     
                if(coverImageContent != null)
                {
                    Console.WriteLine("Has cover image");
                }     
                else{
                    Console.WriteLine("No image");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }*/
    }

    
}