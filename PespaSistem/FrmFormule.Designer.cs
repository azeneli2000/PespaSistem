namespace PespaSistem
{
    partial class FrmFormule
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
            Janus.Windows.EditControls.UIComboBoxItem uiComboBoxItem1 = new Janus.Windows.EditControls.UIComboBoxItem();
            Janus.Windows.EditControls.UIComboBoxItem uiComboBoxItem2 = new Janus.Windows.EditControls.UIComboBoxItem();
            Janus.Windows.EditControls.UIComboBoxItem uiComboBoxItem3 = new Janus.Windows.EditControls.UIComboBoxItem();
            Janus.Windows.EditControls.UIComboBoxItem uiComboBoxItem4 = new Janus.Windows.EditControls.UIComboBoxItem();
            System.Drawing.StringFormat stringFormat1 = new System.Drawing.StringFormat();
            this.btnRuaj = new PespaSistemLibrary.Button(this.components);
            this.numKoeficienti = new System.Windows.Forms.NumericUpDown();
            this.btnPlus = new DevComponents.DotNetBar.ButtonX();
            this.btnMinus = new DevComponents.DotNetBar.ButtonX();
            this.btnPjesetim = new DevComponents.DotNetBar.ButtonX();
            this.btnShumezim = new DevComponents.DotNetBar.ButtonX();
            this.gbOperatore = new Janus.Windows.EditControls.UIGroupBox();
            this.btnKllMbyllese = new DevComponents.DotNetBar.ButtonX();
            this.btnKllHapese = new DevComponents.DotNetBar.ButtonX();
            this.cmbVaresiPergj = new Janus.Windows.EditControls.UIComboBox();
            this.lbVaresia = new System.Windows.Forms.ListBox();
            this.gbVaresia = new Janus.Windows.EditControls.UIGroupBox();
            this.gbVeprime = new Janus.Windows.EditControls.UIGroupBox();
            this.lblFormula = new System.Windows.Forms.Label();
            this.uiGroupBox1 = new Janus.Windows.EditControls.UIGroupBox();
            this.button1 = new PespaSistemLibrary.Button(this.components);
            this.txtFormula = new System.Windows.Forms.TextBox();
            this.btnAnullo = new PespaSistemLibrary.Button(this.components);
            this.dsProduktetAksesoret = new PespaSistem.DsProduktetAksesoret();
            this.aksesoreProdukteAksesoreTableAdapter1 = new PespaSistem.DsProduktetAksesoretTableAdapters.AksesoreProdukteAksesoreTableAdapter();
            this.aluminProdukteAksesoreTableAdapter = new PespaSistem.DsProduktetAksesoretTableAdapters.AluminProdukteAksesoreTableAdapter();
            this.produkteAksesoreTableAdapter = new PespaSistem.DsProduktetAksesoretTableAdapters.ProdukteAksesoreTableAdapter();
            this.produkteProdukteAksesoreTableAdapter = new PespaSistem.DsProduktetAksesoretTableAdapters.ProdukteProdukteAksesoreTableAdapter();
            this.xhamProdukteAksesoreTableAdapter = new PespaSistem.DsProduktetAksesoretTableAdapters.XhamProdukteAksesoreTableAdapter();
            this.dsProduktAksesore = new PespaSistem.DsProduktAksesore();
            this.produktAksesoreTableAdapter = new PespaSistem.DsProduktAksesoreTableAdapters.PRODUKT_AKSESORETableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.numKoeficienti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbOperatore)).BeginInit();
            this.gbOperatore.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbVaresia)).BeginInit();
            this.gbVaresia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbVeprime)).BeginInit();
            this.gbVeprime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox1)).BeginInit();
            this.uiGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsProduktetAksesoret)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProduktAksesore)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRuaj
            // 
            this.btnRuaj.Location = new System.Drawing.Point(173, 353);
            this.btnRuaj.Name = "btnRuaj";
            this.btnRuaj.Size = new System.Drawing.Size(75, 23);
            this.btnRuaj.TabIndex = 41;
            this.btnRuaj.TeDrejta = PespaSistemLibrary.Button.teDrejta.administrator;
            this.btnRuaj.Text = "Ruaj";
            this.btnRuaj.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // numKoeficienti
            // 
            this.numKoeficienti.DecimalPlaces = 3;
            this.numKoeficienti.Location = new System.Drawing.Point(46, 21);
            this.numKoeficienti.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numKoeficienti.Name = "numKoeficienti";
            this.numKoeficienti.Size = new System.Drawing.Size(96, 20);
            this.numKoeficienti.TabIndex = 42;
            // 
            // btnPlus
            // 
            this.btnPlus.ColorScheme.DockSiteBackColorGradientAngle = 0;
            this.btnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlus.Location = new System.Drawing.Point(21, 28);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(37, 37);
            this.btnPlus.TabIndex = 43;
            this.btnPlus.Text = "+";
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.ColorScheme.DockSiteBackColorGradientAngle = 0;
            this.btnMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinus.Location = new System.Drawing.Point(79, 28);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(37, 37);
            this.btnMinus.TabIndex = 44;
            this.btnMinus.Text = "-";
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnPjesetim
            // 
            this.btnPjesetim.ColorScheme.DockSiteBackColorGradientAngle = 0;
            this.btnPjesetim.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPjesetim.Location = new System.Drawing.Point(80, 87);
            this.btnPjesetim.Name = "btnPjesetim";
            this.btnPjesetim.Size = new System.Drawing.Size(37, 37);
            this.btnPjesetim.TabIndex = 45;
            this.btnPjesetim.Text = "/";
            this.btnPjesetim.Click += new System.EventHandler(this.btnPjesetim_Click);
            // 
            // btnShumezim
            // 
            this.btnShumezim.ColorScheme.DockSiteBackColorGradientAngle = 0;
            this.btnShumezim.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShumezim.Location = new System.Drawing.Point(21, 87);
            this.btnShumezim.Name = "btnShumezim";
            this.btnShumezim.Size = new System.Drawing.Size(37, 37);
            this.btnShumezim.TabIndex = 46;
            this.btnShumezim.Text = "*";
            this.btnShumezim.Click += new System.EventHandler(this.btnShumezim_Click);
            // 
            // gbOperatore
            // 
            this.gbOperatore.Controls.Add(this.btnKllMbyllese);
            this.gbOperatore.Controls.Add(this.btnKllHapese);
            this.gbOperatore.Controls.Add(this.btnPlus);
            this.gbOperatore.Controls.Add(this.btnShumezim);
            this.gbOperatore.Controls.Add(this.btnMinus);
            this.gbOperatore.Controls.Add(this.btnPjesetim);
            this.gbOperatore.FrameStyle = Janus.Windows.EditControls.FrameStyle.Top;
            this.gbOperatore.Location = new System.Drawing.Point(278, 17);
            this.gbOperatore.Name = "gbOperatore";
            this.gbOperatore.Size = new System.Drawing.Size(184, 131);
            this.gbOperatore.TabIndex = 47;
            this.gbOperatore.Text = "Operatore";
            this.gbOperatore.TextAlignment = Janus.Windows.EditControls.TextAlignment.Center;
            this.gbOperatore.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
            // 
            // btnKllMbyllese
            // 
            this.btnKllMbyllese.ColorScheme.DockSiteBackColorGradientAngle = 0;
            this.btnKllMbyllese.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKllMbyllese.Location = new System.Drawing.Point(137, 87);
            this.btnKllMbyllese.Name = "btnKllMbyllese";
            this.btnKllMbyllese.Size = new System.Drawing.Size(37, 37);
            this.btnKllMbyllese.TabIndex = 48;
            this.btnKllMbyllese.Text = ")";
            this.btnKllMbyllese.Click += new System.EventHandler(this.btnKllMbyllese_Click);
            // 
            // btnKllHapese
            // 
            this.btnKllHapese.ColorScheme.DockSiteBackColorGradientAngle = 0;
            this.btnKllHapese.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKllHapese.Location = new System.Drawing.Point(137, 28);
            this.btnKllHapese.Name = "btnKllHapese";
            this.btnKllHapese.Size = new System.Drawing.Size(37, 37);
            this.btnKllHapese.TabIndex = 47;
            this.btnKllHapese.Text = "(";
            this.btnKllHapese.Click += new System.EventHandler(this.btnKllHapese_Click);
            // 
            // cmbVaresiPergj
            // 
            uiComboBoxItem1.FormatStyle.Alpha = 0;
            uiComboBoxItem1.Text = "Produkti";
            uiComboBoxItem2.FormatStyle.Alpha = 0;
            uiComboBoxItem2.Text = "Alumin";
            uiComboBoxItem3.FormatStyle.Alpha = 0;
            uiComboBoxItem3.Text = "Xham";
            uiComboBoxItem4.FormatStyle.Alpha = 0;
            uiComboBoxItem4.Text = "Aksesore";
            this.cmbVaresiPergj.Items.AddRange(new Janus.Windows.EditControls.UIComboBoxItem[] {
            uiComboBoxItem1,
            uiComboBoxItem2,
            uiComboBoxItem3,
            uiComboBoxItem4});
            this.cmbVaresiPergj.Location = new System.Drawing.Point(25, 25);
            this.cmbVaresiPergj.Name = "cmbVaresiPergj";
            this.cmbVaresiPergj.Size = new System.Drawing.Size(132, 20);
            stringFormat1.Alignment = System.Drawing.StringAlignment.Near;
            stringFormat1.FormatFlags = ((System.Drawing.StringFormatFlags)(((System.Drawing.StringFormatFlags.FitBlackBox | System.Drawing.StringFormatFlags.NoWrap)
                        | System.Drawing.StringFormatFlags.NoClip)));
            stringFormat1.HotkeyPrefix = System.Drawing.Text.HotkeyPrefix.None;
            stringFormat1.LineAlignment = System.Drawing.StringAlignment.Center;
            stringFormat1.Trimming = System.Drawing.StringTrimming.Character;
            this.cmbVaresiPergj.StringFormat = stringFormat1;
            this.cmbVaresiPergj.TabIndex = 47;
            this.cmbVaresiPergj.SelectedIndexChanged += new System.EventHandler(this.cmbVaresiPergj_SelectedIndexChanged);
            // 
            // lbVaresia
            // 
            this.lbVaresia.FormattingEnabled = true;
            this.lbVaresia.Location = new System.Drawing.Point(25, 56);
            this.lbVaresia.Name = "lbVaresia";
            this.lbVaresia.Size = new System.Drawing.Size(132, 95);
            this.lbVaresia.TabIndex = 49;
            this.lbVaresia.DoubleClick += new System.EventHandler(this.lbVaresia_DoubleClick);
            // 
            // gbVaresia
            // 
            this.gbVaresia.Controls.Add(this.cmbVaresiPergj);
            this.gbVaresia.Controls.Add(this.lbVaresia);
            this.gbVaresia.FrameStyle = Janus.Windows.EditControls.FrameStyle.Top;
            this.gbVaresia.Location = new System.Drawing.Point(27, 20);
            this.gbVaresia.Name = "gbVaresia";
            this.gbVaresia.Size = new System.Drawing.Size(200, 158);
            this.gbVaresia.TabIndex = 50;
            this.gbVaresia.Text = "Varesia";
            this.gbVaresia.TextAlignment = Janus.Windows.EditControls.TextAlignment.Center;
            this.gbVaresia.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
            // 
            // gbVeprime
            // 
            this.gbVeprime.Controls.Add(this.lblFormula);
            this.gbVeprime.Controls.Add(this.uiGroupBox1);
            this.gbVeprime.Controls.Add(this.gbVaresia);
            this.gbVeprime.Controls.Add(this.gbOperatore);
            this.gbVeprime.Location = new System.Drawing.Point(30, 55);
            this.gbVeprime.Name = "gbVeprime";
            this.gbVeprime.Size = new System.Drawing.Size(480, 240);
            this.gbVeprime.TabIndex = 51;
            this.gbVeprime.Text = "Percaktimi i formules";
            this.gbVeprime.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
            // 
            // lblFormula
            // 
            this.lblFormula.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblFormula.Location = new System.Drawing.Point(24, 181);
            this.lblFormula.Name = "lblFormula";
            this.lblFormula.Size = new System.Drawing.Size(232, 45);
            this.superTooltip1.SetSuperTooltip(this.lblFormula, new DevComponents.DotNetBar.SuperTooltipInfo("Formula aktuale per aksesorin", "", "", null, null, DevComponents.DotNetBar.eTooltipColor.Gray));
            this.lblFormula.TabIndex = 55;
            this.lblFormula.Text = "label1";
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.Controls.Add(this.button1);
            this.uiGroupBox1.Controls.Add(this.numKoeficienti);
            this.uiGroupBox1.FrameStyle = Janus.Windows.EditControls.FrameStyle.Top;
            this.uiGroupBox1.Location = new System.Drawing.Point(262, 175);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.Size = new System.Drawing.Size(200, 51);
            this.uiGroupBox1.TabIndex = 51;
            this.uiGroupBox1.Text = "Koeficient";
            this.uiGroupBox1.TextAlignment = Janus.Windows.EditControls.TextAlignment.Center;
            this.uiGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(160, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 23);
            this.button1.TabIndex = 43;
            this.button1.TeDrejta = PespaSistemLibrary.Button.teDrejta.all;
            this.button1.Text = "Shto";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtFormula
            // 
            this.txtFormula.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFormula.Location = new System.Drawing.Point(12, 311);
            this.txtFormula.Name = "txtFormula";
            this.txtFormula.Size = new System.Drawing.Size(652, 20);
            this.txtFormula.TabIndex = 53;
            // 
            // btnAnullo
            // 
            this.btnAnullo.Location = new System.Drawing.Point(329, 353);
            this.btnAnullo.Name = "btnAnullo";
            this.btnAnullo.Size = new System.Drawing.Size(75, 23);
            this.btnAnullo.TabIndex = 54;
            this.btnAnullo.TeDrejta = PespaSistemLibrary.Button.teDrejta.all;
            this.btnAnullo.Text = "Anullo";
            this.btnAnullo.Click += new System.EventHandler(this.btnAnullo_Click);
            // 
            // dsProduktetAksesoret
            // 
            this.dsProduktetAksesoret.DataSetName = "DsProduktetAksesoret";
            this.dsProduktetAksesoret.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aksesoreProdukteAksesoreTableAdapter1
            // 
            this.aksesoreProdukteAksesoreTableAdapter1.ClearBeforeFill = true;
            // 
            // aluminProdukteAksesoreTableAdapter
            // 
            this.aluminProdukteAksesoreTableAdapter.ClearBeforeFill = true;
            // 
            // produkteAksesoreTableAdapter
            // 
            this.produkteAksesoreTableAdapter.ClearBeforeFill = true;
            // 
            // produkteProdukteAksesoreTableAdapter
            // 
            this.produkteProdukteAksesoreTableAdapter.ClearBeforeFill = true;
            // 
            // xhamProdukteAksesoreTableAdapter
            // 
            this.xhamProdukteAksesoreTableAdapter.ClearBeforeFill = true;
            // 
            // dsProduktAksesore
            // 
            this.dsProduktAksesore.DataSetName = "DsProduktAksesore";
            this.dsProduktAksesore.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // produktAksesoreTableAdapter
            // 
            this.produktAksesoreTableAdapter.ClearBeforeFill = true;
            // 
            // FrmFormule
            // 
            this.ClientSize = new System.Drawing.Size(693, 397);
            this.Controls.Add(this.btnAnullo);
            this.Controls.Add(this.txtFormula);
            this.Controls.Add(this.gbVeprime);
            this.Controls.Add(this.btnRuaj);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmFormule";
            this.Text = "Nderto formule";
            this.Load += new System.EventHandler(this.FrmFormule_Load);
            this.Controls.SetChildIndex(this.btnRuaj, 0);
            this.Controls.SetChildIndex(this.gbVeprime, 0);
            this.Controls.SetChildIndex(this.txtFormula, 0);
            this.Controls.SetChildIndex(this.btnAnullo, 0);
            ((System.ComponentModel.ISupportInitialize)(this.numKoeficienti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbOperatore)).EndInit();
            this.gbOperatore.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gbVaresia)).EndInit();
            this.gbVaresia.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gbVeprime)).EndInit();
            this.gbVeprime.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox1)).EndInit();
            this.uiGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsProduktetAksesoret)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProduktAksesore)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PespaSistemLibrary.Button btnRuaj;
        private System.Windows.Forms.NumericUpDown numKoeficienti;
        private DevComponents.DotNetBar.ButtonX btnPlus;
        private DevComponents.DotNetBar.ButtonX btnMinus;
        private DevComponents.DotNetBar.ButtonX btnPjesetim;
        private DevComponents.DotNetBar.ButtonX btnShumezim;
        private Janus.Windows.EditControls.UIGroupBox gbOperatore;
        private DevComponents.DotNetBar.ButtonX btnKllMbyllese;
        private DevComponents.DotNetBar.ButtonX btnKllHapese;
        private Janus.Windows.EditControls.UIComboBox cmbVaresiPergj;
        private System.Windows.Forms.ListBox lbVaresia;
        private Janus.Windows.EditControls.UIGroupBox gbVaresia;
        private Janus.Windows.EditControls.UIGroupBox gbVeprime;
        private Janus.Windows.EditControls.UIGroupBox uiGroupBox1;
        private System.Windows.Forms.TextBox txtFormula;
        private DsProduktAksesore dsProduktAksesore;
        private PespaSistem.DsProduktAksesoreTableAdapters.PRODUKT_AKSESORETableAdapter produktAksesoreTableAdapter;
        private DsProduktetAksesoret dsProduktetAksesoret;
        private PespaSistem.DsProduktetAksesoretTableAdapters.AksesoreProdukteAksesoreTableAdapter aksesoreProdukteAksesoreTableAdapter1;
        private PespaSistem.DsProduktetAksesoretTableAdapters.AluminProdukteAksesoreTableAdapter aluminProdukteAksesoreTableAdapter;
        private PespaSistem.DsProduktetAksesoretTableAdapters.ProdukteAksesoreTableAdapter produkteAksesoreTableAdapter;
        private PespaSistem.DsProduktetAksesoretTableAdapters.ProdukteProdukteAksesoreTableAdapter produkteProdukteAksesoreTableAdapter;
        private PespaSistem.DsProduktetAksesoretTableAdapters.XhamProdukteAksesoreTableAdapter xhamProdukteAksesoreTableAdapter;
        private PespaSistemLibrary.Button btnAnullo;
        private PespaSistemLibrary.Button button1;
        private System.Windows.Forms.Label lblFormula;
    }
}
