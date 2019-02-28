namespace PespaSistem
{
    partial class KonfigurimeTeDrejtash
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
            this.expandablePanel2 = new DevComponents.DotNetBar.ExpandablePanel();
            this.btnRuaj = new PespaSistemLibrary.Button();
            this.gbKonfigurimDrejtash = new Janus.Windows.EditControls.UIGroupBox();
            this.btnKaloMajtas = new PespaSistemLibrary.Button();
            this.btnKaloDjathtas = new PespaSistemLibrary.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDrejtaMundshme = new System.Windows.Forms.Label();
            this.lbDrejta = new System.Windows.Forms.ListBox();
            this.lbDrejtaMundshme = new System.Windows.Forms.ListBox();
            this.dsRoleDrejtat = new PespaSistem.DsRoleDrejtat();
            this.lblEmri = new System.Windows.Forms.Label();
            this.cmbRolet = new System.Windows.Forms.ComboBox();
            this.teDrejtatTableAdapter = new PespaSistem.DsRoleDrejtatTableAdapters.TE_DREJTATTableAdapter();
            this.rolePerdoruesTableAdapter = new PespaSistem.DsRoleDrejtatTableAdapters.ROLE_PERDORUESTableAdapter();
            this.roleDrejtatTableAdapter = new PespaSistem.DsRoleDrejtatTableAdapters.ROLE_DREJTATTableAdapter();
            this.expandablePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbKonfigurimDrejtash)).BeginInit();
            this.gbKonfigurimDrejtash.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsRoleDrejtat)).BeginInit();
            this.SuspendLayout();
            // 
            // expandablePanel2
            // 
            this.expandablePanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.expandablePanel2.Controls.Add(this.btnRuaj);
            this.expandablePanel2.Controls.Add(this.gbKonfigurimDrejtash);
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
            this.expandablePanel2.TabIndex = 36;
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
            // btnRuaj
            // 
            this.btnRuaj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRuaj.Location = new System.Drawing.Point(305, 384);
            this.btnRuaj.Name = "btnRuaj";
            this.btnRuaj.Size = new System.Drawing.Size(75, 24);
            this.superTooltip1.SetSuperTooltip(this.btnRuaj, new DevComponents.DotNetBar.SuperTooltipInfo("Modifikon emrin ose cmimin e nje aksesori te profileve horizontale", "", "", null, null, DevComponents.DotNetBar.eTooltipColor.Gray));
            this.btnRuaj.TabIndex = 34;
            this.btnRuaj.Text = "&Ruaj";
            this.btnRuaj.Click += new System.EventHandler(this.btnRuaj_Click);
            // 
            // gbKonfigurimDrejtash
            // 
            this.gbKonfigurimDrejtash.BackColor = System.Drawing.Color.Transparent;
            this.gbKonfigurimDrejtash.Controls.Add(this.btnKaloMajtas);
            this.gbKonfigurimDrejtash.Controls.Add(this.btnKaloDjathtas);
            this.gbKonfigurimDrejtash.Controls.Add(this.label1);
            this.gbKonfigurimDrejtash.Controls.Add(this.lblDrejtaMundshme);
            this.gbKonfigurimDrejtash.Controls.Add(this.lbDrejta);
            this.gbKonfigurimDrejtash.Controls.Add(this.lbDrejtaMundshme);
            this.gbKonfigurimDrejtash.Controls.Add(this.lblEmri);
            this.gbKonfigurimDrejtash.Controls.Add(this.cmbRolet);
            this.gbKonfigurimDrejtash.Location = new System.Drawing.Point(21, 21);
            this.gbKonfigurimDrejtash.Name = "gbKonfigurimDrejtash";
            this.gbKonfigurimDrejtash.Size = new System.Drawing.Size(592, 331);
            this.gbKonfigurimDrejtash.TabIndex = 33;
            this.gbKonfigurimDrejtash.Text = "Konfigurimi i te drejtave";
            this.gbKonfigurimDrejtash.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
            // 
            // btnKaloMajtas
            // 
            this.btnKaloMajtas.Location = new System.Drawing.Point(334, 162);
            this.btnKaloMajtas.Name = "btnKaloMajtas";
            this.btnKaloMajtas.Size = new System.Drawing.Size(46, 23);
            this.btnKaloMajtas.TabIndex = 43;
            this.btnKaloMajtas.Text = "<<<";
            this.btnKaloMajtas.Click += new System.EventHandler(this.btnKaloMajtas_Click);
            // 
            // btnKaloDjathtas
            // 
            this.btnKaloDjathtas.Location = new System.Drawing.Point(334, 133);
            this.btnKaloDjathtas.Name = "btnKaloDjathtas";
            this.btnKaloDjathtas.Size = new System.Drawing.Size(46, 23);
            this.btnKaloDjathtas.TabIndex = 42;
            this.btnKaloDjathtas.Text = ">>>";
            this.btnKaloDjathtas.Click += new System.EventHandler(this.btnKaloDjathtas_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(395, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "Te drejtat e tanishme";
            // 
            // lblDrejtaMundshme
            // 
            this.lblDrejtaMundshme.AutoSize = true;
            this.lblDrejtaMundshme.Location = new System.Drawing.Point(196, 44);
            this.lblDrejtaMundshme.Name = "lblDrejtaMundshme";
            this.lblDrejtaMundshme.Size = new System.Drawing.Size(115, 13);
            this.lblDrejtaMundshme.TabIndex = 40;
            this.lblDrejtaMundshme.Text = "Te drejtat e mundshme";
            // 
            // lbDrejta
            // 
            this.lbDrejta.FormattingEnabled = true;
            this.lbDrejta.Location = new System.Drawing.Point(389, 60);
            this.lbDrejta.Name = "lbDrejta";
            this.lbDrejta.Size = new System.Drawing.Size(120, 225);
            this.lbDrejta.TabIndex = 39;
            // 
            // lbDrejtaMundshme
            // 
            this.lbDrejtaMundshme.DataSource = this.dsRoleDrejtat;
            this.lbDrejtaMundshme.DisplayMember = "TE_DREJTAT.EMER_DREJTA";
            this.lbDrejtaMundshme.FormattingEnabled = true;
            this.lbDrejtaMundshme.Location = new System.Drawing.Point(191, 60);
            this.lbDrejtaMundshme.Name = "lbDrejtaMundshme";
            this.lbDrejtaMundshme.Size = new System.Drawing.Size(129, 225);
            this.lbDrejtaMundshme.TabIndex = 37;
            this.lbDrejtaMundshme.ValueMember = "TE_DREJTAT.ID_DREJTA";
            // 
            // dsRoleDrejtat
            // 
            this.dsRoleDrejtat.DataSetName = "DsRoleDrejtat";
            this.dsRoleDrejtat.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblEmri
            // 
            this.lblEmri.AutoSize = true;
            this.lblEmri.Location = new System.Drawing.Point(48, 44);
            this.lblEmri.Name = "lblEmri";
            this.lblEmri.Size = new System.Drawing.Size(103, 13);
            this.lblEmri.TabIndex = 38;
            this.lblEmri.Text = "Rolet e perdoruesve";
            // 
            // cmbRolet
            // 
            this.cmbRolet.FormattingEnabled = true;
            this.cmbRolet.Items.AddRange(new object[] {
            "Perdorues",
            "Vizitor"});
            this.cmbRolet.Location = new System.Drawing.Point(42, 60);
            this.cmbRolet.Name = "cmbRolet";
            this.cmbRolet.Size = new System.Drawing.Size(121, 21);
            this.cmbRolet.TabIndex = 37;
            this.cmbRolet.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // teDrejtatTableAdapter
            // 
            this.teDrejtatTableAdapter.ClearBeforeFill = true;
            // 
            // rolePerdoruesTableAdapter
            // 
            this.rolePerdoruesTableAdapter.ClearBeforeFill = true;
            // 
            // roleDrejtatTableAdapter
            // 
            this.roleDrejtatTableAdapter.ClearBeforeFill = true;
            // 
            // KonfigurimeTeDrejtash
            // 
            this.ClientSize = new System.Drawing.Size(1036, 520);
            this.Controls.Add(this.expandablePanel2);
            this.Name = "KonfigurimeTeDrejtash";
            this.Text = "Konfigurime te drejtash";
            this.Load += new System.EventHandler(this.KonfigurimeTeDrejtash_Load);
            this.Controls.SetChildIndex(this.expandablePanel2, 0);
            this.expandablePanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gbKonfigurimDrejtash)).EndInit();
            this.gbKonfigurimDrejtash.ResumeLayout(false);
            this.gbKonfigurimDrejtash.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsRoleDrejtat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ExpandablePanel expandablePanel2;
        private PespaSistemLibrary.Button btnRuaj;
        private Janus.Windows.EditControls.UIGroupBox gbKonfigurimDrejtash;
        private System.Windows.Forms.ComboBox cmbRolet;
        private System.Windows.Forms.Label lblEmri;
        private PespaSistemLibrary.Button btnKaloMajtas;
        private PespaSistemLibrary.Button btnKaloDjathtas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDrejtaMundshme;
        private System.Windows.Forms.ListBox lbDrejta;
        private System.Windows.Forms.ListBox lbDrejtaMundshme;
        private DsRoleDrejtat dsRoleDrejtat;
        private PespaSistem.DsRoleDrejtatTableAdapters.TE_DREJTATTableAdapter teDrejtatTableAdapter;
        private PespaSistem.DsRoleDrejtatTableAdapters.ROLE_PERDORUESTableAdapter rolePerdoruesTableAdapter;
        private PespaSistem.DsRoleDrejtatTableAdapters.ROLE_DREJTATTableAdapter roleDrejtatTableAdapter;
    }
}
