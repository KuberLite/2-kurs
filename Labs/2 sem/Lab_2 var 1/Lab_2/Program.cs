using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;

namespace Lab_2
{
    [Serializable]
    public class Program 
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>

        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
