using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Individualizer
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new FrmAbout());
                Application.Run(new Form1());
            }
            catch (Exception s) { MessageBox.Show(s.Message,"Please Report to gersy.ch2@gmail.com"); }
        }

        internal static void SetCheckSubDirs(bool p)
        {
            global::Individualizer.Properties.Settings.Default.CheckSubDirs = p;
            global::Individualizer.Properties.Settings.Default.Save();

        }

        internal static void SetShowFilePath(bool p)
        {
              global::Individualizer.Properties.Settings.Default.ShowFilePath=p;
              global::Individualizer.Properties.Settings.Default.Save();


        }

        internal static bool GetShowFilePath()
        {
            return global::Individualizer.Properties.Settings.Default.ShowFilePath;

        }

        internal static bool GetCheckSubDirs()
        {
            return global::Individualizer.Properties.Settings.Default.CheckSubDirs;
        }

        internal static string[] GetDisAllowed()
        {
            try
            {
                string x = global::Individualizer.Properties.Settings.Default.__DisAllowed__;

                if(x==",")
                    x="";
                if (x.Contains(","))
                {
                    string[] ps = x.Split(new char[] { ',' });
                    return ps;
                }
                else
                    x = x.Trim();
                return new string[] { x };
            }
            catch { return null; }
        }

       
        internal static void setDisAllowed(string lst1)
        {

            global::Individualizer.Properties.Settings.Default.__DisAllowed__ = lst1;
            global::Individualizer.Properties.Settings.Default.Save();
        }

      
    }
}
