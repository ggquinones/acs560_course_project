using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VersOne.Epub;

namespace GutenLib
{
    public class Book
    {
        private int id;
        private string title;
        private string author;
        private string subject;
        private Image cover;
        private List<string> pages;
        private int currentPage;

        public Book(int id, string title, string author, string subject)
        {
            this.id = id;
            this.title = title;
            this.author = author;
            this.subject = subject;
            this.currentPage = 1;
            pages = new List<string>();
        }

        public Book(int id, string title, string author, string subject, Image cover, List<string> pages)
        {
            this.id = id;
            this.title = title;
            this.author = author;
            this.subject = subject;
            this.currentPage = 1;
            this.cover = cover;
            this.pages = pages;
        }

        public int Id
        {
            get { return id; }
        }

        public string Title
        {
            get
            {
                if (title is null || title.Equals(""))
                {
                    return "Unknown";
                }
                else
                {
                    return title;
                }
            }
        }

        public string Author
        {
            get
            {
                if(author is null || author.Equals(""))
                {
                    return "Unknown";
                }
                else
                {
                    return author;
                }
            }
        }

        public string Subject
        {
            get
            {
                if (subject is null || subject.Equals(""))
                {
                    return "Unknown";
                }
                else
                {
                    return subject;
                }
            }
        }

        public Image Cover
        {
            get { return cover; }
            set { cover = value; }
        }

        public string Page
        {
            get
            {
                if(pages.Count > 0)
                {
                    return pages[currentPage - 1];
                }
                else
                {
                    return "";
                }
            }
        }

        public List<string> Pages
        {
            get { return pages; }
            set { pages = value; }
        }

        public void SetCover(byte[] coverByteArray)
        {
            using (MemoryStream imageStream = new MemoryStream(coverByteArray))
            {
                cover = Image.FromStream(imageStream);
            }
        }

        public void NextPage()
        {
            if(currentPage < pages.Count)
            {
                currentPage++;
            }
        }

        public void PreviousPage()
        {
            if(currentPage > 1)
            {
                currentPage--;
            }
        }

        public static Image GetCoverFromEpub(EpubBook book)
        {
            Image cover = null;
            foreach (KeyValuePair<string, EpubContentFile> entry in book.Content.AllFiles)
            {
                if (entry.Key.Contains("cover"))
                {
                    EpubByteContentFile file = (EpubByteContentFile)book.Content.AllFiles[entry.Key];
                    using (MemoryStream imageStream = new MemoryStream(file.Content))
                    {
                        cover = Image.FromStream(imageStream);
                    }
                    break;
                }
            }
            return cover;
        }

        public static List<string> GetPagesFromEpub(EpubBook book)
        {
            List<string> pages = new List<string>();
            EpubContent bookContent = book.Content;
            Dictionary<string, EpubTextContentFile> htmlFiles = bookContent.Html;
            foreach(EpubTextContentFile file in htmlFiles.Values)
            {
                pages.Add(file.Content);
            }
            /*
            string currentPageFileName = "";
            foreach (EpubChapter chapter in book.Chapters)
            {
                if (!currentPageFileName.Equals(chapter.ContentFileName))
                {
                    pages.Add(chapter.HtmlContent);
                }
                currentPageFileName = chapter.ContentFileName;
            }*/
            return pages;
        }
    }
}
