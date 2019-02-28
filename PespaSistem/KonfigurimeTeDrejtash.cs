using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PespaSistem
{
    public partial class KonfigurimeTeDrejtash : PespaSistemLibrary.Form
    {
        /// <summary>
        /// Variabel privat boolean qe percakton nese jane ndryshuar te drejtat per perdoruesit
        /// </summary>
        private bool kaNdryshime = false;
        private DataSet dsEmerRolet = new DataSet();
        public KonfigurimeTeDrejtash()
        {
            InitializeComponent();
        }

        private void btnRuaj_Click(object sender, EventArgs e)
        {
            // Nese nuk jane ndryshuar te drejtat atehere dil nga metoda
            bool uGjet = false;
            if (this.kaNdryshime == false)
                return;
            DialogResult res;
            res = MessageBox.Show("Jeni te sigurte qe doni te modifikoni te drejtat e perdoruesve?", "Te drejtat e perdoruesve", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res != DialogResult.Yes)
            {
                return;
            }
            // Hedhim te dhenat qe jane aktualisht ne baze te dhenash ne nje dataset ne menyre qe te
            // kontrollojme ndryshimet ndermjet tabelave
            DataTable dtBaza = new DataTable();
            int idRoli = 0;
            int idDrejtat = 0;
            if (this.cmbRolet.SelectedIndex == 0)
                dtBaza = this.roleDrejtatTableAdapter.GetDataByIdRoli(2);
            else if (this.cmbRolet.SelectedIndex == 1)
                dtBaza = this.roleDrejtatTableAdapter.GetDataByIdRoli(3);
            for (int i = 0; i < dtBaza.Rows.Count; i++)
            {
                DataRow dr = dtBaza.Rows[i];
                foreach (DataRow drDs in this.dsEmerRolet.Tables[0].Rows)
                {
                    if (Convert.ToInt32(dr["ID_ROLI"]) == Convert.ToInt32(drDs["ID_ROLI"]) && Convert.ToInt32(dr["ID_DREJTAT"]) == Convert.ToInt32(drDs["ID_DREJTAT"]))
                    {
                        uGjet = true;
                    }
                }
                idRoli = (Int32)dr["ID_ROLI"];
                idDrejtat = (Int32)dr["ID_DREJTAT"];
                // Nese nuk gjendet ky rresht ne dataset atehere duhet te fshihet nga baza
                if (!uGjet)
                {
                    this.roleDrejtatTableAdapter.DeleteQueryByIdRoliIdDrejtat(idRoli, idDrejtat);
                    dtBaza.Rows.Remove(dr);
                }
                uGjet = false;
            }
            uGjet = false;
            for (int i = 0; i < dsEmerRolet.Tables[0].Rows.Count; i++)
            {
                DataRow drDs = dsEmerRolet.Tables[0].Rows[i];
                foreach (DataRow dr in dtBaza.Rows)
                {
                    if (Convert.ToInt32(drDs["ID_ROLI"]) == Convert.ToInt32(dr["ID_ROLI"]) && Convert.ToInt32(drDs["ID_DREJTAT"]) == Convert.ToInt32(dr["ID_DREJTAT"]))
                    {
                        uGjet = true;
                    }
                }
                // Nese nuk gjendet ky rresht ne databaze atehere duhet te shtohet ne databaze
                if (!uGjet)
                {
                    this.roleDrejtatTableAdapter.Insert((Int32)drDs["ID_ROLI"], (Int32)drDs["ID_DREJTAT"]);
                    DataRow drNew = dtBaza.NewRow();
                    drNew["ID_ROLI"] = drDs["ID_ROLI"];
                    drNew["ID_DREJTAT"] = drDs["ID_DREJTAT"];
                    dtBaza.Rows.Add(drNew);
                }
                uGjet = false;
            }
            MessageBox.Show("Te drejtat e perdoruesve u ruajten me sukses!", "Konfigurimi i te drejtave", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnKaloDjathtas_Click(object sender, EventArgs e)
        {
            // Ne fillim kontrollojme nese eshte zgjedhur ndonje rol
            if (this.cmbRolet.SelectedIndex < 0)
                return;
            // Kontrollojme nese e drejta e mundshme ekziston tashme per kete rol 
            int idDrejta = Convert.ToInt32(this.lbDrejtaMundshme.SelectedValue);
            if (this.dsEmerRolet.Tables[0].Select("ID_DREJTAT = " + idDrejta).Length > 0)
            {
                return;
            }
            this.kaNdryshime = true;
            DataRow dr = this.dsEmerRolet.Tables[0].NewRow();
            if (this.cmbRolet.SelectedIndex == 0)
                dr["ID_ROLI"] = 2;
            else if (this.cmbRolet.SelectedIndex == 1)
                dr["ID_ROLI"] = 3;
            dr["ID_DREJTAT"] = Convert.ToInt32(this.lbDrejtaMundshme.SelectedValue);
            dr["EMER_DREJTA"] = this.lbDrejtaMundshme.Text;
            this.dsEmerRolet.Tables[0].Rows.Add(dr);
        }

        private void btnKaloMajtas_Click(object sender, EventArgs e)
        {
            // Ne fillim kontrollojme nese eshte zgjedhur ndonje rol
            if (this.cmbRolet.SelectedIndex < 0)
                return;
            this.kaNdryshime = true;
            this.dsEmerRolet.Tables[0].Rows.RemoveAt(this.lbDrejta.SelectedIndex);
        }

        private void KonfigurimeTeDrejtash_Load(object sender, EventArgs e)
        {
            this.teDrejtatTableAdapter.Fill(this.dsRoleDrejtat.TE_DREJTAT);
            this.roleDrejtatTableAdapter.Fill(this.dsRoleDrejtat.ROLE_DREJTAT);
            this.rolePerdoruesTableAdapter.Fill(this.dsRoleDrejtat.ROLE_PERDORUES);
            // Mbushim datasetin dsEmerRolet i cili do te sherbeje per te mbushur lbDrejtaMundshme
            // me te dhenat e duhura.
            DataTable dt = new DataTable("TE_DREJTAT");
            
            dt.Columns.Add("ID_ROLE_DREJTAT", typeof(Int32));
            dt.Columns.Add("ID_ROLI", typeof(Int32));
            dt.Columns.Add("ID_DREJTAT", typeof(Int32));
            dt.Columns.Add("EMER_DREJTA", typeof(String));
            this.dsEmerRolet.Tables.Add(dt);
            //this.dsEmerRolet = this.dsRoleDrejtat.Copy();
            //this.dsEmerRolet.Tables["ROLE_DREJTAT"].Columns.Add("EMER_DREJTA", typeof(String));
            this.lbDrejta.DataSource = this.dsEmerRolet.Tables[0];
            this.lbDrejta.DisplayMember = "EMER_DREJTA";
            this.lbDrejta.ValueMember = "ID_DREJTAT";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.dsEmerRolet.Tables[0].Rows.Clear();
            if (this.cmbRolet.SelectedIndex == 0)
            {
                DataTable dt1 = this.roleDrejtatTableAdapter.GetDataByIdRoli(2);
                foreach (DataRow dr in dt1.Rows)
                {
                    DataRow dr1 = this.dsEmerRolet.Tables[0].NewRow();
                    dr1["ID_ROLE_DREJTAT"] = dr["ID_ROLE_DREJTAT"];
                    dr1["ID_ROLI"] = dr["ID_ROLI"];
                    dr1["ID_DREJTAT"] = dr["ID_DREJTAT"];
                    dr1["EMER_DREJTA"] = dr["EMER_DREJTA"];
                    this.dsEmerRolet.Tables[0].Rows.Add(dr1);
                }
            }
            else
            {
                DataTable dt1 = this.roleDrejtatTableAdapter.GetDataByIdRoli(3);
                foreach (DataRow dr in dt1.Rows)
                {
                    DataRow dr1 = this.dsEmerRolet.Tables[0].NewRow();
                    dr1["ID_ROLE_DREJTAT"] = dr["ID_ROLE_DREJTAT"];
                    dr1["ID_ROLI"] = dr["ID_ROLI"];
                    dr1["ID_DREJTAT"] = dr["ID_DREJTAT"];
                    dr1["EMER_DREJTA"] = dr["EMER_DREJTA"];
                    this.dsEmerRolet.Tables[0].Rows.Add(dr1);
                }
            }
        }
    }
}

