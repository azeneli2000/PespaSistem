using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Jyc.Expr;
using System.Text.RegularExpressions;

namespace PespaSistem
{
    public partial class ProduktAksesore : PespaSistemLibrary.Form
    {
        #region Public & Private Declarations
        public DataSet dsProjekteDataPublic;
        public DataSet dsProdukteProjektePublic;
        private int idProdukti = 1;
        private int idProjekti = 0;
        private DataTable dtAlumin;
        private DataTable dtXham;
        private DataTable dtAksesore;
        #endregion

        #region Constructors
        public ProduktAksesore()
        {
            InitializeComponent();
        }

        public ProduktAksesore(int produkti, int projekti)
        {
            InitializeComponent();
            idProdukti = produkti;
            idProjekti = projekti;
        }
        #endregion

        private void ProduktAksesore_Load(object sender, EventArgs e)
        {
            this.produkteAksesoreTableAdapter.FillByIdProdukti(dsProduktetAksesoret.PRODUKT_AKSESORE, idProdukti);
            this.aluminProdukteAksesoreTableAdapter.Fill(dsProduktetAksesoret.ALUMIN);
            this.xhamProdukteAksesoreTableAdapter.Fill(dsProduktetAksesoret.XHAM);
            this.aksesoreProdukteAksesoreTableAdapter.Fill(dsProduktetAksesoret.AKSESORE);
            // Per tre gridat krijojme lidhjen me tabelat perkatese qe krijohen nga querie-t ne dsProduktAksesore
            dtAlumin = this.produkteAksesoreTableAdapter.GetDataByAlumin(this.idProdukti);
            dtXham = this.produkteAksesoreTableAdapter.GetDataByXham(this.idProdukti);
            dtAksesore = this.produkteAksesoreTableAdapter.GetDataByAksesor(this.idProdukti);
            this.dgAlumini.DataSource = dtAlumin;
            this.dgAksesori.DataSource = dtAksesore;
            this.dgXhami.DataSource = dtXham;
            // Krijojme edhe stilet per gridat
            this.KrijoStilDgAlumin();
            this.KrijoStilDgAksesore();
            this.KrijoStilDgXham();
        }

        #region NumericBoxes EventHandlers
        private void numGjeresi_Validated(object sender, EventArgs e)
        {
            if (this.numLartesi.Value > 0)
                this.numSiperfaqe.Value = numLartesi.Value * numGjeresi.Value;
        }

        private void numLartesi_Validated(object sender, EventArgs e)
        {
            if (this.numGjeresi.Value > 0)
                this.numSiperfaqe.Value = numGjeresi.Value * numLartesi.Value;
        }
        #endregion

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (this.numSiperfaqe.Value <= 0 || this.numSasia.Value <= 0)
            {
                this.btnShto.Enabled = false;
            }
            else
                this.btnShto.Enabled = true;
            dtAlumin.Clear();
            dtXham.Clear();
            dtAksesore.Clear();
            dtAlumin = this.produkteAksesoreTableAdapter.GetDataByAlumin(this.idProdukti);
            dtXham = this.produkteAksesoreTableAdapter.GetDataByXham(this.idProdukti);
            dtAksesore = this.produkteAksesoreTableAdapter.GetDataByAksesor(this.idProdukti);
            this.MbushDsProdukteProjekte();
            this.RregulloDtAlumin();
            this.RregulloDtXham();
            this.RregulloDtAksesore();
            this.dgAlumini.DataSource = dtAlumin;
            this.dgAksesori.DataSource = dtAksesore;
            this.dgXhami.DataSource = dtXham;
            this.KrijoStilDgAlumin();
            this.KrijoStilDgAksesore();
            this.KrijoStilDgXham();
        }

        private void MbushDsProdukteProjekte()
        {
            DataRow dr = this.dsProdukteProjekte.Tables[0].NewRow();
            dr["ID_PROJEKTE"] = this.idProjekti;
            dr["ID_PRODUKTI"] = this.idProdukti;
            dr["GJERESI"] = this.numGjeresi.Value;
            dr["LARTESI"] = this.numLartesi.Value;
            dr["NR_KANATE"] = this.numKanate.Value;
            dr["NR_VETRATA"] = Convert.DBNull;
            dr["NR_COPE"] = this.numSasia.Value;
            this.dsProdukteProjekte.Tables[0].Rows.Add(dr);
        }

        private void RregulloDtAlumin()
        {
            DataRow drAlumin;
            decimal copeProdukte = Convert.ToDecimal(this.numSasia.Value);
            decimal gjeresi = this.numGjeresi.Value;
            decimal lartesi = this.numLartesi.Value;
            int kanate = Convert.ToInt32(this.numKanate.Value);
            decimal siperfaqe = this.numSiperfaqe.Value;
            //this.dtAlumin.Columns.Add("CMIMI", typeof(Decimal));
            this.dtAlumin.Columns.Add("SASIA", typeof(Decimal));
            this.dtAlumin.Columns.Add("VLERA", typeof(Decimal));
            bool mbaruan = false;
            if (dtAlumin.Rows.Count == 0)
                return;
            while (mbaruan == false)
            {
                foreach (DataRow dr in this.dtAlumin.Rows)
                {
                    // Kontrollojme nese kete vlere e kemi hedhur me pare ne ndonje cikel tjeter ne dataset
                    if (dsProjekteData.Tables[0].Select("ID_PROJEKTI = " + this.idProjekti + " AND ID_PRODUKTI = " +
                        dr["ID_AKSESORE_ALUMINI"] + " AND AL_XH_AK = 0").Length == 0)
                    {
                        decimal value1 = LlogaritFormulen(dr["FORMULA"].ToString());
                        
                        dr["SASIA"] = value1;
                        // Nese sasia eshte = 0, do te thote qe formula nuk eshte ekzekutuar sakte
                        if (value1 != 0)
                        {
                            if (Convert.ToDecimal(dr["ID_CMIMI"]) != 0)
                            {
                                // Kap cmimin ne baze te ID_CMIMI
                                dr["CMIMI"] = this.cmimetProdukteAksesoreTableAdapter.ScalarQueryByIdCmimi((Int32)dr["ID_CMIMI"]);
                                dr["VLERA"] = value1 * Convert.ToDecimal(dr["CMIMI"]) * Convert.ToDecimal(dr["PESHA_SPECIFIKE"]);
                            }
                            else
                            {
                                dr["CMIMI"] = 0;
                                dr["VLERA"] = 0;
                            }
                            // Hedhim elementet ne baze te dhenash
                            drAlumin = this.dsProjekteData.Tables[0].NewRow();
                            drAlumin["ID_PROJEKTI"] = this.idProjekti;
                            drAlumin["ID_PRODUKTI"] = dr["ID_AKSESORE_ALUMINI"];
                            drAlumin["SASIA"] = value1;
                            drAlumin["AL_XH_AK"] = 0;
                            this.dsProjekteData.Tables[0].Rows.Add(drAlumin);
                            // Nese numri i rreshtave te hedhur eshte i njejte me ate te dtAlumin, do te thote
                            // qe tani formula eshte ekzekutuar sakte per te gjithe elementet e dtAlumin
                            if (this.dtAlumin.Rows.Count == this.dsProjekteData.Tables[0].Rows.Count)
                                mbaruan = true;
                        }
                        else
                        {
                            if (dr["FORMULA"].ToString().Trim() == "")
                            {
 
                            }
                        }
                    }
                    else
                    {
                        mbaruan = true;
                        break;
                    }
                }
            }
        }

        private void RregulloDtXham()
        {
            DataRow drXham;
            decimal copeProdukte = Convert.ToDecimal(this.numSasia.Value);
            decimal gjeresi = this.numGjeresi.Value;
            decimal lartesi = this.numLartesi.Value;
            int kanate = Convert.ToInt32(this.numKanate.Value);
            decimal siperfaqe = this.numSiperfaqe.Value;
            //this.dtXham.Columns.Add("CMIMI", typeof(Decimal));
            this.dtXham.Columns.Add("SASIA", typeof(Decimal));
            this.dtXham.Columns.Add("VLERA", typeof(Decimal));
            foreach (DataRow dr in this.dtXham.Rows)
            {
                decimal value1 = LlogaritFormulen(dr["FORMULA"].ToString());
                dr["SASIA"] = value1;
                if (value1 > -1)
                {
                    if (Convert.ToDecimal(dr["CMIMI"]) > -1)
                    {
                        dr["CMIMI"] = this.cmimetProdukteAksesoreTableAdapter.ScalarQueryByIdCmimi((Int32)dr["ID_CMIMI"]);
                        dr["VLERA"] = value1 * Convert.ToDecimal(dr["CMIMI"]);
                    }
                    else
                    {
                        dr["CMIMI"] = 0;
                        dr["VLERA"] = 0;
                    }
                    drXham = this.dsProjekteData.Tables[0].NewRow();
                    drXham["ID_PROJEKTI"] = this.idProjekti;
                    drXham["ID_PRODUKTI"] = dr["ID_AKSESORE_XHAMI"];
                    drXham["SASIA"] = value1;
                    drXham["AL_XH_AK"] = 1;
                    this.dsProjekteData.Tables[0].Rows.Add(drXham);
                }
            }
        }

        private void RregulloDtAksesore()
        {
            DataRow drAksesore;
            decimal copeProdukte = Convert.ToDecimal(this.numSasia.Value);
            decimal gjeresi = this.numGjeresi.Value;
            decimal lartesi = this.numLartesi.Value;
            int kanate = Convert.ToInt32(this.numKanate.Value);
            decimal siperfaqe = this.numSiperfaqe.Value;
            //this.dtAksesore.Columns.Add("CMIMI", typeof(Decimal));
            this.dtAksesore.Columns.Add("SASIA", typeof(decimal));
            this.dtAksesore.Columns.Add("VLERA", typeof(decimal));
            if (dtAksesore.Rows.Count < 1)
                return;
            bool mbaruan = false;
            while (mbaruan == false)
            {
                foreach (DataRow dr in this.dtAksesore.Rows)
                {
                    if (dsProjekteData.Tables[0].Select("ID_PROJEKTI = " + this.idProjekti + " AND ID_PRODUKTI = " +
                        dr["ID_AKSESORE"] + " AND AL_XH_AK = 2").Length == 0)
                    {
                        decimal value1 = LlogaritFormulen(dr["FORMULA"].ToString());
                        dr["SASIA"] = value1;
                        if (value1 > -1)
                        {
                            if (Convert.ToDecimal(dr["CMIMI"]) > -1)
                            {
                                dr["CMIMI"] = this.cmimetProdukteAksesoreTableAdapter.ScalarQueryByIdCmimi((Int32)dr["ID_CMIMI"]);
                                dr["VLERA"] = value1 * Convert.ToDecimal(dr["CMIMI"]);
                            }
                            else
                            {
                                dr["CMIMI"] = 0;
                                dr["VLERA"] = 0;
                            }
                            drAksesore = this.dsProjekteData.Tables[0].NewRow();
                            drAksesore["ID_PROJEKTI"] = this.idProjekti;
                            drAksesore["ID_PRODUKTI"] = dr["ID_AKSESORE"];
                            drAksesore["SASIA"] = value1;
                            drAksesore["AL_XH_AK"] = 2;
                            this.dsProjekteData.Tables[0].Rows.Add(drAksesore);
                        }
                    }
                    else
                    {
                        mbaruan = true;
                        break;
                    }
                }
            }
        }
        
        private decimal LlogaritFormulen(string formula)
        {
            Parser ep = new Parser();
            Evaluater evaluater = new Evaluater();
            ParameterVariableHolder pvh = new ParameterVariableHolder();
            string expression = "";
            double kontrollVlere = 0;
            string[] str = formula.Split(' ');
            string[] vlera = str;
            for (int i = 0; i < str.Length; i++)
            {
                // Nese varesia eshte nga gjatesia e produktit
                if (str[i] == "PRGJER")
                {
                    expression += this.numGjeresi.Value.ToString();
                    vlera[i] = this.numGjeresi.Value.ToString();
                }
                // Nese varesia eshte nga lartesia e produktit
                else if (str[i] == "PRLART")
                {
                    expression += this.numLartesi.Value.ToString();
                    vlera[i] = this.numLartesi.Value.ToString();
                }
                // Nese varesia eshte nga numri i copeve te produktit
                else if (str[i] == "PRCOP")
                {
                    expression += this.numSasia.Value.ToString();
                    vlera[i] = this.numSasia.Value.ToString();
                }
                // Nese varesia eshte nga siperfaqja e produktit
                else if (str[i] == "PRSIP")
                {
                    expression += this.numSiperfaqe.Value.ToString();
                    vlera[i] = this.numSiperfaqe.Value.ToString();
                }
                // Nese varesia eshte nga numri i kanatave
                else if (str[i] == "PRKAN")
                {
                    expression += this.numKanate.Value.ToString();
                    vlera[i] = this.numKanate.Value.ToString();
                }
                else if (str[i] == "(" || str[i] == ")" || str[i] == "*" || str[i] == "/" || str[i] == "+" || str[i] == "-")
                {
                    expression += str[i];
                }
                else if (double.TryParse(str[i], out kontrollVlere))
                {
                    expression += str[i];
                }
                else if (str[i] == "")
                { 
                }
                // Nese varesia tani nuk eshte me nga produkti por nga aksesore te tjere
                else if (str[i] != "")
                {
                    decimal sasiaAks = 0;
                    string[] strPart = str[i].Split('_');
                    int id = 0;
                    if (strPart.Length == 2)
                    {
                        id = Convert.ToInt32(strPart[1]);
                        // Nese varesia eshte nga alumini
                        if (strPart[0] == "AL")
                        {
                            DataRow[] drAlumine = this.dsProjekteData.PROJEKTE_DATA.Select("ID_PROJEKTI = " + this.idProjekti + " AND ID_PRODUKTI = " + id + " AND AL_XH_AK = 0");
                            if (drAlumine.Length > 0)
                            {
                                sasiaAks = Convert.ToDecimal(drAlumine[0]["SASIA"]);
                            }
                        }
                        // Nese varesia eshte nga xhami
                        else if (strPart[0] == "XH")
                        {
                            DataRow[] drXhama = this.dsProjekteData.PROJEKTE_DATA.Select("ID_PROJEKTI = " + this.idProjekti + " AND ID_PRODUKTI = " + id + " AND AL_XH_AK = 1");
                            if (drXhama.Length > 0)
                            {
                                sasiaAks = Convert.ToDecimal(drXhama[0]["SASIA"]);
                            }
                        }
                        // Nese varesia eshte nga aksesoret
                        else if (strPart[0] == "AK")
                        {
                            DataRow[] drAksesore = this.dsProjekteData.PROJEKTE_DATA.Select("ID_PROJEKTI = " + this.idProjekti + " AND ID_PRODUKTI = " + id + " AND AL_XH_AK = 2");
                            if (drAksesore.Length > 0)
                            {
                                sasiaAks = Convert.ToDecimal(drAksesore[0]["SASIA"]);
                            }
                        }
                        else
                        {
                            return 0;
                        }
                        expression += sasiaAks.ToString();
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
            if (expression == "")
                return 0;
            object result = evaluater.Eval(expression);
            return Convert.ToDecimal(result);
        }

        #region DataGrid Styles
        private void KrijoStilDgAlumin()
        {
            this.dgAlumini.Columns.Clear();
            //
            DataGridViewTextBoxColumn colID = new DataGridViewTextBoxColumn();
            colID.HeaderText = "ID";
            colID.Width = 70;
            colID.ValueType = typeof(Int32);
            colID.DataPropertyName = "ID_AKSESORE_ALUMINI";
            colID.Visible = false;
            this.dgAlumini.Columns.Add(colID);
            //
            DataGridViewTextBoxColumn colKodi = new DataGridViewTextBoxColumn();
            colKodi.HeaderText = "Kodi";
            colKodi.Width = 70;
            colKodi.ValueType = typeof(String);
            colKodi.DataPropertyName = "KOD_ALUMINI";
            this.dgAlumini.Columns.Add(colKodi);
            //
            DataGridViewTextBoxColumn colEmri = new DataGridViewTextBoxColumn();
            colEmri.HeaderText = "Emri";
            colEmri.DataPropertyName = "EMER_ALUMINI";
            colEmri.ValueType = typeof(String);
            colEmri.Width = 100;
            this.dgAlumini.Columns.Add(colEmri);
            //
            DataGridViewTextBoxColumn colCmimi = new DataGridViewTextBoxColumn();
            colCmimi.HeaderText = "Cmimi";
            colCmimi.DataPropertyName = "CMIMI";
            colCmimi.ValueType = typeof(Decimal);
            colCmimi.Width = 100;
            this.dgAlumini.Columns.Add(colCmimi);
            //
            DataGridViewTextBoxColumn colPesha = new DataGridViewTextBoxColumn();
            colPesha.HeaderText = "Pesha specifike";
            colPesha.DataPropertyName = "PESHA_SPECIFIKE";
            colPesha.ValueType = typeof(Decimal);
            colPesha.Width = 120;
            this.dgAlumini.Columns.Add(colPesha);
            //
            DataGridViewTextBoxColumn colSasia = new DataGridViewTextBoxColumn();
            colSasia.HeaderText = "Sasia";
            colSasia.Width = 70;
            colSasia.ValueType = typeof(Decimal);
            colSasia.DataPropertyName = "SASIA";
            this.dgAlumini.Columns.Add(colSasia);
            //
            DataGridViewTextBoxColumn colVlera = new DataGridViewTextBoxColumn();
            colVlera.HeaderText = "Vlera";
            colVlera.Width = 70;
            colVlera.ValueType = typeof(Decimal);
            colVlera.DataPropertyName = "VLERA";
            this.dgAlumini.Columns.Add(colVlera);
            this.dgAlumini.Columns[0].Visible = false;
        }

        private void KrijoStilDgXham()
        {
            this.dgXhami.Columns.Clear();
            //
            DataGridViewTextBoxColumn colID = new DataGridViewTextBoxColumn();
            colID.HeaderText = "ID";
            colID.Width = 70;
            colID.ValueType = typeof(Int32);
            colID.DataPropertyName = "ID_AKSESORE_XHAMI";
            colID.Visible = false;
            this.dgXhami.Columns.Add(colID);
            //
            DataGridViewTextBoxColumn colKodi = new DataGridViewTextBoxColumn();
            colKodi.HeaderText = "Kodi";
            colKodi.Width = 70;
            colKodi.ValueType = typeof(String);
            colKodi.DataPropertyName = "KOD_XHAMI";
            this.dgXhami.Columns.Add(colKodi);
            //
            DataGridViewTextBoxColumn colEmri = new DataGridViewTextBoxColumn();
            colEmri.HeaderText = "Emri";
            colEmri.Width = 120;
            colEmri.ValueType = typeof(String);
            colEmri.DataPropertyName = "EMER_XHAMI";
            this.dgXhami.Columns.Add(colEmri);
            //
            DataGridViewTextBoxColumn colCmimi = new DataGridViewTextBoxColumn();
            colCmimi.HeaderText = "Cmimi";
            colCmimi.Width = 70;
            colCmimi.ValueType = typeof(String);
            colCmimi.DataPropertyName = "CMIMI";
            this.dgXhami.Columns.Add(colCmimi);
            //
            DataGridViewTextBoxColumn colSasia = new DataGridViewTextBoxColumn();
            colSasia.HeaderText = "Sasia";
            colSasia.Width = 70;
            colSasia.ValueType = typeof(Decimal);
            colSasia.DataPropertyName = "SASIA";
            this.dgXhami.Columns.Add(colSasia);
            //
            DataGridViewTextBoxColumn colVlera = new DataGridViewTextBoxColumn();
            colVlera.HeaderText = "Vlera";
            colVlera.Width = 70;
            colVlera.ValueType = typeof(Decimal);
            colVlera.DataPropertyName = "VLERA";
            this.dgXhami.Columns.Add(colVlera);
            this.dgXhami.Columns[0].Visible = false;

        }

        private void KrijoStilDgAksesore()
        {
            this.dgAksesori.Columns.Clear();
            //
            DataGridViewTextBoxColumn colID = new DataGridViewTextBoxColumn();
            colID.HeaderText = "ID";
            colID.Width = 20;
            colID.ValueType = typeof(Int32);
            colID.DataPropertyName = "ID_AKSESORE";
            colID.Visible = false;
            this.dgAksesori.Columns.Add(colID);
            //
            DataGridViewTextBoxColumn colKodi = new DataGridViewTextBoxColumn();
            colKodi.HeaderText = "Kodi";
            colKodi.Width = 120;
            colKodi.ValueType = typeof(String);
            colKodi.DataPropertyName = "KOD_AKSESORI";
            this.dgAksesori.Columns.Add(colKodi);
            //
            DataGridViewTextBoxColumn colEmri = new DataGridViewTextBoxColumn();
            colEmri.HeaderText = "Emri";
            colEmri.Width = 70;
            colEmri.ValueType = typeof(String);
            colEmri.DataPropertyName = "EMER_AKSESORI";
            this.dgAksesori.Columns.Add(colEmri);
            //
            DataGridViewTextBoxColumn colCmimi = new DataGridViewTextBoxColumn();
            colCmimi.HeaderText = "Cmimi";
            colCmimi.Width = 70;
            colCmimi.ValueType = typeof(String);
            colCmimi.DataPropertyName = "CMIMI";
            this.dgAksesori.Columns.Add(colCmimi);
            //
            DataGridViewTextBoxColumn colSasia = new DataGridViewTextBoxColumn();
            colSasia.HeaderText = "Sasia";
            colSasia.Width = 70;
            colSasia.ValueType = typeof(Decimal);
            colSasia.DataPropertyName = "SASIA";
            this.dgAksesori.Columns.Add(colSasia);
            //
            DataGridViewTextBoxColumn colVlera = new DataGridViewTextBoxColumn();
            colVlera.HeaderText = "Vlera";
            colVlera.Width = 70;
            colVlera.ValueType = typeof(Decimal);
            colVlera.DataPropertyName = "VLERA";
            this.dgAksesori.Columns.Add(colVlera);
            this.dgAksesori.Columns[0].Visible = false;
        }
        #endregion

        private void btnRuaj_Click(object sender, EventArgs e)
        {
            try
            {
                decimal vleraTotale = 0;
                this.dsProjekteDataPublic = this.dsProjekteData;
                this.dsProdukteProjektePublic = this.dsProdukteProjekte;
                if (this.dtAlumin.Rows.Count < 1 && this.dtXham.Rows.Count < 1 && this.dtAksesore.Rows.Count < 1)
                    return;
                if (!dtAlumin.Columns.Contains("VLERA"))
                    return;
                foreach (DataRow dr in this.dtAlumin.Rows)
                {
                    if (!Convert.IsDBNull(dr["VLERA"]))
                    {
                        dr["VLERA"] = Convert.ToDecimal(dr["SASIA"]) * Convert.ToDecimal(dr["CMIMI"]) * Convert.ToDecimal(dr["PESHA_SPECIFIKE"]);
                        vleraTotale += Convert.ToDecimal(dr["VLERA"]);
                    }
                }
                foreach (DataRow dr in this.dtXham.Rows)
                {
                    if (!Convert.IsDBNull(dr["VLERA"]))
                    {
                        dr["VLERA"] = Convert.ToDecimal(dr["SASIA"]) * Convert.ToDecimal(dr["CMIMI"]);
                        vleraTotale += Convert.ToDecimal(dr["VLERA"]);
                    }
                }
                foreach (DataRow dr in this.dtAksesore.Rows)
                {
                    if (!Convert.IsDBNull(dr["VLERA"]))
                    {
                        dr["VLERA"] = Convert.ToDecimal(dr["SASIA"]) * Convert.ToDecimal(dr["CMIMI"]);
                        vleraTotale += Convert.ToDecimal(dr["VLERA"]);
                    }
                }
                dsProdukteProjektePublic.Tables[0].Rows[0]["PREVENTIVI"] = vleraTotale;
                this.Close();
                MessageBox.Show("Te dhenat u ruajten me sukses!", "Ruajtja e te dhenave", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nje gabim ndodhi gjate ekzekutimit te programit!" + Environment.NewLine + "Ju lutemi kontaktoni me VisionInfoSolution",
                    "Ruajtja e te dhenave", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAnullo_Click(object sender, EventArgs e)
        {
            this.dsProjekteDataPublic = this.dsProjekteData;
            this.dsProjekteDataPublic.Tables[0].Clear();
            this.dsProjekteData.Tables[0].Clear();
            this.dsProdukteProjektePublic = this.dsProdukteProjekte;
            this.dsProdukteProjektePublic.Tables[0].Clear();
            this.dsProdukteProjekte.Tables[0].Clear();
            this.Close();
        }

        #region DataGridViews EventHandlers
        private void dgAlumini_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.label1.Text = this.dgAlumini[2, e.RowIndex].Value.ToString();
            if (this.dgAlumini[5, e.RowIndex] != null)
                this.numVlera.Value = Convert.ToDecimal(this.dgAlumini[5, e.RowIndex].Value);
            this.label1.Visible = true;
            this.numVlera.Visible = true;
            //this.txtID.Text = this.dgAlumini[0, e.RowIndex].Value.ToString();
            this.txtID.Text = this.dtAlumin.Rows[e.RowIndex][0].ToString();
            this.txtLloj.Text = "AL";
        }

        private void dgXhami_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.label1.Text = this.dgXhami[2, e.RowIndex].Value.ToString();
            if (this.dgXhami[4, e.RowIndex] != null)
                this.numVlera.Value = Convert.ToDecimal(this.dgXhami[4, e.RowIndex].Value);
            this.label1.Visible = true;
            this.numVlera.Visible = true;
            //this.txtID.Text = this.dgXhami[0, e.RowIndex].Value.ToString();
            this.txtID.Text = this.dtXham.Rows[e.RowIndex][0].ToString();
            this.txtLloj.Text = "XH";
        }

        private void dgAksesori_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.label1.Text = this.dgAksesori[2, e.RowIndex].Value.ToString();
            if (this.dgAksesori[4, e.RowIndex] != null)
                this.numVlera.Value = Convert.ToDecimal(this.dgAksesori[4, e.RowIndex].Value);
            this.label1.Visible = true;
            this.numVlera.Visible = true;
            //this.txtID.Text = this.dgAksesori[0, e.RowIndex].Value.ToString();
            this.txtID.Text = this.dtAksesore.Rows[e.RowIndex][0].ToString();
            this.txtLloj.Text = "AK";
        }
        #endregion

        private void numVlera_Validated(object sender, EventArgs e)
        {
            DataRow dr;
            if (this.txtLloj.Text == "AL")
            {
                dr = this.dtAlumin.NewRow();
                foreach (DataRow dr1 in this.dtAlumin.Rows)
                {
                    if (Convert.ToInt32(dr1["ID_PRODUKT_AKSESORE"]) == Convert.ToInt32(this.txtID.Text))
                    {
                        dr = dr1;
                        break;
                    }
                }
                //dr = this.dtAlumin.Rows.Find(Convert.ToInt32(this.txtID.Text));
                dr["SASIA"] = this.numVlera.Value;
                dr["VLERA"] = Convert.ToDecimal(dr["SASIA"]) * Convert.ToDecimal(dr["CMIMI"]) * Convert.ToDecimal(dr["PESHA_SPECIFIKE"]);
                DataRow[] drAlumine = dsProjekteData.Tables[0].Select("ID_PROJEKTI = " + this.idProjekti + 
                    " AND ID_PRODUKTI = " + dr["ID_AKSESORE_ALUMINI"] + " AND AL_XH_AK = 0");
                if (drAlumine != null)
                {
                    drAlumine[0]["SASIA"] = this.numVlera.Value;
                }
                this.KrijoStilDgAlumin();
            }
            else if (this.txtLloj.Text == "XH")
            {
                dr = this.dtXham.NewRow();
                foreach (DataRow dr1 in this.dtXham.Rows)
                {
                    if (Convert.ToInt32(dr1["ID_PRODUKT_AKSESORE"]) == Convert.ToInt32(this.txtID.Text))
                    {
                        dr = dr1;
                        break;
                    }
                }
                dr["SASIA"] = this.numVlera.Value;
                dr["VLERA"] = Convert.ToDecimal(dr["SASIA"]) * Convert.ToDecimal(dr["CMIMI"]);
                DataRow[] drXhama = dsProjekteData.Tables[0].Select("ID_PROJEKTI = " + this.idProjekti +
                    " AND ID_PRODUKTI = " + dr["ID_AKSESORE_XHAMI"] + " AND AL_XH_AK = 1");
                if (drXhama != null)
                {
                    drXhama[0]["SASIA"] = this.numVlera.Value;
                }
            }
            else if (this.txtLloj.Text == "AK")
            {
                dr = this.dtAksesore.NewRow();
                foreach (DataRow dr1 in this.dtAksesore.Rows)
                {
                    if (Convert.ToInt32(dr1["ID_PRODUKT_AKSESORE"]) == Convert.ToInt32(this.txtID.Text))
                    {
                        dr = dr1;
                        break;
                    }
                }
                dr["SASIA"] = this.numVlera.Value;
                dr["VLERA"] = Convert.ToDecimal(dr["SASIA"]) * Convert.ToDecimal(dr["CMIMI"]);
                DataRow[] drAksesore = dsProjekteData.Tables[0].Select("ID_PROJEKTI = " + this.idProjekti +
                    " AND ID_PRODUKTI = " + dr["ID_AKSESORE"] + " AND AL_XH_AK = 2");
                if (drAksesore != null)
                {
                    drAksesore[0]["SASIA"] = this.numVlera.Value;
                }
            }
        }

        private void btnShto_Click(object sender, EventArgs e)
        {
            try
            {
                FrmShtoProduktAksesore frm = new FrmShtoProduktAksesore();
                frm.ShowDialog();
                if (frm.sasia == 0)
                    return;
                if (frm.llojAksesore == "Alumin")
                {
                    if (dtAksesore.Select("ID_AKSESORE_ALUMINI = " + frm.idAksesore).Length > 0)
                    {
                        MessageBox.Show("Ky aksesor eshte tashme pjese e ketij produkti", "Shtimi i aksesoreve", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    DataRow drAlumin = this.dtAlumin.NewRow();
                    drAlumin["ID_PRODUKTI"] = this.idProdukti;
                    drAlumin["ID_AKSESORE_ALUMINI"] = frm.idAksesore;
                    drAlumin["KOD_ALUMINI"] = frm.kodAksesori;
                    drAlumin["EMER_ALUMINI"] = frm.emerAksesori;
                    drAlumin["SASIA"] = frm.sasia;
                    drAlumin["ID_CMIMI"] = frm.idCmimi;
                    drAlumin["CMIMI"] = frm.cmimi;
                    drAlumin["VLERA"] = frm.vlera;
                    drAlumin["AL_XH_AK"] = 0;
                    this.dtAlumin.Rows.Add(drAlumin);
                }
                else if (frm.llojAksesore == "Aksesore")
                {
                    if (dtAksesore.Select("ID_AKSESORE = " + frm.idAksesore).Length > 0)
                    {
                        MessageBox.Show("Ky aksesor eshte tashme pjese e ketij produkti", "Shtimi i aksesoreve", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    DataRow drAksesore = this.dtAksesore.NewRow();
                    drAksesore["ID_PRODUKTI"] = this.idProdukti;
                    drAksesore["ID_AKSESORE"] = frm.idAksesore;
                    drAksesore["KOD_AKSESORI"] = frm.kodAksesori;
                    drAksesore["EMER_AKSESORI"] = frm.emerAksesori;
                    drAksesore["SASIA"] = frm.sasia;
                    drAksesore["ID_CMIMI"] = frm.idCmimi;
                    drAksesore["CMIMI"] = frm.cmimi;
                    drAksesore["VLERA"] = frm.vlera;
                    drAksesore["AL_XH_AK"] = 2;
                    this.dtAksesore.Rows.Add(drAksesore);
                }
                else if (frm.llojAksesore == "Xham")
                {
                    if (dtAksesore.Select("ID_AKSESORE_XHAMI = " + frm.idAksesore).Length > 0)
                    {
                        MessageBox.Show("Ky aksesor eshte tashme pjese e ketij produkti", "Shtimi i aksesoreve", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    DataRow drXham = this.dtXham.NewRow();
                    drXham["ID_PRODUKTI"] = this.idProdukti;
                    drXham["ID_AKSESORE_XHAMI"] = frm.idAksesore;
                    drXham["KOD_XHAMI"] = frm.kodAksesori;
                    drXham["EMER_XHAMI"] = frm.emerAksesori;
                    drXham["SASIA"] = frm.sasia;
                    drXham["ID_CMIMI"] = frm.idCmimi;
                    drXham["CMIMI"] = frm.cmimi;
                    drXham["VLERA"] = frm.vlera;
                    drXham["AL_XH_AK"] = 1;
                    this.dtXham.Rows.Add(drXham);
                }
            }
            catch (Exception ex)
            {
                return;
            }
        }
    }
}

