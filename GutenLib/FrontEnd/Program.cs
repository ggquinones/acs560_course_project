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

        static async Task<Byte[]> LoadBookAsync(string path)
        {
            Byte[] content = null;
            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                content = await response.Content.ReadAsByteArrayAsync();
            }
            return content;
        }

        static void Main()
        {
            RunAsync().Wait();
        }

        static async Task RunAsync()
        {
            client.BaseAddress = new Uri("http://gutenberg-library-ggquinones.c9users.io/");
            client.DefaultRequestHeaders.Accept.Clear();
            //client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/zip"));

            try
            {     
                Byte [] file;
                file = await LoadBookAsync("getBook?file=ChristmasCarol.epub");
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


                EpubContent bookContent = book.Content;
                Dictionary<string, EpubByteContentFile> images = bookContent.Images;
                EpubByteContentFile firstImage = images.Values.First();

                // Content type (e.g. EpubContentType.IMAGE_JPEG, EpubContentType.IMAGE_PNG)
                EpubContentType contentType = firstImage.ContentType;

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
        }
    }

    
}