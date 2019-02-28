using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PespaSistem
{
    public partial class KopjoProdukt : PespaSistemLibrary.Form
    {
        public bool anulluar = true;
        public string emerProdukti = "";
        public int idProdukti = 0;
        public KopjoProdukt()
        {
            InitializeComponent();
            
        }

        private void btnAnullo_Click(object sender, EventArgs e)
        {
            anulluar = true;
        }

        private void btnRuaj_Click(object sender, EventArgs e)
        {
            int idProduktiRi = 0;
            int idAksesori = 0;
            if (this.lbProdukte.SelectedItems.Count < 1)
            {
                MessageBox.Show("Nuk keni zgjedhur asnje produkt tek i cili te kopjoni te dhenat e produktit", "Kopjimi produkteve", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
           }
            this.produktAksesoreTableAdapter.FillByIdProdukti(this.dsProdukteTotal.PRODUKT_AKSESORE, this.idProdukti);
            foreach (System.Data.DataRowView dr in this.lbProdukte.SelectedItems)
            {
                foreach (DataRow drProdAksesore in this.dsProdukteTotal.PRODUKT_AKSESORE.Rows)
                {
                    idProduktiRi = Convert.ToInt32(dr["ID_PRODUKTI"]);
                    if (!Convert.IsDBNull(drProdAksesore["ID_AKSESORE_ALUMINI"]))
                    {
                        idAksesori = Convert.ToInt32(drProdAksesore["ID_AKSESORE_ALUMINI"]);
                        this.produktAksesoreTableAdapter.Insert(idProduktiRi, idAksesori, null, null, drProdAksesore["FORMULA"].ToString());
                    }
                    else if (!Convert.IsDBNull(drProdAksesore["ID_AKSESORE_XHAMI"]))
                    {
                        idAksesori = Convert.ToInt32(drProdAksesore["ID_AKSESORE_XHAMI"]);
                        this.produktAksesoreTableAdapter.Insert(idProduktiRi, null, idAksesori, null, drProdAksesore["FORMULA"].ToString());
                    }
                    else if (!Convert.IsDBNull(drProdAksesore["ID_AKSESORE"]))
                    {
                        idAksesori = Convert.ToInt32(drProdAksesore["ID_AKSESORE"]);
                        this.produktAksesoreTableAdapter.Insert(idProduktiRi, null, null, idAksesori, drProdAksesore["FORMULA"].ToString());
                    }
                }
            }
            this.Close();
        }

        private void KopjoProdukt_Load(object sender, EventArgs e)
        {
            this.produkteTotalTableAdapter.Fill(dsProdukteTotal.PRODUKTE_TOTAL, idProdukti);
        }
    }
}

