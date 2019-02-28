using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PespaSistem
{
    public partial class FrmShtoProdukt : PespaSistemLibrary.Form
    {
        private DataTable dt;
        private int idProdukti = 0;
        public FrmShtoProdukt()
        {
            InitializeComponent();
        }

        private void btnShto_Click(object sender, EventArgs e)
        {
            if (this.txtProdukti.Text.Trim() == "")
            {
                MessageBox.Show("Duhet qe te jepni nje emer per produktin qe do te shtoni!",
                    "Shtimi i produkteve", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (this.lbLlojSistemesh.SelectedItems.Count < 1)
            {
                MessageBox.Show("Duhet te zgjidhni te pakten nje nga llojet e sistemeve per te vazhduar!",
                    "Shtimi i produkteve", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            foreach (System.Data.DataRowView dr in this.lbLlojSistemesh.SelectedItems)
            {
                this.produkteTableAdapter.Insert(this.txtProdukti.Text, Convert.ToInt32(this.cmbLlojProduktesh.SelectedValue), Convert.ToInt32(dr[0]));
            }
            MessageBox.Show("Produktet u shtuan me sukses", "Shtimi i produkteve", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.txtProdukti.Text = "";
            this.idProdukti = 0;
            dt.Clear();
            this.dsLlojeProduktesh.Clear();
            dt = this.produkteTableAdapter.GetDataProduktet();
            this.dgProdukte.DataSource = dt;
            this.produkteTableAdapter.Fill(this.dsLlojeProduktesh.PRODUKTE);
            this.llojProduktiTableAdapter.Fill(this.dsLlojeProduktesh.LLOJ_PRODUKTI);
            this.llojSistemiTableAdapter.Fill(this.dsLlojeProduktesh.LLOJ_SISTEMI);
            RregulloGride();
        }

        private void FrmShtoProdukt_Load(object sender, EventArgs e)
        {
            try
            {
                dt = this.produkteTableAdapter.GetDataProduktet();
                this.dgProdukte.DataSource = dt;
                this.produkteTableAdapter.Fill(this.dsLlojeProduktesh.PRODUKTE);
                this.llojProduktiTableAdapter.Fill(this.dsLlojeProduktesh.LLOJ_PRODUKTI);
                this.llojSistemiTableAdapter.Fill(this.dsLlojeProduktesh.LLOJ_SISTEMI);
                RregulloGride();
            }
            catch (Exception ex)
            {
                return;
            }
       }

        private void RregulloGride()
        {
            this.dgProdukte.Columns.Clear();
            //
            DataGridViewTextBoxColumn colID = new DataGridViewTextBoxColumn();
            colID.HeaderText = "ID";
            colID.Width = 70;
            colID.ValueType = typeof(Int32);
            colID.DataPropertyName = "ID_PRODUKTI";
            colID.Visible = false;
            this.dgProdukte.Columns.Add(colID);
            //
            DataGridViewTextBoxColumn colEmri = new DataGridViewTextBoxColumn();
            colEmri.HeaderText = "Produkti";
            colEmri.Width = 160;
            colEmri.ValueType = typeof(String);
            colEmri.DataPropertyName = "EMER_PRODUKTI";
            this.dgProdukte.Columns.Add(colEmri);
            //
            DataGridViewTextBoxColumn colLloji = new DataGridViewTextBoxColumn();
            colLloji.HeaderText = "Lloji i produktit";
            colLloji.Width = 150;
            colLloji.ValueType = typeof(String);
            colLloji.DataPropertyName = "EMER_LLOJI";
            this.dgProdukte.Columns.Add(colLloji);
            //
            DataGridViewTextBoxColumn colSistemi = new DataGridViewTextBoxColumn();
            colSistemi.HeaderText = "Lloji i sistemit";
            colSistemi.Width = 120;
            colSistemi.ValueType = typeof(String);
            colSistemi.DataPropertyName = "LLOJ_SISTEMI";
            this.dgProdukte.Columns.Add(colSistemi);

            this.dgProdukte.Columns[0].Visible = false;
        }

        private void dgProdukte_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            idProdukti = Convert.ToInt32(this.dgProdukte[0, e.RowIndex].Value);
            this.txtProdukti.Text = this.dgProdukte[1, e.RowIndex].Value.ToString();
        }

        private void btnModifiko_Click(object sender, EventArgs e)
        {
            if (this.idProdukti == 0)
            {
                MessageBox.Show("Me pare duhet te zgjidhni produktin qe doni te modifikoni!",
                    "Modifikimi i produkteve", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            this.produkteTableAdapter.UpdateQuery(this.txtProdukti.Text, this.idProdukti);
            MessageBox.Show("Produkti u modifikua me sukses!",
                "Modifikimi i produkteve", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

