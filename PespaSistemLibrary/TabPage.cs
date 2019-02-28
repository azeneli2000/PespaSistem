using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace PespaSistemLibrary
{
    public partial class TabPage : System.Windows.Forms.TabPage
    {
        public TabPage()
        {
            InitializeComponent();
        }

        public TabPage(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        protected override void OnPaintBackground(System.Windows.Forms.PaintEventArgs pevent)
        {
            Graphics gfx = pevent.Graphics;
            Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);
            using (LinearGradientBrush lgb = new LinearGradientBrush(rect, Color.FromKnownColor(KnownColor.InactiveCaptionText),
                       Color.FromKnownColor(KnownColor.InactiveCaption), 90f, false))
                gfx.FillRectangle(lgb, rect);
        }

    }
}
