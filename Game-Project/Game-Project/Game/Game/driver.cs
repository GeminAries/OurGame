using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    static class driver
    {
    
        // The main entry point for the application.
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Run the GUI
            Application.Run(new GUI());

            
            // Everything that happens in the game will be driven from this file.
        }
    }

}
