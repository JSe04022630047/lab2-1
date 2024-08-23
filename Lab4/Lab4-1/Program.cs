using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new formSimpleCalc());
        }
    }

    public class infinityException : Exception
    {
        public infinityException() : base() { }
        public infinityException(string message) : base(message) { }
        public infinityException(string message, System.Exception inner) : base(message, inner) { }
    }
}
