using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteka
{
    public partial class BibliotekaMain : Form
    {
        private int childFormNumber = 0;

        public BibliotekaMain()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void DodajKnjiguToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dodajKnjigu dk = new dodajKnjigu();
            dk.Show();
        }

        private void PregledajKnjigeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PregledajKnjige pk = new PregledajKnjige();
            pk.Show();
        }

        private void DodajKorisnikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DodajKorisnika dk = new DodajKorisnika();
            dk.Show();
        }

        private void PregledajKorisnikeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PregledajKorisnike pk = new PregledajKorisnike();
            pk.Show();
        }

        private void IzdavanjeKnjigaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IzdavanjeKnjige ik = new IzdavanjeKnjige();
            ik.Show();
        }

        private void VracanjeKnjigeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VracanjeKnjige vk = new VracanjeKnjige();
            vk.Show();
        }

        private void StanjeKnjigaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StanjeKnjiga sk = new StanjeKnjiga();
            sk.Show();
        }
    }
}
