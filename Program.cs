using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Form_Projek_Akhir
{
    using View;
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           //Application.Run(new Form_Projek_Akhir.View.form_Kk());
            //Application.Run(new Form_Projek_Akhir.model.form_ktp());
            //Application.Run(new Form_Projek_Akhir.model.form_KK());
            //Application.Run(new   View.CRUDUser());
            //Application.Run(new View.MenuUtama());
           Application.Run(new SplashScreenpenduduk());
           //pplication.Run(new model.ChartJenisKelamin());
        }
    }
}
