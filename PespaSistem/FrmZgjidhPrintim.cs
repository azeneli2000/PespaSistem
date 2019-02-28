using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PespaSistem
{
    public partial class FrmZgjidhPrintim : Form
    {
        /// <summary>
        /// Kthen 1 nese duhet te printohet fatura e pergjithshme;
        /// Kthen 2 nese vendoset te printohet fatura e detajuar;
        /// Kthen 0 nese vendoset te anullohet printimi;
        /// </summary>
        public int vlere = 0;
        public FrmZgjidhPrintim()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (this.rbFatureEPergjithshme.Checked)
            {
                vlere = 1;
            }
            else if (this.rbFatureDetajuar.Checked)
            {
                vlere = 2;
            }
            else
            {
                vlere = 0;
            }
            this.Close();
            return;
        }

        private void btnAnullo_Click(object sender, EventArgs e)
        {
            vlere = 0;
            this.Close();
        }
    }
}