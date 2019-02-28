using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PespaSistem
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// sherben per propertine Perdoruesi i cili mban perdoruesin e loguar per momentin
        /// </summary>
        private string perdoruesi = "";
        private int perdoruesId;
        private int rolId;

        public MainForm()
        {
            InitializeComponent();
            this.Initialize();
        }

        #region Private Methods
        private void AddNewTab(PespaSistemLibrary.Form frm)
        {
            try
            {
                Type tipi = frm.GetType();
                int indeks = this.GetFormIndex(tipi);
                // Mund te kemi vetem nje forme te nje lloji te hapur
                if (indeks != -1)
                {
                    // Kemi nje forme te hapur ne MainForm
                    this.docManager.FocusedDocument = this.docManager.TabStrips[0].Documents[indeks];
                    this.tabStrip1.SelectedTabIndex = indeks;
                    return;
                }
                DocumentManager.Document doc = new DocumentManager.Document(frm, frm.Text);
                frm.MdiParent = this;
                frm.Perdorues = this.perdoruesi;
                frm.PerdoruesId = this.perdoruesId;
                frm.RolId = this.rolId;
                
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.Main = this;
                frm.ControlBox = false;
                // Vendosim propertine AutoScroll ne true, ne menyre qe programi te punoje me te gjitha
                // rezolucionet, megjithate aplikacioni punon me mire me rezolucionin 1024 x 768 
                if (frm.Name != "FaqeKryesore")
                {
                    frm.AutoScroll = true;
                }
                else
                {
                    frm.AutoScroll = false;
                    //this.pnlNdihme.Width = 200;
                    //this.pnlNdihme.AutoHideButtonVisible = Janus.Windows.UI.InheritableBoolean.False;
                    //this.pnlNdihme.CloseButtonVisible = Janus.Windows.UI.InheritableBoolean.False;
                    //this.faqeKryesore = true;
                }
                this.docManager.AddDocument(doc);
                DevComponents.DotNetBar.TabItem tab = new DevComponents.DotNetBar.TabItem();
                tab.Text = frm.Text;
                this.tabStrip1.Tabs.Add(tab);
                this.docManager.FocusedDocument = doc;
                this.tabStrip1.SelectedTabIndex = this.docManager.TabStrips[0].Documents.Count - 1;
            }
            catch (Exception ex)
            {
                //VisionInfoSolutionLibrary.MessageBox.Show(this, ex);
                return;
            }

        }

        private bool Initialize()
        {
            if (this.Logimi())
            {
                this.AddNewTab(new FaqeKryesore());
            }
            return true;
        }

        /// <summary>
        /// Kthen indeksin e formes ne tab, nese kjo forme gjendet; perndryshe kthen -1
        /// </summary>
        /// <param name="formType">Forma</param>
        /// <returns>Indeksin</returns>
        private int GetFormIndex(Type formType)
        {
            if (this.docManager.TabStrips.Count > 0)
            {
                for (int i = 0; i < this.docManager.TabStrips[0].Documents.Count; i++)
                {
                    if (this.docManager.TabStrips[0].Documents[i].Control.GetType() == formType)
                    {
                        return i;
                    }
                }
            }
            return -1;
        }

        private bool Logimi()
        {
            bool sukses = false;
            if (!FrmLogin.KontrolloPerdoruesit())
            {
                return true;
            }
            FrmLogin.ShowForm();
            string username = FrmLogin.emer;
            string password = FrmLogin.fjalekalim;
            if (username == "" || password == "" || username == null || password == null)
            {
                Application.Exit();
                return false;
            }
            try
            {
                sukses = FrmLogin.Logimi(username, password);
            }
            catch
            {
                return false;
            }
            if (!sukses)
            {
                this.Logimi();
            }
            this.perdoruesi = FrmLogin.emer;
            this.perdoruesId = FrmLogin.userId;
            this.rolId = FrmLogin.rolID;
            this.NgarkoTeDrejtat(FrmLogin.rolID);
            return true;
        }


        private void NgarkoTeDrejtat(int idRoli)
        {
            // Nese perdoruesi eshte administrator atehere dil nga metoda
            if (idRoli == 1)
                return;
            bool uGjet = false;
            this.roleDrejtatTableAdapter.FillByRoli(dsRoleDrejtat.ROLE_DREJTAT, idRoli);
            foreach (PespaSistemLibrary.MenuItem menuItem in menuStrip1.Items)
            {
                if (menuItem.IdDrejta == -1)
                {
                    menuItem.Enabled = true;
                    uGjet = true;
                    if (menuItem.HasDropDownItems)
                    {
                        foreach (PespaSistemLibrary.MenuItem menuCol in menuItem.DropDownItems)
                        {
                            if (menuCol.IdDrejta == -2)
                                uGjet = true;
                            else
                            {
                                foreach (DataRow dr in this.dsRoleDrejtat.ROLE_DREJTAT.Rows)
                                {
                                    if (menuCol.IdDrejta == Convert.ToInt32(dr["ID_DREJTAT"]))
                                    {
                                        uGjet = true;
                                        break;
                                    }
                                }
                            }
                            if (uGjet)
                                menuCol.Enabled = true;
                            else
                                menuCol.Enabled = false;
                            uGjet = false;
                        }
                    }
                }
            }
        }


        #endregion

        private void produkteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.AddNewTab(new KonfigurimeDyerMeHapje());
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //this.AddNewTab(new FaqeKryesore());
        }

        private void aluminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.AddNewTab(new PespaSistem.KonfigurimeAlumin());
        }

        private void xhamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.AddNewTab(new PespaSistem.KonfigurimeXham());
        }

        private void aksesoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.AddNewTab(new KonfigurimeAksesore());
        }

        private void dyerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.AddNewTab(new KonfigurimeDyerMeHapje());
        }

        private void docManager_CloseButtonPressed(object sender, DocumentManager.CloseButtonPressedEventArgs e)
        {
            // Faqja kryesore nuk duhet te mbyllet asnjehere
            if (this.docManager.FocusedDocument != null)
            {
                if (this.docManager.FocusedDocument.Control is FaqeKryesore)
                    return;
                PespaSistemLibrary.Form sysForm = this.docManager.FocusedDocument.Control as PespaSistemLibrary.Form;
                if (this.CloseForm(sysForm, this.docManager.FocusedDocument))
                {
                    if (this.docManager.TabStrips.Count > 0 && this.docManager.TabStrips[0].Documents.Contains(this.docManager.FocusedDocument))
                    {
                        this.docManager.RemoveDocument(this.docManager.FocusedDocument);
                    }
                }
            }
        }

        private bool CloseForm(System.Windows.Forms.Form sysForm, DocumentManager.Document focusedDocument)
        {
            if (sysForm != null)
            {
                sysForm.ActiveControl = null;
                this.docManager.FocusedDocument = focusedDocument;
                sysForm.Close();
                return true;

            }
            return false;
        }

        private void tabStrip1_SelectedTabChanged(object sender, DevComponents.DotNetBar.TabStripTabChangedEventArgs e)
        {
            this.docManager.FocusedDocument = this.docManager.TabStrips[0].Documents[tabStrip1.SelectedTabIndex];
        }

        private void tabStrip1_TabItemClose(object sender, DevComponents.DotNetBar.TabStripActionEventArgs e)
        {
            // Faqja kryesore nuk duhet te mbyllet asnjehere
            if (this.docManager.FocusedDocument != null)
            {
                if (this.docManager.FocusedDocument.Control is FaqeKryesore)
                    return;
                PespaSistemLibrary.Form sysForm = this.docManager.FocusedDocument.Control as PespaSistemLibrary.Form;
                if (this.CloseForm(sysForm, this.docManager.FocusedDocument))
                {
                    if (this.docManager.TabStrips.Count > 0 && this.docManager.TabStrips[0].Documents.Contains(this.docManager.FocusedDocument))
                    {
                        this.docManager.RemoveDocument(this.docManager.FocusedDocument);
                    }
                }
                this.tabStrip1.Tabs.RemoveAt(this.tabStrip1.SelectedTabIndex);
            }
        }

        private void shtoProjektToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.AddNewTab(new ShtoProjekt());
        }

        private void tabStrip1_SelectedTabChanged_1(object sender, DevComponents.DotNetBar.TabStripTabChangedEventArgs e)
        {
            if (this.docManager.FocusedDocument == null)
                return;
            this.docManager.FocusedDocument = this.docManager.TabStrips[0].Documents[tabStrip1.SelectedTabIndex];
            PespaSistemLibrary.Form frm = this.docManager.FocusedDocument.Control as PespaSistemLibrary.Form;
            if (frm.Name != "FaqeKryesore")
                frm.AutoScrollPosition = new Point(0, 0);
        }

        private void tabStrip1_TabItemClose_1(object sender, DevComponents.DotNetBar.TabStripActionEventArgs e)
        {
            // Faqja kryesore nuk duhet te mbyllet asnjehere
            if (this.docManager.FocusedDocument != null)
            {
                if (this.docManager.FocusedDocument.Control is FaqeKryesore)
                    return;
                PespaSistemLibrary.Form sysForm = this.docManager.FocusedDocument.Control as PespaSistemLibrary.Form;
                if (this.CloseForm(sysForm, this.docManager.FocusedDocument))
                {
                    if (this.docManager.TabStrips.Count > 0 && this.docManager.TabStrips[0].Documents.Contains(this.docManager.FocusedDocument))
                    {
                        this.docManager.RemoveDocument(this.docManager.FocusedDocument);
                    }
                }
                this.tabStrip1.Tabs.RemoveAt(this.tabStrip1.SelectedTabIndex);
            }
        }

        private void docManager_CloseButtonPressed_1(object sender, DocumentManager.CloseButtonPressedEventArgs e)
        {
            // Faqja kryesore nuk duhet te mbyllet asnjehere
            if (this.docManager.FocusedDocument != null)
            {
                if (this.docManager.FocusedDocument.Control is FaqeKryesore)
                    return;
                PespaSistemLibrary.Form sysForm = this.docManager.FocusedDocument.Control as PespaSistemLibrary.Form;
                if (this.CloseForm(sysForm, this.docManager.FocusedDocument))
                {
                    if (this.docManager.TabStrips.Count > 0 && this.docManager.TabStrips[0].Documents.Contains(this.docManager.FocusedDocument))
                    {
                        this.docManager.RemoveDocument(this.docManager.FocusedDocument);
                    }
                }
            }
        }

        private void futVlereRealePerProjektinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VlereReale futVlere = new VlereReale();
            futVlere.ShowDialog();
        }

        private void dilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void perdoruesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.AddNewTab(new FrmPerdorues());
        }

        private void teDrejtatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.AddNewTab(new KonfigurimeTeDrejtash());
        }

        private void shtoProdukteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.AddNewTab(new FrmShtoProdukt());
        }

        private void dritareToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void diferencaEProjekteveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.AddNewTab(new FrmStatistika());
        }
    }
}