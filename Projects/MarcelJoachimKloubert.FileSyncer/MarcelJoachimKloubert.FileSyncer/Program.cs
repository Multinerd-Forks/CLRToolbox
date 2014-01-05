﻿// LICENSE: GPL 3 - https://www.gnu.org/licenses/gpl-3.0.txt

// s. http://blog.marcel-kloubert.de


using System;
using System.Windows.Forms;
using MarcelJoachimKloubert.FileSyncer.Forms;

namespace MarcelJoachimKloubert.FileSyncer
{
    internal static class Program
    {
        #region Methods (1)

        // Private Methods (1) 

        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }

        #endregion Methods
    }
}
