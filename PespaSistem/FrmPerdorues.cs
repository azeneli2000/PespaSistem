using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PespaSistem
{
    public partial class FrmPerdorues : PespaSistemLibrary.Form
    {
        /// <summary>
        /// Variabel privat qe mban emrin e perdoruesit. Sherben per propertine Perdorues
        /// </summary>
        private string perdorues;
        public FrmPerdorues()
        {
            InitializeComponent();
        }

        private void btnModifikoAksesor_Click(object sender, EventArgs e)
        {
            if (this.comboBox1.SelectedValue == null)
            {
                MessageBox.Show("Ju lutemi zgjidhni njerin nga perdoruesit qe doni te modifikoni", "Konfigurimi i perdoruesve", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult res = MessageBox.Show("Jeni te sigurte qe doni te modifikoni perdoruesin?", "Konfigurimi i perdoruesve", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (res != DialogResult.OK)
                return;
            if (this.txtEmerModifiko.Text.Trim() == "" || this.txtFjalekalimModifiko.Text.Trim() == "" || this.txtPersFjalekalimModifiko.Text.Trim() == "")
            {
                MessageBox.Show("Disa nga fushat e detyrueshme nuk kane te dhena!", "Konfigurimi i perdoruesve", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (this.txtFjalekalimModifiko.Text != this.txtPersFjalekalimModifiko.Text)
            {
                MessageBox.Show("Fjalekalimi duhet te jete i njejte ne te dy fushat e fjalekalimit!", "Konfigurimi i perdoruesve", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtFjalekalim.Focus();
                return;
            }
            if (this.txtFjalekalimModifiko.Text.Contains(" "))
            {
                MessageBox.Show("Fjalekalimi nuk mund te permbaje hapesira boshe!", "Konfigurimi i perdoruesve", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            this.perdoruesTableAdapter.UpdateQuery(this.txtFjalekalimModifiko.Text, this.txtEmerModifiko.Text, this.txtMbiemerModifiko.Text, (Int32)this.comboBox1.SelectedValue);
            MessageBox.Show("Modifikimi i perdoruesit u krye me sukses", "Konfigurimi i perdoruesve", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FrmPerdorues_Load(object sender, EventArgs e)
        {
            this.rolePerdoruesTableAdapter.Fill(this.dsPerdorues.ROLE_PERDORUES);
            // Nese perdoruesi i loguar nuk eshte administrator ai thjesht mund te modifikoje passwordin e vet
            this.txtPerdoruesModifiko.Enabled = false;
            if (this.RolId > 1)
            {
                this.gbShtoPerdorues.Enabled = false;
                this.perdoruesTableAdapter.FillByIdPerdorues(this.dsPerdorues.PERDORUES, this.PerdoruesId);
                this.txtEmerModifiko.Enabled = false;
                this.txtMbiemerModifiko.Enabled = false;
            }
            // Perndryshe nese perdoruesi eshte administrator
            else if (this.RolId == 1)
            {
                // Nese perdoruesi i loguar eshte administratori i pergjithshem (perdoruesi me ID = 1) atehere
                // atij i jepen te gjitha te drejtat mbi te gjithe perdoruesit
                if (this.PerdoruesId == 1)
                {
                    this.perdoruesTableAdapter.Fill(this.dsPerdorues.PERDORUES);
                }
                else
                {
                    // Nese administratori i loguar eshte administrator i thjeshte atehere atij i jepen te drejtat
                    // mbi veten e tij dhe perdoruesit dhe administratoret
                    this.perdoruesTableAdapter.FillByIdPerdoruesAdmin(this.dsPerdorues.PERDORUES, this.PerdoruesId);

                }
            }
        }

        private void btnShto_Click(object sender, EventArgs e)
        {
            if (!this.gbShtoPerdorues.Enabled)
            {
                MessageBox.Show("Ju nuk keni te drejta administrative per te shtuar perdorues te tjere", "Konfigurimi i perdoruesve", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            if (this.txtEmri.Text.Trim() == "" || this.txtFjalekalim.Text.Trim() == "" || this.txtPerseritFjalekalimin.Text.Trim() == "" ||
                this.txtUserName.Text == "")
            {
                MessageBox.Show("Disa nga fushat e detyrueshme nuk kane te dhena!", "Konfigurimi i perdoruesve", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (this.txtFjalekalim.Text.Contains(" "))
            {
                MessageBox.Show("Fjalekalimi nuk mund te permbaje hapesira boshe!", "Konfigurimi i perdoruesve", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (this.txtFjalekalim.Text != this.txtPerseritFjalekalimin.Text)
            {
                MessageBox.Show("Fjalekalimi duhet te jete i njejte ne te dy fushat e fjalekalimit!", "Konfigurimi i perdoruesve", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtFjalekalim.Focus();
                return;
            }
            DataRow[] drs = this.dsPerdorues.Tables["PERDORUES"].Select("USERNAME = '" + this.txtUserName.Text + "'");
            if (drs.Length > 0)
            {
                MessageBox.Show("Ekziston nje perdorues tashme me kete emer perdoruesi!", "Konfigurimi i perdoruesve", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtUserName.Focus();
                return;
            }
            this.perdoruesTableAdapter.Insert(this.txtUserName.Text, this.txtFjalekalim.Text, (Int32)this.cmbRoli.SelectedValue, this.txtEmri.Text, this.txtMbiemri.Text);
            MessageBox.Show("Perdoruesi i ri u shtua me sukses", "Konfigurimi i perdoruesve", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt1 = this.perdoruesTableAdapter.GetDataByIdPerdorues((Int32)this.comboBox1.SelectedValue);
            if (dt1.Rows.Count == 1)
            {
                this.txtEmerModifiko.Text = dt1.Rows[0]["EMER"].ToString();
                this.txtMbiemerModifiko.Text = dt1.Rows[0]["MBIEMER"].ToString();
                this.txtPerdoruesModifiko.Text = dt1.Rows[0]["USERNAME"].ToString();
                this.txtFjalekalimModifiko.Text = dt1.Rows[0]["PASSWORD"].ToString();
                this.txtPersFjalekalimModifiko.Text = dt1.Rows[0]["PASSWORD"].ToString();
                switch ((Int32)dt1.Rows[0]["ID_ROL"])
                {
                    case 1:
                        this.cmbRoliModifiko.Text = "Administrator";
                        break;
                    case 2:
                        this.cmbRoliModifiko.Text = "Perdorues";
                        break;
                    case 3:
                        this.cmbRoliModifiko.Text = "Vizitor";
                        break;
                }
            }
        }

        private void btnElemino_Click(object sender, EventArgs e)
        {

        }

    }
}

