using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PespaSistem
{
    public partial class KonfigurimeDyerMeHapje : PespaSistemLibrary.Form
    {
        #region Private and public variables
        /// <summary>
        /// DataSeti qe mban te dhenat e listBox per aksesoret qe do te kalohen ne varesi te produktit
        /// </summary>
        DataSet dsKaloAksesore = new DataSet();
        /// <summary>
        /// Vlere qe tregon nese nje produkt mund te kopjohet ne nje produkt tjeter
        /// </summary>
        private bool kopjohet = false;
        /// <summary>
        /// Mban te dhenat qe duhen per te mbushur kombon e modifikimit te aksesoreve te produkteve
        /// </summary>
        DataSet dsMbushModifikim = new DataSet();
        DataSet dsAksTePercaktuar = new DataSet();
        private Int32 idProdukti = 1;
        #endregion

        public KonfigurimeDyerMeHapje()
        {
            InitializeComponent();
            this.aksesoreTableAdapter.Fill(dsAksesore.AKSESORE);
            this.aluminTableAdapter.Fill(dsAksesore.ALUMIN);
            this.xhamTableAdapter.Fill(dsAksesore.XHAM);
            this.produktAksesoreTableAdapter.Fill(dsProduktAksesore.PRODUKT_AKSESORE);
            //this.KrijoDataSet();
        }

        private void btnModifikoAksesor_Click(object sender, EventArgs e)
        {

        }

        private void btnShto_Click(object sender, EventArgs e)
        {
            int i = 0;
            DataTable dt = this.produktAksesoreTableAdapter.GetDataByIdProdukti(this.idProdukti);
            int countDsRows = dt.Rows.Count;
            //this.dsProduktAksesore.Merge(dsKaloAksesore.Tables[0]);
            //DataSet ds = this.dsProduktAksesore.GetChanges();

            foreach (DataRow dr in this.dsKaloAksesore.Tables[0].Rows)
            {
                if (i < countDsRows)
                {
                    if (dr["ID_AKSESORE_ALUMINI"] != Convert.DBNull)
                        this.produktAksesoreTableAdapter.UpdateQuery((Int32)dr["ID_PRODUKTI"], (Int32)dr["ID_AKSESORE_ALUMINI"],
                            null, null, dr["FORMULA"].ToString(), (Int32)dt.Rows[i]["ID_PRODUKT_AKSESORE"]);
                    else if (dr["ID_AKSESORE"] != Convert.DBNull)
                        this.produktAksesoreTableAdapter.UpdateQuery((Int32)dr["ID_PRODUKTI"], null,
                            null, (Int32)dr["ID_AKSESORE"], dr["FORMULA"].ToString(), (Int32)dt.Rows[i]["ID_PRODUKT_AKSESORE"]);
                    else if (dr["ID_AKSESORE_XHAMI"] != Convert.DBNull)
                        this.produktAksesoreTableAdapter.UpdateQuery((Int32)dr["ID_PRODUKTI"], null,
                            (Int32)dr["ID_AKSESORE_XHAMI"], null, dr["FORMULA"].ToString(), (Int32)dt.Rows[i]["ID_PRODUKT_AKSESORE"]);
                }
                else
                {
                    if (dr["ID_AKSESORE_ALUMINI"] != Convert.DBNull)
                        this.produktAksesoreTableAdapter.InsertQuery((Int32)dr["ID_PRODUKTI"], (Int32)dr["ID_AKSESORE_ALUMINI"],
                            null, null, dr["FORMULA"].ToString());
                    else if (dr["ID_AKSESORE"] != Convert.DBNull)
                        this.produktAksesoreTableAdapter.InsertQuery((Int32)dr["ID_PRODUKTI"], null,
                            null, (Int32)dr["ID_AKSESORE"], dr["FORMULA"].ToString());
                    else if (dr["ID_AKSESORE_XHAMI"] != Convert.DBNull)
                        this.produktAksesoreTableAdapter.InsertQuery((Int32)dr["ID_PRODUKTI"], null,
                            (Int32)dr["ID_AKSESORE_XHAMI"], null, dr["FORMULA"].ToString());
                }
                i += 1;
            }
            //this.produktAksesoreTableAdapter.Update(this.dsProduktAksesore);
            MessageBox.Show("Te dhenat per produktin u ruajten me sukses!", "Ruajtja e te dhenave", MessageBoxButtons.OK,
                 MessageBoxIcon.Information);
        }

        private void cmbLlojAksesore_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbLlojAksesore.SelectedIndex == 0)
            {
                this.lbPercaktoAksesore.DataSource = this.dsAksesore;
                this.lbPercaktoAksesore.DisplayMember = "ALUMIN.KOD_ALUMINI";
                this.lbPercaktoAksesore.ValueMember = "ALUMIN.ID_ALUMINI";
            }
            else if (this.cmbLlojAksesore.SelectedIndex == 1)
            {
                this.lbPercaktoAksesore.DataSource = this.dsAksesore;
                this.lbPercaktoAksesore.DisplayMember = "XHAM.KOD_XHAMI";
                this.lbPercaktoAksesore.ValueMember = "XHAM.ID_XHAMI";
            }
            else if (this.cmbLlojAksesore.SelectedIndex == 2)
            {
                this.lbPercaktoAksesore.DataSource = this.dsAksesore;
                this.lbPercaktoAksesore.DisplayMember = "AKSESORE.KOD_AKSESORI";
                this.lbPercaktoAksesore.ValueMember = "AKSESORE.ID_AKSESORI";
            }
        }

        private void lbPercaktoAksesore_DoubleClick(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            DataTable dtVaresia = new DataTable();
            string varesia = "";
            if (this.cmbLlojAksesore.SelectedIndex == 0)
            {
                dt = this.aluminTableAdapter.GetDataByIdAlumini(Convert.ToInt32(this.lbPercaktoAksesore.SelectedValue));
                this.cmbVaresi.DataSource = null;
                this.cmbVaresi.Text = "Produkt";
                this.txtPercaktoVaresi.Text = "A";
            }
            else if (this.cmbLlojAksesore.SelectedIndex == 1)
            {
                dt = this.xhamTableAdapter.GetDataByIdXhami(Convert.ToInt32(this.lbPercaktoAksesore.SelectedValue));
                this.cmbVaresi.DataSource = null;
                this.cmbVaresi.Text = "Produkt";
                this.txtPercaktoVaresi.Text = "X";
            }
            else if (this.cmbLlojAksesore.SelectedIndex == 2)
            {
                dt = this.aksesoreTableAdapter.GetDataByIdAksesori(Convert.ToInt32(this.lbPercaktoAksesore.SelectedValue));
                dtVaresia = this.aksesoreTableAdapter.GetDataByIdAlumini(Convert.ToInt32(this.lbPercaktoAksesore.SelectedValue));
                if (dtVaresia != null)
                {
                    cmbVaresi.DataSource = dtVaresia;
                    cmbVaresi.DisplayMember = "KOD_ALUMINI";
                    cmbVaresi.ValueMember = "ID_ALUMINI";
                    this.txtPercaktoVaresi.Text = "AA";
                }
                else
                {
                    dtVaresia = this.aksesoreTableAdapter.GetDataByIdXhami(Convert.ToInt32(this.lbPercaktoAksesore.SelectedValue));
                    if (dtVaresia != null)
                    {
                        cmbVaresi.DataSource = dtVaresia;
                        cmbVaresi.DisplayMember = "KOD_XHAMI";
                        cmbVaresi.ValueMember = "ID_XHAMI";
                        this.txtPercaktoVaresi.Text = "XA";
                    }
                    else
                    {
                        cmbVaresi.DataSource = null;
                        cmbVaresi.Text = "Produkt";
                        this.txtPercaktoVaresi.Text = "PA";
                    }
                }
                varesia = this.aksesoreTableAdapter.ScalarQueryAksesorAlumin(Convert.ToInt32(this.lbPercaktoAksesore.SelectedValue));
                
        }
            this.txtEmerAksesori1.Text = dt.Rows[0][2].ToString();
            this.tstKodAksesori.Text = dt.Rows[0][1].ToString();
            this.numCmimi.Value = Convert.ToInt32(dt.Rows[0][4]);
        }

        private void btnKalo_Click(object sender, EventArgs e)
        {
            if (this.dsAksTePercaktuar.Tables.Count < 1)
                return;
            string lloji = "";
            // Shohim nese vlera e zgjedhur i perket aluminit, xhamit apo aksesoreve dhe i japim nje vlere
            if (this.cmbLlojAksesore.SelectedIndex == 0)
                lloji = "AL";
            else if (this.cmbLlojAksesore.SelectedIndex == 1)
                lloji = "XH";
            else if (this.cmbLlojAksesore.SelectedIndex == 2)
                lloji = "AK";
            // Kontrollojme nese vlera e zgjedhur i perket me pare ketij produkti
            foreach (DataRow dr1 in this.dsAksTePercaktuar.Tables[0].Rows)
            {
                string[] str = dr1["ID_LLOJ"].ToString().Split('_');
                if (str.Length != 2)
                    return;
                // stringut lloji
                if ((Int32)this.lbPercaktoAksesore.SelectedValue == Convert.ToInt32(str[0]) && str[1] == lloji)
                {
                    MessageBox.Show("Ky element i zgjedhur eshte pjese e ketij produkti!" + Environment.NewLine + "Ju lutemi zgjidhni nje element tjeter.",
                        "Konfigurimi i produkteve", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            int idVaresi = 0;
            string formula = "";
            DataRow dr = dsKaloAksesore.Tables[0].NewRow();
            idVaresi = Convert.ToInt32(this.lbPercaktoAksesore.SelectedValue);
            switch (this.cmbLlojAksesore.SelectedIndex)
            {
                case 0:
                    dr[2] = idVaresi;
                    break;
                case 1:
                    dr[3] = idVaresi;
                    break;
                case 2:
                    dr[4] = idVaresi;
                    break;
            }
            dr[1] = idProdukti; ;
            this.dsKaloAksesore.Tables[0].Rows.Add(dr);
            // Shtojme nje rresht te ri ne datasetin dsKaloAksesore
            DataRow drAksTePercaktuar = this.dsAksTePercaktuar.Tables[0].NewRow();
            drAksTePercaktuar["ID_LLOJ"] = this.lbPercaktoAksesore.SelectedValue + "_" + lloji;
            drAksTePercaktuar["ID_PRODUKTI"] = this.idProdukti;
            drAksTePercaktuar["EMER"] = this.txtEmerAksesori1.Text;
            this.dsAksTePercaktuar.Tables[0].Rows.Add(drAksTePercaktuar);
            this.dsAksTePercaktuar.AcceptChanges();
            this.lbAksesoreTePercaktuar.DataSource = this.dsAksTePercaktuar.Tables[0];
            this.lbAksesoreTePercaktuar.DisplayMember = "EMER";
            this.lbAksesoreTePercaktuar.ValueMember = "ID_LLOJ";
            //this.KrijoDataSet();
            //this.lbAksesoreTePercaktuar.DataSource = this.dsAksTePercaktuar;
        }

        private void KrijoDataSet()
        {
            dsKaloAksesore = this.dsProduktAksesore.Copy();
            dsKaloAksesore.Clear();
        }

        /// <summary>
        /// Mbushim kombon e modifikimit me te dhenat perkatese per produktin
        /// </summary>
        private void MbushModifikim()
        {
            dsMbushModifikim = dsProduktAksesore.Copy();
            dsMbushModifikim.Clear();
        }

        private void cmbModifikoAlumin_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbLlojAksesore.SelectedIndex == 0)
            {
                this.lbPercaktoAksesore.DataSource = this.dsAksesore;
                this.lbPercaktoAksesore.DisplayMember = "ALUMIN.KOD_ALUMINI";
                this.lbPercaktoAksesore.ValueMember = "ALUMIN.ID_ALUMINI";
            }
            else if (this.cmbLlojAksesore.SelectedIndex == 1)
            {
                this.lbPercaktoAksesore.DataSource = this.dsAksesore;
                this.lbPercaktoAksesore.DisplayMember = "XHAM.KOD_XHAMI";
                this.lbPercaktoAksesore.ValueMember = "XHAM.ID_XHAMI";
            }
            else if (this.cmbLlojAksesore.SelectedIndex == 2)
            {
                this.lbPercaktoAksesore.DataSource = this.dsAksesore;
                this.lbPercaktoAksesore.DisplayMember = "AKSESORE.KOD_AKSESORI";
                this.lbPercaktoAksesore.ValueMember = "AKSESORE.ID_AKSESORI";
            }
        }

        private void lbModifikoLlojProdukti_DoubleClick(object sender, EventArgs e)
        {

        }

        private void btnFormule_Click(object sender, EventArgs e)
        {
            if (this.lbAksesoreTePercaktuar.SelectedItems.Count == 0)
            {
                MessageBox.Show("Per te percaktuar formulen duhet qe te zgjidhni nje nga aksesoret", "Percaktimi i formules",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Ne fillim shohim nese ndonjeri nga elementet e ndodhur ne listBox nuk jane
            // te hedhur si varesi ndaj ketij lloj produkti
            bool uGjet = false;
            for (int i = 0; i < this.dsKaloAksesore.Tables[0].Rows.Count; i++)
            {
                uGjet = false;
                // Kontrollojme nese kjo vlere ndodhet tashme ne databaze si varesi ndaj produktit
                foreach (DataRow drPrAks in this.dsProduktAksesore.Tables[0].Rows)
                {
                    if (drPrAks == this.dsKaloAksesore.Tables[0].Rows[i])
                    {
                        uGjet = true;
                    }
                    if (uGjet)
                        break;
                }
                if (!uGjet)
                {
                    //this.produktAksesoreTableAdapter.Insert((Int32)this.dsKaloAksesore.Tables[0].Rows[i]["ID_PRODUKTI"],
                    //    (Int32)this.dsKaloAksesore.Tables[0].Rows[i]["ID_AKSESORE_ALUMINI"], (Int32)this.dsKaloAksesore.Tables[0].Rows[i]["ID_AKSESORE_XHAMI"], 
                    //    (Int32)this.dsKaloAksesore.Tables[0].Rows[i]["ID_AKSESORE"], "");
                }
            }
            int idProduktAksesori = 0;
            int idAksesori = 0;
            string idAksesoriStr = "";
            idAksesoriStr = this.lbAksesoreTePercaktuar.SelectedValue.ToString();
            idAksesori = Convert.ToInt32(idAksesoriStr.Split('_')[0]);
            int idAlumini = 0;
            int idAksesori2 = 0;
            int idXhami = 0;
            switch (idAksesoriStr.Split('_')[1])
            {
                case "AL":
                    idAlumini = idAksesori;
                    if (this.produktAksesoreTableAdapter.ScalarQueryByAluminProdukt(idProdukti, idAksesori) == null)
                        idProduktAksesori = -1;
                    else
                        idProduktAksesori = (Int32)this.produktAksesoreTableAdapter.ScalarQueryByAluminProdukt(idProdukti, idAksesori);
                    break;
                case "XH":
                    idXhami = idAksesori;
                    if (this.produktAksesoreTableAdapter.ScalarQueryByXhamProdukt(idProdukti, idAksesori) == null)
                        idProduktAksesori = -1;
                    else
                        idProduktAksesori = (Int32)this.produktAksesoreTableAdapter.ScalarQueryByXhamProdukt(idProdukti, idAksesori);
                    break;
                case "AK":
                    idAksesori2 = idAksesori;
                    if (this.produktAksesoreTableAdapter.ScalarQueryByAksesoreProdukt(idProdukti, idAksesori) == null)
                        idProduktAksesori = -1;
                    else
                        idProduktAksesori = (Int32)this.produktAksesoreTableAdapter.ScalarQueryByAksesoreProdukt(idProdukti, idAksesori);
                    break;
            }
            //FrmFormule frmFormula = new FrmFormule((Int32)this.dsKaloAksesore.Tables[0].Rows[this.lbAksesoreTePercaktuar.SelectedIndex]["ID_PRODUKT_AKSESORE"], this.idProdukti);
            FrmFormule frmFormula = new FrmFormule(idProduktAksesori, this.idProdukti);
            frmFormula.ShowDialog();
            if (frmFormula.formula.Trim() != "")
            {
                //DataRow drKaloAks1 = this.dsKaloAksesore.Tables[0].NewRow();
                if (idAlumini != 0)
                    this.dsKaloAksesore.Tables[0].Select("ID_AKSESORE_ALUMINI = " + idAlumini + " AND ID_PRODUKTI = " + this.idProdukti)[0]["FORMULA"] = frmFormula.formula;
                else if (idXhami != 0)
                    this.dsKaloAksesore.Tables[0].Select("ID_AKSESORE_XHAMI = " + idXhami + " AND ID_PRODUKTI = " + this.idProdukti)[0]["FORMULA"] = frmFormula.formula;
                else if (idAksesori2 != 0)
                    this.dsKaloAksesore.Tables[0].Select("ID_AKSESORE = " + idAksesori2 + " AND ID_PRODUKTI = " + this.idProdukti)[0]["FORMULA"] = frmFormula.formula;
                //drKaloAks1["FORMULA"] = frmFormula.formula;
                dsKaloAksesore.AcceptChanges();
                //this.produktAksesoreTableAdapter.UpdateQueryFormula(frmFormula.formula, idProduktAksesori);
            }
        }

        private void cmbLlojProduktesh_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.dsLlojeProduktesh.LLOJ_SISTEMI.Rows.Clear();
            DataTable dtEmerProdukti = new DataTable();
            dtEmerProdukti.Columns.Add("EMER_PRODUKTI", typeof(String));
            dtEmerProdukti.AcceptChanges();
            dtEmerProdukti = produkteTableAdapter.GetDataByGroupEmerProdukti((Int32)this.cmbLlojProduktesh.SelectedValue);
            this.chkLlojProduktesh.DataSource = dtEmerProdukti;
            this.chkLlojProduktesh.DisplayMember = "EMER_PRODUKTI";
            this.chkLlojProduktesh.ValueMember = "EMER_PRODUKTI";
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            this.dsAksTePercaktuar.Clear();
            if (this.lbLlojSistemi.SelectedItems.Count < 1)
            {
                MessageBox.Show("Ju lutemi zgjidhni njerin nga llojet e produkteve", "Konfigurimi i produkteve", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string emerProdukti = "";
            emerProdukti = this.chkLlojProduktesh.SelectedValue.ToString();
            this.idProdukti = (Int32)this.produkteTableAdapter.ScalarQueryIdProdukti(emerProdukti, (Int32)this.lbLlojSistemi.SelectedValue);
            this.produkteTableAdapter.FillByIdProdukti(this.dsProdukte.PRODUKTE, this.idProdukti);
            this.produktAksesoreTableAdapter.FillByIdProdukti(this.dsProduktAksesore.PRODUKT_AKSESORE, idProdukti);
            this.KrijoDataSet();
            dsAksPercaktuar();
            this.kopjohet = true;
        }
        
        /// <summary>
        /// Mbush lbAksTePercaktuar me aksesoret qe perdoren per produktin e zgjedhur
        /// </summary>
        private void dsAksPercaktuar()
        {
            DataTable dt = new DataTable();
            DataTable dtAlumin = new DataTable();
            DataTable dtXham = new DataTable();
            DataTable dtAksesore = new DataTable();
            dt.Columns.Add("ID_LLOJ", typeof(String));
            dt.Columns.Add("ID_PRODUKTI", typeof(Int32));
            dt.Columns.Add("EMER", typeof(String));
            this.dsAksTePercaktuar.Tables.Add(dt);
            if (this.produkteAksesoreTableAdapter.GetDataByAlumin(this.idProdukti) == null)
            {
                return;
            }
            dtAlumin = this.produkteAksesoreTableAdapter.GetDataByAlumin(this.idProdukti);
            foreach (DataRow dr in dtAlumin.Rows)
            {
                DataRow dr1 = dt.NewRow();
                dr1["ID_LLOJ"] = dr["ID_AKSESORE_ALUMINI"] + "_AL";
                dr1["ID_PRODUKTI"] = dr["ID_PRODUKTI"];
                dr1["EMER"] = dr["EMER_ALUMINI"];
                dt.Rows.Add(dr1);
            }
            if (this.produkteAksesoreTableAdapter.GetDataByXham(this.idProdukti) == null)
            {
                return;
            }
            dtXham = this.produkteAksesoreTableAdapter.GetDataByXham(this.idProdukti);
            foreach (DataRow dr in dtXham.Rows)
            {
                DataRow dr1 = dt.NewRow();
                dr1["ID_LLOJ"] = dr["ID_AKSESORE_XHAMI"] + "_XH";
                dr1["ID_PRODUKTI"] = dr["ID_PRODUKTI"];
                dr1["EMER"] = dr["EMER_XHAMI"];
                dt.Rows.Add(dr1);
            }
            if (this.produkteAksesoreTableAdapter.GetDataByAksesor(this.idProdukti) == null)
            {
                return;
            }
            dtAksesore = this.produkteAksesoreTableAdapter.GetDataByAksesor(this.idProdukti);
            foreach (DataRow dr in dtAksesore.Rows)
            {
                DataRow dr1 = dt.NewRow();
                dr1["ID_LLOJ"] = dr["ID_AKSESORE"] + "_AK";
                dr1["ID_PRODUKTI"] = dr["ID_PRODUKTI"];
                dr1["EMER"] = dr["EMER_AKSESORI"];
                
                dt.Rows.Add(dr1);
            }
            DataTable dtProduktAks = this.produktAksesoreTableAdapter.GetDataByIdProdukti(this.idProdukti);
            foreach (DataRow drProdAks in dtProduktAks.Rows)
            {
                DataRow drKaloAks = this.dsKaloAksesore.Tables[0].NewRow();
                drKaloAks["ID_PRODUKTI"] = drProdAks["ID_PRODUKTI"];
                drKaloAks["ID_AKSESORE_ALUMINI"] = drProdAks["ID_AKSESORE_ALUMINI"];
                drKaloAks["ID_AKSESORE_XHAMI"] = drProdAks["ID_AKSESORE_XHAMI"];
                drKaloAks["ID_AKSESORE"] = drProdAks["ID_AKSESORE"];
                drKaloAks["FORMULA"] = drProdAks["FORMULA"];
                this.dsKaloAksesore.Tables[0].Rows.Add(drKaloAks);
            }
            this.lbAksesoreTePercaktuar.DataSource = dt;
            this.lbAksesoreTePercaktuar.DisplayMember = "EMER";
            this.lbAksesoreTePercaktuar.ValueMember = "ID_LLOJ";
            
        }

        private void KonfigurimeDyerMeHapje_Load(object sender, EventArgs e)
        {
            this.Size = new Size(874, 720);
            //this.llojSistemiTableAdapter.Fill(dsLlojeProduktesh.LLOJ_SISTEMI);
            this.llojProduktiTableAdapter.Fill(dsLlojeProduktesh.LLOJ_PRODUKTI);
        }

        private void chkLlojProduktesh_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.llojSistemiTableAdapter.FillByEmerProdukti(dsLlojeProduktesh.LLOJ_SISTEMI, this.chkLlojProduktesh.SelectedValue.ToString());
        }

        private void btnKopjo_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Jeni te sigurte qe deshironi te kopjoni te dhenat e ketij produkti ne nje produkt tjeter?", "Konfigurimi i produkteve", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res != DialogResult.Yes)
                return;
            if (!this.kopjohet)
            {
                MessageBox.Show("Nuk eshte zgjedhur akoma asnje produkt per tu kopjuar!" + Environment.NewLine + "Duhet te zgjidhni me pare nje produkt", "Konfigurimi i produkteve", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (this.lbAksesoreTePercaktuar.Items.Count < 1)
            {
                MessageBox.Show("Produkti i zgjedhur nga ju nuk ka asnje aksesor!", "Konfigurimi i produkteve", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            KopjoProdukt kopjoPr = new KopjoProdukt();
            kopjoPr.idProdukti = this.idProdukti;
            kopjoPr.ShowDialog();
        }
    }
}

