using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PespaSistem
{
    public partial class KonfigurimeXham : PespaSistemLibrary.Form
    {
        public KonfigurimeXham()
        {
            InitializeComponent();
        }

        private void btnShto_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtEmerXhami.Text == "" || this.txtKodXhami.Text == "" || this.numCmimi.Value <= 0)
                {
                    MessageBox.Show("Nje ose disa nga vlerat e futura nuk jane te sakta." + Environment.NewLine +
                        "Ju lutemi shikoni edhe njehere vlerat e dhena", "Shtimi i llojit te xhamit", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }
                // Shto ne fillim ne baze te dhenat mbi xhamin e shtuar me ID_CMIMI = 0
                this.xhamTableAdapter.InsertQueryXham(this.txtKodXhami.Text, this.txtEmerXhami.Text, 0, 
                    this.cmbNjesia.SelectedIndex);
                int idMax = Convert.ToInt32(this.xhamTableAdapter.ScalarQueryTopIdXhami());
                // Shto edhe cmimin e ri te krijuar
                this.cmimetTableAdapter.Insert(this.numCmimi.Value, idMax, 3, this.dtpDateFillimi.Value, null);
                int idCmimiMax = Convert.ToInt32(this.cmimetTableAdapter.ScalarQueryTopIdCmimi());
                this.xhamTableAdapter.UpdateQueryIdCmimi(idCmimiMax, idMax);
                MessageBox.Show("Lloji i xhamit u shtua ne bazen e te dhenave", "Shtimi i llojit te xhamit", MessageBoxButtons.OK,
                     MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nje gabim ndodhi gjate hedhjes se te dhenave ne baze", "Shtimi i llojit te xhamit",
                     MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void KonfigurimeXham_Load(object sender, EventArgs e)
        {
            this.xhamTableAdapter.Fill(this.dsXham.XHAM);
            this.dtpDateFillimi.Value = DateTime.Now;
        }

        private void btnModifikoAksesor_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult res = MessageBox.Show("Jeni te sigurte qe doni te modifikoni llojin e xhamit?", "Modifikimi i xhamit",
                     MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (res != DialogResult.Yes)
                    return;
                // Modifikojme te dhenat per xhamin
                this.xhamTableAdapter.UpdateQuery(this.txtModifikoKod.Text, this.txtModifikoEmer.Text, (Int32)this.cmbModifikoXham.SelectedValue);
                // Shtojme nje cmim te ri ne tabelen CMIMET dhe modifikojme cmimin e pare duke shtuar daten e fundit te cmimit
                int idCmimi = (Int32)this.xhamTableAdapter.ScalarQueryIdCmimi((Int32)this.cmbModifikoXham.SelectedValue);
                this.cmimetTableAdapter.UpdateQueryDateMbarimi(this.dtpModifikoDateFillimi.Value, idCmimi);
                this.cmimetTableAdapter.InsertQuery(this.numModifikoCmim.Value, (Int32)this.cmbModifikoXham.SelectedValue,
                    3, this.dtpModifikoDateFillimi.Value, null);
                idCmimi = (Int32)this.cmimetTableAdapter.ScalarQueryTopIdCmimi();
                this.xhamTableAdapter.UpdateQueryIdCmimi(idCmimi, (Int32)this.cmbModifikoXham.SelectedValue);

                MessageBox.Show("Lloji i xhamit u modifikua me sukses!", "Modifikimi i xhamit", MessageBoxButtons.OK,
                     MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nje gabim ndodhi gjate modifikimit te te dhenave", "Modifikimi i xhamit", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnElemino_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Jeni te sigurte qe doni te fshini llojin e aluminit?", "Eleminimi i llojit te xhamit",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (res != DialogResult.Yes)
                return;
            //this.xhamSingleTableAdapter.DeleteQueryXham(Convert.ToInt32(this.cmbModifikoXham.SelectedValue));
            MessageBox.Show("Lloji i xhamit u fshi nga baza e te dhenave!", "Eleminimi i llojit te xhamit", MessageBoxButtons.OK,
                 MessageBoxIcon.Information);
        }

        private void cmbModifikoXham_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = this.xhamTableAdapter.GetDataByIdXhami(Convert.ToInt32(this.cmbModifikoXham.SelectedValue));
            this.txtModifikoKod.Text = dt.Rows[0]["KOD_XHAMI"].ToString();
            this.txtModifikoEmer.Text = dt.Rows[0]["EMER_XHAMI"].ToString();
            if (Convert.ToDecimal(dt.Rows[0]["CMIMI"]) < 0)
                this.numModifikoCmim.Value = 0;
            else
                this.numModifikoCmim.Value = Convert.ToDecimal(dt.Rows[0]["CMIMI"]);
            
        }
    }
}

