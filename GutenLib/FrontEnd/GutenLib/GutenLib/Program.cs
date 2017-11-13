using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GutenLib
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //ServerProxy.GetUserLibraryById(1).Wait();
            //Library libraryFromFiles = new Library();
            Library library = ServerProxy.GetUserLibraryById(2);
            //library.CombineLibraries(libraryFromFiles);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm(library));
        }
    }
}
