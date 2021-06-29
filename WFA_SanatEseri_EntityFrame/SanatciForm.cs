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
    public partial class SanatciForm : Form
    {
        public event EventHandler SanatcilarDegisti;

        private readonly SanatOkuluContext db;

        public SanatciForm(SanatOkuluContext db)
        {
            this.db = db;
            InitializeComponent();
            Listele();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string ad = txtAd.Text.Trim();
            if (ad == "")
            {
                MessageBox.Show("Lütfen bir ad belirtin.");
                return;
            }

            if (duzenlenen == null)
            {

            db.Sanatcilar.Add(new Sanatci() { Ad = ad });

            }
            else
            {
                duzenlenen.Ad = ad;
            }

            db.SaveChanges();
            Listele();
            SanatcilarDegistiginde(EventArgs.Empty);
            FormuResetle();
        }

        protected virtual void SanatcilarDegistiginde(EventArgs args)
        {
            if (SanatcilarDegisti != null)
            {
                SanatcilarDegisti(this, args);
            }

        }


        private void btnKapat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (LstSanatcilar.SelectedIndex == -1) return;

            Sanatci sanatci = (Sanatci)LstSanatcilar.SelectedItem;
            db.Sanatcilar.Remove(sanatci);
            db.SaveChanges();
            Listele();
            SanatcilarDegistiginde(EventArgs.Empty);

        }

        private void Listele()
        {
            LstSanatcilar.DataSource = db.Sanatcilar.OrderBy(x => x.Ad).ToList();
            LstSanatcilar.DisplayMember = "Ad";
        }

        Sanatci duzenlenen;
        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            if (LstSanatcilar.SelectedIndex == -1) return;

            duzenlenen = (Sanatci)LstSanatcilar.SelectedItem;
            txtAd.Text = duzenlenen.Ad;
            btnEkle.Text = "Kaydet";
            btniptal.Show();
            LstSanatcilar.Enabled = false;
            btnDuzenle.Enabled = false;
            btnSil.Enabled = false;


        }

        private void btniptal_Click(object sender, EventArgs e)
        {
            FormuResetle();
        }

        private void FormuResetle()
        {
            txtAd.Clear();
            duzenlenen = null;
            btnEkle.Text = "Ekle";
            btniptal.Hide();
            LstSanatcilar.Enabled = btnDuzenle.Enabled = btnSil.Enabled = true;



        }
    }
}
