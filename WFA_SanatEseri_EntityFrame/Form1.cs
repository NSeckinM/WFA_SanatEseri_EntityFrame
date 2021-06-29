using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFA_SanatEseri_EntityFrame.Models;

namespace WFA_SanatEseri_EntityFrame
{
    public partial class Form1 : Form
    {
        SanatOkuluContext db = new SanatOkuluContext();

        public Form1()
        {
            InitializeComponent();
            SanatcilariYukle();
            EserleriListele();
        }

        private void SanatcilariYukle()
        {
            cboSanatci.DataSource = db.Sanatcilar.OrderBy(x => x.Ad).ToList();
            cboSanatci.ValueMember = "Id";
            cboSanatci.DisplayMember = "Ad";
            cboSanatci.SelectedIndex = -1;
        }
        private void pboYeniSanatci_Click_1(object sender, EventArgs e)
        {
            SanatciFormuAc();
        }

        void SanatciFormuAc()
        {
            SanatciForm frm = new SanatciForm(db);
            frm.SanatcilarDegisti += frm_sanatcilarDegisti;
            frm.ShowDialog();
        }

        private void frm_sanatcilarDegisti(object sender, EventArgs e)
        {
            EserleriListele();
            SanatcilariYukle();
        }

        private void btnEkle_Click_1(object sender, EventArgs e)
        {
            string ad = txtAd.Text.Trim();
            if (ad == "")
            {
                MessageBox.Show("Lütfen eserin adını belirtin");
                return;
            }
            if (cboSanatci.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen bir sanatçı seçin");
                return;
            }

            Eser eser = new Eser()
            {
                Ad = ad,
                SanatciId = (int)cboSanatci.SelectedValue,
                Yil = mtbYil.Text == "" ? null as int? : Convert.ToInt32(mtbYil.Text)
            };
            db.Eserler.Add(eser);
            db.SaveChanges();
            FormuResetle();
            EserleriListele();
        }

        private void EserleriListele()
        {
            lvwEserler.Items.Clear();

            foreach (Eser eser in db.Eserler.OrderBy(x => x.Yil))
            {
                ListViewItem lvi = new ListViewItem(eser.Ad);
                lvi.SubItems.Add(eser.Sanatci.Ad);
                lvi.SubItems.Add(eser.Yil.ToString());
                lvi.Tag = eser;
                lvwEserler.Items.Add(lvi);
            }
        }

        private void FormuResetle()
        {
            txtAd.Clear();
            mtbYil.Clear();
            cboSanatci.SelectedIndex = -1;
            txtAd.Focus();

        }

        private void TsmiSanatcilar_Click(object sender, EventArgs e)
        {
            SanatciFormuAc();
        }

        private void lvwEserler_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && lvwEserler.SelectedItems.Count == 1)
            {
                DialogResult dr = MessageBox.Show("Seçili eseri silmek istediğinize emin misiniz ?","Silme onayı",MessageBoxButtons.YesNo,MessageBoxIcon.Warning,MessageBoxDefaultButton.Button1);

                if (dr == DialogResult.Yes)
                {
                    Eser eser = (Eser)lvwEserler.SelectedItems[0].Tag;
                    db.Eserler.Remove(eser);
                    db.SaveChanges();
                    EserleriListele();
                }

            }
        }
    }
}
