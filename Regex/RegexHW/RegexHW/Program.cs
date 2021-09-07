using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegexHW
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());



            #region Qst 01
            Regexs.Check();
            #endregion

            #region Qst 02
            Regexs.CheckTwo();
            #endregion

            #region Qst 03
            Regexs.CheckThree();
            #endregion

            #region Qst 04
            Regexs.CheckFour();
            #endregion

            #region Qst 05
            Regexs.CheckFive();
            #endregion

            #region Qst 06
            Regexs.CheckSix();
            #endregion

            #region Qst 07
            Regexs.CheckSeven();
            #endregion

            #region Qst 08
            Regexs.CheckEight();
            #endregion

            #region Qst 09
            Regexs.CheckNine();
            #endregion

            #region Qst 10
            Regexs.CheckTen();
            #endregion
        }
    }
}
