using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;
using Janus.Windows.EditControls;

namespace PespaSistemLibrary
{
    public partial class Button : Janus.Windows.EditControls.UIButton
    {
        #region Private Fields
        public enum teDrejta
        {
            all = 1, 
            administrator = 2, 
            perdorues = 3,
        }
        private teDrejta m_teDrejta;
        #endregion
        public Button()
        {
            m_teDrejta = teDrejta.all;
            InitializeComponent();
        }

        public Button(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        protected override void OnClick(EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            base.OnClick(e);
            this.Cursor = Cursors.Default;
        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            if (this.TeDrejta == teDrejta.all)
            {
                this.Enabled = true;
                return;
            }
            Control prnt = this.Parent;
            bool prntForm = false;
            while (!prntForm)
            {
                if (!(prnt is PespaSistemLibrary.Form))
                {
                    prnt = prnt.Parent;
                }
                else
                {
                    PespaSistemLibrary.Form frm = prnt as PespaSistemLibrary.Form;
                    if (frm.RolId == 1)
                    {
                        this.Enabled = true;
                    }
                    else if (frm.RolId == 2)
                    {
                        if (this.m_teDrejta == teDrejta.administrator)
                            this.Enabled = false;
                        else if (this.m_teDrejta == teDrejta.perdorues)
                            this.Enabled = true;
                    }
                    else if (frm.RolId == 3)
                        this.Enabled = false;
                    prntForm = true;
                }
            }
        }
        
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (this.TeDrejta == teDrejta.all)
            {
                this.Enabled = true;
                return;
            }
            Control prnt = this.Parent;
            bool prntForm = false;
            while (prntForm)
            {
                if (prnt is PespaSistemLibrary.Form)
                {
                    prnt = prnt.Parent;
                }
                else
                {
                    PespaSistemLibrary.Form frm = prnt.Parent as PespaSistemLibrary.Form;
                    if (frm.RolId == 1)
                    {
                        this.Enabled = true;
                    }
                    else if (frm.RolId == 2)
                    {
                        if (this.m_teDrejta == teDrejta.administrator)
                            this.Enabled = false;
                        else if (this.m_teDrejta == teDrejta.perdorues)
                            this.Enabled = true;
                    }
                    else if (frm.RolId == 3)
                        this.Enabled = false;
                    prntForm = true;
                }
            }
        }

        public teDrejta TeDrejta
        {
            get
            {
                return m_teDrejta;
            }
            set
            {
                m_teDrejta = value;
            }
        }
    }
}
