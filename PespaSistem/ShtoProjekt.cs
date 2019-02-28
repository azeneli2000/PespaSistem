using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PespaSistem
{
    public partial class ShtoProjekt : PespaSistemLibrary.Form
    {
        /// <summary>
        /// Sherben pe te mbajtur idProjektin per projektin e ri qe do te shtohet
        /// </summary>
        private int idProjekti = 0;
        /// <summary>
        /// Sherben per te mbajtur idProdukti-n e produktit te zgjedhur
        /// </summary>
        private int idProdukti = 0;
        public ShtoProjekt()
        {
            InitializeComponent();
        }

        private void btnShto_Click(object sender, EventArgs e)
        {

        }

        private void btnElemino_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dsPespaSistem.Tables["PROJEKTE"].Rows.Clear();
            DataRow dr = dsPespaSistem.Tables["PROJEKTE"].NewRow();
            dr["EMER_PROJEKTI"] = this.txtEmerProjekti.Text;
            dr["DATA_PROJEKTI"] = this.dtpDataProjekti.Value;
            dsPespaSistem.Tables["PROJEKTE"].Rows.Add(dr);
        }

        private void cmbLlojProduktesh_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            this.dsLlojeProduktesh.LLOJ_SISTEMI.Rows.Clear();
            DataTable dtEmerProdukti = new DataTable();
            dtEmerProdukti.Columns.Add("EMER_PRODUKTI", typeof(String));
            dtEmerProdukti.AcceptChanges();
            dtEmerProdukti = produkteTableAdapter.GetDataByGroupEmerProdukti((Int32)this.cmbLlojProduktesh.SelectedValue);
            this.lbProdukte.DataSource = dtEmerProdukti;
            this.lbProdukte.DisplayMember = "EMER_PRODUKTI";
            this.lbProdukte.ValueMember = "EMER_PRODUKTI";

            //this.chkLlojProduktesh.DisplayMember = "StringType";
            //this.produkteTableAdapter.FillByLlojProdukti(dsProdukte.PRODUKTE, this.cmbLlojProduktesh.SelectedIndex);
            //this.chkLlojProduktesh.DataSource = this.dsProdukte.PRODUKTE;
            //this.chkLlojProduktesh.DisplayMember = "EMER_PRODUKTI";
            //this.chkLlojProduktesh.ValueMember = "ID_PRODUKTI";
        }

        private void ShtoProjekt_Load(object sender, EventArgs e)
        {
            this.produkteTableAdapter.Fill(dsProdukte.PRODUKTE);
            this.llojProduktiTableAdapter.Fill(dsLlojeProduktesh.LLOJ_PRODUKTI);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (this.lbLlojSistemi.SelectedItems.Count < 1)
            {
                MessageBox.Show("Ju lutemi zgjidhni njerin nga llojet e produkteve", "Konfigurimi i produkteve", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (this.dsPespaSistem.Tables["PROJEKTE"].Rows.Count < 1)
            {
                MessageBox.Show("Me pare duhet te shtoni projektin!", "Konfigurimi i produkteve", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                this.Cursor = Cursors.WaitCursor;
                string emerProdukti = "";
                emerProdukti = this.lbProdukte.SelectedValue.ToString();
                this.idProdukti = (Int32)this.produkteTableAdapter.ScalarQueryIdProdukti(emerProdukti, (Int32)this.lbLlojSistemi.SelectedValue);
                idProjekti = (Int32)this.dsPespaSistem.Tables["PROJEKTE"].Rows[this.dsPespaSistem.PROJEKTE.Rows.Count - 1]["ID_PROJEKTI"];
                //idProjekti = Convert.ToInt32(projekteTableAdapter.ScalarQueryMaxId());
                ProduktAksesore produktAksesore = new ProduktAksesore(idProdukti, idProjekti);
                produktAksesore.ShowDialog();
                if (produktAksesore.dsProjekteDataPublic.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow dr in produktAksesore.dsProjekteDataPublic.Tables[0].Rows)
                    {
                        DataRow drProjekte = dsProjekteData.Tables[0].NewRow();
                        drProjekte["ID_PROJEKTI"] = dr["ID_PROJEKTI"];
                        drProjekte["ID_PRODUKTI"] = dr["ID_PRODUKTI"];
                        drProjekte["SASIA"] = dr["SASIA"];
                        drProjekte["AL_XH_AK"] = dr["AL_XH_AK"];
                        dsProjekteData.Tables[0].Rows.Add(drProjekte);
                    }
                    DataRow dr1 = dsPespaSistem.Tables["PRODUKTE_PROJEKTE"].NewRow();
                    dr1["ID_PROJEKTE"] = produktAksesore.dsProdukteProjektePublic.Tables[0].Rows[0]["ID_PROJEKTE"];
                    dr1["ID_PRODUKTI"] = produktAksesore.dsProdukteProjektePublic.Tables[0].Rows[0]["ID_PRODUKTI"];
                    dr1["GJERESI"] = produktAksesore.dsProdukteProjektePublic.Tables[0].Rows[0]["GJERESI"];
                    dr1["LARTESI"] = produktAksesore.dsProdukteProjektePublic.Tables[0].Rows[0]["LARTESI"];
                    dr1["NR_KANATE"] = produktAksesore.dsProdukteProjektePublic.Tables[0].Rows[0]["NR_KANATE"];
                    dr1["NR_VETRATA"] = produktAksesore.dsProdukteProjektePublic.Tables[0].Rows[0]["NR_VETRATA"];
                    dr1["NR_COPE"] = produktAksesore.dsProdukteProjektePublic.Tables[0].Rows[0]["NR_COPE"];
                    dsPespaSistem.Tables["PRODUKTE_PROJEKTE"].Rows.Add(dr1);

                    // Mbush tabelen DtProdukte te datasetit dsFatura
                    DataRow drProdukte = dsFatura.DtProdukte.NewRow();
                    int produktId = 0;
                    produktId = Convert.ToInt32(produktAksesore.dsProdukteProjektePublic.Tables[0].Rows[0]["ID_PRODUKTI"]);
                    DataRow dr2 = (DataRow)produkteTableAdapter1.GetDataByIdProdukt(produktId).Rows[0];
                    drProdukte["ID_PRODUKTI"] = produktAksesore.dsProdukteProjektePublic.Tables[0].Rows[0]["ID_PRODUKTI"];
                    drProdukte["EMER_PRODUKTI"] = dr2["EMER_PRODUKTI"];
                    drProdukte["LLOJ_PRODUKTI"] = dr2["EMER_LLOJI"];
                    drProdukte["LLOJ_SISTEMI"] = dr2["LLOJ_SISTEMI"];
                    drProdukte["GJERESI"] = produktAksesore.dsProdukteProjektePublic.Tables[0].Rows[0]["GJERESI"];
                    drProdukte["LARTESI"] = produktAksesore.dsProdukteProjektePublic.Tables[0].Rows[0]["LARTESI"];
                    drProdukte["SIPERFAQE"] = Convert.ToDecimal(drProdukte["GJERESI"]) * Convert.ToDecimal(drProdukte["LARTESI"]);
                    drProdukte["NR_KANATE"] = produktAksesore.dsProdukteProjektePublic.Tables[0].Rows[0]["NR_KANATE"];
                    drProdukte["NR_VETRATA"] = produktAksesore.dsProdukteProjektePublic.Tables[0].Rows[0]["NR_VETRATA"];
                    drProdukte["NR_COPE"] = produktAksesore.dsProdukteProjektePublic.Tables[0].Rows[0]["NR_COPE"];
                    drProdukte["PREVENTIVI"] = Convert.ToDecimal(produktAksesore.dsProdukteProjektePublic.Tables[0].Rows[0]["PREVENTIVI"]).ToString(".000");
                    dsFatura.DtProdukte.Rows.Add(drProdukte);
                    int idDtProdukti = Convert.ToInt32(dsFatura.DtProdukte.Rows[dsFatura.DtProdukte.Rows.Count - 1]["IDDtProdukti"]);

                    // Mbush tabelen DtAksesore te datasetit dsFatura
                    MbushDsFaturaDtAksesore(produktAksesore.dsProjekteDataPublic.Tables[0]);
                    DataTable dtAlAkXh = new DataTable();
                    foreach (DataRow dr3 in produktAksesore.dsProjekteDataPublic.Tables[0].Rows)
                    {
                        DataRow drAksesore = dsFatura.DtAksesore.NewRow();
                        drAksesore["IDDtProdukti"] = idDtProdukti;
                        drAksesore["ID_PRODUKTI"] = dr3["ID_PRODUKTI"];
                        switch (Convert.ToInt32(dr3["AL_XH_AK"]))
                        {
                            // Nese varesia eshte nga Alumini
                            case 0:
                                dtAlAkXh = aluminTableAdapter.GetDataByIdAlumini((Int32)dr3["ID_PRODUKTI"]);
                                drAksesore["ID_AKSESORE_ALUMINI"] = dtAlAkXh.Rows[0]["ID_ALUMINI"];
                                drAksesore["ID_AKSESORE_XHAMI"] = Convert.DBNull;
                                drAksesore["ID_AKSESORE"] = Convert.DBNull;
                                drAksesore["KOD_AKSESORI"] = dtAlAkXh.Rows[0]["KOD_ALUMINI"];
                                drAksesore["EMER_AKSESORI"] = dtAlAkXh.Rows[0]["EMER_ALUMINI"];
                                drAksesore["CMIMI"] = dtAlAkXh.Rows[0]["CMIMI"];
                                drAksesore["PESHA_SPECIFIKE"] = Convert.ToDecimal(dtAlAkXh.Rows[0]["PESHA_SPECIFIKE"]);
                                break;
                            // Nese varesia eshte nga Xhami
                            case 1:
                                dtAlAkXh = xhamTableAdapter.GetDataByIdXhami((Int32)dr3["ID_PRODUKTI"]);
                                drAksesore["ID_AKSESORE_XHAMI"] = dtAlAkXh.Rows[0]["ID_XHAMI"];
                                drAksesore["ID_AKSESORE_ALUMINI"] = Convert.DBNull;
                                drAksesore["ID_AKSESORE"] = Convert.DBNull;
                                drAksesore["KOD_AKSESORI"] = dtAlAkXh.Rows[0]["KOD_XHAMI"];
                                drAksesore["EMER_AKSESORI"] = dtAlAkXh.Rows[0]["EMER_XHAMI"];
                                drAksesore["CMIMI"] = dtAlAkXh.Rows[0]["CMIMI"];
                                drAksesore["PESHA_SPECIFIKE"] = 1;
                                break;
                            // Nese varesia eshte nga Produkti
                            case 2:
                                dtAlAkXh = aksesoreTableAdapter.GetDataByIdAksesori((Int32)dr3["ID_PRODUKTI"]);
                                drAksesore["ID_AKSESORE_ALUMINI"] = Convert.DBNull;
                                drAksesore["ID_AKSESORE_XHAMI"] = Convert.DBNull;
                                drAksesore["ID_AKSESORE"] = dtAlAkXh.Rows[0]["ID_AKSESORI"];
                                drAksesore["KOD_AKSESORI"] = dtAlAkXh.Rows[0]["KOD_AKSESORI"];
                                drAksesore["EMER_AKSESORI"] = dtAlAkXh.Rows[0]["EMER_AKSESORI"];
                                drAksesore["CMIMI"] = dtAlAkXh.Rows[0]["CMIMI"];
                                drAksesore["PESHA_SPECIFIKE"] = 1;
                                break;
                        }
                        drAksesore["SASIA"] = dr3["SASIA"];
                        dsFatura.DtAksesore.Rows.Add(drAksesore);
                    }
                }
            }
            catch (Exception ex)
            {
                return;
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }

        }

        private void btnRuaj_Click(object sender, EventArgs e)
        {
            decimal preventivi = 0;
            if (this.dataGridView1.Rows.Count < 2)
            {
                MessageBox.Show("Per projektin nuk eshte ruajtur asnje produkt." + Environment.NewLine + "Projekti nuk mund te ruhet!",
                    "Ruajtja e projekteve", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult res = MessageBox.Show("Jeni te sigurte qe doni ta ruani projektin?", "Ruajtja e projekteve", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res != DialogResult.Yes)
                return;
            for (int i = 0; i < this.dataGridView1.Rows.Count; i++)
            {
                preventivi += Convert.ToDecimal(this.dataGridView1.Rows[i].Cells["pREVENTIVIDataGridViewTextBoxColumn"].Value);
            }
            this.dsPespaSistem.Tables["PROJEKTE"].Rows[0]["PREVENTIVI"] = preventivi;
            this.projekteTableAdapter.Update(dsPespaSistem.PROJEKTE);
            this.projektE_DATATableAdapter.Update(dsProjekteData.PROJEKTE_DATA);
            MessageBox.Show("Projekti u ruajt me sukses!", "Hedhja e projekteve", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.dsPespaSistem.Tables["PROJEKTE"].Rows.Clear();
            this.dsPespaSistem.Tables["AKSESORE"].Rows.Clear();
            this.dsPespaSistem.Tables["ALUMIN"].Rows.Clear();
            this.dsPespaSistem.Tables["PROJEKTE_DATA"].Rows.Clear();
            this.dsPespaSistem.Tables["PRODUKTE_PROJEKTE"].Rows.Clear();
            this.dsPespaSistem.Tables["ALUMIN"].Rows.Clear();
            this.dsPespaSistem.Tables["XHAM"].Rows.Clear();
            this.dsPespaSistem.Tables["PRODUKT_AKSESORE"].Rows.Clear();
            this.dsPespaSistem.Tables["PRODUKT_AKSESORE"].Rows.Clear();
            this.dsProdukte.Tables[0].Rows.Clear();
            this.dsProdukteProjekte.Tables[0].Rows.Clear();
            this.dsProjekteData.Tables[0].Rows.Clear();
            this.dsRaport.Tables[0].Rows.Clear();
            this.dsFatura.DtProdukte.Rows.Clear();
            this.dsFatura.DtAksesore.Rows.Clear();
            this.txtEmerProjekti.Text = "";

        }

        private void btnShfaq_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                FrmZgjidhPrintim frmZgjidhPrint = new FrmZgjidhPrintim();
                frmZgjidhPrint.ShowDialog();
                if (frmZgjidhPrint.vlere == 0)
                    return;
                if (frmZgjidhPrint.vlere == 1)
                {
                    CrRaport crRaport = new CrRaport();
                    FrmPrintim frmPrintim = new FrmPrintim(crRaport);
                    crRaport.SetDataSource(dsFatura);
                    frmPrintim.ShowDialog();
                    return;
                }
                if (frmZgjidhPrint.vlere == 2)
                {
                    MbushDsFatura();
                    decimal totali = 0;
                    foreach (DataRow dr in this.dsFatura.DtProdukte.Rows)
                    {
                        //totali += Convert.ToDecimal(dr["PREVENTIVI"]) * Convert.ToDecimal(dr["NR_COPE"]);
                        totali += Convert.ToDecimal(dr["PREVENTIVI"]);
                    }
                    CrFatura crFature = new CrFatura();
                    FrmPrintim frmPrintim = new FrmPrintim(crFature);
                    crFature.SetDataSource(dsFatura);
                    crFature.SummaryInfo.ReportComments = totali.ToString(".00");
                    crFature.SummaryInfo.ReportTitle = this.dsPespaSistem.Tables["PROJEKTE"].Rows[0]["EMER_PROJEKTI"].ToString();
                    frmPrintim.ShowDialog();
                }
            }
            catch
            {
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
            //this.aksesoreTableAdapter.Fill(dsPespaSistem.AKSESORE);
            //this.aluminTableAdapter.Fill(dsPespaSistem.ALUMIN);
            //this.xhamTableAdapter.Fill(dsPespaSistem.XHAM);
            //CrFatura crFatura = new CrFatura();
            //crFatura.SetDataSource(dsPespaSistem);
            //FrmPrintim frmPrintim = new FrmPrintim(crFatura);
            //frmPrintim.ShowDialog();
        }

        private void MbushDsRaport_Produkte()
        {

            dsRaport.Tables["PRODUKTE"].Rows.Clear();
             //Mbushim ne fillim tabelen e produkteve qe i perkasin ketij projekti
            foreach (DataRow dr in this.dsPespaSistem.Tables["PRODUKTE_PROJEKTE"].Rows)
            {
                DataRow drRaportProdukte = this.dsRaport.Tables["PRODUKTE"].NewRow();
                drRaportProdukte["ID_PRODUKTI"] = dr["ID_PRODUKTI"];
                drRaportProdukte["EMER_PRODUKTI"] = this.produkteTableAdapter.ScalarQueryEmerProdukti(Convert.ToInt32(dr["ID_PRODUKTI"]));
                drRaportProdukte["GJERESI"] = dr["GJERESI"];
                drRaportProdukte["LARTESI"] = dr["LARTESI"];
                drRaportProdukte["NR_KANATE"] = dr["NR_KANATE"];
                drRaportProdukte["NR_VETRATA"] = dr["NR_VETRATA"];
                drRaportProdukte["NR_COPE"] = dr["NR_COPE"];
                dsRaport.Tables["PRODUKTE"].Rows.Add(drRaportProdukte);

            }
        }

        /// <summary>
        /// Ben mbushjen e tabeles DtAksesore te datasetit DsFatura
        /// </summary>
        private void MbushDsFatura()
        {
            DataRow drDtAksesore = this.dsFatura.DtAksesore.NewRow();
            foreach (DataRow dr in this.dsProjekteData.PROJEKTE_DATA.Rows)
            {
                //drDtAksesore["IdDtProdukti"] = dsProjekteData.PROJEKTE_DATA["ID_PRODUKTI"];
                //drDtAksesore[""]
            }
            //int produktId = 0;
            //dsFatura.Tables[0].Rows.Clear();
            //dsFatura.Tables[1].Rows.Clear();
            //foreach (DataRow drRaportIdProdukt in this.dsRaport.PRODUKTE.Rows)
            //{
            //    DataRow drProdukte = dsFatura.DtProdukte.NewRow();
            //    produktId = Convert.ToInt32(drRaportIdProdukt["ID_PRODUKTI"]);
            //    DataRow dr = (DataRow)produkteTableAdapter1.GetDataByIdProdukt(produktId).Rows[0];
            //    //drProdukte["ID_PRODUKTI"] = dr["ID_PRODUKTI"];
            //    drProdukte["EMER_PRODUKTI"] = dr["EMER_PRODUKTI"];
            //    drProdukte["LLOJ_PRODUKTI"] = dr["EMER_LLOJI"];
            //    drProdukte["LLOJ_SISTEMI"] = dr["LLOJ_SISTEMI"];
            //    dsFatura.DtProdukte.Rows.Add(drProdukte);
            //}
        }

        /// <summary>
        /// Mbush tabelen DtAksesore te datasetit dsFatura
        /// </summary>
        /// <param name="dtAks">DataTable e cila eshte baza per mbushjen e DtAksesore</param>
        private void MbushDsFaturaDtAksesore(DataTable dtAks)
        { 
        }

        /// <summary>
        ///  Shton dy kolona ne griden e produkteve. Njera eshte per siperfaqen ndersa tjetra per preventivin e produktit
        /// Thirret vetem ne EventHandler-in e klikimit te butonit OK
        /// </summary>
        private void ShtoKoloneDg()
        {
            decimal siperfaqe = 0;
            for (int i = 0; i < this.dataGridView1.Rows.Count - 1; i++ )
            {
                siperfaqe = Convert.ToDecimal(this.dataGridView1.Rows[i].Cells["colGjeresi"].Value) * 
                    Convert.ToDecimal(this.dataGridView1.Rows[i].Cells["colLartesi"].Value);
                this.dataGridView1.Rows[i].Cells["colSiperfaqe"].Value = siperfaqe;
            }

        }

        private void lbProdukte_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.llojSistemiTableAdapter.FillByEmerProdukti(dsLlojeProduktesh.LLOJ_SISTEMI, this.lbProdukte.SelectedValue.ToString());
            
        }
    }
}