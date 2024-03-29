﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/**
 * AC22005 Assignment 2 Group 3
 * Ross Coombs: 2410466
 * Daniel Ferrier: 2413440
 * Kamil Krauze: 2414951
 */

namespace ATM_Simulator___Team_3__with_Data_Race_
{
    public class Program
    {
        // Reset log file when program is ran
        public static void createFile()
        {
            string fp = @"..\..\logs\log.txt";

            if (File.Exists(fp))
            {
                File.WriteAllText(fp, string.Empty);
                return;
            }
            else
            {
                File.CreateText(fp);
                return;
            }
        }

        [STAThread]
        static void Main()
        {
            createFile(); // Resets the log file when app runs.

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new BankComputer_form());
        }
    }
}
