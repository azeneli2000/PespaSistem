namespace PespaSistem
{
    partial class FaqeKryesore
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
            this.label1 = new System.Windows.Forms.Label();
            this.expandablePanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // expandablePanel2
            // 
            this.expandablePanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.expandablePanel2.Controls.Add(this.label1);
            this.expandablePanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.expandablePanel2.Location = new System.Drawing.Point(0, 26);
            this.expandablePanel2.Name = "expandablePanel2";
            this.expandablePanel2.Size = new System.Drawing.Size(908, 614);
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
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(910, 470);
            this.label1.TabIndex = 36;
            this.label1.Text = "PESPA\r\nSISTEM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FaqeKryesore
            // 
            this.ClientSize = new System.Drawing.Size(925, 520);
            this.Controls.Add(this.expandablePanel2);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "FaqeKryesore";
            this.Text = "Faqe Kryesore";
            this.Load += new System.EventHandler(this.FaqeKryesore_Load);
            this.Controls.SetChildIndex(this.expandablePanel2, 0);
            this.expandablePanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ExpandablePanel expandablePanel2;
        private System.Windows.Forms.Label label1;
    }
}
