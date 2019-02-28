using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PespaSistem
{
    public partial class VlereReale : PespaSistemLibrary.Form
    {
        public VlereReale()
        {
            InitializeComponent();
        }

        private void VlereReale_Load(object sender, EventArgs e)
        {
            this.projekteTableAdapter.Fill(this.dsPespaSistem.PROJEKTE);
        }

        private void btnRuaj_Click(object sender, EventArgs e)
        {
            this.projekteTableAdapter.UpdateQueryByVleraReale(Convert.ToInt32(this.numericUpDown1.Value), (Int32)this.cmbProjekti.SelectedValue);
            MessageBox.Show("Vlerat u ruajten me sukses", "Hedhja e kostos se projekteve", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

