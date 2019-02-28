using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace PespaSistemLibrary
{
    public partial class MenuItem : System.Windows.Forms.ToolStripMenuItem
    {
        private string emri = "";
        private int idDrejta = 0;
        public MenuItem()
        {
            InitializeComponent();
        }

        public MenuItem(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        #region Public Properties
        [Category("Properti te shtuara")]
        public string Emri
        {
            get
            {
                return this.emri;
            }
            set
            {
                this.emri = value;
            }
        }

        [Category("Properti te shtuara")]
        public int IdDrejta
        {
            get
            {
                return this.idDrejta;
            }
            set
            {
                this.idDrejta = value;
            }
        }
        #endregion
    }
}
