using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VersOne.Epub;

namespace GutenLib
{
    public partial class MainForm : Form
    {
        private Library library;
        private BookLabel[] recentShelf;
        private BookLabel[] libraryShelf;
        private int recentShelfPosInLib;
        private int libraryShelfPosInLib;
        private Book currentBookBeingRead;

        public MainForm(Library library)
        {
            this.library = library;
            recentShelfPosInLib = 0;
            libraryShelfPosInLib = 0;
            InitializeComponent();

            recentShelf = new BookLabel[6];
            libraryShelf = new BookLabel[6];
            foreach(Control c in pnlContent.Controls)
            {
                if(c is Label)
                {
                    Label lbl = (Label)c;
                    if (lbl.Name.Contains("LibraryBook"))
                    {
                        int index = int.Parse((string)lbl.Tag) - 7;
                        libraryShelf[index] = new BookLabel(library.GetBook(index), lbl);
                    }
                    if (lbl.Name.Contains("RecentBook"))
                    {
                        int index = int.Parse((string)lbl.Tag) - 1;
                        recentShelf[index] = new BookLabel(library.GetBook(index), lbl);
                    }
                }
            }
            
            for(int i = 0; i < 6; i++)
            {
                recentShelf[i].SetCover();
                libraryShelf[i].SetCover();
            }

            // for testing
            Console.WriteLine("Number of books: " + library.Count);
        }

        private void ShowOrHideOptions(object sender, EventArgs e)
        {
            if (pnlOptions.Visible == false)
            {
                pnlOptions.Visible = true;
                lblShowOptions.Text = "Hide Options";
            }
            else
            {
                pnlOptions.Visible = false;
                lblShowOptions.Text = "Show Options";
            }
        }

        private void SortLibrary(object sender, EventArgs e)
        {
            RadioButton button = (RadioButton)sender;
            lblLibrary.Text = "Library | " + button.Text;
            libraryShelfPosInLib = 0;

            if (button.Text.Equals("All"))
            {
                library.Randomize();
            }
            if (button.Text.Equals("Title"))
            {
                library.SortByTitle();
            }
            if (button.Text.Equals("Author"))
            {
                library.SortByAuthor();
            }
            if (button.Text.Equals("Subject"))
            {
                library.SortBySubject();
            }

            for(int i = 0; i < 6; i++)
            {
                libraryShelf[i].Book = library.GetBook(i);
                libraryShelf[i].SetCover();
            }

        }

        // needs to be edited so recent cycles through recent library
        private void CycleShelf(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;
            int libSize = library.Count;
            if (lbl.Tag.Equals("recent"))
            {
                if (lbl.Text.Equals("<"))
                {
                    recentShelfPosInLib--;
                    if(recentShelfPosInLib < 0)
                    {
                        recentShelfPosInLib = libSize - 1;
                    }
                }
                else
                {
                    recentShelfPosInLib++;
                    if(recentShelfPosInLib >= libSize)
                    {
                        recentShelfPosInLib = 0;
                    }
                }
            }
            else
            {
                if (lbl.Text.Equals("<"))
                {
                    libraryShelfPosInLib--;
                    if (libraryShelfPosInLib < 0)
                    {
                        libraryShelfPosInLib = libSize - 1;
                    }
                }
                else
                {
                    libraryShelfPosInLib++;
                    if (libraryShelfPosInLib >= libSize)
                    {
                        libraryShelfPosInLib = 0;
                    }
                }
            }

            UpdateShelf((string)lbl.Tag);
        }
        
        private void UpdateShelf(string shelfType)
        {
            int position;
            int size = library.Count;
            if (shelfType.Equals("recent"))
            {
                position = recentShelfPosInLib;
                for (int i = 0; i < 6; i++)
                {
                    if (position >= size)
                    {
                        position = 0;
                    }
                    recentShelf[i].Book = library.GetBook(position);
                    recentShelf[i].SetCover();
                    position++;
                }
            }
            if (shelfType.Equals("library"))
            {
                position = libraryShelfPosInLib;
                for (int i = 0; i < 6; i++)
                {
                    if (position >= size)
                    {
                        position = 0;
                    }
                    libraryShelf[i].Book = library.GetBook(position);
                    libraryShelf[i].SetCover();
                    position++;
                }
            }
        }
        
        private void OpenOrCloseBook(object sender, EventArgs e)
        {
            BookLabel bl = DetermineBookLabel(sender);

            if (bl.IsOpen)
            {
                bl.SetCover();
            }
            else
            {
                for(int i = 0; i < 6; i++)
                {
                    recentShelf[i].SetCover();
                    libraryShelf[i].SetCover();
                }
                bl.SetInfo();
            }
        }

        private BookLabel DetermineBookLabel(object sender)
        {
            Label lbl = (Label)sender;
            BookLabel bl;

            int index = int.Parse((string)lbl.Tag);
            if (index < 7)
            {
                index -= 1;
                bl = recentShelf[index];
            }
            else
            {
                index -= 7;
                bl = libraryShelf[index];
            }

            return bl;
        }

        private void ReadBook(object sender, EventArgs e)
        {
            BookLabel bl = DetermineBookLabel(sender);
            currentBookBeingRead = bl.Book;
            //temp
            EpubBook epubBook = ServerProxy.GetEpubBookById(currentBookBeingRead.Id);
            currentBookBeingRead.Cover = Book.GetCoverFromEpub(epubBook);
            currentBookBeingRead.Pages = Book.GetPagesFromEpub(epubBook);

            lblTitle.Text = currentBookBeingRead.Title + " by " + currentBookBeingRead.Author;
            pnlReader.Visible = true;
            pnlReader.BringToFront();
            htmlReader.DocumentText = currentBookBeingRead.Page;
            htmlReader.Focus();
        }

        private void NavigateBook(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            if (label.Tag.Equals("close"))
            {
                CloseReader();
            }
            if (label.Tag.Equals("previous"))
            {
                PreviousPage();
            }
            if (label.Tag.Equals("next"))
            {
                NextPage();
            }
        }

        private void CloseReader()
        {
            pnlReader.Visible = false;
            currentBookBeingRead = null;
        }

        private void PreviousPage()
        {
            currentBookBeingRead.PreviousPage();
            htmlReader.DocumentText = currentBookBeingRead.Page;
        }

        private void NextPage()
        {
            currentBookBeingRead.NextPage();
            htmlReader.DocumentText = currentBookBeingRead.Page;
        }

        private void KeyPressEvents(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.Up)
            {
                e.IsInputKey = true;
            }
            if(e.KeyCode == Keys.Left)
            {
                PreviousPage();
            }
            if(e.KeyCode == Keys.Right)
            {
                NextPage();
            }
            if(e.KeyCode == Keys.Escape)
            {
                CloseReader();
            }
        }

        private void Login(object sender, EventArgs e)
        {
            if (txtUsername.Text.ToLower().Equals("admin") && txtPassword.Text.Equals("password"))
            {
                pnlLogin.Visible = false;
                lblStatus.Text = "";
                pnlMaster.Visible = true;
            }
            else
            {
                lblStatus.Text = "Incorrect username and password combination";
                txtUsername.Text = "";
                txtPassword.Text = "";
            }
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }
    }
}
