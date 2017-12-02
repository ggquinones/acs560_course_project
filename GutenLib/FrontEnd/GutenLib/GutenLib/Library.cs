using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VersOne.Epub;

namespace GutenLib
{
    public class Library
    {
        private List<Book> library;

        // used to instantiate library from folder
        public Library()
        {
            library = new List<Book>();

            // temp code below
            int count = 100;
            string[] files = Directory.GetFiles(Directory.GetCurrentDirectory() + "\\books");
            foreach (string fileName in files)
            {
                if (File.Exists(fileName))
                {
                    try
                    {
                        EpubBook epubBook = EpubReader.ReadBook(fileName.Replace("\\", "//"));
                        Book book = new Book(++count, epubBook.Title, epubBook.Author, "Unknown");
                        book.Pages = Book.GetPagesFromEpub(epubBook);
                        book.Cover = Book.GetCoverFromEpub(epubBook);
                        library.Add(book);
                    }
                    catch(Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
                
            }
        }

        public Library(List<Book> library)
        {
            this.library = library;
        }

        public int Count
        {
            get { return library.Count; }
        }

        public List<Book> Books
        {
            get { return library; }
        }

        public void CombineLibraries(Library library)
        {
            foreach(Book book in library.Books)
            {
                this.AddBook(book);
            }
        }

        public bool AddBook(Book book)
        {
            bool containsBook = false;
            foreach(Book libraryBook in library)
            {
                if(libraryBook.Id == book.Id)
                {
                    containsBook = true;
                    break;
                }
            }
            if (!containsBook)
            {
                library.Add(book);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool RemoveBook(Book book)
        {
            bool bookRemoved = false;
            int librarySize = library.Count;
            for(int i = 0; i < librarySize; i++)
            {
                if(library[i].Id == book.Id)
                {
                    library.RemoveAt(i);
                    bookRemoved = true;
                    break;
                }
            }
            return bookRemoved;
        }

        public bool RemoveBook(string title, string author)
        {
            bool bookRemoved = false;
            int librarySize = library.Count;
            for(int i = 0; i < librarySize; i++)
            {
                if (library[i].Title.Equals(title) && library[i].Author.Equals(author))
                {
                    library.RemoveAt(i);
                    bookRemoved = true;
                    break;
                }
            }
            return bookRemoved;
        }

        public Book GetBook(int index)
        {
            if(index <= library.Count - 1)
            {
                return library[index];
            }
            else
            {
                return null;
            }
            
        }

        public void SortByTitle()
        {
            library.Sort(delegate (Book x, Book y)
            {
                return x.Title.CompareTo(y.Title);
            });
        }

        public void SortByAuthor()
        {
            library.Sort(delegate (Book x, Book y)
            {
                string[] xAuthors = x.Author.Split();
                string[] yAuthors = y.Author.Split();
                return xAuthors[xAuthors.Length - 1].CompareTo(yAuthors[yAuthors.Length - 1]);
            });
        }

        public void SortBySubject()
        {
            library.Sort(delegate (Book x, Book y)
            {
                return x.Subject.CompareTo(y.Subject);
            });
        }

        public void Randomize()
        {
            Random rand = new Random();
            library = library.OrderBy(x => rand.Next()).ToList();
        }
    }
}
