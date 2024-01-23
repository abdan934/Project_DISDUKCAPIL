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
    public partial class Form_KTPRptCrp : Form
    {
        ReportDocument repDok = new ReportDocument();
        string nik;

        public Form_KTPRptCrp(string nik)
        {
            InitializeComponent();
            this.nik = nik;
        }

        private void Form_KTPRptCrp_Load(object sender, EventArgs e)
        {

            
            //this.reportViewer1.RefreshReport();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            repDok.Load(@"D:\Abdan\Semester 3 (ME)\PBO II\Form_Projek_Akhir\report\Form_KTPrpt.rpt");
            repDok.SetDatabaseLogon("root","");
            repDok.Refresh();

           // ktp_crv.ReportSource = repDok;
           // ktp_crv.Refresh();

            ParameterFieldDefinitions parFlds;
            ParameterFieldDefinition parFdl;
            ParameterValues parVal = new ParameterValues();
            ParameterDiscreteValue parDis = new ParameterDiscreteValue();

            parDis.Value = nik.Trim();
            parFlds = repDok.DataDefinition.ParameterFields;
            parFdl = parFlds["p_nik"];
            parVal = parFdl.CurrentValues;

            parVal.Clear();
            parVal.Add(parDis);
            parFdl.ApplyCurrentValues(parVal);

            ktp_crv.ReportSource = repDok;
            ktp_crv.Refresh();

           

        }
    }
}
