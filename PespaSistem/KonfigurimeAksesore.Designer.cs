namespace PespaSistem
{
    partial class KonfigurimeAksesore
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
            this.expandablePanel2 = new DevComponents.DotNetBar.ExpandablePanel();
            this.gbAksesoret = new Janus.Windows.EditControls.UIGroupBox();
            this.lblDataCmimi = new System.Windows.Forms.Label();
            this.dtpDateFillimi = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbVaresia = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmerAksesori = new System.Windows.Forms.TextBox();
            this.lblPershkrimi = new System.Windows.Forms.Label();
            this.cmbNjesia = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtKodAksesori = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numCmimi = new System.Windows.Forms.NumericUpDown();
            this.gbModifikoAksesoret = new Janus.Windows.EditControls.UIGroupBox();
            this.dtpModifikoDateFillimi = new System.Windows.Forms.DateTimePicker();
            this.lblModifikoDate = new System.Windows.Forms.Label();
            this.cmbModifikoAksesore = new System.Windows.Forms.ComboBox();
            this.dsAksesore = new PespaSistem.DsAksesore();
            this.txtModifikoEmerAksesori = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtModifikoAksesor = new System.Windows.Forms.TextBox();
            this.lblModifikoKod = new System.Windows.Forms.Label();
            this.numModifikoCmim = new System.Windows.Forms.NumericUpDown();
            this.lblLlojetAksesore = new System.Windows.Forms.Label();
            this.btnShto = new PespaSistemLibrary.Button(this.components);
            this.btnElemino = new PespaSistemLibrary.Button(this.components);
            this.btnModifikoAksesor = new PespaSistemLibrary.Button(this.components);
            this.aKSESOREBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aksesoreTableAdapter = new PespaSistem.DsAksesoreTableAdapters.AKSESORETableAdapter();
            this.aluminTableAdapter = new PespaSistem.DsAksesoreTableAdapters.ALUMINTableAdapter();
            this.xhamTableAdapter = new PespaSistem.DsAksesoreTableAdapters.XHAMTableAdapter();
            this.cmimetTableAdapter = new PespaSistem.DsAksesoreTableAdapters.CMIMETTableAdapter();
            this.expandablePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbAksesoret)).BeginInit();
            this.gbAksesoret.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCmimi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbModifikoAksesoret)).BeginInit();
            this.gbModifikoAksesoret.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsAksesore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numModifikoCmim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aKSESOREBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // expandablePanel2
            // 
            this.expandablePanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.expandablePanel2.Controls.Add(this.gbAksesoret);
            this.expandablePanel2.Controls.Add(this.gbModifikoAksesoret);
            this.expandablePanel2.Controls.Add(this.btnShto);
            this.expandablePanel2.Controls.Add(this.btnElemino);
            this.expandablePanel2.Controls.Add(this.btnModifikoAksesor);
            this.expandablePanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.expandablePanel2.Location = new System.Drawing.Point(0, 26);
            this.expandablePanel2.Name = "expandablePanel2";
            this.expandablePanel2.Size = new System.Drawing.Size(1070, 614);
            this.expandablePanel2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.expandablePanel2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.expandablePanel2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.expandablePanel2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.expandablePanel2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expandablePanel2.Style.GradientAngle = 90;
            this.expandablePanel2.TabIndex = 34;
            this.expandablePanel2.TitleHeight = 0;
            this.expandablePanel2.TitleStyle.Alignment = System.Drawing.StringAlignment.Center;
            this.expandablePanel2.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.expandablePanel2.TitleStyle.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.expandablePanel2.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.expandablePanel2.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandablePanel2.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.expandablePanel2.TitleStyle.GradientAngle = 90;
            this.expandablePanel2.TitleText = "Title Bar";
            // 
            // gbAksesoret
            // 
            this.gbAksesoret.BackColor = System.Drawing.Color.Transparent;
            this.gbAksesoret.Controls.Add(this.lblDataCmimi);
            this.gbAksesoret.Controls.Add(this.dtpDateFillimi);
            this.gbAksesoret.Controls.Add(this.label3);
            this.gbAksesoret.Controls.Add(this.cmbVaresia);
            this.gbAksesoret.Controls.Add(this.label2);
            this.gbAksesoret.Controls.Add(this.txtEmerAksesori);
            this.gbAksesoret.Controls.Add(this.lblPershkrimi);
            this.gbAksesoret.Controls.Add(this.cmbNjesia);
            this.gbAksesoret.Controls.Add(this.label7);
            this.gbAksesoret.Controls.Add(this.txtKodAksesori);
            this.gbAksesoret.Controls.Add(this.label5);
            this.gbAksesoret.Controls.Add(this.numCmimi);
            this.gbAksesoret.Location = new System.Drawing.Point(23, 21);
            this.gbAksesoret.Name = "gbAksesoret";
            this.gbAksesoret.Size = new System.Drawing.Size(495, 214);
            this.gbAksesoret.TabIndex = 34;
            this.gbAksesoret.Text = "Shto aksesore";
            this.gbAksesoret.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
            // 
            // lblDataCmimi
            // 
            this.lblDataCmimi.AutoSize = true;
            this.lblDataCmimi.Location = new System.Drawing.Point(322, 70);
            this.lblDataCmimi.Name = "lblDataCmimi";
            this.lblDataCmimi.Size = new System.Drawing.Size(125, 13);
            this.lblDataCmimi.TabIndex = 64;
            this.lblDataCmimi.Text = "Data e nderrimit te cmimit";
            // 
            // dtpDateFillimi
            // 
            this.dtpDateFillimi.CustomFormat = "dd/MM/yyyy    HH:mm";
            this.dtpDateFillimi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateFillimi.Location = new System.Drawing.Point(325, 85);
            this.dtpDateFillimi.Name = "dtpDateFillimi";
            this.dtpDateFillimi.ShowUpDown = true;
            this.dtpDateFillimi.Size = new System.Drawing.Size(141, 20);
            this.dtpDateFillimi.TabIndex = 63;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 59;
            this.label3.Text = "Varesia e aksesorit";
            this.label3.Visible = false;
            // 
            // cmbVaresia
            // 
            this.cmbVaresia.FormattingEnabled = true;
            this.cmbVaresia.Location = new System.Drawing.Point(180, 139);
            this.cmbVaresia.Name = "cmbVaresia";
            this.cmbVaresia.Size = new System.Drawing.Size(127, 21);
            this.cmbVaresia.TabIndex = 5;
            this.cmbVaresia.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 57;
            this.label2.Text = "Njesia matese";
            // 
            // txtEmerAksesori
            // 
            this.txtEmerAksesori.Location = new System.Drawing.Point(180, 58);
            this.txtEmerAksesori.Name = "txtEmerAksesori";
            this.txtEmerAksesori.Size = new System.Drawing.Size(127, 20);
            this.txtEmerAksesori.TabIndex = 2;
            // 
            // lblPershkrimi
            // 
            this.lblPershkrimi.AutoSize = true;
            this.lblPershkrimi.Location = new System.Drawing.Point(91, 61);
            this.lblPershkrimi.Name = "lblPershkrimi";
            this.lblPershkrimi.Size = new System.Drawing.Size(77, 13);
            this.lblPershkrimi.TabIndex = 53;
            this.lblPershkrimi.Text = "Emri i aksesorit";
            // 
            // cmbNjesia
            // 
            this.cmbNjesia.FormattingEnabled = true;
            this.cmbNjesia.Items.AddRange(new object[] {
            "cope",
            "ml",
            "m²",
            "kg"});
            this.cmbNjesia.Location = new System.Drawing.Point(180, 112);
            this.cmbNjesia.Name = "cmbNjesia";
            this.cmbNjesia.Size = new System.Drawing.Size(56, 21);
            this.cmbNjesia.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(134, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 48;
            this.label7.Text = "Cmimi";
            // 
            // txtKodAksesori
            // 
            this.txtKodAksesori.Location = new System.Drawing.Point(180, 32);
            this.txtKodAksesori.Name = "txtKodAksesori";
            this.txtKodAksesori.Size = new System.Drawing.Size(127, 20);
            this.txtKodAksesori.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(90, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 46;
            this.label5.Text = "Kodi i aksesorit";
            // 
            // numCmimi
            // 
            this.numCmimi.DecimalPlaces = 2;
            this.numCmimi.Location = new System.Drawing.Point(180, 85);
            this.numCmimi.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numCmimi.Name = "numCmimi";
            this.numCmimi.Size = new System.Drawing.Size(127, 20);
            this.numCmimi.TabIndex = 3;
            // 
            // gbModifikoAksesoret
            // 
            this.gbModifikoAksesoret.BackColor = System.Drawing.Color.Transparent;
            this.gbModifikoAksesoret.Controls.Add(this.dtpModifikoDateFillimi);
            this.gbModifikoAksesoret.Controls.Add(this.lblModifikoDate);
            this.gbModifikoAksesoret.Controls.Add(this.cmbModifikoAksesore);
            this.gbModifikoAksesoret.Controls.Add(this.txtModifikoEmerAksesori);
            this.gbModifikoAksesoret.Controls.Add(this.label1);
            this.gbModifikoAksesoret.Controls.Add(this.label6);
            this.gbModifikoAksesoret.Controls.Add(this.txtModifikoAksesor);
            this.gbModifikoAksesoret.Controls.Add(this.lblModifikoKod);
            this.gbModifikoAksesoret.Controls.Add(this.numModifikoCmim);
            this.gbModifikoAksesoret.Controls.Add(this.lblLlojetAksesore);
            this.gbModifikoAksesoret.Location = new System.Drawing.Point(23, 284);
            this.gbModifikoAksesoret.Name = "gbModifikoAksesoret";
            this.gbModifikoAksesoret.Size = new System.Drawing.Size(457, 214);
            this.gbModifikoAksesoret.TabIndex = 33;
            this.gbModifikoAksesoret.Text = "Modifiko aksesoret";
            this.gbModifikoAksesoret.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
            // 
            // dtpModifikoDateFillimi
            // 
            this.dtpModifikoDateFillimi.CustomFormat = "dd/MM/yyyy    HH:mm";
            this.dtpModifikoDateFillimi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpModifikoDateFillimi.Location = new System.Drawing.Point(287, 124);
            this.dtpModifikoDateFillimi.Name = "dtpModifikoDateFillimi";
            this.dtpModifikoDateFillimi.ShowUpDown = true;
            this.dtpModifikoDateFillimi.Size = new System.Drawing.Size(141, 20);
            this.dtpModifikoDateFillimi.TabIndex = 62;
            // 
            // lblModifikoDate
            // 
            this.lblModifikoDate.AutoSize = true;
            this.lblModifikoDate.Location = new System.Drawing.Point(143, 128);
            this.lblModifikoDate.Name = "lblModifikoDate";
            this.lblModifikoDate.Size = new System.Drawing.Size(125, 13);
            this.lblModifikoDate.TabIndex = 63;
            this.lblModifikoDate.Text = "Data e nderrimit te cmimit";
            // 
            // cmbModifikoAksesore
            // 
            this.cmbModifikoAksesore.DataSource = this.dsAksesore;
            this.cmbModifikoAksesore.DisplayMember = "AKSESORE.EMER_AKSESORI";
            this.cmbModifikoAksesore.FormattingEnabled = true;
            this.cmbModifikoAksesore.Location = new System.Drawing.Point(25, 42);
            this.cmbModifikoAksesore.Name = "cmbModifikoAksesore";
            this.cmbModifikoAksesore.Size = new System.Drawing.Size(121, 21);
            this.cmbModifikoAksesore.TabIndex = 7;
            this.cmbModifikoAksesore.ValueMember = "AKSESORE.ID_AKSESORI";
            this.cmbModifikoAksesore.SelectedIndexChanged += new System.EventHandler(this.cmbModifikoAksesore_SelectedIndexChanged);
            // 
            // dsAksesore
            // 
            this.dsAksesore.DataSetName = "DsAksesore";
            this.dsAksesore.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtModifikoEmerAksesori
            // 
            this.txtModifikoEmerAksesori.Location = new System.Drawing.Point(287, 68);
            this.txtModifikoEmerAksesori.Name = "txtModifikoEmerAksesori";
            this.txtModifikoEmerAksesori.Size = new System.Drawing.Size(127, 20);
            this.txtModifikoEmerAksesori.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(191, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Emri i aksesorit";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(234, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Cmimi";
            // 
            // txtModifikoAksesor
            // 
            this.txtModifikoAksesor.Location = new System.Drawing.Point(287, 42);
            this.txtModifikoAksesor.Name = "txtModifikoAksesor";
            this.txtModifikoAksesor.Size = new System.Drawing.Size(127, 20);
            this.txtModifikoAksesor.TabIndex = 8;
            // 
            // lblModifikoKod
            // 
            this.lblModifikoKod.AutoSize = true;
            this.lblModifikoKod.Location = new System.Drawing.Point(190, 45);
            this.lblModifikoKod.Name = "lblModifikoKod";
            this.lblModifikoKod.Size = new System.Drawing.Size(78, 13);
            this.lblModifikoKod.TabIndex = 26;
            this.lblModifikoKod.Text = "Kodi i aksesorit";
            // 
            // numModifikoCmim
            // 
            this.numModifikoCmim.DecimalPlaces = 2;
            this.numModifikoCmim.Location = new System.Drawing.Point(287, 96);
            this.numModifikoCmim.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numModifikoCmim.Name = "numModifikoCmim";
            this.numModifikoCmim.Size = new System.Drawing.Size(127, 20);
            this.numModifikoCmim.TabIndex = 10;
            // 
            // lblLlojetAksesore
            // 
            this.lblLlojetAksesore.AutoSize = true;
            this.lblLlojetAksesore.Location = new System.Drawing.Point(57, 26);
            this.lblLlojetAksesore.Name = "lblLlojetAksesore";
            this.lblLlojetAksesore.Size = new System.Drawing.Size(54, 13);
            this.lblLlojetAksesore.TabIndex = 16;
            this.lblLlojetAksesore.Text = "Aksesoret";
            // 
            // btnShto
            // 
            this.btnShto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShto.Location = new System.Drawing.Point(539, 108);
            this.btnShto.Name = "btnShto";
            this.btnShto.Size = new System.Drawing.Size(75, 24);
            this.superTooltip1.SetSuperTooltip(this.btnShto, new DevComponents.DotNetBar.SuperTooltipInfo("Shton nje aksesor te ri", "", "", null, null, DevComponents.DotNetBar.eTooltipColor.Gray));
            this.btnShto.TabIndex = 6;
            this.btnShto.TeDrejta = PespaSistemLibrary.Button.teDrejta.all;
            this.btnShto.Text = "Shto";
            this.btnShto.Click += new System.EventHandler(this.btnShto_Click);
            // 
            // btnElemino
            // 
            this.btnElemino.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnElemino.Location = new System.Drawing.Point(524, 390);
            this.btnElemino.Name = "btnElemino";
            this.btnElemino.Size = new System.Drawing.Size(75, 24);
            this.superTooltip1.SetSuperTooltip(this.btnElemino, new DevComponents.DotNetBar.SuperTooltipInfo("Fshin aksesorin e dhene", "", "", null, null, DevComponents.DotNetBar.eTooltipColor.Gray));
            this.btnElemino.TabIndex = 12;
            this.btnElemino.TeDrejta = PespaSistemLibrary.Button.teDrejta.all;
            this.btnElemino.Text = "Elemino";
            this.btnElemino.Click += new System.EventHandler(this.btnElemino_Click);
            // 
            // btnModifikoAksesor
            // 
            this.btnModifikoAksesor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModifikoAksesor.Location = new System.Drawing.Point(524, 345);
            this.btnModifikoAksesor.Name = "btnModifikoAksesor";
            this.btnModifikoAksesor.Size = new System.Drawing.Size(75, 24);
            this.superTooltip1.SetSuperTooltip(this.btnModifikoAksesor, new DevComponents.DotNetBar.SuperTooltipInfo("Modifikon emrin ose cmimin e nje aksesori", "", "", null, null, DevComponents.DotNetBar.eTooltipColor.Gray));
            this.btnModifikoAksesor.TabIndex = 11;
            this.btnModifikoAksesor.TeDrejta = PespaSistemLibrary.Button.teDrejta.all;
            this.btnModifikoAksesor.Text = "Modifiko";
            this.btnModifikoAksesor.Click += new System.EventHandler(this.btnModifikoAksesor_Click);
            // 
            // aKSESOREBindingSource
            // 
            this.aKSESOREBindingSource.DataMember = "AKSESORE";
            this.aKSESOREBindingSource.DataSource = this.dsAksesore;
            // 
            // aksesoreTableAdapter
            // 
            this.aksesoreTableAdapter.ClearBeforeFill = true;
            // 
            // aluminTableAdapter
            // 
            this.aluminTableAdapter.ClearBeforeFill = true;
            // 
            // xhamTableAdapter
            // 
            this.xhamTableAdapter.ClearBeforeFill = true;
            // 
            // cmimetTableAdapter
            // 
            this.cmimetTableAdapter.ClearBeforeFill = true;
            // 
            // KonfigurimeAksesore
            // 
            this.ClientSize = new System.Drawing.Size(1087, 520);
            this.Controls.Add(this.expandablePanel2);
            this.Name = "KonfigurimeAksesore";
            this.Text = "Konfigurimi i aksesoreve";
            this.Load += new System.EventHandler(this.KonfigurimeAksesore_Load);
            this.Controls.SetChildIndex(this.expandablePanel2, 0);
            this.expandablePanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gbAksesoret)).EndInit();
            this.gbAksesoret.ResumeLayout(false);
            this.gbAksesoret.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCmimi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbModifikoAksesoret)).EndInit();
            this.gbModifikoAksesoret.ResumeLayout(false);
            this.gbModifikoAksesoret.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsAksesore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numModifikoCmim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aKSESOREBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ExpandablePanel expandablePanel2;
        private Janus.Windows.EditControls.UIGroupBox gbAksesoret;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmerAksesori;
        private System.Windows.Forms.Label lblPershkrimi;
        private System.Windows.Forms.ComboBox cmbNjesia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtKodAksesori;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numCmimi;
        private Janus.Windows.EditControls.UIGroupBox gbModifikoAksesoret;
        private System.Windows.Forms.ComboBox cmbModifikoAksesore;
        private System.Windows.Forms.TextBox txtModifikoEmerAksesori;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtModifikoAksesor;
        private System.Windows.Forms.Label lblModifikoKod;
        private System.Windows.Forms.NumericUpDown numModifikoCmim;
        private System.Windows.Forms.Label lblLlojetAksesore;
        private PespaSistemLibrary.Button btnShto;
        private PespaSistemLibrary.Button btnElemino;
        private PespaSistemLibrary.Button btnModifikoAksesor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbVaresia;
        private PespaSistem.DsAksesoreTableAdapters.AKSESORETableAdapter aksesoreTableAdapter;
        private DsAksesore dsAksesore;
        private PespaSistem.DsAksesoreTableAdapters.ALUMINTableAdapter aluminTableAdapter;
        private PespaSistem.DsAksesoreTableAdapters.XHAMTableAdapter xhamTableAdapter;
        private System.Windows.Forms.BindingSource aKSESOREBindingSource;
        private System.Windows.Forms.Label lblDataCmimi;
        private System.Windows.Forms.DateTimePicker dtpDateFillimi;
        private System.Windows.Forms.DateTimePicker dtpModifikoDateFillimi;
        private System.Windows.Forms.Label lblModifikoDate;
        private PespaSistem.DsAksesoreTableAdapters.CMIMETTableAdapter cmimetTableAdapter;
    }
}
