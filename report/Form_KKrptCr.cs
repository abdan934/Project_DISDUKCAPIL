using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace Form_Projek_Akhir.report
{
    public partial class Form_KKrptCr : Form
    {
        ReportDocument repDok = new ReportDocument();
        string no_kk;

        public Form_KKrptCr(string no_kk)
        {
            InitializeComponent();
            this.no_kk = no_kk;
        }

        private void Form_KKrptCr_Load(object sender, EventArgs e)
        {
            repDok.Load(@"D:\Abdan\Semester 3 (ME)\PBO II\Form_Projek_Akhir\report\Form_KKrpt.rpt");
            repDok.SetDatabaseLogon("root", "");
            repDok.Refresh();

            // ktp_crv.ReportSource = repDok;
            // ktp_crv.Refresh();

            ParameterFieldDefinitions parFlds;
            ParameterFieldDefinition parFdl;
            ParameterValues parVal = new ParameterValues();
            ParameterDiscreteValue parDis = new ParameterDiscreteValue();

            parDis.Value = no_kk.Trim();
            parFlds = repDok.DataDefinition.ParameterFields;
            parFdl = parFlds["p_no_kk"];
            parVal = parFdl.CurrentValues;

            parVal.Clear();
            parVal.Add(parDis);
            parFdl.ApplyCurrentValues(parVal);

            rpt_kk.ReportSource = repDok;
            rpt_kk.Refresh();
        }



    }
}
