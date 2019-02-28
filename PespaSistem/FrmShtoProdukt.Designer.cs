namespace PespaSistem
{
    partial class FrmShtoProdukt
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
            this.btnShto = new PespaSistemLibrary.Button(this.components);
            this.gbLlojeProdukte = new Janus.Windows.EditControls.UIGroupBox();
            this.cmbLlojProduktesh = new System.Windows.Forms.ComboBox();
            this.dsLlojeProduktesh = new PespaSistem.DsLlojeProduktesh();
            this.lblLlojProduktesh = new System.Windows.Forms.Label();
            this.lbLlojSistemesh = new System.Windows.Forms.ListBox();
            this.txtProdukti = new System.Windows.Forms.TextBox();
            this.lblLlojSistemesh = new System.Windows.Forms.Label();
            this.lblProdukteSpecifike = new System.Windows.Forms.Label();
            this.expandablePanel2 = new DevComponents.DotNetBar.ExpandablePanel();
            this.btnModifiko = new PespaSistemLibrary.Button(this.components);
            this.uiGroupBox1 = new Janus.Windows.EditControls.UIGroupBox();
            this.dgProdukte = new System.Windows.Forms.DataGridView();
            this.llojSistemiTableAdapter = new PespaSistem.DsLlojeProdukteshTableAdapters.LLOJ_SISTEMITableAdapter();
            this.produkteTableAdapter = new PespaSistem.DsLlojeProdukteshTableAdapters.PRODUKTETableAdapter();
            this.llojProduktiTableAdapter = new PespaSistem.DsLlojeProdukteshTableAdapters.LLOJ_PRODUKTITableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gbLlojeProdukte)).BeginInit();
            this.gbLlojeProdukte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsLlojeProduktesh)).BeginInit();
            this.expandablePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox1)).BeginInit();
            this.uiGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProdukte)).BeginInit();
            this.SuspendLayout();
            // 
            // btnShto
            // 
            this.btnShto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShto.Location = new System.Drawing.Point(597, 110);
            this.btnShto.Name = "btnShto";
            this.btnShto.Size = new System.Drawing.Size(75, 24);
            this.superTooltip1.SetSuperTooltip(this.btnShto, new DevComponents.DotNetBar.SuperTooltipInfo("Shton nje produkt te ri", "", "", null, null, DevComponents.DotNetBar.eTooltipColor.Gray));
            this.btnShto.TabIndex = 4;
            this.btnShto.TeDrejta = PespaSistemLibrary.Button.teDrejta.all;
            this.btnShto.Text = "Shto";
            this.btnShto.Click += new System.EventHandler(this.btnShto_Click);
            // 
            // gbLlojeProdukte
            // 
            this.gbLlojeProdukte.Controls.Add(this.cmbLlojProduktesh);
            this.gbLlojeProdukte.Controls.Add(this.lblLlojProduktesh);
            this.gbLlojeProdukte.Controls.Add(this.lbLlojSistemesh);
            this.gbLlojeProdukte.Controls.Add(this.txtProdukti);
            this.gbLlojeProdukte.Controls.Add(this.lblLlojSistemesh);
            this.gbLlojeProdukte.Controls.Add(this.lblProdukteSpecifike);
            this.gbLlojeProdukte.Location = new System.Drawing.Point(35, 62);
            this.gbLlojeProdukte.Name = "gbLlojeProdukte";
            this.gbLlojeProdukte.Size = new System.Drawing.Size(506, 137);
            this.gbLlojeProdukte.TabIndex = 41;
            this.gbLlojeProdukte.Text = "Shto produkte";
            this.gbLlojeProdukte.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
            // 
            // cmbLlojProduktesh
            // 
            this.cmbLlojProduktesh.DataSource = this.dsLlojeProduktesh;
            this.cmbLlojProduktesh.DisplayMember = "LLOJ_PRODUKTI.LLOJ_PRODUKTI";
            this.cmbLlojProduktesh.FormattingEnabled = true;
            this.cmbLlojProduktesh.Location = new System.Drawing.Point(192, 32);
            this.cmbLlojProduktesh.Name = "cmbLlojProduktesh";
            this.cmbLlojProduktesh.Size = new System.Drawing.Size(121, 21);
            this.cmbLlojProduktesh.TabIndex = 2;
            this.cmbLlojProduktesh.ValueMember = "LLOJ_PRODUKTI.ID_LLOJ_PRODUKTI";
            // 
            // dsLlojeProduktesh
            // 
            this.dsLlojeProduktesh.DataSetName = "DsLlojeProduktesh";
            this.dsLlojeProduktesh.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblLlojProduktesh
            // 
            this.lblLlojProduktesh.AutoSize = true;
            this.lblLlojProduktesh.Location = new System.Drawing.Point(203, 16);
            this.lblLlojProduktesh.Name = "lblLlojProduktesh";
            this.lblLlojProduktesh.Size = new System.Drawing.Size(98, 13);
            this.lblLlojProduktesh.TabIndex = 41;
            this.lblLlojProduktesh.Text = "Llojet e produkteve";
            // 
            // lbLlojSistemesh
            // 
            this.lbLlojSistemesh.DataSource = this.dsLlojeProduktesh;
            this.lbLlojSistemesh.DisplayMember = "LLOJ_SISTEMI.LLOJ_SISTEMI";
            this.lbLlojSistemesh.FormattingEnabled = true;
            this.lbLlojSistemesh.Location = new System.Drawing.Point(365, 32);
            this.lbLlojSistemesh.Name = "lbLlojSistemesh";
            this.lbLlojSistemesh.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbLlojSistemesh.Size = new System.Drawing.Size(121, 95);
            this.lbLlojSistemesh.TabIndex = 3;
            this.lbLlojSistemesh.ValueMember = "LLOJ_SISTEMI.ID_LLOJ_SISTEMI";
            // 
            // txtProdukti
            // 
            this.txtProdukti.Location = new System.Drawing.Point(14, 32);
            this.txtProdukti.Name = "txtProdukti";
            this.txtProdukti.Size = new System.Drawing.Size(121, 20);
            this.txtProdukti.TabIndex = 1;
            // 
            // lblLlojSistemesh
            // 
            this.lblLlojSistemesh.AutoSize = true;
            this.lblLlojSistemesh.Location = new System.Drawing.Point(376, 16);
            this.lblLlojSistemesh.Name = "lblLlojSistemesh";
            this.lblLlojSistemesh.Size = new System.Drawing.Size(91, 13);
            this.lblLlojSistemesh.TabIndex = 39;
            this.lblLlojSistemesh.Text = "Llojet e sistemeve";
            // 
            // lblProdukteSpecifike
            // 
            this.lblProdukteSpecifike.AutoSize = true;
            this.lblProdukteSpecifike.Location = new System.Drawing.Point(30, 16);
            this.lblProdukteSpecifike.Name = "lblProdukteSpecifike";
            this.lblProdukteSpecifike.Size = new System.Drawing.Size(76, 13);
            this.lblProdukteSpecifike.TabIndex = 38;
            this.lblProdukteSpecifike.Text = "Emri i produktit";
            // 
            // expandablePanel2
            // 
            this.expandablePanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.expandablePanel2.Controls.Add(this.btnModifiko);
            this.expandablePanel2.Controls.Add(this.uiGroupBox1);
            this.expandablePanel2.Controls.Add(this.gbLlojeProdukte);
            this.expandablePanel2.Controls.Add(this.btnShto);
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
            // btnModifiko
            // 
            this.btnModifiko.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModifiko.Location = new System.Drawing.Point(597, 149);
            this.btnModifiko.Name = "btnModifiko";
            this.btnModifiko.Size = new System.Drawing.Size(75, 24);
            this.superTooltip1.SetSuperTooltip(this.btnModifiko, new DevComponents.DotNetBar.SuperTooltipInfo("Modifikon emrin e nje produkti", "", "", null, null, DevComponents.DotNetBar.eTooltipColor.Gray));
            this.btnModifiko.TabIndex = 44;
            this.btnModifiko.TeDrejta = PespaSistemLibrary.Button.teDrejta.all;
            this.btnModifiko.Text = "Modifiko";
            this.btnModifiko.Click += new System.EventHandler(this.btnModifiko_Click);
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.Controls.Add(this.dgProdukte);
            this.uiGroupBox1.Location = new System.Drawing.Point(35, 223);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.Size = new System.Drawing.Size(506, 187);
            this.uiGroupBox1.TabIndex = 43;
            this.uiGroupBox1.Text = "Produktet";
            this.uiGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
            // 
            // dgProdukte
            // 
            this.dgProdukte.AllowUserToAddRows = false;
            this.dgProdukte.AllowUserToDeleteRows = false;
            this.dgProdukte.AutoGenerateColumns = false;
            this.dgProdukte.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgProdukte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProdukte.DataSource = this.dsLlojeProduktesh;
            this.dgProdukte.Location = new System.Drawing.Point(14, 25);
            this.dgProdukte.MultiSelect = false;
            this.dgProdukte.Name = "dgProdukte";
            this.dgProdukte.ReadOnly = true;
            this.dgProdukte.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgProdukte.Size = new System.Drawing.Size(472, 150);
            this.superTooltip1.SetSuperTooltip(this.dgProdukte, new DevComponents.DotNetBar.SuperTooltipInfo("Kliko dy here mbi nje rresht qe te modifikoni emrin e produktit", "", "", null, null, DevComponents.DotNetBar.eTooltipColor.Gray));
            this.dgProdukte.TabIndex = 42;
            this.dgProdukte.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgProdukte_CellDoubleClick);
            // 
            // llojSistemiTableAdapter
            // 
            this.llojSistemiTableAdapter.ClearBeforeFill = true;
            // 
            // produkteTableAdapter
            // 
            this.produkteTableAdapter.ClearBeforeFill = true;
            // 
            // llojProduktiTableAdapter
            // 
            this.llojProduktiTableAdapter.ClearBeforeFill = true;
            // 
            // FrmShtoProdukt
            // 
            this.ClientSize = new System.Drawing.Size(1036, 520);
            this.Controls.Add(this.expandablePanel2);
            this.Name = "FrmShtoProdukt";
            this.Text = "Shto produkte";
            this.Load += new System.EventHandler(this.FrmShtoProdukt_Load);
            this.Controls.SetChildIndex(this.expandablePanel2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gbLlojeProdukte)).EndInit();
            this.gbLlojeProdukte.ResumeLayout(false);
            this.gbLlojeProdukte.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsLlojeProduktesh)).EndInit();
            this.expandablePanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox1)).EndInit();
            this.uiGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgProdukte)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PespaSistemLibrary.Button btnShto;
        private Janus.Windows.EditControls.UIGroupBox gbLlojeProdukte;
        private System.Windows.Forms.Label lblLlojSistemesh;
        private System.Windows.Forms.Label lblProdukteSpecifike;
        private DevComponents.DotNetBar.ExpandablePanel expandablePanel2;
        private System.Windows.Forms.TextBox txtProdukti;
        private System.Windows.Forms.ComboBox cmbLlojProduktesh;
        private System.Windows.Forms.Label lblLlojProduktesh;
        private DsLlojeProduktesh dsLlojeProduktesh;
        private PespaSistem.DsLlojeProdukteshTableAdapters.LLOJ_SISTEMITableAdapter llojSistemiTableAdapter;
        private PespaSistem.DsLlojeProdukteshTableAdapters.PRODUKTETableAdapter produkteTableAdapter;
        private PespaSistem.DsLlojeProdukteshTableAdapters.LLOJ_PRODUKTITableAdapter llojProduktiTableAdapter;
        private System.Windows.Forms.ListBox lbLlojSistemesh;
        private System.Windows.Forms.DataGridView dgProdukte;
        private Janus.Windows.EditControls.UIGroupBox uiGroupBox1;
        private PespaSistemLibrary.Button btnModifiko;


    }
}
