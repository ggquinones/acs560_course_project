using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GutenLib
{
    public class BookLabel
    {
        private Book book;
        private Label label;
        private bool isOpen;

        public BookLabel(Book book, Label label)
        {
            this.book = book;
            this.label = label;
            isOpen = false;
        }

        public Book Book
        {
            get { return book; }
            set { book = value; }
        }

        public bool IsOpen
        {
            get { return isOpen; }
        }

        public void SetCover()
        {
            isOpen = false;
            Image cover = book.Cover;
            if(cover != null)
            {
                cover = new Bitmap(cover, 153, 210);
            }
            if (cover != null)
            {
                label.Text = "";
                label.BackColor = Color.WhiteSmoke;
                label.Image = cover;
            }
            else
            {
                label.Image = null;
                label.Font = new System.Drawing.Font("Arial", 14);
                label.ForeColor = Color.White;
                label.BackColor = GetColor();
                label.Text = book.Title;
            }
        }

        public void SetInfo()
        {
            isOpen = true;
            label.Image = null;
            label.ForeColor = Color.Black;
            label.BackColor = Color.AntiqueWhite;
            label.Font = new Font("Arial", 12);
            label.Text = book.Title.ToUpper() + "\n\nby " + book.Author + "\n\n" + book.Subject;
        }

        private Color GetColor()
        {
            Color color;
            int total = 0;
            foreach(char letter in book.Title)
            {
                total += letter;
            }
            switch (total % 10)
            {
                case 0: color = Color.FromArgb(255, 17, 49, 99);        // dark blue
                        break;
                case 1: color = Color.FromArgb(255, 16, 32, 58);        // darker blue
                        break;
                case 2: color = Color.FromArgb(255, 83, 33, 114);       // purpleish
                        break;
                case 3: color = Color.FromArgb(255, 155, 65, 6);        // dark orange
                        break;
                case 4: color = Color.FromArgb(255, 155, 16, 6);        // redish
                        break;
                case 5: color = Color.FromArgb(255, 160, 34, 25);       // also redish
                        break;
                case 6: color = Color.FromArgb(255, 3, 76, 11);         // greenish
                        break;
                case 7: color = Color.FromArgb(255, 14, 51, 17);        // dark green
                        break;
                case 8: color = Color.FromArgb(255, 168, 138, 18);      // goldish
                        break;
                case 9: color = Color.FromArgb(255, 66, 21, 89);        // also purpleish
                        break;

                default: color = Color.FromArgb(255, 255, 255, 255);    // white
                        break;
            }

            return color;
        }

    }
}
