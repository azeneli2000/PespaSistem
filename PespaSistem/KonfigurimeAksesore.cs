using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PespaSistem
{
    
    public partial class KonfigurimeAksesore : PespaSistemLibrary.Form
    {
        private DataSet dsXhamAksesore;
        public KonfigurimeAksesore()
        {
            dsXhamAksesore = new DataSet("dsXhamAksesore");
            DataTable dt1 = new DataTable("Table1");
            dt1.Columns.Add("ID", typeof(String));
            dt1.Columns.Add("KOD", typeof(String));
            this.dsXhamAksesore.Tables.Add(dt1);
            InitializeComponent();
        }

        private void KonfigurimeAksesore_Load(object sender, EventArgs e)
        {
            this.aksesoreTableAdapter.Fill(dsAksesore.AKSESORE);
            this.aluminTableAdapter.Fill(dsAksesore.ALUMIN);
            this.xhamTableAdapter.Fill(dsAksesore.XHAM);
            for (int i = 0; i < dsAksesore.ALUMIN.Rows.Count; i++)
            {
                DataRow dr = this.dsXhamAksesore.Tables[0].NewRow();
                dr["ID"] = "A" + dsAksesore.ALUMIN[i][0].ToString();
                dr["KOD"] = dsAksesore.ALUMIN[i][1];
                this.dsXhamAksesore.Tables["Table1"].Rows.Add(dr);
            }
            for (int i = 0; i < dsAksesore.XHAM.Rows.Count; i++)
            {
                DataRow dr = this.dsXhamAksesore.Tables[0].NewRow();
                dr["ID"] = "X" + dsAksesore.XHAM[i][0].ToString();
                dr["KOD"] = dsAksesore.XHAM[i][1];
                this.dsXhamAksesore.Tables["Table1"].Rows.Add(dr);
            }
            this.dsXhamAksesore.AcceptChanges();
            this.cmbVaresia.DataSource = this.dsXhamAksesore.Tables[0];
            this.cmbVaresia.ValueMember = "ID";
            this.cmbVaresia.DisplayMember = "KOD";
        }

        private void btnShto_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtEmerAksesori.Text == "" || this.txtKodAksesori.Text == "" || this.numCmimi.Value <= 0)
                {
                    MessageBox.Show("Nje nga te dhenat nuk jane te sakta." + Environment.NewLine +
                        "Ju lutemi shikoni dhe nje here te dhenat!", "Shtimi i aksesoreve", MessageBoxButtons.OK,
                         MessageBoxIcon.Warning);
                    return;
                }
                string vlera = this.cmbVaresia.SelectedValue.ToString();
                int idAlumini = 0;
                int idXhami = 0;
                string varesia = "";
                // Shohim nese aksesori varet nga Alumini apo nga Xhami
                if (vlera.StartsWith("A"))
                {
                    idAlumini = Convert.ToInt32(vlera.Substring(1));
                    varesia = "A";
                }
                else if (vlera.StartsWith("X"))
                {
                    idXhami = Convert.ToInt32(vlera.Substring(1));
                    varesia = "X";
                }
                // Shto ne fillim ne baze te dhenat mbi aksesorin e shtuar me ID_CMIMI = 0
                this.aksesoreTableAdapter.InsertQueryAksesore(this.txtKodAksesori.Text, this.txtEmerAksesori.Text, 0,
                    idAlumini, this.cmbNjesia.SelectedIndex, idXhami, varesia);
                int idMax = Convert.ToInt32(this.aksesoreTableAdapter.ScalarQueryTopIdAksesori());
                // Shto edhe cmimin e ri te krijuar
                this.cmimetTableAdapter.InsertQuery(this.numCmimi.Value, idMax, 2, this.dtpDateFillimi.Value, null);
                int idCmimiMax = Convert.ToInt32(this.cmimetTableAdapter.ScalarQueryTopIdCmimi());
                this.aksesoreTableAdapter.UpdateQueryIdCmimi(idCmimiMax, idMax);

                MessageBox.Show("Aksesori u shtua ne bazen e te dhenave", "Shtimi i aksesoreve", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                this.PastroFushaShto();

            }
            catch(Exception ex)
            {
                MessageBox.Show("Nje gabim ndodhi gjate hedhjes se aksesorit ne bazen e te dhenave", "Shtimi i aksesoreve",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void PastroFushaShto()
        {
            this.txtEmerAksesori.Text = "";
            this.txtKodAksesori.Text = "";
            this.cmbModifikoAksesore.Text = "";
        }

        private void btnModifikoAksesor_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult res = MessageBox.Show("Jeni te sigurte qe doni te modifikoni aksesorin?", "Modifikimi i aksesoreve", MessageBoxButtons.YesNo,
                     MessageBoxIcon.Question);
                if (res != DialogResult.Yes)
                    return;
                this.aksesoreTableAdapter.UpdateQueryAksesore(this.txtModifikoAksesor.Text, this.txtModifikoEmerAksesori.Text, Convert.ToInt32(this.cmbModifikoAksesore.SelectedValue));
                // Shtojme nje cmim te ri ne tabelen CMIMET dhe modifikojme cmimin e pare duke shtuar daten e fundit te cmimit
                int idCmimi = (Int32)this.aksesoreTableAdapter.ScalarQueryIdCmimi(Convert.ToInt32(this.cmbModifikoAksesore.SelectedValue));
                this.cmimetTableAdapter.UpdateQueryDateMbarimi(this.dtpModifikoDateFillimi.Value, idCmimi);
                this.cmimetTableAdapter.InsertQuery(this.numModifikoCmim.Value, (Int32)this.cmbModifikoAksesore.SelectedValue, 2, this.dtpModifikoDateFillimi.Value, null);
                idCmimi = Convert.ToInt32(this.cmimetTableAdapter.ScalarQueryTopIdCmimi());
                this.aksesoreTableAdapter.UpdateQueryIdCmimi(idCmimi, (Int32)this.cmbModifikoAksesore.SelectedValue);
                
                MessageBox.Show("Aksesori u modifikua me sukses!", "Modifikimi i aksesoreve", MessageBoxButtons.OK,
                     MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Nje gabim ndodhi gjate modifikimit te aksesorit", "Modifikimi i aksesoreve", MessageBoxButtons.OK,
                     MessageBoxIcon.Error);
                return;
            }
        }

        private void btnElemino_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult res = MessageBox.Show("Jeni te sigurte qe doni te fshini aksesorin?", "Eleminimi i aksesoreve", MessageBoxButtons.YesNo,
                     MessageBoxIcon.Question);
                if (res != DialogResult.Yes)
                    return;
                this.aksesoreTableAdapter.DeleteQueryAksesore(Convert.ToInt32(this.cmbModifikoAksesore.SelectedValue));
                MessageBox.Show("Aksesori u fshi me sukses!", "Eleminimi i aksesoreve", MessageBoxButtons.OK,
                     MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Nje gabim ndodhi gjate fshirjes se aksesorit", "Eleminimi i aksesoreve", MessageBoxButtons.OK,
                     MessageBoxIcon.Error);
                return;
            }
        }

        private void cmbModifikoAksesore_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dtModifiko = aksesoreTableAdapter.GetDataByIdAksesori(Convert.ToInt32(this.cmbModifikoAksesore.SelectedValue));
            this.txtModifikoAksesor.Text = dtModifiko.Rows[0]["EMER_AKSESORI"].ToString();
            this.txtKodAksesori.Text = dtModifiko.Rows[0]["KOD_AKSESORI"].ToString();
            if (Convert.ToDecimal(dtModifiko.Rows[0]["CMIMI"]) < 0)
                this.numModifikoCmim.Value = 0;
            else
                this.numModifikoCmim.Value = Convert.ToDecimal(dtModifiko.Rows[0]["CMIMI"]);
        }

    }
}

