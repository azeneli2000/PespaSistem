namespace PespaSistem
{
    partial class FrmStatistika
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
            this.btnPrinto = new PespaSistemLibrary.Button(this.components);
            this.gbStatistikat = new Janus.Windows.EditControls.UIGroupBox();
            this.dgStatistikat = new System.Windows.Forms.DataGridView();
            this.iDPROJEKTIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMERPROJEKTIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATAPROJEKTIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pREVENTIVIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vLERAREALEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDiferenca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsPespaSistem = new PespaSistem.DsPespaSistem();
            this.btnKerko = new PespaSistemLibrary.Button(this.components);
            this.gbKerkimi = new Janus.Windows.EditControls.UIGroupBox();
            this.txtEmerProjekti = new System.Windows.Forms.TextBox();
            this.lblDateFillimi = new System.Windows.Forms.Label();
            this.lblDateMbarimi = new System.Windows.Forms.Label();
            this.dtpDateFillimi = new System.Windows.Forms.DateTimePicker();
            this.dtpDateMbarimi = new System.Windows.Forms.DateTimePicker();
            this.rbEmerProjekti = new System.Windows.Forms.RadioButton();
            this.rbData = new System.Windows.Forms.RadioButton();
            this.projekteTableAdapter = new PespaSistem.DsPespaSistemTableAdapters.PROJEKTETableAdapter();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbStatistikat)).BeginInit();
            this.gbStatistikat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgStatistikat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPespaSistem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbKerkimi)).BeginInit();
            this.gbKerkimi.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.Controls.Add(this.btnPrinto);
            this.panelEx1.Controls.Add(this.gbStatistikat);
            this.panelEx1.Controls.Add(this.btnKerko);
            this.panelEx1.Controls.Add(this.gbKerkimi);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 26);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(1019, 614);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.panelEx1.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 4;
            // 
            // btnPrinto
            // 
            this.btnPrinto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrinto.Location = new System.Drawing.Point(731, 362);
            this.btnPrinto.Name = "btnPrinto";
            this.btnPrinto.Size = new System.Drawing.Size(75, 24);
            this.btnPrinto.TabIndex = 5;
            this.btnPrinto.TeDrejta = PespaSistemLibrary.Button.teDrejta.all;
            this.btnPrinto.Text = "Printo";
            this.btnPrinto.Click += new System.EventHandler(this.btnPrinto_Click);
            // 
            // gbStatistikat
            // 
            this.gbStatistikat.Controls.Add(this.dgStatistikat);
            this.gbStatistikat.Location = new System.Drawing.Point(19, 174);
            this.gbStatistikat.Name = "gbStatistikat";
            this.gbStatistikat.Size = new System.Drawing.Size(684, 385);
            this.gbStatistikat.TabIndex = 4;
            this.gbStatistikat.Text = "Statistikat";
            this.gbStatistikat.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
            // 
            // dgStatistikat
            // 
            this.dgStatistikat.AllowUserToAddRows = false;
            this.dgStatistikat.AllowUserToDeleteRows = false;
            this.dgStatistikat.AutoGenerateColumns = false;
            this.dgStatistikat.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgStatistikat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgStatistikat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDPROJEKTIDataGridViewTextBoxColumn,
            this.eMERPROJEKTIDataGridViewTextBoxColumn,
            this.dATAPROJEKTIDataGridViewTextBoxColumn,
            this.pREVENTIVIDataGridViewTextBoxColumn,
            this.vLERAREALEDataGridViewTextBoxColumn,
            this.ColDiferenca});
            this.dgStatistikat.DataMember = "PROJEKTE";
            this.dgStatistikat.DataSource = this.dsPespaSistem;
            this.dgStatistikat.Location = new System.Drawing.Point(9, 20);
            this.dgStatistikat.Name = "dgStatistikat";
            this.dgStatistikat.ReadOnly = true;
            this.dgStatistikat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgStatistikat.Size = new System.Drawing.Size(662, 344);
            this.dgStatistikat.TabIndex = 0;
            // 
            // iDPROJEKTIDataGridViewTextBoxColumn
            // 
            this.iDPROJEKTIDataGridViewTextBoxColumn.DataPropertyName = "ID_PROJEKTI";
            this.iDPROJEKTIDataGridViewTextBoxColumn.HeaderText = "ID_PROJEKTI";
            this.iDPROJEKTIDataGridViewTextBoxColumn.Name = "iDPROJEKTIDataGridViewTextBoxColumn";
            this.iDPROJEKTIDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDPROJEKTIDataGridViewTextBoxColumn.Visible = false;
            this.iDPROJEKTIDataGridViewTextBoxColumn.Width = 5;
            // 
            // eMERPROJEKTIDataGridViewTextBoxColumn
            // 
            this.eMERPROJEKTIDataGridViewTextBoxColumn.DataPropertyName = "EMER_PROJEKTI";
            this.eMERPROJEKTIDataGridViewTextBoxColumn.HeaderText = "Projekti";
            this.eMERPROJEKTIDataGridViewTextBoxColumn.Name = "eMERPROJEKTIDataGridViewTextBoxColumn";
            this.eMERPROJEKTIDataGridViewTextBoxColumn.ReadOnly = true;
            this.eMERPROJEKTIDataGridViewTextBoxColumn.Width = 180;
            // 
            // dATAPROJEKTIDataGridViewTextBoxColumn
            // 
            this.dATAPROJEKTIDataGridViewTextBoxColumn.DataPropertyName = "DATA_PROJEKTI";
            this.dATAPROJEKTIDataGridViewTextBoxColumn.HeaderText = "Data e projektit";
            this.dATAPROJEKTIDataGridViewTextBoxColumn.Name = "dATAPROJEKTIDataGridViewTextBoxColumn";
            this.dATAPROJEKTIDataGridViewTextBoxColumn.ReadOnly = true;
            this.dATAPROJEKTIDataGridViewTextBoxColumn.Width = 145;
            // 
            // pREVENTIVIDataGridViewTextBoxColumn
            // 
            this.pREVENTIVIDataGridViewTextBoxColumn.DataPropertyName = "PREVENTIVI";
            this.pREVENTIVIDataGridViewTextBoxColumn.HeaderText = "Preventivi";
            this.pREVENTIVIDataGridViewTextBoxColumn.Name = "pREVENTIVIDataGridViewTextBoxColumn";
            this.pREVENTIVIDataGridViewTextBoxColumn.ReadOnly = true;
            this.pREVENTIVIDataGridViewTextBoxColumn.Width = 98;
            // 
            // vLERAREALEDataGridViewTextBoxColumn
            // 
            this.vLERAREALEDataGridViewTextBoxColumn.DataPropertyName = "VLERA_REALE";
            this.vLERAREALEDataGridViewTextBoxColumn.HeaderText = "Vlera reale";
            this.vLERAREALEDataGridViewTextBoxColumn.Name = "vLERAREALEDataGridViewTextBoxColumn";
            this.vLERAREALEDataGridViewTextBoxColumn.ReadOnly = true;
            this.vLERAREALEDataGridViewTextBoxColumn.Width = 98;
            // 
            // ColDiferenca
            // 
            this.ColDiferenca.HeaderText = "Diferenca";
            this.ColDiferenca.Name = "ColDiferenca";
            this.ColDiferenca.ReadOnly = true;
            this.ColDiferenca.Width = 98;
            // 
            // dsPespaSistem
            // 
            this.dsPespaSistem.DataSetName = "DsPespaSistem";
            this.dsPespaSistem.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnKerko
            // 
            this.btnKerko.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKerko.Location = new System.Drawing.Point(616, 73);
            this.btnKerko.Name = "btnKerko";
            this.btnKerko.Size = new System.Drawing.Size(75, 24);
            this.btnKerko.TabIndex = 3;
            this.btnKerko.TeDrejta = PespaSistemLibrary.Button.teDrejta.all;
            this.btnKerko.Text = "Kerko";
            this.btnKerko.Click += new System.EventHandler(this.btnKerko_Click);
            // 
            // gbKerkimi
            // 
            this.gbKerkimi.Controls.Add(this.txtEmerProjekti);
            this.gbKerkimi.Controls.Add(this.lblDateFillimi);
            this.gbKerkimi.Controls.Add(this.lblDateMbarimi);
            this.gbKerkimi.Controls.Add(this.dtpDateFillimi);
            this.gbKerkimi.Controls.Add(this.dtpDateMbarimi);
            this.gbKerkimi.Controls.Add(this.rbEmerProjekti);
            this.gbKerkimi.Controls.Add(this.rbData);
            this.gbKerkimi.Location = new System.Drawing.Point(19, 20);
            this.gbKerkimi.Name = "gbKerkimi";
            this.gbKerkimi.Size = new System.Drawing.Size(531, 130);
            this.gbKerkimi.TabIndex = 0;
            this.gbKerkimi.Text = "Kerko sipas ...";
            this.gbKerkimi.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
            // 
            // txtEmerProjekti
            // 
            this.txtEmerProjekti.Location = new System.Drawing.Point(161, 83);
            this.txtEmerProjekti.Name = "txtEmerProjekti";
            this.txtEmerProjekti.Size = new System.Drawing.Size(149, 20);
            this.txtEmerProjekti.TabIndex = 7;
            // 
            // lblDateFillimi
            // 
            this.lblDateFillimi.AutoSize = true;
            this.lblDateFillimi.Location = new System.Drawing.Point(192, 24);
            this.lblDateFillimi.Name = "lblDateFillimi";
            this.lblDateFillimi.Size = new System.Drawing.Size(54, 13);
            this.lblDateFillimi.TabIndex = 6;
            this.lblDateFillimi.Text = "Date fillimi";
            // 
            // lblDateMbarimi
            // 
            this.lblDateMbarimi.AutoSize = true;
            this.lblDateMbarimi.Location = new System.Drawing.Point(363, 24);
            this.lblDateMbarimi.Name = "lblDateMbarimi";
            this.lblDateMbarimi.Size = new System.Drawing.Size(68, 13);
            this.lblDateMbarimi.TabIndex = 5;
            this.lblDateMbarimi.Text = "Date mbarimi";
            // 
            // dtpDateFillimi
            // 
            this.dtpDateFillimi.CustomFormat = "dd/MM/yyyy";
            this.dtpDateFillimi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateFillimi.Location = new System.Drawing.Point(161, 40);
            this.dtpDateFillimi.Name = "dtpDateFillimi";
            this.dtpDateFillimi.ShowUpDown = true;
            this.dtpDateFillimi.Size = new System.Drawing.Size(149, 20);
            this.dtpDateFillimi.TabIndex = 4;
            // 
            // dtpDateMbarimi
            // 
            this.dtpDateMbarimi.CustomFormat = "dd/MM/yyyy";
            this.dtpDateMbarimi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateMbarimi.Location = new System.Drawing.Point(336, 40);
            this.dtpDateMbarimi.Name = "dtpDateMbarimi";
            this.dtpDateMbarimi.ShowUpDown = true;
            this.dtpDateMbarimi.Size = new System.Drawing.Size(149, 20);
            this.dtpDateMbarimi.TabIndex = 3;
            // 
            // rbEmerProjekti
            // 
            this.rbEmerProjekti.AutoSize = true;
            this.rbEmerProjekti.Location = new System.Drawing.Point(18, 84);
            this.rbEmerProjekti.Name = "rbEmerProjekti";
            this.rbEmerProjekti.Size = new System.Drawing.Size(100, 17);
            this.rbEmerProjekti.TabIndex = 2;
            this.rbEmerProjekti.Text = "Emrit te projektit";
            this.rbEmerProjekti.UseVisualStyleBackColor = true;
            this.rbEmerProjekti.CheckedChanged += new System.EventHandler(this.rbFatureDetajuar_CheckedChanged);
            // 
            // rbData
            // 
            this.rbData.AutoSize = true;
            this.rbData.Checked = true;
            this.rbData.Location = new System.Drawing.Point(18, 40);
            this.rbData.Name = "rbData";
            this.rbData.Size = new System.Drawing.Size(53, 17);
            this.rbData.TabIndex = 1;
            this.rbData.TabStop = true;
            this.rbData.Text = "Dates";
            this.rbData.UseVisualStyleBackColor = true;
            // 
            // projekteTableAdapter
            // 
            this.projekteTableAdapter.ClearBeforeFill = true;
            // 
            // printDialog
            // 
            this.printDialog.UseEXDialog = true;
            // 
            // FrmStatistika
            // 
            this.ClientSize = new System.Drawing.Size(1036, 557);
            this.Controls.Add(this.panelEx1);
            this.Name = "FrmStatistika";
            this.Text = "Statistikat";
            this.Load += new System.EventHandler(this.FrmStatistika_Load);
            this.Controls.SetChildIndex(this.panelEx1, 0);
            this.panelEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gbStatistikat)).EndInit();
            this.gbStatistikat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgStatistikat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPespaSistem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbKerkimi)).EndInit();
            this.gbKerkimi.ResumeLayout(false);
            this.gbKerkimi.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private PespaSistemLibrary.Button btnKerko;
        private Janus.Windows.EditControls.UIGroupBox gbKerkimi;
        private System.Windows.Forms.RadioButton rbEmerProjekti;
        private System.Windows.Forms.RadioButton rbData;
        private System.Windows.Forms.Label lblDateFillimi;
        private System.Windows.Forms.Label lblDateMbarimi;
        private System.Windows.Forms.DateTimePicker dtpDateFillimi;
        private System.Windows.Forms.DateTimePicker dtpDateMbarimi;
        private System.Windows.Forms.TextBox txtEmerProjekti;
        private Janus.Windows.EditControls.UIGroupBox gbStatistikat;
        private System.Windows.Forms.DataGridView dgStatistikat;
        private DsPespaSistem dsPespaSistem;
        private PespaSistem.DsPespaSistemTableAdapters.PROJEKTETableAdapter projekteTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPROJEKTIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMERPROJEKTIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATAPROJEKTIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pREVENTIVIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vLERAREALEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDiferenca;
        private PespaSistemLibrary.Button btnPrinto;
        private System.Windows.Forms.PrintDialog printDialog;
    }
}
