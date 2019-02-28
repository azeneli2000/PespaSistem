namespace PespaSistem
{
    partial class FrmPrintim
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.crystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.crFatura = new PespaSistem.CrFatura();
            this.SuspendLayout();
            // 
            // crystalReportViewer
            // 
            this.crystalReportViewer.ActiveViewIndex = 0;
            this.crystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer.Location = new System.Drawing.Point(0, 26);
            this.crystalReportViewer.Name = "crystalReportViewer";
            this.crystalReportViewer.ReportSource = this.crFatura;
            this.crystalReportViewer.Size = new System.Drawing.Size(964, 610);
            this.crystalReportViewer.TabIndex = 1;
            // 
            // FrmPrintim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(964, 636);
            this.ControlBox = true;
            this.Controls.Add(this.crystalReportViewer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPrintim";
            this.Text = "Vizualizim";
            this.Load += new System.EventHandler(this.FrmPrintim_Load);
            this.Controls.SetChildIndex(this.crystalReportViewer, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer;
        private CrFatura crFatura;

    }
}
