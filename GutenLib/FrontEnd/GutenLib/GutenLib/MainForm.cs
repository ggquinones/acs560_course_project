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
        private Library gutenLibrary;
        private BookLabel[] shelf;
        private int currentShelfPosition;
        private Book currentBookBeingRead;
        private const int NUM_SHELF_POSITIONS = 27;
        private int user_id = -1;

        public MainForm(Library gutenLibrary)
        {
            library = null;
            this.gutenLibrary = gutenLibrary;
            shelf = new BookLabel[NUM_SHELF_POSITIONS];
            currentShelfPosition = 0;
            InitializeComponent();
            
            foreach(Control c in pnlLibrary.Controls)
            {
                if(c is Label)
                {
                    Label lbl = (Label)c;
                    if (lbl.Name.Contains("LibraryBook"))
                    {
                        int index = int.Parse((string)lbl.Tag);
                        shelf[index] = new BookLabel(null, lbl);
                    }
                }
            }
        }

        public void SetUpLibraryView()
        {
            // gets library
            library = ServerProxy.GetUserLibrary(user_id, gutenLibrary);

            // links books in library to booklabel objects
            for (int i = 0; i < NUM_SHELF_POSITIONS; i++)
            {
                shelf[i].Book = library.GetBook(i);
                shelf[i].SetCover();
            }

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
            currentShelfPosition = 0;

            if (button.Text.Equals("Recent"))
            {
                library.SortByRecent();
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

            for(int i = 0; i < NUM_SHELF_POSITIONS; i++)
            {
                shelf[i].Book = library.GetBook(i);
                shelf[i].SetCover();
            }

        }
        
        private void CycleShelf(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;
            int libSize = library.Count;

            if (lbl.Text.Equals("<"))
            {
                currentShelfPosition--;
                if (currentShelfPosition < 0)
                {
                    currentShelfPosition = libSize - 1;
                }
            }
            else
            {
                currentShelfPosition++;
                if (currentShelfPosition >= libSize)
                {
                    currentShelfPosition = 0;
                }
            }

            UpdateShelf();
        }

        private void ClearCovers()
        {
            currentShelfPosition = 0;
            for(int i = 0; i < NUM_SHELF_POSITIONS; i++)
            {
                shelf[i].Clear();
            }
        }
        
        private void UpdateShelf()
        {
            int size = library.Count;
            int position = currentShelfPosition;
            for (int i = 0; i < size; i++)
            {
                if (position >= size)
                {
                    position = 0;
                }
                shelf[i].Book = library.GetBook(position);
                shelf[i].SetCover();
                position++;
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
                for(int i = 0; i < NUM_SHELF_POSITIONS; i++)
                {
                    shelf[i].SetCover();
                }
                bl.SetInfo();
            }
        }

        private BookLabel DetermineBookLabel(object sender)
        {
            Label lbl = (Label)sender;
            int index = int.Parse((string)lbl.Tag);

            return shelf[index];
        }

        private void ReadBook(object sender, EventArgs e)
        {
            BookLabel bl = DetermineBookLabel(sender);
            currentBookBeingRead = bl.Book;
            if(currentBookBeingRead is null)
            {
                return;
            }
            /*
            EpubBook epubBook = ServerProxy.GetEpubBookById(currentBookBeingRead.Id);
            currentBookBeingRead.Cover = Book.GetCoverFromEpub(epubBook);
            currentBookBeingRead.Pages = Book.GetPagesFromEpub(epubBook);*/
            
            lblTitle.Text = currentBookBeingRead.Title + " by " + currentBookBeingRead.Author;
            pnlLibrary.Visible = false;
            pnlReader.Visible = true;
            //htmlReader.DocumentText = currentBookBeingRead.Page;
            htmlReader.Navigate(currentBookBeingRead.Url);
            htmlReader.Focus();
            bl.Book.Datetime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            
        }

        private void NavigateBook(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            if (label.Tag.Equals("close"))
            {
                CloseReader();
            }
            /*
            if (label.Tag.Equals("previous"))
            {
                PreviousPage();
            }
            if (label.Tag.Equals("next"))
            {
                NextPage();
            }*/
        }

        private void CloseReader()
        {
            pnlReader.Visible = false;
            pnlLibrary.Visible = true;
            currentBookBeingRead = null;
        }

        // deprecated
        private void PreviousPage()
        {
            currentBookBeingRead.PreviousPage();
            htmlReader.DocumentText = currentBookBeingRead.Page;
        }

        // deprecated
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
            /*
            if(e.KeyCode == Keys.Left)
            {
                PreviousPage();
            }
            if(e.KeyCode == Keys.Right)
            {
                NextPage();
            }*/
            if(e.KeyCode == Keys.Escape)
            {
                CloseReader();
            }
        }

        private void EditLibraryEvent(object sender, EventArgs e)
        {
            if (sender is Label)
            {
                ClearCovers();
                pnlLibrary.Visible = false;
                LoadUserLibraryListView();
                pnlEditLibrary.Visible = true;
                lblUserLibrary.BorderStyle = BorderStyle.Fixed3D;
                lblGlobalLibrary.BorderStyle = BorderStyle.None;
                btnAddToLibrary.Enabled = false;
                btnRemoveFromLibrary.Enabled = true;
            }
            if (sender is Button)
            {
                UpdateShelf();
                pnlLibrary.Visible = true;
                pnlEditLibrary.Visible = false;
            }
        }

        private void SwitchEditLibrary(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;
            ClearSearch(null, null);
            if (lbl.Tag.Equals("user"))
            {
                lblUserLibrary.BorderStyle = BorderStyle.Fixed3D;
                lblGlobalLibrary.BorderStyle = BorderStyle.None;
                btnAddToLibrary.Enabled = false;
                btnRemoveFromLibrary.Enabled = true;
                LoadUserLibraryListView();
            }
            if (lbl.Tag.Equals("global"))
            {
                lblUserLibrary.BorderStyle = BorderStyle.None;
                lblGlobalLibrary.BorderStyle = BorderStyle.Fixed3D;
                btnAddToLibrary.Enabled = true;
                btnRemoveFromLibrary.Enabled = false;
                LoadGlobalLibraryListView();
            }
        }

        private void ClearSearch(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            if(lblUserLibrary.BorderStyle == BorderStyle.Fixed3D)
            {
                LoadUserLibraryListView();
            }
            if(lblGlobalLibrary.BorderStyle == BorderStyle.Fixed3D)
            {
                LoadGlobalLibraryListView();
            }
        }

        private void RemoveBook(object sender, EventArgs e)
        {
            if(lstLibraryView.SelectedItems.Count > 0)
            {
                ListViewItem item = lstLibraryView.SelectedItems[0];
                string title = item.SubItems[0].Text;
                string author = item.SubItems[1].Text;
                int bookRemoved = library.RemoveBook(title, author);
                if(bookRemoved != -1)
                {
                    // book removed successfully
                    ServerProxy.RemoveBookFromUserLibrary(user_id, bookRemoved);
                    lstLibraryView.Items.Remove(item);
                }
            }
        }

        private void AddBook(object sender, EventArgs e)
        {
            if (lstLibraryView.SelectedItems.Count > 0)
            {
                ListViewItem item = lstLibraryView.SelectedItems[0];
                string title = item.SubItems[0].Text;
                string author = item.SubItems[1].Text;
                int id = gutenLibrary.GetBookId(title, author);
                if (id != -1)
                {
                    // book added successfully
                    ServerProxy.AddBookToUserLibrary(user_id, id);
                    //library = ServerProxy.GetUserLibrary(user_id, gutenLibrary);
                }
            }
        }

        private void ClearListView()
        {
            lstLibraryView.Clear();
            lstLibraryView.Columns.Add("Title", 600);
            lstLibraryView.Columns.Add("Author", 350);
            lstLibraryView.Columns.Add("Subject", 286);
        }

        private void SearchListView(object sender, EventArgs e)
        {
            string searchQuery = txtSearch.Text;
            int size = lstLibraryView.Items.Count;

            List<ListViewItem> items = new List<ListViewItem>();
            foreach(ListViewItem item in lstLibraryView.Items)
            {
                string itemToCompare = "";
                if (radSearchTitle.Checked)
                {
                    itemToCompare = item.SubItems[0].Text;
                }
                if (radSearchAuthor.Checked)
                {
                    itemToCompare = item.SubItems[1].Text;
                }
                if (radSearchSubject.Checked)
                {
                    itemToCompare = item.SubItems[2].Text;
                }
                if (itemToCompare.ToLower().Contains(searchQuery.ToLower()))
                {
                    items.Add(item);
                }
            }

            ClearListView();
            foreach(ListViewItem item in items)
            {
                lstLibraryView.Items.Add(item);
            }
            
        }

        private void LoadUserLibraryListView()
        {
            ClearListView();

            int size = library.Count;
            for(int i = 0; i < size; i++)
            {
                Book book = library.GetBook(i);
                string[] arr = new string[3];
                arr[0] = book.Title;
                arr[1] = book.Author;
                arr[2] = book.Subject;
                ListViewItem item = new ListViewItem(arr);
                lstLibraryView.Items.Add(item);
            }
        }

        private void LoadGlobalLibraryListView()
        {
            ClearListView();

            int size = gutenLibrary.Count;
            for(int i = 0; i < size; i++)
            {
                Book book = gutenLibrary.GetBook(i);
                string[] arr = new string[3];
                arr[0] = book.Title;
                arr[1] = book.Author;
                arr[2] = book.Subject;
                ListViewItem item = new ListViewItem(arr);
                lstLibraryView.Items.Add(item);
            }
        }

        private void ChangePasswordEvent(object sender, EventArgs e)
        {
            PasswordChangerForm form = new PasswordChangerForm();
            form.ShowDialog();
        }
        
        private void Login(object sender, EventArgs e)
        {
            user_id = ServerProxy.ValidateUser(txtUsername.Text, txtPassword.Text);
            //Console.WriteLine(user_id);

            // validate username and password combination
            if (user_id != -1)
            {
                pnlLogin.Visible = false;
                pnlLibrary.Visible = true;
                SetUpLibraryView();
            }
            else
            {
                lblLoginStatus.Text = "ERROR: Incorrect username and password combination";
                txtUsername.Text = "";
                txtPassword.Text = "";
            }
        }
        
        private void CheckUsernamePassword(object sender, EventArgs e)
        {
            if(!txtUsername.Text.Equals("") && !txtPassword.Text.Equals(""))
            {
                btnLogin.Enabled = true;
            }
            else
            {
                btnLogin.Enabled = false;
            }
        }

        private void NewUserCreation(object sender, EventArgs e)
        {
            NewUserForm form = new NewUserForm();
            form.ShowDialog();
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
