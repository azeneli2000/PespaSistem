using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PespaSistem
{
    public partial class FrmShtoProduktAksesore : PespaSistemLibrary.Form
    {
        public string llojAksesore = "";
        public int idAksesore = 0;
        public decimal sasia = 0;
        public string kodAksesori = "";
        public string emerAksesori = "";
        public decimal vlera = 0;
        public decimal cmimi = 0;
        public int idCmimi = 0;
        public FrmShtoProduktAksesore()
        {
            InitializeComponent();
        }

        private void FrmShtoProduktAksesore_Load(object sender, EventArgs e)
        {
            this.aksesoreTotalTableAdapter.Fill(dsShtoAksesoreProdukti.AKSESORE_TOTAL);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.sasia = 0;
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgAksesore_DoubleClick(object sender, EventArgs e)
        {
            if (this.dgAksesore.SelectedItems.Count < 1)
            {
                this.idAksesore = 0;
                this.llojAksesore = "";
                this.sasia = 0;
                return;
            }
            int row = this.dgAksesore.SelectedItems[0].Position;
            if (this.dgAksesore.GetRow(row).Cells[1].Value == null)
                return;
            this.idAksesore = Convert.ToInt32(this.dgAksesore.GetRow(row).Cells[0].Value);
            this.llojAksesore = this.dgAksesore.GetRow(row).Cells[1].Value.ToString();
            this.sasia = 0;
            this.txtKodSasia.Text = this.dgAksesore.GetRow(row).Cells[2].Value.ToString();
            this.kodAksesori = this.txtKodSasia.Text;
            this.txtEmerSasia.Text = this.dgAksesore.GetRow(row).Cells[3].Value.ToString();
            this.emerAksesori = this.txtEmerSasia.Text;
            this.cmimi = Convert.ToDecimal(this.dgAksesore.GetRow(row).Cells[5].Value);
            this.idCmimi = Convert.ToInt32(this.dgAksesore.GetRow(row).Cells[4].Value);
        }

        private void btnKerkoKod_Click(object sender, EventArgs e)
        {
            this.aksesoreTotalTableAdapter.FillByKodAksesore(dsShtoAksesoreProdukti.AKSESORE_TOTAL, this.txtKodi.Text);
        }

        private void btnKerkoEmer_Click(object sender, EventArgs e)
        {
            this.aksesoreTotalTableAdapter.FillByEmerAksesore(dsShtoAksesoreProdukti.AKSESORE_TOTAL, this.txtEmri.Text);
        }

        private void btnKerkoLloj_Click(object sender, EventArgs e)
        {
            if (this.cmbLloji.Text != "Alumin" && this.cmbLloji.Text != "Aksesore" && this.cmbLloji.Text != "Xham")
                return;
            this.aksesoreTotalTableAdapter.FillByLlojAksesore(dsShtoAksesoreProdukti.AKSESORE_TOTAL, this.cmbLloji.Text);
        }

        private void numSasia_Validated(object sender, EventArgs e)
        {
            this.sasia = Convert.ToDecimal(this.numSasia.Value);
            this.vlera = this.sasia * this.cmimi;
        }
    }
}

