using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PespaSistem
{
    public partial class FrmPrintim : PespaSistemLibrary.Form
    {
        public FrmPrintim()
        {
            InitializeComponent();
        }

        public FrmPrintim(CrFatura cr)
        {
            InitializeComponent();
            crystalReportViewer.ReportSource = cr;
        }

        public FrmPrintim(CrRaport crRaport)
        {
            InitializeComponent();
            crystalReportViewer.ReportSource = crRaport;
        }

        private void FrmPrintim_Load(object sender, EventArgs e)
        {
            this.crystalReportViewer.RefreshReport();
            
        }
    }
}

