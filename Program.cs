using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Configuracao
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            if(File.Exists("P88.Console.exe"))
                Application.Run(new FormP88());
            else if(File.Exists("CIP.Console.exe"))
                Application.Run(new FormCIP());
            else if (File.Exists("SeloDigital.GO.Console.exe"))
                Application.Run(new FormSEDIGO());
            else if (File.Exists("Dadp.Servidor.Console.exe"))
                Application.Run(new FormDADP());
            else if (File.Exists("Launcher.Console.exe"))
                Application.Run(new FormLauncher());
        }
    }
}
