namespace PespaSistem
{
    partial class FrmZgjidhPrintim
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
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.btnOK = new PespaSistemLibrary.Button();
            this.gbLlojFature = new Janus.Windows.EditControls.UIGroupBox();
            this.btnAnullo = new PespaSistemLibrary.Button();
            this.rbFatureDetajuar = new System.Windows.Forms.RadioButton();
            this.rbFatureEPergjithshme = new System.Windows.Forms.RadioButton();
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbLlojFature)).BeginInit();
            this.gbLlojFature.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.Controls.Add(this.btnAnullo);
            this.panelEx1.Controls.Add(this.btnOK);
            this.panelEx1.Controls.Add(this.gbLlojFature);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(423, 209);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.panelEx1.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 3;
            // 
            // btnOK
            // 
            this.btnOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOK.Location = new System.Drawing.Point(64, 136);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 24);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // gbLlojFature
            // 
            this.gbLlojFature.Controls.Add(this.rbFatureDetajuar);
            this.gbLlojFature.Controls.Add(this.rbFatureEPergjithshme);
            this.gbLlojFature.Location = new System.Drawing.Point(31, 28);
            this.gbLlojFature.Name = "gbLlojFature";
            this.gbLlojFature.Size = new System.Drawing.Size(349, 83);
            this.gbLlojFature.TabIndex = 0;
            this.gbLlojFature.Text = "Lloji i fatures";
            this.gbLlojFature.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003;
            // 
            // btnAnullo
            // 
            this.btnAnullo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnullo.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnullo.Location = new System.Drawing.Point(244, 136);
            this.btnAnullo.Name = "btnAnullo";
            this.btnAnullo.Size = new System.Drawing.Size(75, 24);
            this.btnAnullo.TabIndex = 4;
            this.btnAnullo.Text = "Anullo";
            this.btnAnullo.Click += new System.EventHandler(this.btnAnullo_Click);
            // 
            // rbFatureDetajuar
            // 
            this.rbFatureDetajuar.AutoSize = true;
            this.rbFatureDetajuar.Location = new System.Drawing.Point(195, 29);
            this.rbFatureDetajuar.Name = "rbFatureDetajuar";
            this.rbFatureDetajuar.Size = new System.Drawing.Size(105, 17);
            this.rbFatureDetajuar.TabIndex = 2;
            this.rbFatureDetajuar.Text = "Fature e detajuar";
            this.rbFatureDetajuar.UseVisualStyleBackColor = true;
            // 
            // rbFatureEPergjithshme
            // 
            this.rbFatureEPergjithshme.AutoSize = true;
            this.rbFatureEPergjithshme.Checked = true;
            this.rbFatureEPergjithshme.Location = new System.Drawing.Point(18, 29);
            this.rbFatureEPergjithshme.Name = "rbFatureEPergjithshme";
            this.rbFatureEPergjithshme.Size = new System.Drawing.Size(126, 17);
            this.rbFatureEPergjithshme.TabIndex = 1;
            this.rbFatureEPergjithshme.TabStop = true;
            this.rbFatureEPergjithshme.Text = "Fature e pergjithshme";
            this.rbFatureEPergjithshme.UseVisualStyleBackColor = true;
            // 
            // FrmZgjidhPrintim
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnAnullo;
            this.ClientSize = new System.Drawing.Size(423, 209);
            this.ControlBox = false;
            this.Controls.Add(this.panelEx1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmZgjidhPrintim";
            this.Text = "Zgjidhni llojin e fatures";
            this.panelEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gbLlojFature)).EndInit();
            this.gbLlojFature.ResumeLayout(false);
            this.gbLlojFature.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private PespaSistemLibrary.Button btnAnullo;
        private PespaSistemLibrary.Button btnOK;
        private Janus.Windows.EditControls.UIGroupBox gbLlojFature;
        private System.Windows.Forms.RadioButton rbFatureDetajuar;
        private System.Windows.Forms.RadioButton rbFatureEPergjithshme;
    }
}