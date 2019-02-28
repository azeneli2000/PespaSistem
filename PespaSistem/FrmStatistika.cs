using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using System.Drawing.Printing;

namespace PespaSistem
{
    public partial class FrmStatistika : PespaSistemLibrary.Form
    {
        public FrmStatistika()
        {
            InitializeComponent();
        }
        private DataTable dtStatistikaDg;

        private void rbFatureDetajuar_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnKerko_Click(object sender, EventArgs e)
        {
            if (this.rbData.Checked)
            {
                this.projekteTableAdapter.FillByDataProjekti(this.dsPespaSistem.PROJEKTE, this.dtpDateFillimi.Value,
                    this.dtpDateMbarimi.Value);
            }
            else if (this.rbEmerProjekti.Checked)
            {
                this.projekteTableAdapter.FillByEmerProjekti(this.dsPespaSistem.PROJEKTE, this.txtEmerProjekti.Text);
            }
            else
                return;
            this.MbushDtStatistikaDg();
            this.RregulloDgStatistikat();
        }

        private void FrmStatistika_Load(object sender, EventArgs e)
        {
            this.projekteTableAdapter.Fill(this.dsPespaSistem.PROJEKTE);
            this.dtStatistikaDg = this.dsPespaSistem.PROJEKTE;
            this.dtStatistikaDg.Columns.Add("DIFERENCA", typeof(Int32));
            this.MbushDtStatistikaDg();
            this.RregulloDgStatistikat();
        }

        private void MbushDtStatistikaDg()
        {
            foreach (DataRow dr in this.dtStatistikaDg.Rows)
            {
                if (Convert.IsDBNull(dr["VLERA_REALE"]) || Convert.IsDBNull(dr["PREVENTIVI"])
                    || dr["VLERA_REALE"] == null || dr["PREVENTIVI"] == null)
                {
                    dr["DIFERENCA"] = Convert.DBNull;
                }
                else
                {
                    dr["DIFERENCA"] = Convert.ToInt32(dr["PREVENTIVI"]) - Convert.ToInt32(dr["VLERA_REALE"]);
                }
            }
            dtStatistikaDg.AcceptChanges();
            this.dgStatistikat.DataSource = dtStatistikaDg;
        }

        private void RregulloDgStatistikat()
        {
            this.dgStatistikat.Columns.Clear();

            DataGridViewTextBoxColumn colID_PROJEKTI = new DataGridViewTextBoxColumn();
            colID_PROJEKTI.ReadOnly = true;
            colID_PROJEKTI.DataPropertyName = "ID_PROJEKTI";
            colID_PROJEKTI.HeaderText = "ID_PROJEKTI";
            colID_PROJEKTI.Width = 100;
            dgStatistikat.Columns.Add(colID_PROJEKTI);
            colID_PROJEKTI.Visible = false;

            DataGridViewTextBoxColumn colEMER_PROJEKTI = new DataGridViewTextBoxColumn();
            colEMER_PROJEKTI.ReadOnly = true;
            colEMER_PROJEKTI.DataPropertyName = "EMER_PROJEKTI";
            colEMER_PROJEKTI.HeaderText = "Emri i projektit";
            colEMER_PROJEKTI.Width = 180;
            colEMER_PROJEKTI.Visible = true;
            dgStatistikat.Columns.Add(colEMER_PROJEKTI);

            DataGridViewTextBoxColumn colDATA_PROJEKTI = new DataGridViewTextBoxColumn();
            colDATA_PROJEKTI.ReadOnly = true;
            colDATA_PROJEKTI.DataPropertyName = "DATA_PROJEKTI";
            colDATA_PROJEKTI.HeaderText = "Data";
            colDATA_PROJEKTI.Width = 145;
            colDATA_PROJEKTI.Visible = true;
            dgStatistikat.Columns.Add(colDATA_PROJEKTI);

            DataGridViewTextBoxColumn colPREVENTIVI = new DataGridViewTextBoxColumn();
            colPREVENTIVI.ReadOnly = true;
            colPREVENTIVI.DataPropertyName = "PREVENTIVI";
            colPREVENTIVI.HeaderText = "Preventivi";
            colPREVENTIVI.Width = 98;
            colPREVENTIVI.Visible = true;
            dgStatistikat.Columns.Add(colPREVENTIVI);

            DataGridViewTextBoxColumn colVLERA_REALE = new DataGridViewTextBoxColumn();
            colVLERA_REALE.ReadOnly = true;
            colVLERA_REALE.DataPropertyName = "VLERA_REALE";
            colVLERA_REALE.HeaderText = "Vlera reale";
            colVLERA_REALE.Width = 98;
            colVLERA_REALE.Visible = true;
            dgStatistikat.Columns.Add(colVLERA_REALE);

            DataGridViewTextBoxColumn colDIFERENCA = new DataGridViewTextBoxColumn();
            colDIFERENCA.ReadOnly = true;
            colDIFERENCA.DataPropertyName = "DIFERENCA";
            colDIFERENCA.HeaderText = "Diferenca";
            colDIFERENCA.Width = 98;
            colDIFERENCA.Visible = true;
            dgStatistikat.Columns.Add(colDIFERENCA);

            //dgStatistikat.Columns.Add({colID_PROJEKTI, colEMER_PROJEKTI, colDATA_PROJEKTI, colPREVENTIVI, colVLERA_REALE, ColDiferenca});

        }

        private void btnPrinto_Click(object sender, EventArgs e)
        {
            CrProjekte crStatistika = new CrProjekte();
            PrintDocument pDoc = new PrintDocument();
            string printerName = "";
            short printCopies = 1;
            pDoc.DocumentName = "Statistikat";
            printDialog.Document = pDoc;
            if (printDialog.ShowDialog() != DialogResult.OK)
                return;
            printerName = printDialog.PrinterSettings.PrinterName;
            printCopies = printDialog.PrinterSettings.Copies;
            crStatistika.SetDataSource(dsPespaSistem);
            crStatistika.PrintOptions.PrinterName = printerName;
            crStatistika.PrintToPrinter(printCopies, true, 0, 0);
        }
    }
}

