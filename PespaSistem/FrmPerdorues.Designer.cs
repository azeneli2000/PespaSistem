namespace PespaSistem
{
    partial class FrmPerdorues
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
            this.btnElemino = new PespaSistemLibrary.Button(this.components);
            this.uiGroupBox1 = new Janus.Windows.EditControls.UIGroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dsPerdorues = new PespaSistem.DsPerdorues();
            this.txtPersFjalekalimModifiko = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFjalekalimModifiko = new System.Windows.Forms.TextBox();
            this.txtEmerModifiko = new System.Windows.Forms.TextBox();
            this.cmbRoliModifiko = new System.Windows.Forms.ComboBox();
            this.txtPerdoruesModifiko = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMbiemerModifiko = new System.Windows.Forms.TextBox();
            this.btnShto = new PespaSistemLibrary.Button(this.components);
            this.gbShtoPerdorues = new Janus.Windows.EditControls.UIGroupBox();
            this.txtPerseritFjalekalimin = new System.Windows.Forms.TextBox();
            this.lblMbiemri = new System.Windows.Forms.Label();
            this.lblEmerPerdoruesi = new System.Windows.Forms.Label();
            this.lblFjalekalim = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFjalekalim = new System.Windows.Forms.TextBox();
            this.txtEmri = new System.Windows.Forms.TextBox();
            this.cmbRoli = new System.Windows.Forms.ComboBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblEmri = new System.Windows.Forms.Label();
            this.txtMbiemri = new System.Windows.Forms.TextBox();
            this.btnModifikoAksesor = new PespaSistemLibrary.Button(this.components);
            this.perdoruesTableAdapter = new PespaSistem.DsPerdoruesTableAdapters.PERDORUESTableAdapter();
            this.rolePerdoruesTableAdapter = new PespaSistem.DsPerdoruesTableAdapters.ROLE_PERDORUESTableAdapter();
            this.expandablePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox1)).BeginInit();
            this.uiGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsPerdorues)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbShtoPerdorues)).BeginInit();
            this.gbShtoPerdorues.SuspendLayout();
            this.SuspendLayout();
            // 
            // expandablePanel2
            // 
            this.expandablePanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.expandablePanel2.Controls.Add(this.btnElemino);
            this.expandablePanel2.Controls.Add(this.uiGroupBox1);
            this.expandablePanel2.Controls.Add(this.btnShto);
            this.expandablePanel2.Controls.Add(this.gbShtoPerdorues);
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
            this.expandablePanel2.TabIndex = 35;
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
            // btnElemino
            // 
            this.btnElemino.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnElemino.Location = new System.Drawing.Point(619, 338);
            this.btnElemino.Name = "btnElemino";
            this.btnElemino.Size = new System.Drawing.Size(75, 24);
            this.superTooltip1.SetSuperTooltip(this.btnElemino, new DevComponents.DotNetBar.SuperTooltipInfo("Modifikon emrin ose cmimin e nje aksesori te profileve horizontale", "", "", null, null, DevComponents.DotNetBar.eTooltipColor.Gray));
            this.btnElemino.TabIndex = 15;
            this.btnElemino.TeDrejta = PespaSistemLibrary.Button.teDrejta.all;
            this.btnElemino.Text = "Elemino";
            this.btnElemino.Click += new System.EventHandler(this.btnElemino_Click);
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.uiGroupBox1.Controls.Add(this.label9);
            this.uiGroupBox1.Controls.Add(this.comboBox1);
            this.uiGroupBox1.Controls.Add(this.txtPersFjalekalimModifiko);
            this.uiGroupBox1.Controls.Add(this.label3);
            this.uiGroupBox1.Controls.Add(this.label4);
            this.uiGroupBox1.Controls.Add(this.label5);
            this.uiGroupBox1.Controls.Add(this.label6);
            this.uiGroupBox1.Controls.Add(this.label7);
            this.uiGroupBox1.Controls.Add(this.txtFjalekalimModifiko);
            this.uiGroupBox1.Controls.Add(this.txtEmerModifiko);
            this.uiGroupBox1.Controls.Add(this.cmbRoliModifiko);
            this.uiGroupBox1.Controls.Add(this.txtPerdoruesModifiko);
            this.uiGroupBox1.Controls.Add(this.label8);
            this.uiGroupBox1.Controls.Add(this.txtMbiemerModifiko);
            this.uiGroupBox1.Location = new System.Drawing.Point(21, 221);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.Size = new System.Drawing.Size(556, 195);
            this.uiGroupBox1.TabIndex = 35;
            this.uiGroupBox1.Text = "Modifiko / Elemino perdorues";
            this.uiGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 13);
            this.label9.TabIndex = 40;
            this.label9.Text = "Roli i perdoruesit";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.dsPerdorues;
            this.comboBox1.DisplayMember = "PERDORUES.USERNAME";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(112, 28);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(127, 21);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.ValueMember = "PERDORUES.ID_PERDORUES";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dsPerdorues
            // 
            this.dsPerdorues.DataSetName = "DsPerdorues";
            this.dsPerdorues.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtPersFjalekalimModifiko
            // 
            this.txtPersFjalekalimModifiko.Location = new System.Drawing.Point(397, 132);
            this.txtPersFjalekalimModifiko.Name = "txtPersFjalekalimModifiko";
            this.txtPersFjalekalimModifiko.PasswordChar = '●';
            this.txtPersFjalekalimModifiko.Size = new System.Drawing.Size(127, 20);
            this.txtPersFjalekalimModifiko.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Mbiemri";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(295, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "Emri i perdoruesit";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(327, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "Fjalekalimi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(276, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "Perserisni fjalekalimin";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(297, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Roli i perdoruesit";
            // 
            // txtFjalekalimModifiko
            // 
            this.txtFjalekalimModifiko.Location = new System.Drawing.Point(397, 104);
            this.txtFjalekalimModifiko.Name = "txtFjalekalimModifiko";
            this.txtFjalekalimModifiko.PasswordChar = '●';
            this.txtFjalekalimModifiko.Size = new System.Drawing.Size(127, 20);
            this.txtFjalekalimModifiko.TabIndex = 11;
            // 
            // txtEmerModifiko
            // 
            this.txtEmerModifiko.Location = new System.Drawing.Point(112, 78);
            this.txtEmerModifiko.Name = "txtEmerModifiko";
            this.txtEmerModifiko.Size = new System.Drawing.Size(127, 20);
            this.txtEmerModifiko.TabIndex = 8;
            // 
            // cmbRoliModifiko
            // 
            this.cmbRoliModifiko.DisplayMember = "AKSESORE.ID_AKSESORI";
            this.cmbRoliModifiko.Enabled = false;
            this.cmbRoliModifiko.FormattingEnabled = true;
            this.cmbRoliModifiko.Location = new System.Drawing.Point(397, 158);
            this.cmbRoliModifiko.Name = "cmbRoliModifiko";
            this.cmbRoliModifiko.Size = new System.Drawing.Size(127, 21);
            this.cmbRoliModifiko.TabIndex = 13;
            this.cmbRoliModifiko.ValueMember = "AKSESORE.ID_AKSESORI";
            // 
            // txtPerdoruesModifiko
            // 
            this.txtPerdoruesModifiko.Location = new System.Drawing.Point(397, 78);
            this.txtPerdoruesModifiko.Name = "txtPerdoruesModifiko";
            this.txtPerdoruesModifiko.ReadOnly = true;
            this.txtPerdoruesModifiko.Size = new System.Drawing.Size(127, 20);
            this.txtPerdoruesModifiko.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(72, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "Emri";
            // 
            // txtMbiemerModifiko
            // 
            this.txtMbiemerModifiko.Location = new System.Drawing.Point(112, 104);
            this.txtMbiemerModifiko.Name = "txtMbiemerModifiko";
            this.txtMbiemerModifiko.Size = new System.Drawing.Size(127, 20);
            this.txtMbiemerModifiko.TabIndex = 9;
            // 
            // btnShto
            // 
            this.btnShto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShto.Location = new System.Drawing.Point(619, 99);
            this.btnShto.Name = "btnShto";
            this.btnShto.Size = new System.Drawing.Size(75, 24);
            this.superTooltip1.SetSuperTooltip(this.btnShto, new DevComponents.DotNetBar.SuperTooltipInfo("Modifikon emrin ose cmimin e nje aksesori te profileve horizontale", "", "", null, null, DevComponents.DotNetBar.eTooltipColor.Gray));
            this.btnShto.TabIndex = 6;
            this.btnShto.TeDrejta = PespaSistemLibrary.Button.teDrejta.all;
            this.btnShto.Text = "&Shto";
            this.btnShto.Click += new System.EventHandler(this.btnShto_Click);
            // 
            // gbShtoPerdorues
            // 
            this.gbShtoPerdorues.BackColor = System.Drawing.Color.Transparent;
            this.gbShtoPerdorues.Controls.Add(this.txtPerseritFjalekalimin);
            this.gbShtoPerdorues.Controls.Add(this.lblMbiemri);
            this.gbShtoPerdorues.Controls.Add(this.lblEmerPerdoruesi);
            this.gbShtoPerdorues.Controls.Add(this.lblFjalekalim);
            this.gbShtoPerdorues.Controls.Add(this.label2);
            this.gbShtoPerdorues.Controls.Add(this.label1);
            this.gbShtoPerdorues.Controls.Add(this.txtFjalekalim);
            this.gbShtoPerdorues.Controls.Add(this.txtEmri);
            this.gbShtoPerdorues.Controls.Add(this.cmbRoli);
            this.gbShtoPerdorues.Controls.Add(this.txtUserName);
            this.gbShtoPerdorues.Controls.Add(this.lblEmri);
            this.gbShtoPerdorues.Controls.Add(this.txtMbiemri);
            this.gbShtoPerdorues.Location = new System.Drawing.Point(21, 21);
            this.gbShtoPerdorues.Name = "gbShtoPerdorues";
            this.gbShtoPerdorues.Size = new System.Drawing.Size(556, 177);
            this.gbShtoPerdorues.TabIndex = 33;
            this.gbShtoPerdorues.Text = "Shto perdorues";
            this.gbShtoPerdorues.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
            // 
            // txtPerseritFjalekalimin
            // 
            this.txtPerseritFjalekalimin.Location = new System.Drawing.Point(397, 93);
            this.txtPerseritFjalekalimin.Name = "txtPerseritFjalekalimin";
            this.txtPerseritFjalekalimin.PasswordChar = '●';
            this.txtPerseritFjalekalimin.Size = new System.Drawing.Size(127, 20);
            this.txtPerseritFjalekalimin.TabIndex = 4;
            // 
            // lblMbiemri
            // 
            this.lblMbiemri.AutoSize = true;
            this.lblMbiemri.Location = new System.Drawing.Point(56, 68);
            this.lblMbiemri.Name = "lblMbiemri";
            this.lblMbiemri.Size = new System.Drawing.Size(43, 13);
            this.lblMbiemri.TabIndex = 37;
            this.lblMbiemri.Text = "Mbiemri";
            // 
            // lblEmerPerdoruesi
            // 
            this.lblEmerPerdoruesi.AutoSize = true;
            this.lblEmerPerdoruesi.Location = new System.Drawing.Point(295, 42);
            this.lblEmerPerdoruesi.Name = "lblEmerPerdoruesi";
            this.lblEmerPerdoruesi.Size = new System.Drawing.Size(87, 13);
            this.lblEmerPerdoruesi.TabIndex = 36;
            this.lblEmerPerdoruesi.Text = "Emri i perdoruesit";
            // 
            // lblFjalekalim
            // 
            this.lblFjalekalim.AutoSize = true;
            this.lblFjalekalim.Location = new System.Drawing.Point(327, 68);
            this.lblFjalekalim.Name = "lblFjalekalim";
            this.lblFjalekalim.Size = new System.Drawing.Size(55, 13);
            this.lblFjalekalim.TabIndex = 35;
            this.lblFjalekalim.Text = "Fjalekalimi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(276, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Perserisni fjalekalimin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(297, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Roli i perdoruesit";
            // 
            // txtFjalekalim
            // 
            this.txtFjalekalim.Location = new System.Drawing.Point(397, 65);
            this.txtFjalekalim.Name = "txtFjalekalim";
            this.txtFjalekalim.PasswordChar = '●';
            this.txtFjalekalim.Size = new System.Drawing.Size(127, 20);
            this.txtFjalekalim.TabIndex = 3;
            // 
            // txtEmri
            // 
            this.txtEmri.Location = new System.Drawing.Point(114, 39);
            this.txtEmri.Name = "txtEmri";
            this.txtEmri.Size = new System.Drawing.Size(127, 20);
            this.txtEmri.TabIndex = 0;
            // 
            // cmbRoli
            // 
            this.cmbRoli.DataSource = this.dsPerdorues;
            this.cmbRoli.DisplayMember = "ROLE_PERDORUES.EMER_ROLI";
            this.cmbRoli.FormattingEnabled = true;
            this.cmbRoli.Location = new System.Drawing.Point(397, 119);
            this.cmbRoli.Name = "cmbRoli";
            this.cmbRoli.Size = new System.Drawing.Size(127, 21);
            this.cmbRoli.TabIndex = 5;
            this.cmbRoli.ValueMember = "ROLE_PERDORUES.ID_ROLI";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(397, 39);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(127, 20);
            this.txtUserName.TabIndex = 2;
            // 
            // lblEmri
            // 
            this.lblEmri.AutoSize = true;
            this.lblEmri.Location = new System.Drawing.Point(72, 42);
            this.lblEmri.Name = "lblEmri";
            this.lblEmri.Size = new System.Drawing.Size(27, 13);
            this.lblEmri.TabIndex = 28;
            this.lblEmri.Text = "Emri";
            // 
            // txtMbiemri
            // 
            this.txtMbiemri.Location = new System.Drawing.Point(114, 65);
            this.txtMbiemri.Name = "txtMbiemri";
            this.txtMbiemri.Size = new System.Drawing.Size(127, 20);
            this.txtMbiemri.TabIndex = 1;
            // 
            // btnModifikoAksesor
            // 
            this.btnModifikoAksesor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModifikoAksesor.Location = new System.Drawing.Point(619, 288);
            this.btnModifikoAksesor.Name = "btnModifikoAksesor";
            this.btnModifikoAksesor.Size = new System.Drawing.Size(75, 24);
            this.superTooltip1.SetSuperTooltip(this.btnModifikoAksesor, new DevComponents.DotNetBar.SuperTooltipInfo("Modifikon emrin ose cmimin e nje aksesori te profileve horizontale", "", "", null, null, DevComponents.DotNetBar.eTooltipColor.Gray));
            this.btnModifikoAksesor.TabIndex = 14;
            this.btnModifikoAksesor.TeDrejta = PespaSistemLibrary.Button.teDrejta.all;
            this.btnModifikoAksesor.Text = "Modifiko";
            this.btnModifikoAksesor.Click += new System.EventHandler(this.btnModifikoAksesor_Click);
            // 
            // perdoruesTableAdapter
            // 
            this.perdoruesTableAdapter.ClearBeforeFill = true;
            // 
            // rolePerdoruesTableAdapter
            // 
            this.rolePerdoruesTableAdapter.ClearBeforeFill = true;
            // 
            // FrmPerdorues
            // 
            this.ClientSize = new System.Drawing.Size(1036, 520);
            this.Controls.Add(this.expandablePanel2);
            this.Name = "FrmPerdorues";
            this.Load += new System.EventHandler(this.FrmPerdorues_Load);
            this.Controls.SetChildIndex(this.expandablePanel2, 0);
            this.expandablePanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox1)).EndInit();
            this.uiGroupBox1.ResumeLayout(false);
            this.uiGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsPerdorues)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbShtoPerdorues)).EndInit();
            this.gbShtoPerdorues.ResumeLayout(false);
            this.gbShtoPerdorues.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ExpandablePanel expandablePanel2;
        private Janus.Windows.EditControls.UIGroupBox gbShtoPerdorues;
        private System.Windows.Forms.ComboBox cmbRoli;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblEmri;
        private System.Windows.Forms.TextBox txtMbiemri;
        private PespaSistemLibrary.Button btnModifikoAksesor;
        private System.Windows.Forms.TextBox txtEmri;
        private System.Windows.Forms.Label lblMbiemri;
        private System.Windows.Forms.Label lblEmerPerdoruesi;
        private System.Windows.Forms.Label lblFjalekalim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFjalekalim;
        private PespaSistemLibrary.Button btnShto;
        private System.Windows.Forms.TextBox txtPerseritFjalekalimin;
        private Janus.Windows.EditControls.UIGroupBox uiGroupBox1;
        private System.Windows.Forms.TextBox txtPersFjalekalimModifiko;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFjalekalimModifiko;
        private System.Windows.Forms.TextBox txtEmerModifiko;
        private System.Windows.Forms.ComboBox cmbRoliModifiko;
        private System.Windows.Forms.TextBox txtPerdoruesModifiko;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMbiemerModifiko;
        private DsPerdorues dsPerdorues;
        private PespaSistem.DsPerdoruesTableAdapters.PERDORUESTableAdapter perdoruesTableAdapter;
        private PespaSistem.DsPerdoruesTableAdapters.ROLE_PERDORUESTableAdapter rolePerdoruesTableAdapter;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox1;
        private PespaSistemLibrary.Button btnElemino;
    }
}
