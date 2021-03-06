namespace PespaSistem
{
    partial class FrmLogin
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
            this.btnOK = new PespaSistemLibrary.Button();
            this.btnAnullo = new PespaSistemLibrary.Button();
            this.txtFjalekalim = new System.Windows.Forms.TextBox();
            this.txtEmerPerdoruesi = new System.Windows.Forms.TextBox();
            this.lblFjalekalim = new System.Windows.Forms.Label();
            this.lblEmerPerdoruesi = new System.Windows.Forms.Label();
            this.dsPerdorues = new PespaSistem.DsPerdorues();
            this.perdoruesTableAdapter = new PespaSistem.DsPerdoruesTableAdapters.PERDORUESTableAdapter();
            this.rolePerdoruesTableAdapter = new PespaSistem.DsPerdoruesTableAdapters.ROLE_PERDORUESTableAdapter();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dsPerdorues)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(76, 137);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 24);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnAnullo
            // 
            this.btnAnullo.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnullo.Location = new System.Drawing.Point(188, 137);
            this.btnAnullo.Name = "btnAnullo";
            this.btnAnullo.Size = new System.Drawing.Size(75, 24);
            this.btnAnullo.TabIndex = 3;
            this.btnAnullo.Text = "Anullo";
            this.btnAnullo.Click += new System.EventHandler(this.btnAnullo_Click);
            // 
            // txtFjalekalim
            // 
            this.txtFjalekalim.Location = new System.Drawing.Point(148, 91);
            this.txtFjalekalim.Name = "txtFjalekalim";
            this.txtFjalekalim.PasswordChar = '●';
            this.txtFjalekalim.Size = new System.Drawing.Size(128, 20);
            this.txtFjalekalim.TabIndex = 1;
            this.txtFjalekalim.Validated += new System.EventHandler(this.txtFjalekalim_Validated);
            // 
            // txtEmerPerdoruesi
            // 
            this.txtEmerPerdoruesi.Location = new System.Drawing.Point(148, 55);
            this.txtEmerPerdoruesi.Name = "txtEmerPerdoruesi";
            this.txtEmerPerdoruesi.Size = new System.Drawing.Size(128, 20);
            this.txtEmerPerdoruesi.TabIndex = 0;
            this.txtEmerPerdoruesi.Validated += new System.EventHandler(this.txtEmerPerdoruesi_Validated);
            this.txtEmerPerdoruesi.TextChanged += new System.EventHandler(this.txtEmerPerdoruesi_TextChanged);
            // 
            // lblFjalekalim
            // 
            this.lblFjalekalim.AutoSize = true;
            this.lblFjalekalim.Location = new System.Drawing.Point(83, 94);
            this.lblFjalekalim.Name = "lblFjalekalim";
            this.lblFjalekalim.Size = new System.Drawing.Size(55, 13);
            this.lblFjalekalim.TabIndex = 5;
            this.lblFjalekalim.Text = "Fjalekalimi";
            // 
            // lblEmerPerdoruesi
            // 
            this.lblEmerPerdoruesi.AutoSize = true;
            this.lblEmerPerdoruesi.Location = new System.Drawing.Point(51, 58);
            this.lblEmerPerdoruesi.Name = "lblEmerPerdoruesi";
            this.lblEmerPerdoruesi.Size = new System.Drawing.Size(87, 13);
            this.lblEmerPerdoruesi.TabIndex = 6;
            this.lblEmerPerdoruesi.Text = "Emri i perdoruesit";
            // 
            // dsPerdorues
            // 
            this.dsPerdorues.DataSetName = "DsPerdorues";
            this.dsPerdorues.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // perdoruesTableAdapter
            // 
            this.perdoruesTableAdapter.ClearBeforeFill = true;
            // 
            // rolePerdoruesTableAdapter
            // 
            this.rolePerdoruesTableAdapter.ClearBeforeFill = true;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // FrmLogin
            // 
            this.AcceptButton = this.btnOK;
            this.CancelButton = this.btnAnullo;
            this.ClientSize = new System.Drawing.Size(342, 198);
            this.Controls.Add(this.lblEmerPerdoruesi);
            this.Controls.Add(this.lblFjalekalim);
            this.Controls.Add(this.txtEmerPerdoruesi);
            this.Controls.Add(this.txtFjalekalim);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnAnullo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hyrja";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.Controls.SetChildIndex(this.btnAnullo, 0);
            this.Controls.SetChildIndex(this.btnOK, 0);
            this.Controls.SetChildIndex(this.txtFjalekalim, 0);
            this.Controls.SetChildIndex(this.txtEmerPerdoruesi, 0);
            this.Controls.SetChildIndex(this.lblFjalekalim, 0);
            this.Controls.SetChildIndex(this.lblEmerPerdoruesi, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dsPerdorues)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PespaSistemLibrary.Button btnOK;
        private PespaSistemLibrary.Button btnAnullo;
        private System.Windows.Forms.TextBox txtFjalekalim;
        private System.Windows.Forms.TextBox txtEmerPerdoruesi;
        private System.Windows.Forms.Label lblFjalekalim;
        private System.Windows.Forms.Label lblEmerPerdoruesi;
        private DsPerdorues dsPerdorues;
        private PespaSistem.DsPerdoruesTableAdapters.PERDORUESTableAdapter perdoruesTableAdapter;
        private PespaSistem.DsPerdoruesTableAdapters.ROLE_PERDORUESTableAdapter rolePerdoruesTableAdapter;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}
