using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

/**
 * AC22005 Assignment 2 Group 3
 * Ross Coombs: 2410466
 * Daniel Ferrier: 2413440
 * Kamil Krauze: 2414951
 */

namespace ATM_Team3
{
    class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new BankComputer_form());
        }
    }
}
