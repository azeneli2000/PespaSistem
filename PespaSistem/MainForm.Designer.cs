namespace PespaSistem
{
    partial class MainForm
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
            this.tabStrip1 = new DevComponents.DotNetBar.TabStrip();
            this.docManager = new DocumentManager.DocumentManager();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.shtoProjektToolStripMenuItem = new PespaSistemLibrary.MenuItem(this.components);
            this.shtoProjektToolStripMenuItem1 = new PespaSistemLibrary.MenuItem(this.components);
            this.futVlereRealePerProjektinToolStripMenuItem = new PespaSistemLibrary.MenuItem(this.components);
            this.dilToolStripMenuItem = new PespaSistemLibrary.MenuItem(this.components);
            this.konfigurimeToolStripMenuItem = new PespaSistemLibrary.MenuItem(this.components);
            this.aluminToolStripMenuItem = new PespaSistemLibrary.MenuItem(this.components);
            this.xhamToolStripMenuItem = new PespaSistemLibrary.MenuItem(this.components);
            this.aksesoreToolStripMenuItem = new PespaSistemLibrary.MenuItem(this.components);
            this.produkteToolStripMenuItem = new PespaSistemLibrary.MenuItem(this.components);
            this.shtoProdukteToolStripMenuItem = new PespaSistemLibrary.MenuItem(this.components);
            this.statistikaToolStripMenuItem = new PespaSistemLibrary.MenuItem(this.components);
            this.diferencaEProjekteveToolStripMenuItem = new PespaSistemLibrary.MenuItem(this.components);
            this.rregullimeToolStripMenuItem = new PespaSistemLibrary.MenuItem(this.components);
            this.perdoruesToolStripMenuItem = new PespaSistemLibrary.MenuItem(this.components);
            this.teDrejtatToolStripMenuItem = new PespaSistemLibrary.MenuItem(this.components);
            this.ndihmeToolStripMenuItem = new PespaSistemLibrary.MenuItem(this.components);
            this.ndihmaToolStripMenuItem = new PespaSistemLibrary.MenuItem(this.components);
            this.dsRoleDrejtat = new PespaSistem.DsRoleDrejtat();
            this.roleDrejtatTableAdapter = new PespaSistem.DsRoleDrejtatTableAdapters.ROLE_DREJTATTableAdapter();
            this.rolePerdoruesTableAdapter = new PespaSistem.DsRoleDrejtatTableAdapters.ROLE_PERDORUESTableAdapter();
            this.teDrejtatTableAdapter = new PespaSistem.DsRoleDrejtatTableAdapters.TE_DREJTATTableAdapter();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsRoleDrejtat)).BeginInit();
            this.SuspendLayout();
            // 
            // tabStrip1
            // 
            this.tabStrip1.CanReorderTabs = true;
            this.tabStrip1.CloseButtonVisible = true;
            this.tabStrip1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabStrip1.Location = new System.Drawing.Point(0, 24);
            this.tabStrip1.Name = "tabStrip1";
            this.tabStrip1.SelectedTab = null;
            this.tabStrip1.SelectedTabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.tabStrip1.Size = new System.Drawing.Size(855, 23);
            this.tabStrip1.Style = DevComponents.DotNetBar.eTabStripStyle.OneNote;
            this.tabStrip1.TabIndex = 6;
            this.tabStrip1.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox;
            this.tabStrip1.Text = "tabStrip1";
            this.tabStrip1.TabItemClose += new DevComponents.DotNetBar.TabStrip.UserActionEventHandler(this.tabStrip1_TabItemClose_1);
            this.tabStrip1.SelectedTabChanged += new DevComponents.DotNetBar.TabStrip.SelectedTabChangedEventHandler(this.tabStrip1_SelectedTabChanged_1);
            // 
            // docManager
            // 
            this.docManager.Dock = System.Windows.Forms.DockStyle.Fill;
            this.docManager.Location = new System.Drawing.Point(0, 24);
            this.docManager.Name = "docManager";
            this.docManager.Size = new System.Drawing.Size(855, 481);
            this.docManager.TabIndex = 5;
            this.docManager.CloseButtonPressed += new DocumentManager.DocumentManager.CloseButtonPressedEventHandler(this.docManager_CloseButtonPressed_1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.shtoProjektToolStripMenuItem,
            this.konfigurimeToolStripMenuItem,
            this.statistikaToolStripMenuItem,
            this.rregullimeToolStripMenuItem,
            this.ndihmeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(855, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // shtoProjektToolStripMenuItem
            // 
            this.shtoProjektToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.shtoProjektToolStripMenuItem1,
            this.futVlereRealePerProjektinToolStripMenuItem,
            this.dilToolStripMenuItem});
            this.shtoProjektToolStripMenuItem.Emri = "";
            this.shtoProjektToolStripMenuItem.IdDrejta = -1;
            this.shtoProjektToolStripMenuItem.Name = "shtoProjektToolStripMenuItem";
            this.shtoProjektToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.shtoProjektToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.shtoProjektToolStripMenuItem.Text = "Skedar";
            // 
            // shtoProjektToolStripMenuItem1
            // 
            this.shtoProjektToolStripMenuItem1.Emri = "";
            this.shtoProjektToolStripMenuItem1.IdDrejta = 1;
            this.shtoProjektToolStripMenuItem1.Name = "shtoProjektToolStripMenuItem1";
            this.shtoProjektToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.shtoProjektToolStripMenuItem1.Size = new System.Drawing.Size(254, 22);
            this.shtoProjektToolStripMenuItem1.Text = "Shto projekt";
            this.shtoProjektToolStripMenuItem1.Click += new System.EventHandler(this.shtoProjektToolStripMenuItem1_Click);
            // 
            // futVlereRealePerProjektinToolStripMenuItem
            // 
            this.futVlereRealePerProjektinToolStripMenuItem.Emri = "";
            this.futVlereRealePerProjektinToolStripMenuItem.IdDrejta = 2;
            this.futVlereRealePerProjektinToolStripMenuItem.Name = "futVlereRealePerProjektinToolStripMenuItem";
            this.futVlereRealePerProjektinToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.R)));
            this.futVlereRealePerProjektinToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.futVlereRealePerProjektinToolStripMenuItem.Text = "Fut vlere reale per projektin";
            this.futVlereRealePerProjektinToolStripMenuItem.Click += new System.EventHandler(this.futVlereRealePerProjektinToolStripMenuItem_Click);
            // 
            // dilToolStripMenuItem
            // 
            this.dilToolStripMenuItem.Emri = "";
            this.dilToolStripMenuItem.IdDrejta = -2;
            this.dilToolStripMenuItem.Name = "dilToolStripMenuItem";
            this.dilToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.dilToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.dilToolStripMenuItem.Text = "Dil";
            this.dilToolStripMenuItem.Click += new System.EventHandler(this.dilToolStripMenuItem_Click);
            // 
            // konfigurimeToolStripMenuItem
            // 
            this.konfigurimeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aluminToolStripMenuItem,
            this.xhamToolStripMenuItem,
            this.aksesoreToolStripMenuItem,
            this.produkteToolStripMenuItem,
            this.shtoProdukteToolStripMenuItem});
            this.konfigurimeToolStripMenuItem.Emri = "";
            this.konfigurimeToolStripMenuItem.IdDrejta = -1;
            this.konfigurimeToolStripMenuItem.Name = "konfigurimeToolStripMenuItem";
            this.konfigurimeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.K)));
            this.konfigurimeToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.konfigurimeToolStripMenuItem.Text = "Konfigurime";
            // 
            // aluminToolStripMenuItem
            // 
            this.aluminToolStripMenuItem.Emri = "";
            this.aluminToolStripMenuItem.IdDrejta = 3;
            this.aluminToolStripMenuItem.Name = "aluminToolStripMenuItem";
            this.aluminToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.aluminToolStripMenuItem.Text = "Alumin";
            this.aluminToolStripMenuItem.Click += new System.EventHandler(this.aluminToolStripMenuItem_Click);
            // 
            // xhamToolStripMenuItem
            // 
            this.xhamToolStripMenuItem.Emri = "";
            this.xhamToolStripMenuItem.IdDrejta = 4;
            this.xhamToolStripMenuItem.Name = "xhamToolStripMenuItem";
            this.xhamToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.xhamToolStripMenuItem.Text = "Xham";
            this.xhamToolStripMenuItem.Click += new System.EventHandler(this.xhamToolStripMenuItem_Click);
            // 
            // aksesoreToolStripMenuItem
            // 
            this.aksesoreToolStripMenuItem.Emri = "";
            this.aksesoreToolStripMenuItem.IdDrejta = 5;
            this.aksesoreToolStripMenuItem.Name = "aksesoreToolStripMenuItem";
            this.aksesoreToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.aksesoreToolStripMenuItem.Text = "Aksesore";
            this.aksesoreToolStripMenuItem.Click += new System.EventHandler(this.aksesoreToolStripMenuItem_Click);
            // 
            // produkteToolStripMenuItem
            // 
            this.produkteToolStripMenuItem.Emri = "";
            this.produkteToolStripMenuItem.IdDrejta = 6;
            this.produkteToolStripMenuItem.Name = "produkteToolStripMenuItem";
            this.produkteToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.produkteToolStripMenuItem.Text = "Produkte";
            this.produkteToolStripMenuItem.Click += new System.EventHandler(this.produkteToolStripMenuItem_Click);
            // 
            // shtoProdukteToolStripMenuItem
            // 
            this.shtoProdukteToolStripMenuItem.Emri = "";
            this.shtoProdukteToolStripMenuItem.IdDrejta = 0;
            this.shtoProdukteToolStripMenuItem.Name = "shtoProdukteToolStripMenuItem";
            this.shtoProdukteToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.shtoProdukteToolStripMenuItem.Text = "Shto produkte";
            this.shtoProdukteToolStripMenuItem.Click += new System.EventHandler(this.shtoProdukteToolStripMenuItem_Click);
            // 
            // statistikaToolStripMenuItem
            // 
            this.statistikaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.diferencaEProjekteveToolStripMenuItem});
            this.statistikaToolStripMenuItem.Emri = "";
            this.statistikaToolStripMenuItem.IdDrejta = -1;
            this.statistikaToolStripMenuItem.Name = "statistikaToolStripMenuItem";
            this.statistikaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.T)));
            this.statistikaToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.statistikaToolStripMenuItem.Text = "Statistika";
            // 
            // diferencaEProjekteveToolStripMenuItem
            // 
            this.diferencaEProjekteveToolStripMenuItem.Emri = "";
            this.diferencaEProjekteveToolStripMenuItem.IdDrejta = -2;
            this.diferencaEProjekteveToolStripMenuItem.Name = "diferencaEProjekteveToolStripMenuItem";
            this.diferencaEProjekteveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.diferencaEProjekteveToolStripMenuItem.Text = "Diferenca";
            this.diferencaEProjekteveToolStripMenuItem.Click += new System.EventHandler(this.diferencaEProjekteveToolStripMenuItem_Click);
            // 
            // rregullimeToolStripMenuItem
            // 
            this.rregullimeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.perdoruesToolStripMenuItem,
            this.teDrejtatToolStripMenuItem});
            this.rregullimeToolStripMenuItem.Emri = "";
            this.rregullimeToolStripMenuItem.IdDrejta = -1;
            this.rregullimeToolStripMenuItem.Name = "rregullimeToolStripMenuItem";
            this.rregullimeToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.rregullimeToolStripMenuItem.Text = "Rregullime";
            // 
            // perdoruesToolStripMenuItem
            // 
            this.perdoruesToolStripMenuItem.Emri = "";
            this.perdoruesToolStripMenuItem.IdDrejta = 0;
            this.perdoruesToolStripMenuItem.Name = "perdoruesToolStripMenuItem";
            this.perdoruesToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.perdoruesToolStripMenuItem.Text = "Perdorues";
            this.perdoruesToolStripMenuItem.Click += new System.EventHandler(this.perdoruesToolStripMenuItem_Click);
            // 
            // teDrejtatToolStripMenuItem
            // 
            this.teDrejtatToolStripMenuItem.Emri = "";
            this.teDrejtatToolStripMenuItem.IdDrejta = 0;
            this.teDrejtatToolStripMenuItem.Name = "teDrejtatToolStripMenuItem";
            this.teDrejtatToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.teDrejtatToolStripMenuItem.Text = "Te drejtat";
            this.teDrejtatToolStripMenuItem.Click += new System.EventHandler(this.teDrejtatToolStripMenuItem_Click);
            // 
            // ndihmeToolStripMenuItem
            // 
            this.ndihmeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ndihmaToolStripMenuItem});
            this.ndihmeToolStripMenuItem.Emri = "";
            this.ndihmeToolStripMenuItem.IdDrejta = -2;
            this.ndihmeToolStripMenuItem.Name = "ndihmeToolStripMenuItem";
            this.ndihmeToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.ndihmeToolStripMenuItem.Text = "Ndihme";
            // 
            // ndihmaToolStripMenuItem
            // 
            this.ndihmaToolStripMenuItem.Emri = "";
            this.ndihmaToolStripMenuItem.IdDrejta = -1;
            this.ndihmaToolStripMenuItem.Name = "ndihmaToolStripMenuItem";
            this.ndihmaToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.ndihmaToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.ndihmaToolStripMenuItem.Text = "Ndihma";
            // 
            // dsRoleDrejtat
            // 
            this.dsRoleDrejtat.DataSetName = "DsRoleDrejtat";
            this.dsRoleDrejtat.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // roleDrejtatTableAdapter
            // 
            this.roleDrejtatTableAdapter.ClearBeforeFill = true;
            // 
            // rolePerdoruesTableAdapter
            // 
            this.rolePerdoruesTableAdapter.ClearBeforeFill = true;
            // 
            // teDrejtatTableAdapter
            // 
            this.teDrejtatTableAdapter.ClearBeforeFill = true;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(855, 505);
            this.Controls.Add(this.tabStrip1);
            this.Controls.Add(this.docManager);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pespa Sistem";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsRoleDrejtat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.TabStrip tabStrip1;
        private DocumentManager.DocumentManager docManager;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private PespaSistemLibrary.MenuItem shtoProjektToolStripMenuItem;
        private PespaSistemLibrary.MenuItem shtoProjektToolStripMenuItem1;
        private PespaSistemLibrary.MenuItem futVlereRealePerProjektinToolStripMenuItem;
        private PespaSistemLibrary.MenuItem dilToolStripMenuItem;
        private PespaSistemLibrary.MenuItem konfigurimeToolStripMenuItem;
        private PespaSistemLibrary.MenuItem statistikaToolStripMenuItem;
        private PespaSistemLibrary.MenuItem diferencaEProjekteveToolStripMenuItem;
        private PespaSistemLibrary.MenuItem ndihmeToolStripMenuItem;
        private PespaSistemLibrary.MenuItem ndihmaToolStripMenuItem;
        private PespaSistemLibrary.MenuItem aluminToolStripMenuItem;
        private PespaSistemLibrary.MenuItem xhamToolStripMenuItem;
        private PespaSistemLibrary.MenuItem produkteToolStripMenuItem;
        private PespaSistemLibrary.MenuItem aksesoreToolStripMenuItem;
        private PespaSistemLibrary.MenuItem rregullimeToolStripMenuItem;
        private PespaSistemLibrary.MenuItem perdoruesToolStripMenuItem;
        private PespaSistemLibrary.MenuItem teDrejtatToolStripMenuItem;
        private DsRoleDrejtat dsRoleDrejtat;
        private PespaSistem.DsRoleDrejtatTableAdapters.ROLE_DREJTATTableAdapter roleDrejtatTableAdapter;
        private PespaSistem.DsRoleDrejtatTableAdapters.ROLE_PERDORUESTableAdapter rolePerdoruesTableAdapter;
        private PespaSistem.DsRoleDrejtatTableAdapters.TE_DREJTATTableAdapter teDrejtatTableAdapter;
        private PespaSistemLibrary.MenuItem shtoProdukteToolStripMenuItem;
    }
}

