namespace PespaSistem
{
    partial class FrmShtoProduktAksesore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmShtoProduktAksesore));
            this.btnOK = new PespaSistemLibrary.Button(this.components);
            this.gbPermasat = new Janus.Windows.EditControls.UIGroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKerkoLloj = new PespaSistemLibrary.Button(this.components);
            this.cmbLloji = new System.Windows.Forms.ComboBox();
            this.btnKerkoEmer = new PespaSistemLibrary.Button(this.components);
            this.txtEmri = new System.Windows.Forms.TextBox();
            this.txtKodi = new System.Windows.Forms.TextBox();
            this.btnKerkoKod = new PespaSistemLibrary.Button(this.components);
            this.dgAksesore = new Janus.Windows.GridEX.GridEX();
            this.dsShtoAksesoreProdukti = new PespaSistem.DsShtoAksesoreProdukti();
            this.numSasia = new System.Windows.Forms.NumericUpDown();
            this.lblKodi = new System.Windows.Forms.Label();
            this.lblEmri = new System.Windows.Forms.Label();
            this.aksesoreTotalTableAdapter = new PespaSistem.DsShtoAksesoreProduktiTableAdapters.AKSESORE_TOTALTableAdapter();
            this.btnAnullo = new PespaSistemLibrary.Button(this.components);
            this.lblSasia = new System.Windows.Forms.Label();
            this.txtKodSasia = new System.Windows.Forms.TextBox();
            this.txtEmerSasia = new System.Windows.Forms.TextBox();
            this.lblEmerSasia = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gbPermasat)).BeginInit();
            this.gbPermasat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAksesore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsShtoAksesoreProdukti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSasia)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(571, 185);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 49;
            this.btnOK.TeDrejta = PespaSistemLibrary.Button.teDrejta.all;
            this.btnOK.Text = "OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // gbPermasat
            // 
            this.gbPermasat.Controls.Add(this.label3);
            this.gbPermasat.Controls.Add(this.lblEmerSasia);
            this.gbPermasat.Controls.Add(this.txtKodSasia);
            this.gbPermasat.Controls.Add(this.txtEmerSasia);
            this.gbPermasat.Controls.Add(this.lblSasia);
            this.gbPermasat.Controls.Add(this.label1);
            this.gbPermasat.Controls.Add(this.btnKerkoLloj);
            this.gbPermasat.Controls.Add(this.cmbLloji);
            this.gbPermasat.Controls.Add(this.btnKerkoEmer);
            this.gbPermasat.Controls.Add(this.txtEmri);
            this.gbPermasat.Controls.Add(this.txtKodi);
            this.gbPermasat.Controls.Add(this.btnKerkoKod);
            this.gbPermasat.Controls.Add(this.dgAksesore);
            this.gbPermasat.Controls.Add(this.numSasia);
            this.gbPermasat.Controls.Add(this.lblKodi);
            this.gbPermasat.Controls.Add(this.lblEmri);
            this.gbPermasat.Location = new System.Drawing.Point(12, 43);
            this.gbPermasat.Name = "gbPermasat";
            this.gbPermasat.Size = new System.Drawing.Size(530, 405);
            this.gbPermasat.TabIndex = 48;
            this.gbPermasat.Text = "Aksesoret";
            this.gbPermasat.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(294, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 56;
            this.label1.Text = "Lloji";
            // 
            // btnKerkoLloj
            // 
            this.btnKerkoLloj.Image = global::PespaSistem.Properties.Resources.search_32;
            this.btnKerkoLloj.Location = new System.Drawing.Point(461, 21);
            this.btnKerkoLloj.Name = "btnKerkoLloj";
            this.btnKerkoLloj.Size = new System.Drawing.Size(29, 20);
            this.superTooltip1.SetSuperTooltip(this.btnKerkoLloj, new DevComponents.DotNetBar.SuperTooltipInfo("Kerko sipas llojit te aksesoreve", "", "", null, null, DevComponents.DotNetBar.eTooltipColor.Gray));
            this.btnKerkoLloj.TabIndex = 55;
            this.btnKerkoLloj.TeDrejta = PespaSistemLibrary.Button.teDrejta.all;
            this.btnKerkoLloj.Click += new System.EventHandler(this.btnKerkoLloj_Click);
            // 
            // cmbLloji
            // 
            this.cmbLloji.FormattingEnabled = true;
            this.cmbLloji.Items.AddRange(new object[] {
            "Alumin",
            "Aksesore",
            "Xham"});
            this.cmbLloji.Location = new System.Drawing.Point(328, 20);
            this.cmbLloji.Name = "cmbLloji";
            this.cmbLloji.Size = new System.Drawing.Size(127, 21);
            this.cmbLloji.TabIndex = 54;
            // 
            // btnKerkoEmer
            // 
            this.btnKerkoEmer.Image = global::PespaSistem.Properties.Resources.search_32;
            this.btnKerkoEmer.Location = new System.Drawing.Point(180, 47);
            this.btnKerkoEmer.Name = "btnKerkoEmer";
            this.btnKerkoEmer.Size = new System.Drawing.Size(29, 20);
            this.superTooltip1.SetSuperTooltip(this.btnKerkoEmer, new DevComponents.DotNetBar.SuperTooltipInfo("Kerko sipas emrit", "", "", null, null, DevComponents.DotNetBar.eTooltipColor.Gray));
            this.btnKerkoEmer.TabIndex = 53;
            this.btnKerkoEmer.TeDrejta = PespaSistemLibrary.Button.teDrejta.all;
            this.btnKerkoEmer.Click += new System.EventHandler(this.btnKerkoEmer_Click);
            // 
            // txtEmri
            // 
            this.txtEmri.Location = new System.Drawing.Point(47, 46);
            this.txtEmri.Name = "txtEmri";
            this.txtEmri.Size = new System.Drawing.Size(127, 20);
            this.txtEmri.TabIndex = 52;
            // 
            // txtKodi
            // 
            this.txtKodi.Location = new System.Drawing.Point(47, 21);
            this.txtKodi.Name = "txtKodi";
            this.txtKodi.Size = new System.Drawing.Size(127, 20);
            this.txtKodi.TabIndex = 51;
            // 
            // btnKerkoKod
            // 
            this.btnKerkoKod.Image = global::PespaSistem.Properties.Resources.search_32;
            this.btnKerkoKod.Location = new System.Drawing.Point(180, 21);
            this.btnKerkoKod.Name = "btnKerkoKod";
            this.btnKerkoKod.Size = new System.Drawing.Size(29, 20);
            this.superTooltip1.SetSuperTooltip(this.btnKerkoKod, new DevComponents.DotNetBar.SuperTooltipInfo("Kerko sipas kodit", "", "", null, null, DevComponents.DotNetBar.eTooltipColor.Gray));
            this.btnKerkoKod.TabIndex = 50;
            this.btnKerkoKod.TeDrejta = PespaSistemLibrary.Button.teDrejta.all;
            this.btnKerkoKod.Click += new System.EventHandler(this.btnKerkoKod_Click);
            // 
            // dgAksesore
            // 
            this.dgAksesore.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.dgAksesore.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgAksesore.DataMember = "AKSESORE_TOTAL";
            this.dgAksesore.DataSource = this.dsShtoAksesoreProdukti;
            this.dgAksesore.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
            this.dgAksesore.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.dgAksesore.GroupByBoxVisible = false;
            this.dgAksesore.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
            this.dgAksesore.LayoutData = resources.GetString("dgAksesore.LayoutData");
            this.dgAksesore.Location = new System.Drawing.Point(11, 101);
            this.dgAksesore.Name = "dgAksesore";
            this.dgAksesore.Size = new System.Drawing.Size(485, 246);
            this.dgAksesore.TabIndex = 48;
            this.dgAksesore.DoubleClick += new System.EventHandler(this.dgAksesore_DoubleClick);
            // 
            // dsShtoAksesoreProdukti
            // 
            this.dsShtoAksesoreProdukti.DataSetName = "DsShtoAksesoreProdukti";
            this.dsShtoAksesoreProdukti.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // numSasia
            // 
            this.numSasia.DecimalPlaces = 2;
            this.numSasia.Location = new System.Drawing.Point(352, 377);
            this.numSasia.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numSasia.Name = "numSasia";
            this.numSasia.Size = new System.Drawing.Size(120, 20);
            this.numSasia.TabIndex = 1;
            this.numSasia.Validated += new System.EventHandler(this.numSasia_Validated);
            // 
            // lblKodi
            // 
            this.lblKodi.AutoSize = true;
            this.lblKodi.Location = new System.Drawing.Point(13, 24);
            this.lblKodi.Name = "lblKodi";
            this.lblKodi.Size = new System.Drawing.Size(28, 13);
            this.lblKodi.TabIndex = 42;
            this.lblKodi.Text = "Kodi";
            // 
            // lblEmri
            // 
            this.lblEmri.AutoSize = true;
            this.lblEmri.Location = new System.Drawing.Point(14, 49);
            this.lblEmri.Name = "lblEmri";
            this.lblEmri.Size = new System.Drawing.Size(27, 13);
            this.lblEmri.TabIndex = 43;
            this.lblEmri.Text = "Emri";
            // 
            // aksesoreTotalTableAdapter
            // 
            this.aksesoreTotalTableAdapter.ClearBeforeFill = true;
            // 
            // btnAnullo
            // 
            this.btnAnullo.Location = new System.Drawing.Point(571, 227);
            this.btnAnullo.Name = "btnAnullo";
            this.btnAnullo.Size = new System.Drawing.Size(75, 23);
            this.btnAnullo.TabIndex = 50;
            this.btnAnullo.TeDrejta = PespaSistemLibrary.Button.teDrejta.all;
            this.btnAnullo.Text = "Anullo";
            this.btnAnullo.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblSasia
            // 
            this.lblSasia.AutoSize = true;
            this.lblSasia.Location = new System.Drawing.Point(349, 360);
            this.lblSasia.Name = "lblSasia";
            this.lblSasia.Size = new System.Drawing.Size(33, 13);
            this.lblSasia.TabIndex = 57;
            this.lblSasia.Text = "Sasia";
            // 
            // txtKodSasia
            // 
            this.txtKodSasia.Location = new System.Drawing.Point(17, 376);
            this.txtKodSasia.Name = "txtKodSasia";
            this.txtKodSasia.ReadOnly = true;
            this.txtKodSasia.Size = new System.Drawing.Size(127, 20);
            this.txtKodSasia.TabIndex = 59;
            // 
            // txtEmerSasia
            // 
            this.txtEmerSasia.Location = new System.Drawing.Point(180, 376);
            this.txtEmerSasia.Name = "txtEmerSasia";
            this.txtEmerSasia.ReadOnly = true;
            this.txtEmerSasia.Size = new System.Drawing.Size(127, 20);
            this.txtEmerSasia.TabIndex = 58;
            // 
            // lblEmerSasia
            // 
            this.lblEmerSasia.AutoSize = true;
            this.lblEmerSasia.Location = new System.Drawing.Point(177, 360);
            this.lblEmerSasia.Name = "lblEmerSasia";
            this.lblEmerSasia.Size = new System.Drawing.Size(27, 13);
            this.lblEmerSasia.TabIndex = 60;
            this.lblEmerSasia.Text = "Emri";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 360);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 61;
            this.label3.Text = "Kodi";
            // 
            // FrmShtoProduktAksesore
            // 
            this.AutoScroll = false;
            this.ClientSize = new System.Drawing.Size(713, 460);
            this.Controls.Add(this.btnAnullo);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.gbPermasat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmShtoProduktAksesore";
            this.ShowInTaskbar = false;
            this.Text = "Shto aksesore te rinj per produktin ne projekt";
            this.Load += new System.EventHandler(this.FrmShtoProduktAksesore_Load);
            this.Controls.SetChildIndex(this.gbPermasat, 0);
            this.Controls.SetChildIndex(this.btnOK, 0);
            this.Controls.SetChildIndex(this.btnAnullo, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gbPermasat)).EndInit();
            this.gbPermasat.ResumeLayout(false);
            this.gbPermasat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAksesore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsShtoAksesoreProdukti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSasia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PespaSistemLibrary.Button btnOK;
        private Janus.Windows.EditControls.UIGroupBox gbPermasat;
        private System.Windows.Forms.NumericUpDown numSasia;
        private System.Windows.Forms.Label lblKodi;
        private System.Windows.Forms.Label lblEmri;
        private Janus.Windows.GridEX.GridEX dgAksesore;
        private DsShtoAksesoreProdukti dsShtoAksesoreProdukti;
        private PespaSistemLibrary.Button btnKerkoKod;
        private PespaSistem.DsShtoAksesoreProduktiTableAdapters.AKSESORE_TOTALTableAdapter aksesoreTotalTableAdapter;
        private PespaSistemLibrary.Button btnAnullo;
        private System.Windows.Forms.TextBox txtEmri;
        private System.Windows.Forms.TextBox txtKodi;
        private PespaSistemLibrary.Button btnKerkoEmer;
        private System.Windows.Forms.Label label1;
        private PespaSistemLibrary.Button btnKerkoLloj;
        private System.Windows.Forms.ComboBox cmbLloji;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblEmerSasia;
        private System.Windows.Forms.TextBox txtKodSasia;
        private System.Windows.Forms.TextBox txtEmerSasia;
        private System.Windows.Forms.Label lblSasia;
    }
}
