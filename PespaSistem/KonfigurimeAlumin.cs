using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PespaSistem
{
    public partial class KonfigurimeAlumin : PespaSistemLibrary.Form
    {
        public KonfigurimeAlumin()
        {
            InitializeComponent();
        }

        private void btnShto_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtEmerAlumini.Text == "" || this.txtKodAlumin.Text == "" || (this.numCmimi.Value <= 0 && this.numCmimi.Enabled))
                {
                    MessageBox.Show("Nje ose disa nga vlerat e futura nuk jane te sakta." + Environment.NewLine +
                        "Ju lutemi shikoni edhe njehere vlerat e dhena", "Shtimi i llojit te xhamit", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }
                int idMax = 0;
                // Nese alumini shtohet pa cmim
                if (!this.chkCmimi.Checked)
                {
                    DialogResult res = MessageBox.Show("Per kete lloj alumini nuk eshte konfiguruar cmimi." + Environment.NewLine + "Jeni te sigurte qe deshironi te vazhdoni?",
                         "Shtimi i aluminit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (res != DialogResult.Yes)
                    {
                        this.PastroFushaShto();
                        return;
                    }
                    this.aluminTableAdapter.InsertQueryAlumin(this.txtKodAlumin.Text, this.txtEmerAlumini.Text, 0,
                        this.numPeshaSpecifike.Value, 1);
                    idMax = (Int32)this.aluminTableAdapter.ScalarQueryTopIdAlumini();
                    // Shto edhe cmimin e ri te krijuar
                    this.cmimetTableAdapter.Insert(0, idMax, 1, this.dtpDateFillimi.Value, null);
                }
                else
                {
                    // Shto ne fillim ne baze te dhenat mbi aluminin e shtuar me ID_CMIMI = 0
                    this.aluminTableAdapter.InsertQueryAlumin(this.txtKodAlumin.Text, this.txtEmerAlumini.Text, 0,
                        this.numPeshaSpecifike.Value, 1);
                    idMax = (Int32)this.aluminTableAdapter.ScalarQueryTopIdAlumini();
                    // Shto edhe cmimin e ri te krijuar
                    this.cmimetTableAdapter.Insert(this.numCmimi.Value, idMax, 1, this.dtpDateFillimi.Value, null);
                }
                int idCmimiMax = Convert.ToInt32(this.cmimetTableAdapter.ScalarQueryTopIdCmimi());
                this.aluminTableAdapter.UpdateQueryIdCmimi(idCmimiMax, idMax);
                MessageBox.Show("Lloji i aluminit u shtua ne bazen e te dhenave", "Shtimi i aluminit", MessageBoxButtons.OK,
                     MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nje gabim ndodhi gjate futjes ne baze te te dhenave", "Konfigurimi i aluminit", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void KonfigurimeAlumin_Load(object sender, EventArgs e)
        {
            this.aluminTableAdapter.Fill(dsAlumin.ALUMIN);
            this.dtpModifikoDateFillimi.Value = DateTime.Now;
            this.dtpModifikoDateFillimi.Value = DateTime.Now;
            this.chkCmimi.Checked = true;
            this.chkPeshaSpecifike.Checked = true;
        }

        private void btnModifikoAksesor_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Jeni te sigurte qe doni te modifikoni llojin e aluminit?", "Modifikimi i aluminit",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (res != DialogResult.Yes)
                return;
            if (this.numModifikoCmim.Value <= 0)
            {
                this.aluminTableAdapter.UpdateQuery(this.txtModifikoKod.Text, this.txtModifikoEmer.Text, Convert.ToInt32(this.cmbModifikoAlumin.SelectedValue));
                MessageBox.Show("Lloji i aluminit u modifikua me sukses!", "Shtimi i aluminit", MessageBoxButtons.OK,
               MessageBoxIcon.Information);
                return;
            }
            // Modifikojme te dhenat per aluminin
            this.aluminTableAdapter.UpdateQuery(this.txtModifikoKod.Text, this.txtModifikoEmer.Text, Convert.ToInt32(this.cmbModifikoAlumin.SelectedValue));
            // Shtojme nje cmim te ri ne tabelen CMIMET dhe modifikojme cmimin e pare duke shtuar daten e fundit te cmimit
            int idCmimi = (Int32)this.aluminTableAdapter.ScalarQueryIdCmimi(Convert.ToInt32(this.cmbModifikoAlumin.SelectedValue));
            this.cmimetTableAdapter.UpdateQueryDateMbarimi(this.dtpModifikoDateFillimi.Value, idCmimi);
            this.cmimetTableAdapter.InsertQuery(this.numModifikoCmim.Value, (Int32)this.cmbModifikoAlumin.SelectedValue, 1, Convert.ToDateTime(this.dtpModifikoDateFillimi.Value), null);
            idCmimi = Convert.ToInt32(this.cmimetTableAdapter.ScalarQueryTopIdCmimi());
            this.aluminTableAdapter.UpdateQueryIdCmimi(idCmimi, (Int32)this.cmbModifikoAlumin.SelectedValue);
            MessageBox.Show("Lloji i aluminit u modifikua me sukses!", "Shtimi i aluminit", MessageBoxButtons.OK,
                 MessageBoxIcon.Information);
        }

        private void btnElemino_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Jeni te sigurte qe doni te fshini llojin e aluminit?", "Eleminimi i aluminit",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (res != DialogResult.Yes)
                return;
            //this.aluminTableAdapter.DeleteQuery(Convert.ToInt32(this.cmbModifikoAlumin.SelectedValue));
            MessageBox.Show("Lloji i aluminit u fshi nga baza e te dhenave!", "Shtimi i aluminit", MessageBoxButtons.OK,
                 MessageBoxIcon.Information);
        }

        private void numModifikoPesha_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cmbModifikoAlumin_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.numModifikoCmim.Enabled = true;
            this.dtpModifikoDateFillimi.Enabled = true;
            DataTable dtModifiko = this.aluminTableAdapter.GetDataByIdAlumini(Convert.ToInt32(this.cmbModifikoAlumin.SelectedValue));
            // Duhet kontrolluar nese ekziston cmimi per kete artikull
            this.txtModifikoKod.Text = dtModifiko.Rows[0]["KOD_ALUMINI"].ToString();
            this.txtModifikoEmer.Text = dtModifiko.Rows[0]["EMER_ALUMINI"].ToString();
            if (Convert.ToDecimal(dtModifiko.Rows[0]["CMIMI"]) <= 0)
            {
                this.numModifikoCmim.Enabled = false;
                this.dtpModifikoDateFillimi.Enabled = false;
                this.numModifikoCmim.Value = 0;
            }
            else
                this.numModifikoCmim.Value = Convert.ToDecimal(dtModifiko.Rows[0]["CMIMI"]);
            //if (Convert.ToDecimal(dtModifiko.Rows[0]["PESHA_SPECIFIKE"]) < 0)
            //    this.numModifikoPesha.Value = 0;
            //else
            //    this.numModifikoPesha.Value = Convert.ToDecimal(dtModifiko.Rows[0]["PESHA_SPECIFIKE"]);
        }

        private void chkCmimi_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkCmimi.Checked)
            {
                this.numCmimi.Enabled = true;
                this.dtpDateFillimi.Enabled = true;
                //this.numCmimi.Value = 0;
                //this.numCmimi.Minimum = 0;
            }
            else
            {
                this.numCmimi.Enabled = false;
                this.dtpDateFillimi.Enabled = false;
                //this.numCmimi.Minimum = -1;
                //this.numCmimi.Value = 0;
            }
        }

        private void chkPeshaSpecifike_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkPeshaSpecifike.Checked)
            {
                this.numPeshaSpecifike.Enabled = true;
                //this.numPeshaSpecifike.Value = 0;
                //this.numPeshaSpecifike.Minimum = 0;
            }
            else
            {
                this.numPeshaSpecifike.Enabled = false;
                //this.numPeshaSpecifike.Minimum = -1;
                //this.numPeshaSpecifike.Value = 0;
            }
        }

        private void PastroFushaShto()
        {
            this.txtEmerAlumini.Text = "";
            this.numCmimi.Value = 0;
            this.numPeshaSpecifike.Value = 0;
            this.txtKodAlumin.Text = "";
        }
    }
}

