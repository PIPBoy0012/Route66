using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Route66_administration
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
            Application.Run(new Form1());
        }
    }

    abstract class Konkurrence
    {
        string name;
        Spoergsmaal[] spoergsmaal;
    }

    public class Spoergsmaal
    {
        string spoergsmaal;
        string[] svarMuligheder;
    }
}
