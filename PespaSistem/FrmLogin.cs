using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PespaSistem
{
    public partial class FrmLogin : PespaSistemLibrary.Form
    {
        /// <summary>
        /// Variabel privat qe mban emrin e perdoruesit. Sherben per propertine Perdorues
        /// </summary>
        private string perdoruesi;
        public static string emer;
        public static string fjalekalim;
        public static int rolID;
        public static int userId;

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (this.txtFjalekalim.Text.Trim() == "" || this.txtEmerPerdoruesi.Text.Trim() == "")
                return;
            bool sukses = FrmLogin.Logimi(this.txtEmerPerdoruesi.Text, this.txtFjalekalim.Text);
            if (!sukses)
            {
                MessageBox.Show("Emri i perdoruesit ose fjalekalimi i tij nuk eshte i sakte!", "Hyrja ne program",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtEmerPerdoruesi.Focus();
                FrmLogin.emer = this.txtEmerPerdoruesi.Text;
                FrmLogin.fjalekalim = this.txtFjalekalim.Text;
                return;
            }
            else
            {
                FrmLogin.emer = this.txtEmerPerdoruesi.Text;
                FrmLogin.fjalekalim = this.txtFjalekalim.Text;
            }
            this.Close();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            this.AutoScroll = false;
            this.perdoruesTableAdapter.Fill(this.dsPerdorues.PERDORUES);
            this.rolePerdoruesTableAdapter.Fill(this.dsPerdorues.ROLE_PERDORUES);
        }

        private void btnAnullo_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public static void ShowForm()
        {
            FrmLogin login = new FrmLogin();
            login.ShowDialog();
        }

        public static bool KontrolloPerdoruesit()
        {
            try
            {
                FrmLogin login = new FrmLogin();
                login.perdoruesTableAdapter.Fill(login.dsPerdorues.PERDORUES);
                if (login.dsPerdorues.PERDORUES.Rows.Count > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nje gabim ndodhi gjate lidhjes me bazen e te dhenave", "Logimi i perdoruesve", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


        public static bool Logimi(string emri, string fjalekalimi)
        {
            FrmLogin login = new FrmLogin();
            login.perdoruesTableAdapter.Fill(login.dsPerdorues.PERDORUES);
            login.rolePerdoruesTableAdapter.Fill(login.dsPerdorues.ROLE_PERDORUES);
            if (login.dsPerdorues.PERDORUES.Select("USERNAME = '" + emri + "' AND PASSWORD = '" + fjalekalimi + "'").Length > 0)
            {
                DataRow dr1 = (DataRow)login.dsPerdorues.PERDORUES.Select("USERNAME = '" + emri + "' AND PASSWORD = '" + fjalekalimi + "'").GetValue(0);
                FrmLogin.rolID = Convert.ToInt32(dr1[3]);
                FrmLogin.userId = Convert.ToInt32(dr1[0]);
                //FrmLogin.rolID = Convert.ToInt32(login.dsPerdorues.ROLE_PERDORUES.Rows[0][3]);
                //FrmLogin.userId = Convert.ToInt32(login.dsPerdorues.PERDORUES.Rows[0][0]);
                return true;
            }
            else
                return false;
        }

        #region Public Properties
        public string Perdoruesi
        {
            get
            {
                return perdoruesi;
            }
        }


        #endregion

        private void txtEmerPerdoruesi_Validated(object sender, EventArgs e)
        {
            if (this.txtEmerPerdoruesi.Text.Trim() != "")
                this.errorProvider.SetError(this.txtEmerPerdoruesi, "");
            else
            {
                this.errorProvider.SetError(this.txtEmerPerdoruesi, "Emri i perdoruesit nuk mund te jete bosh");
            }
        }

        private void txtEmerPerdoruesi_TextChanged(object sender, EventArgs e)
        {
            this.errorProvider.SetError(this.btnOK, "");
        }

        private void txtFjalekalim_Validated(object sender, EventArgs e)
        {
            if (this.txtFjalekalim.Text.Trim() != "")
                this.errorProvider.SetError(this.txtFjalekalim, "");
            else
                this.errorProvider.SetError(this.txtFjalekalim, "Fjalekalimi nuk mund te jete bosh");
        }
    }
}

