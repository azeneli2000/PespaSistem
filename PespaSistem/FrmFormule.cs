using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PespaSistem
{
    public partial class FrmFormule : PespaSistemLibrary.Form
    {
        private String last = "";
        private int idAksesorProdukti;
        private int idProdukti;
        private DataTable dtFormule;
        public String formula = "";
        public FrmFormule()
        {
            InitializeComponent();
        }

        public FrmFormule(int idAksesor, int idProdukt)
        {
            InitializeComponent();
            idAksesorProdukti = idAksesor;
            idProdukti = idProdukt;
            dtFormule = new DataTable();
            dtFormule.Columns.Add("ID", typeof(Int32));
            dtFormule.Columns.Add("KOD_FORMULE", typeof(String));
            dtFormule.Columns.Add("EMER", typeof(String));
            dtFormule.Columns.Add("LLOJI", typeof(String));
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DialogResult res = DialogResult;
            res = MessageBox.Show("Formula qe ju percaktuat per aksesorin eshte:" + Environment.NewLine + this.FormuleAktuale(formula) + Environment.NewLine
            + "Jeni te sigurte qe doni ta ruani?", "Konfigurimi i formulave", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                return;
            }
        }

        private void btnOK_Click_1(object sender, EventArgs e)
        {
            this.Close();
            //this.txtFormula.Text += "";
        }

        #region OperatorButtons EventHandlers

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (this.formula.Trim() == "")
                MessageBox.Show("Formula nuk mund te nise me nje operator!", "Konfigurimi i formules", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (last != "+" || last != "-" || last != "*" || last != "/" || last != ")" || last != "(")
            {
                this.txtFormula.Text += " + ";
                this.last = "+";
                this.formula += "+ ";
            }
            else
            {
                MessageBox.Show("Nuk mund te vendosni dy operatore njeri pas tjetrit ne formule!", "Konfigurimi i formules", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (this.formula.Trim() == "")
                MessageBox.Show("Formula nuk mund te nise me nje operator!", "Konfigurimi i formules", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (last != "+" || last != "-" || last != "*" || last != "/" || last != ")" || last != "(")
            {
                this.txtFormula.Text += " - ";
                this.last = "-";
                this.formula += "- ";
            }
            else
            {
                MessageBox.Show("Nuk mund te vendosni dy operatore njeri pas tjetrit ne formule!", "Konfigurimi i formules", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnPjesetim_Click(object sender, EventArgs e)
        {
            if (this.formula.Trim() == "")
                MessageBox.Show("Formula nuk mund te nise me nje operator!", "Konfigurimi i formules", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (last != "+" || last != "-" || last != "*" || last != "/" || last != ")" || last != "(")
            {
                this.txtFormula.Text += " / ";
                this.last = "/";
                this.formula += "/ ";
            }
            else
            {
                MessageBox.Show("Nuk mund te vendosni dy operatore njeri pas tjetrit ne formule!", "Konfigurimi i formules", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnShumezim_Click(object sender, EventArgs e)
        {
            if (this.formula.Trim() == "")
                MessageBox.Show("Formula nuk mund te nise me nje operator!", "Konfigurimi i formules", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (last != "+" || last != "-" || last != "*" || last != "/" || last != ")" || last != "(")
            {
                this.txtFormula.Text += " * ";
                this.last = "*";
                this.formula += "* ";
            }
            else
            {
                MessageBox.Show("Nuk mund te vendosni dy operatore njeri pas tjetrit ne formule!", "Konfigurimi i formules", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnKllHapese_Click(object sender, EventArgs e)
        {
            if (last != "+" || last != "-" || last != "*" || last != "/" || last != ")" || last != "(")
            {
                this.txtFormula.Text += " ( ";
                this.last = "(";
                this.formula += "( ";
            }
            else
            {
                MessageBox.Show("Nuk mund te vendosni dy operatore njeri pas tjetrit ne formule!", "Konfigurimi i formules", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnKllMbyllese_Click(object sender, EventArgs e)
        {
            if (last != "+" || last != "-" || last != "*" || last != "/" || last != ")" || last != "(")
            {
                this.txtFormula.Text += " ) ";
                this.last = ")";
                this.formula += ") ";
            }
            else
            {
                MessageBox.Show("Nuk mund te vendosni dy operatore njeri pas tjetrit ne formule!", "Konfigurimi i formules", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #endregion

        private bool KontrolloFormule()
        {
            string prove = this.txtFormula.Text;
            prove = prove.Trim();
            int i = prove.Split('(').Length;
            int j = prove.Split(')').Length;
            // Kontrollojme nese ka kllapa dhe nese jane vendosur sakte
            if (i != j)
            {
                return false;
            }
            for (i = 0; i < prove.Length - 1; i++)
            {
                if (prove[i] == '(' || prove[i] == ')' || prove[i] == '+' || prove[i] == '-' || prove[i] == '-' || prove[i] == '-')
                {
                    if (prove[i + 1] == '(' || prove[i + 1] == '(' || prove[i + 1] == ')' || prove[i + 1] == '+' || prove[i + 1] == '-' || prove[i + 1] == '-' || prove[i + 1] == '-')
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private void cmbVaresiPergj_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Nese zgjidhet produkti
            if (cmbVaresiPergj.SelectedIndex == 0)
            {
                #region Shtimi i rreshtave per produktin
                dtFormule.Rows.Clear();
                // Shtojme me rradhe 5 rreshta ne dtFormule per produktin
                DataRow drPrLart = this.dtFormule.NewRow();
                drPrLart["ID"] = 0;
                drPrLart["KOD_FORMULE"] = "PRLART";
                drPrLart["EMER"] = "Lartesi produkti";
                drPrLart["LLOJI"] = "PR";
                this.dtFormule.Rows.Add(drPrLart);
                //
                DataRow drPrGjer = this.dtFormule.NewRow();
                drPrGjer["ID"] = 0;
                drPrGjer["KOD_FORMULE"] = "PRGJER";
                drPrGjer["EMER"] = "Gjeresi produkti";
                drPrGjer["LLOJI"] = "PR";
                this.dtFormule.Rows.Add(drPrGjer);
                //
                DataRow drPrSip = this.dtFormule.NewRow();
                drPrSip["ID"] = 0;
                drPrSip["KOD_FORMULE"] = "PRSIP";
                drPrSip["EMER"] = "Siperfaqe";
                drPrSip["LLOJI"] = "PR";
                this.dtFormule.Rows.Add(drPrSip);
                //
                DataRow drPrCop = this.dtFormule.NewRow();
                drPrCop["ID"] = 0;
                drPrCop["KOD_FORMULE"] = "PRCOP";
                drPrCop["EMER"] = "Cope";
                drPrCop["LLOJI"] = "PR";
                this.dtFormule.Rows.Add(drPrCop);
                //
                DataRow drPrKan = this.dtFormule.NewRow();
                drPrKan["ID"] = 0;
                drPrKan["KOD_FORMULE"] = "PRKAN";
                drPrKan["EMER"] = "Kanate";
                drPrKan["LLOJI"] = "PR";
                this.dtFormule.Rows.Add(drPrKan);
                #endregion
            }
            // Nese zgjidhet alumini
            else if (cmbVaresiPergj.SelectedIndex == 1)
            {
                DataTable dtAlumin = this.produkteAksesoreTableAdapter.GetDataByAlumin(this.idProdukti);
                dtFormule.Rows.Clear();
                foreach (DataRow dr in dtAlumin.Rows)
                {
                    DataRow drFormule = this.dtFormule.NewRow();
                    drFormule["ID"] = dr["ID_AKSESORE_ALUMINI"];
                    drFormule["KOD_FORMULE"] = "AL_" + dr["ID_AKSESORE_ALUMINI"].ToString();
                    drFormule["EMER"] = dr["EMER_ALUMINI"] + " - " + dr["KOD_ALUMINI"];
                    drFormule["LLOJI"] = "AL";
                    dtFormule.Rows.Add(drFormule);
                }
            }
            // Nese zgjidhet xhami
            else if (cmbVaresiPergj.SelectedIndex == 2)
            {
                DataTable dtXhami = this.produkteAksesoreTableAdapter.GetDataByXham(this.idProdukti);
                dtFormule.Rows.Clear();
                foreach (DataRow dr in dtXhami.Rows)
                {
                    DataRow drFormule = this.dtFormule.NewRow();
                    drFormule["ID"] = dr["ID_AKSESORE_XHAMI"];
                    drFormule["KOD_FORMULE"] = "XH_" + dr["ID_AKSESORE_XHAMI"].ToString();
                    drFormule["EMER"] = dr["EMER_XHAMI"] + " - " + dr["KOD_XHAMI"];
                    drFormule["LLOJI"] = "XH";
                    dtFormule.Rows.Add(drFormule);
                }
            }
            // Nese zgjidhet aksesori
            else if (cmbVaresiPergj.SelectedIndex == 3)
            {
                DataTable dtAksesor = this.produkteAksesoreTableAdapter.GetDataByAksesor(this.idProdukti);
                dtFormule.Rows.Clear();
                foreach (DataRow dr in dtAksesor.Rows)
                {
                    DataRow drFormule = this.dtFormule.NewRow();
                    drFormule["ID"] = dr["ID_AKSESORE"];
                    drFormule["KOD_FORMULE"] = "AK_" + dr["ID_AKSESORE"].ToString();
                    drFormule["EMER"] = dr["EMER_AKSESORI"] + " - " + dr["KOD_AKSESORI"];
                    drFormule["LLOJI"] = "AK";
                    dtFormule.Rows.Add(drFormule);
                }
            }
            this.lbVaresia.DataSource = this.dtFormule;
            this.lbVaresia.DisplayMember = "EMER";
            this.lbVaresia.ValueMember = "KOD_FORMULE";
        }

        private void btnAnullo_Click(object sender, EventArgs e)
        {
            this.formula = "";
            this.Close();
        }

        private void lbVaresia_DoubleClick(object sender, EventArgs e)
        {
            if (this.last == "Emer")
            {
                MessageBox.Show("Nuk mund te vendosni dy emra aksesoresh njeri pas tjetrit ne formule!", "Formula", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (this.lbVaresia.DataSource == null)
                return;
            if (this.lbVaresia.Items.Count < 1)
                return;
            this.formula += this.lbVaresia.SelectedValue + " ";
            this.txtFormula.Text += " " + this.lbVaresia.Text;
            this.last = "Emer";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.last == "Emer")
            {
                MessageBox.Show("Nuk mund te vendosni dy vlera njera pas tjetres ne formule!", "Formula", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            this.txtFormula.Text += " " + this.numKoeficienti.Value;
            this.formula += this.numKoeficienti.Value + " ";
            this.last = "Emer";
        }

        private void FrmFormule_Load(object sender, EventArgs e)
        {
            string formuleTemp = "";
            lblFormula.Text = "";
            if (this.idAksesorProdukti == -1 || this.produktAksesoreTableAdapter.ScalarQueryByFormula(this.idAksesorProdukti) == null)
            {
                lblFormula.Text = "Per aksesorin nuk eshte ruajtur akoma nje formule";
                return;
            }
            formuleTemp = this.produktAksesoreTableAdapter.ScalarQueryByFormula(this.idAksesorProdukti).ToString();
            lblFormula.Text = FormuleAktuale(formuleTemp);
        }

        /// <summary>
        /// Kryen konvertimin e formules nga te koduar ne formule user friendly
        /// </summary>
        /// <param name="formuleTemp">Formula e koduar</param>
        /// <returns></returns>
        private string FormuleAktuale(string formuleTemp)
        {
            string expression = "";
            double kontrollVlere = 0;
            string[] str = formuleTemp.Split(' ');
            string[] vlera = str;
            for (int i = 0; i < str.Length; i++)
            {
                // Nese varesia eshte nga gjatesia e produktit
                if (str[i] == "PRGJER")
                {
                    expression += "GjeresiProdukti ";
                    vlera[i] = "GjeresiProdukti ";
                }
                // Nese varesia eshte nga lartesia e produktit
                else if (str[i] == "PRLART")
                {
                    expression += "LartesiProdukti ";
                    vlera[i] = "LartesiProdukti ";
                }
                // Nese varesia eshte nga numri i copeve te produktit
                else if (str[i] == "PRCOP")
                {
                    expression += "SasiProdukti ";
                    vlera[i] = "SasiProdukti ";;
                }
                // Nese varesia eshte nga siperfaqja e produktit
                else if (str[i] == "PRSIP")
                {
                    expression += "SiperfaqeProdukti ";
                    vlera[i] = "SiperfaqeProdukti ";
                }
                // Nese varesia eshte nga numri i kanatave
                else if (str[i] == "PRKAN")
                {
                    expression += "NumerKanatesh ";
                    vlera[i] = "NumerKanatesh ";
                }
                else if (str[i] == "(" || str[i] == ")" || str[i] == "*" || str[i] == "/" || str[i] == "+" || str[i] == "-")
                {
                    expression += str[i] + " ";
                }
                else if (double.TryParse(str[i], out kontrollVlere))
                {
                    expression += str[i] + " ";
                }
                // Nese varesia tani nuk eshte me nga produkti por nga aksesore te tjere
                else
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
                            expression += this.aluminProdukteAksesoreTableAdapter.ScalarQueryByIdAlumini(Convert.ToInt32(strPart[1])) + " ";
                        }
                        // Nese varesia eshte nga xhami
                        else if (strPart[0] == "XH")
                        {
                            expression += this.xhamProdukteAksesoreTableAdapter.ScalarQueryByIdXhami(Convert.ToInt32(strPart[1])) + " ";
                        }
                        // Nese varesia eshte nga aksesoret
                        else if (strPart[0] == "AK")
                        {
                            expression += this.aksesoreProdukteAksesoreTableAdapter1.ScalarQueryByIdAksesori(Convert.ToInt32(strPart[1])) + " ";
                        }
                        else
                        {
                            return "";
                        }
                    }
                    else
                    {
                        return expression;
                    }
                }
            }
            return expression;
        }

    }
}

