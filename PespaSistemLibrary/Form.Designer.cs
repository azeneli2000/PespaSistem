namespace PespaSistemLibrary
{
    partial class Form
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
            this.exPnStatus = new DevComponents.DotNetBar.ExpandablePanel();
            this.superTooltip1 = new DevComponents.DotNetBar.SuperTooltip();
            this.SuspendLayout();
            // 
            // exPnStatus
            // 
            this.exPnStatus.CanvasColor = System.Drawing.SystemColors.Control;
            this.exPnStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.exPnStatus.ExpandButtonVisible = false;
            this.exPnStatus.Expanded = false;
            this.exPnStatus.ExpandedBounds = new System.Drawing.Rectangle(0, 0, 831, 26);
            this.exPnStatus.Location = new System.Drawing.Point(0, 0);
            this.exPnStatus.Name = "exPnStatus";
            this.exPnStatus.Size = new System.Drawing.Size(874, 26);
            this.exPnStatus.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.exPnStatus.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.exPnStatus.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.exPnStatus.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.exPnStatus.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.exPnStatus.Style.GradientAngle = 90;
            this.exPnStatus.TabIndex = 0;
            this.exPnStatus.TitleStyle.Alignment = System.Drawing.StringAlignment.Center;
            this.exPnStatus.TitleStyle.BackColor1.Color = System.Drawing.Color.PeachPuff;
            this.exPnStatus.TitleStyle.BackColor2.Color = System.Drawing.Color.SandyBrown;
            this.exPnStatus.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.exPnStatus.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.exPnStatus.TitleStyle.BorderSide = DevComponents.DotNetBar.eBorderSide.None;
            this.exPnStatus.TitleStyle.BorderWidth = 0;
            this.exPnStatus.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.exPnStatus.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.exPnStatus.TitleStyle.GradientAngle = 90;
            this.exPnStatus.TitleText = "Title Bar";
            // 
            // superTooltip1
            // 
            this.superTooltip1.DefaultFont = new System.Drawing.Font("Tahoma", 8.25F);
            this.superTooltip1.MinimumTooltipSize = new System.Drawing.Size(150, 50);
            // 
            // Form
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(874, 520);
            this.ControlBox = false;
            this.Controls.Add(this.exPnStatus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form";
            this.Text = "Form";
            this.Load += new System.EventHandler(this.Form_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ExpandablePanel exPnStatus;
        protected DevComponents.DotNetBar.SuperTooltip superTooltip1;

    }
}