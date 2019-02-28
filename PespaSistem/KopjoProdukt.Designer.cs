namespace PespaSistem
{
    partial class KopjoProdukt
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
            this.components = new System.ComponentModel.Container();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.btnAnullo = new PespaSistemLibrary.Button(this.components);
            this.btnRuaj = new PespaSistemLibrary.Button(this.components);
            this.gbKopjoProdukt = new Janus.Windows.EditControls.UIGroupBox();
            this.lbProdukte = new System.Windows.Forms.ListBox();
            this.dsProdukteTotal = new PespaSistem.DsProdukteTotal();
            this.produkteTotalTableAdapter = new PespaSistem.DsProdukteTotalTableAdapters.PRODUKTE_TOTALTableAdapter();
            this.produktAksesoreTableAdapter = new PespaSistem.DsProdukteTotalTableAdapters.PRODUKT_AKSESORETableAdapter();
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbKopjoProdukt)).BeginInit();
            this.gbKopjoProdukt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsProdukteTotal)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.Controls.Add(this.btnAnullo);
            this.panelEx1.Controls.Add(this.btnRuaj);
            this.panelEx1.Controls.Add(this.gbKopjoProdukt);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 26);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(640, 614);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.panelEx1.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 3;
            // 
            // btnAnullo
            // 
            this.btnAnullo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnullo.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnullo.Location = new System.Drawing.Point(367, 147);
            this.btnAnullo.Name = "btnAnullo";
            this.btnAnullo.Size = new System.Drawing.Size(75, 24);
            this.btnAnullo.TabIndex = 6;
            this.btnAnullo.TeDrejta = PespaSistemLibrary.Button.teDrejta.all;
            this.btnAnullo.Text = "Anullo";
            this.btnAnullo.Click += new System.EventHandler(this.btnAnullo_Click);
            // 
            // btnRuaj
            // 
            this.btnRuaj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRuaj.Location = new System.Drawing.Point(367, 108);
            this.btnRuaj.Name = "btnRuaj";
            this.btnRuaj.Size = new System.Drawing.Size(75, 24);
            this.btnRuaj.TabIndex = 5;
            this.btnRuaj.TeDrejta = PespaSistemLibrary.Button.teDrejta.all;
            this.btnRuaj.Text = "Ruaj";
            this.btnRuaj.Click += new System.EventHandler(this.btnRuaj_Click);
            // 
            // gbKopjoProdukt
            // 
            this.gbKopjoProdukt.Controls.Add(this.lbProdukte);
            this.gbKopjoProdukt.FrameStyle = Janus.Windows.EditControls.FrameStyle.Top;
            this.gbKopjoProdukt.Location = new System.Drawing.Point(56, 42);
            this.gbKopjoProdukt.Name = "gbKopjoProdukt";
            this.gbKopjoProdukt.Size = new System.Drawing.Size(257, 223);
            this.gbKopjoProdukt.TabIndex = 0;
            this.gbKopjoProdukt.Text = "Kopjo produktin";
            this.gbKopjoProdukt.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
            // 
            // lbProdukte
            // 
            this.lbProdukte.DataSource = this.dsProdukteTotal;
            this.lbProdukte.DisplayMember = "PRODUKTE_TOTAL.EMER_GJATE";
            this.lbProdukte.FormattingEnabled = true;
            this.lbProdukte.Location = new System.Drawing.Point(18, 26);
            this.lbProdukte.Name = "lbProdukte";
            this.lbProdukte.Size = new System.Drawing.Size(225, 173);
            this.lbProdukte.TabIndex = 0;
            this.lbProdukte.ValueMember = "PRODUKTE_TOTAL.ID_PRODUKTI";
            // 
            // dsProdukteTotal
            // 
            this.dsProdukteTotal.DataSetName = "DsProdukteTotal";
            this.dsProdukteTotal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // produkteTotalTableAdapter
            // 
            this.produkteTotalTableAdapter.ClearBeforeFill = true;
            // 
            // produktAksesoreTableAdapter
            // 
            this.produktAksesoreTableAdapter.ClearBeforeFill = true;
            // 
            // KopjoProdukt
            // 
            this.AcceptButton = this.btnRuaj;
            this.AutoScroll = false;
            this.CancelButton = this.btnAnullo;
            this.ClientSize = new System.Drawing.Size(591, 341);
            this.ControlBox = true;
            this.Controls.Add(this.panelEx1);
            this.Name = "KopjoProdukt";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Kopjimi i produkteve";
            this.Load += new System.EventHandler(this.KopjoProdukt_Load);
            this.Controls.SetChildIndex(this.panelEx1, 0);
            this.panelEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gbKopjoProdukt)).EndInit();
            this.gbKopjoProdukt.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsProdukteTotal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private PespaSistemLibrary.Button btnRuaj;
        private Janus.Windows.EditControls.UIGroupBox gbKopjoProdukt;
        private PespaSistemLibrary.Button btnAnullo;
        private DsProdukteTotal dsProdukteTotal;
        private PespaSistem.DsProdukteTotalTableAdapters.PRODUKTE_TOTALTableAdapter produkteTotalTableAdapter;
        private System.Windows.Forms.ListBox lbProdukte;
        private PespaSistem.DsProdukteTotalTableAdapters.PRODUKT_AKSESORETableAdapter produktAksesoreTableAdapter;
    }
}
