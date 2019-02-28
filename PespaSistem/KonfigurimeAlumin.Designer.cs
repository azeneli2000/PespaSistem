namespace PespaSistem
{
    partial class KonfigurimeAlumin
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
            this.dtpDateFillimi = new System.Windows.Forms.DateTimePicker();
            this.lblDataCmimi = new System.Windows.Forms.Label();
            this.chkCmimi = new System.Windows.Forms.CheckBox();
            this.chkPeshaSpecifike = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numPeshaSpecifike = new System.Windows.Forms.NumericUpDown();
            this.txtEmerAlumini = new System.Windows.Forms.TextBox();
            this.lblPershkrimi = new System.Windows.Forms.Label();
            this.cmbNjesia = new System.Windows.Forms.ComboBox();
            this.lblNjesia = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtKodAlumin = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numCmimi = new System.Windows.Forms.NumericUpDown();
            this.gbModifikoAksesoret = new Janus.Windows.EditControls.UIGroupBox();
            this.lblModifikoDate = new System.Windows.Forms.Label();
            this.numModifikoPesha = new System.Windows.Forms.NumericUpDown();
            this.dtpModifikoDateFillimi = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbModifikoAlumin = new System.Windows.Forms.ComboBox();
            this.dsAlumin = new PespaSistem.DsAlumin();
            this.txtModifikoEmer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtModifikoKod = new System.Windows.Forms.TextBox();
            this.lblModifikoKod = new System.Windows.Forms.Label();
            this.numModifikoCmim = new System.Windows.Forms.NumericUpDown();
            this.lblLlojetAlumini = new System.Windows.Forms.Label();
            this.btnShto = new PespaSistemLibrary.Button(this.components);
            this.btnElemino = new PespaSistemLibrary.Button(this.components);
            this.btnModifikoAksesor = new PespaSistemLibrary.Button(this.components);
            this.aluminTableAdapter = new PespaSistem.DsAluminTableAdapters.ALUMINTableAdapter();
            this.cmimetTableAdapter = new PespaSistem.DsAluminTableAdapters.CMIMETTableAdapter();
            this.expandablePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbAksesoret)).BeginInit();
            this.gbAksesoret.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPeshaSpecifike)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCmimi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbModifikoAksesoret)).BeginInit();
            this.gbModifikoAksesoret.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numModifikoPesha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAlumin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numModifikoCmim)).BeginInit();
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
            this.expandablePanel2.Size = new System.Drawing.Size(1019, 614);
            this.expandablePanel2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.expandablePanel2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.expandablePanel2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.expandablePanel2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.expandablePanel2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expandablePanel2.Style.GradientAngle = 90;
            this.expandablePanel2.TabIndex = 33;
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
            this.gbAksesoret.Controls.Add(this.dtpDateFillimi);
            this.gbAksesoret.Controls.Add(this.lblDataCmimi);
            this.gbAksesoret.Controls.Add(this.chkCmimi);
            this.gbAksesoret.Controls.Add(this.chkPeshaSpecifike);
            this.gbAksesoret.Controls.Add(this.label2);
            this.gbAksesoret.Controls.Add(this.numPeshaSpecifike);
            this.gbAksesoret.Controls.Add(this.txtEmerAlumini);
            this.gbAksesoret.Controls.Add(this.lblPershkrimi);
            this.gbAksesoret.Controls.Add(this.cmbNjesia);
            this.gbAksesoret.Controls.Add(this.lblNjesia);
            this.gbAksesoret.Controls.Add(this.label7);
            this.gbAksesoret.Controls.Add(this.txtKodAlumin);
            this.gbAksesoret.Controls.Add(this.label5);
            this.gbAksesoret.Controls.Add(this.numCmimi);
            this.gbAksesoret.Location = new System.Drawing.Point(23, 21);
            this.gbAksesoret.Name = "gbAksesoret";
            this.gbAksesoret.Size = new System.Drawing.Size(488, 237);
            this.gbAksesoret.TabIndex = 34;
            this.gbAksesoret.Text = "Shto lloj alumini";
            this.gbAksesoret.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
            // 
            // dtpDateFillimi
            // 
            this.dtpDateFillimi.CustomFormat = "dd/MM/yyyy    HH:mm";
            this.dtpDateFillimi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateFillimi.Location = new System.Drawing.Point(334, 86);
            this.dtpDateFillimi.Name = "dtpDateFillimi";
            this.dtpDateFillimi.ShowUpDown = true;
            this.dtpDateFillimi.Size = new System.Drawing.Size(141, 20);
            this.dtpDateFillimi.TabIndex = 61;
            // 
            // lblDataCmimi
            // 
            this.lblDataCmimi.AutoSize = true;
            this.lblDataCmimi.Location = new System.Drawing.Point(331, 70);
            this.lblDataCmimi.Name = "lblDataCmimi";
            this.lblDataCmimi.Size = new System.Drawing.Size(125, 13);
            this.lblDataCmimi.TabIndex = 60;
            this.lblDataCmimi.Text = "Data e nderrimit te cmimit";
            // 
            // chkCmimi
            // 
            this.chkCmimi.AutoSize = true;
            this.chkCmimi.Location = new System.Drawing.Point(180, 88);
            this.chkCmimi.Name = "chkCmimi";
            this.chkCmimi.Size = new System.Drawing.Size(15, 14);
            this.chkCmimi.TabIndex = 59;
            this.chkCmimi.UseVisualStyleBackColor = true;
            this.chkCmimi.CheckedChanged += new System.EventHandler(this.chkCmimi_CheckedChanged);
            // 
            // chkPeshaSpecifike
            // 
            this.chkPeshaSpecifike.AutoSize = true;
            this.chkPeshaSpecifike.Location = new System.Drawing.Point(180, 115);
            this.chkPeshaSpecifike.Name = "chkPeshaSpecifike";
            this.chkPeshaSpecifike.Size = new System.Drawing.Size(15, 14);
            this.chkPeshaSpecifike.TabIndex = 58;
            this.chkPeshaSpecifike.UseVisualStyleBackColor = true;
            this.chkPeshaSpecifike.CheckedChanged += new System.EventHandler(this.chkPeshaSpecifike_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 57;
            this.label2.Text = "Njesia matese";
            // 
            // numPeshaSpecifike
            // 
            this.numPeshaSpecifike.DecimalPlaces = 2;
            this.numPeshaSpecifike.Location = new System.Drawing.Point(193, 113);
            this.numPeshaSpecifike.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numPeshaSpecifike.Name = "numPeshaSpecifike";
            this.numPeshaSpecifike.Size = new System.Drawing.Size(114, 20);
            this.numPeshaSpecifike.TabIndex = 4;
            // 
            // txtEmerAlumini
            // 
            this.txtEmerAlumini.Location = new System.Drawing.Point(180, 58);
            this.txtEmerAlumini.Name = "txtEmerAlumini";
            this.txtEmerAlumini.Size = new System.Drawing.Size(127, 20);
            this.txtEmerAlumini.TabIndex = 2;
            // 
            // lblPershkrimi
            // 
            this.lblPershkrimi.AutoSize = true;
            this.lblPershkrimi.Location = new System.Drawing.Point(91, 61);
            this.lblPershkrimi.Name = "lblPershkrimi";
            this.lblPershkrimi.Size = new System.Drawing.Size(70, 13);
            this.lblPershkrimi.TabIndex = 53;
            this.lblPershkrimi.Text = "Emri i aluminit";
            // 
            // cmbNjesia
            // 
            this.cmbNjesia.FormattingEnabled = true;
            this.cmbNjesia.Items.AddRange(new object[] {
            "cope",
            "ml",
            "m²",
            "kg"});
            this.cmbNjesia.Location = new System.Drawing.Point(180, 139);
            this.cmbNjesia.Name = "cmbNjesia";
            this.cmbNjesia.Size = new System.Drawing.Size(56, 21);
            this.cmbNjesia.TabIndex = 5;
            // 
            // lblNjesia
            // 
            this.lblNjesia.AutoSize = true;
            this.lblNjesia.Location = new System.Drawing.Point(79, 115);
            this.lblNjesia.Name = "lblNjesia";
            this.lblNjesia.Size = new System.Drawing.Size(82, 13);
            this.lblNjesia.TabIndex = 51;
            this.lblNjesia.Text = "Pesha specifike";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(127, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 48;
            this.label7.Text = "Cmimi";
            // 
            // txtKodAlumin
            // 
            this.txtKodAlumin.Location = new System.Drawing.Point(180, 32);
            this.txtKodAlumin.Name = "txtKodAlumin";
            this.txtKodAlumin.Size = new System.Drawing.Size(127, 20);
            this.txtKodAlumin.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(94, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 46;
            this.label5.Text = "Kodi i aluminit";
            // 
            // numCmimi
            // 
            this.numCmimi.DecimalPlaces = 2;
            this.numCmimi.Location = new System.Drawing.Point(193, 86);
            this.numCmimi.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numCmimi.Name = "numCmimi";
            this.numCmimi.Size = new System.Drawing.Size(114, 20);
            this.numCmimi.TabIndex = 3;
            // 
            // gbModifikoAksesoret
            // 
            this.gbModifikoAksesoret.BackColor = System.Drawing.Color.Transparent;
            this.gbModifikoAksesoret.Controls.Add(this.lblModifikoDate);
            this.gbModifikoAksesoret.Controls.Add(this.numModifikoPesha);
            this.gbModifikoAksesoret.Controls.Add(this.dtpModifikoDateFillimi);
            this.gbModifikoAksesoret.Controls.Add(this.label3);
            this.gbModifikoAksesoret.Controls.Add(this.cmbModifikoAlumin);
            this.gbModifikoAksesoret.Controls.Add(this.txtModifikoEmer);
            this.gbModifikoAksesoret.Controls.Add(this.label1);
            this.gbModifikoAksesoret.Controls.Add(this.label6);
            this.gbModifikoAksesoret.Controls.Add(this.txtModifikoKod);
            this.gbModifikoAksesoret.Controls.Add(this.lblModifikoKod);
            this.gbModifikoAksesoret.Controls.Add(this.numModifikoCmim);
            this.gbModifikoAksesoret.Controls.Add(this.lblLlojetAlumini);
            this.gbModifikoAksesoret.Location = new System.Drawing.Point(23, 284);
            this.gbModifikoAksesoret.Name = "gbModifikoAksesoret";
            this.gbModifikoAksesoret.Size = new System.Drawing.Size(457, 214);
            this.gbModifikoAksesoret.TabIndex = 33;
            this.gbModifikoAksesoret.Text = "Modifiko llojet e aluminit";
            this.gbModifikoAksesoret.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
            // 
            // lblModifikoDate
            // 
            this.lblModifikoDate.AutoSize = true;
            this.lblModifikoDate.Location = new System.Drawing.Point(136, 127);
            this.lblModifikoDate.Name = "lblModifikoDate";
            this.lblModifikoDate.Size = new System.Drawing.Size(125, 13);
            this.lblModifikoDate.TabIndex = 58;
            this.lblModifikoDate.Text = "Data e nderrimit te cmimit";
            // 
            // numModifikoPesha
            // 
            this.numModifikoPesha.DecimalPlaces = 2;
            this.numModifikoPesha.Location = new System.Drawing.Point(280, 150);
            this.numModifikoPesha.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numModifikoPesha.Name = "numModifikoPesha";
            this.numModifikoPesha.Size = new System.Drawing.Size(127, 20);
            this.numModifikoPesha.TabIndex = 11;
            this.numModifikoPesha.Visible = false;
            this.numModifikoPesha.ValueChanged += new System.EventHandler(this.numModifikoPesha_ValueChanged);
            // 
            // dtpModifikoDateFillimi
            // 
            this.dtpModifikoDateFillimi.CustomFormat = "dd/MM/yyyy    HH:mm";
            this.dtpModifikoDateFillimi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpModifikoDateFillimi.Location = new System.Drawing.Point(280, 123);
            this.dtpModifikoDateFillimi.Name = "dtpModifikoDateFillimi";
            this.dtpModifikoDateFillimi.ShowUpDown = true;
            this.dtpModifikoDateFillimi.Size = new System.Drawing.Size(141, 20);
            this.dtpModifikoDateFillimi.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(179, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 57;
            this.label3.Text = "Pesha specifike";
            this.label3.Visible = false;
            // 
            // cmbModifikoAlumin
            // 
            this.cmbModifikoAlumin.DataSource = this.dsAlumin;
            this.cmbModifikoAlumin.DisplayMember = "ALUMIN.EMER_ALUMINI";
            this.cmbModifikoAlumin.FormattingEnabled = true;
            this.cmbModifikoAlumin.Location = new System.Drawing.Point(25, 42);
            this.cmbModifikoAlumin.Name = "cmbModifikoAlumin";
            this.cmbModifikoAlumin.Size = new System.Drawing.Size(121, 21);
            this.cmbModifikoAlumin.TabIndex = 7;
            this.cmbModifikoAlumin.ValueMember = "ALUMIN.ID_ALUMINI";
            this.cmbModifikoAlumin.SelectedIndexChanged += new System.EventHandler(this.cmbModifikoAlumin_SelectedIndexChanged);
            // 
            // dsAlumin
            // 
            this.dsAlumin.DataSetName = "DsAlumin";
            this.dsAlumin.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtModifikoEmer
            // 
            this.txtModifikoEmer.Location = new System.Drawing.Point(280, 68);
            this.txtModifikoEmer.Name = "txtModifikoEmer";
            this.txtModifikoEmer.Size = new System.Drawing.Size(127, 20);
            this.txtModifikoEmer.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(191, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Emri i aluminit";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(227, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Cmimi";
            // 
            // txtModifikoKod
            // 
            this.txtModifikoKod.Location = new System.Drawing.Point(280, 42);
            this.txtModifikoKod.Name = "txtModifikoKod";
            this.txtModifikoKod.Size = new System.Drawing.Size(127, 20);
            this.txtModifikoKod.TabIndex = 8;
            // 
            // lblModifikoKod
            // 
            this.lblModifikoKod.AutoSize = true;
            this.lblModifikoKod.Location = new System.Drawing.Point(190, 45);
            this.lblModifikoKod.Name = "lblModifikoKod";
            this.lblModifikoKod.Size = new System.Drawing.Size(71, 13);
            this.lblModifikoKod.TabIndex = 26;
            this.lblModifikoKod.Text = "Kodi i aluminit";
            // 
            // numModifikoCmim
            // 
            this.numModifikoCmim.Location = new System.Drawing.Point(280, 96);
            this.numModifikoCmim.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numModifikoCmim.Name = "numModifikoCmim";
            this.numModifikoCmim.Size = new System.Drawing.Size(127, 20);
            this.numModifikoCmim.TabIndex = 10;
            // 
            // lblLlojetAlumini
            // 
            this.lblLlojetAlumini.AutoSize = true;
            this.lblLlojetAlumini.Location = new System.Drawing.Point(45, 23);
            this.lblLlojetAlumini.Name = "lblLlojetAlumini";
            this.lblLlojetAlumini.Size = new System.Drawing.Size(79, 13);
            this.lblLlojetAlumini.TabIndex = 16;
            this.lblLlojetAlumini.Text = "Llojet e aluminit";
            // 
            // btnShto
            // 
            this.btnShto.Location = new System.Drawing.Point(529, 123);
            this.btnShto.Name = "btnShto";
            this.btnShto.Size = new System.Drawing.Size(75, 24);
            this.superTooltip1.SetSuperTooltip(this.btnShto, new DevComponents.DotNetBar.SuperTooltipInfo("Shton nje lloj te ri alumini", "", "", null, null, DevComponents.DotNetBar.eTooltipColor.Gray));
            this.btnShto.TabIndex = 6;
            this.btnShto.TeDrejta = PespaSistemLibrary.Button.teDrejta.all;
            this.btnShto.Text = "Shto";
            this.btnShto.Click += new System.EventHandler(this.btnShto_Click);
            // 
            // btnElemino
            // 
            this.btnElemino.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnElemino.Location = new System.Drawing.Point(512, 390);
            this.btnElemino.Name = "btnElemino";
            this.btnElemino.Size = new System.Drawing.Size(75, 24);
            this.superTooltip1.SetSuperTooltip(this.btnElemino, new DevComponents.DotNetBar.SuperTooltipInfo("Fshin aksesorin e dhene", "", "", null, null, DevComponents.DotNetBar.eTooltipColor.Gray));
            this.btnElemino.TabIndex = 13;
            this.btnElemino.TeDrejta = PespaSistemLibrary.Button.teDrejta.all;
            this.btnElemino.Text = "Elemino";
            this.btnElemino.Click += new System.EventHandler(this.btnElemino_Click);
            // 
            // btnModifikoAksesor
            // 
            this.btnModifikoAksesor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModifikoAksesor.Location = new System.Drawing.Point(512, 345);
            this.btnModifikoAksesor.Name = "btnModifikoAksesor";
            this.btnModifikoAksesor.Size = new System.Drawing.Size(75, 24);
            this.superTooltip1.SetSuperTooltip(this.btnModifikoAksesor, new DevComponents.DotNetBar.SuperTooltipInfo("Modifikon emrin ose cmimin e nje aksesori te profileve horizontale", "", "", null, null, DevComponents.DotNetBar.eTooltipColor.Gray));
            this.btnModifikoAksesor.TabIndex = 12;
            this.btnModifikoAksesor.TeDrejta = PespaSistemLibrary.Button.teDrejta.all;
            this.btnModifikoAksesor.Text = "Modifiko";
            this.btnModifikoAksesor.Click += new System.EventHandler(this.btnModifikoAksesor_Click);
            // 
            // aluminTableAdapter
            // 
            this.aluminTableAdapter.ClearBeforeFill = true;
            // 
            // cmimetTableAdapter
            // 
            this.cmimetTableAdapter.ClearBeforeFill = true;
            // 
            // KonfigurimeAlumin
            // 
            this.ClientSize = new System.Drawing.Size(1036, 570);
            this.Controls.Add(this.expandablePanel2);
            this.Name = "KonfigurimeAlumin";
            this.Text = "Konfigurime alumini";
            this.Load += new System.EventHandler(this.KonfigurimeAlumin_Load);
            this.Controls.SetChildIndex(this.expandablePanel2, 0);
            this.expandablePanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gbAksesoret)).EndInit();
            this.gbAksesoret.ResumeLayout(false);
            this.gbAksesoret.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPeshaSpecifike)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCmimi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbModifikoAksesoret)).EndInit();
            this.gbModifikoAksesoret.ResumeLayout(false);
            this.gbModifikoAksesoret.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numModifikoPesha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAlumin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numModifikoCmim)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ExpandablePanel expandablePanel2;
        private Janus.Windows.EditControls.UIGroupBox gbAksesoret;
        private System.Windows.Forms.TextBox txtEmerAlumini;
        private System.Windows.Forms.Label lblPershkrimi;
        private System.Windows.Forms.ComboBox cmbNjesia;
        private System.Windows.Forms.Label lblNjesia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtKodAlumin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numCmimi;
        private Janus.Windows.EditControls.UIGroupBox gbModifikoAksesoret;
        private System.Windows.Forms.TextBox txtModifikoEmer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtModifikoKod;
        private System.Windows.Forms.Label lblModifikoKod;
        private System.Windows.Forms.NumericUpDown numModifikoCmim;
        private System.Windows.Forms.Label lblLlojetAlumini;
        private PespaSistemLibrary.Button btnShto;
        private PespaSistemLibrary.Button btnElemino;
        private PespaSistemLibrary.Button btnModifikoAksesor;
        private System.Windows.Forms.NumericUpDown numPeshaSpecifike;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbModifikoAlumin;
        private System.Windows.Forms.NumericUpDown numModifikoPesha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkCmimi;
        private System.Windows.Forms.CheckBox chkPeshaSpecifike;
        private System.Windows.Forms.Label lblDataCmimi;
        private System.Windows.Forms.DateTimePicker dtpModifikoDateFillimi;
        private DsAlumin dsAlumin;
        private PespaSistem.DsAluminTableAdapters.ALUMINTableAdapter aluminTableAdapter;
        private PespaSistem.DsAluminTableAdapters.CMIMETTableAdapter cmimetTableAdapter;
        private System.Windows.Forms.Label lblModifikoDate;
        private System.Windows.Forms.DateTimePicker dtpDateFillimi;
    }
}
