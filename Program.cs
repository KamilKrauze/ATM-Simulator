using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace ATM_Team3
{
    class Program
    {
        private Account[] account = new Account[3];

        public Program()
        {
            account[0] = new Account(300, 1111, 111111);
            account[1] = new Account(750, 2222, 222222);
            account[2] = new Account(3000, 3333, 333333);
        }

        public Account[] Account { get => account; set => account = value; }

        [STAThread]
        static void Main()
        {
            Program program = new Program();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            new Program();
            Console.WriteLine("Account 0: " + program.Account[0].getBalance());
            Application.Run(new ATM_form(program.Account));
            Console.WriteLine("Account 0: " + program.Account[0].getBalance());

            Application.Run(new ATM_form(program.Account));

            //Application.Run();
        }
    }
}
