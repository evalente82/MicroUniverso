using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TesteMicroUniverso.Forms;
using TesteMicroUniverso.Models;

namespace TesteMicroUniverso
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            using (var db = new AppDbContext())
            {
                db.Database.CreateIfNotExists();
                
            }
            Application.Run(new Login());
        }
    }
}
