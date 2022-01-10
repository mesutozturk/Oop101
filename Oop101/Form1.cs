using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Oop101.Models;


namespace Oop101
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            Kisi kisi1 = new Kisi(); //instance - örneklemek -- referrer

            try
            {
                kisi1.Ad = "kaMiL";
                kisi1.Soyad = "fıDıL";
                kisi1.DogumTarihi = new DateTime(1995, 1, 5);
                //kisi1.Yas = 25;
                //MessageBox.Show(kisi1.Yas.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                object oo = new object();

                Kisi yeniKisi = new Kisi();

                yeniKisi.Ad = txtAd.Text;
                yeniKisi.Soyad = txtSoyad.Text;
                yeniKisi.DogumTarihi = dtpDogumTarihi.Value;
                yeniKisi.Telefon = txtTelefon.Text;
                yeniKisi.Email = txtEmail.Text;
                yeniKisi.Tckn = txtTckn.Text;

                _kisiler.Add(yeniKisi);
                ListeyiDoldur();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
        }

        private List<Kisi> _kisiler = new List<Kisi>();
        private Kisi _seciliKisi;
        private void lstKisiler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstKisiler.SelectedItem == null) return;

            _seciliKisi = lstKisiler.SelectedItem as Kisi;
            Kisi seciliKisi2 = (Kisi)lstKisiler.SelectedItem;

            txtAd.Text = _seciliKisi.Ad;
            txtSoyad.Text = _seciliKisi.Soyad;
            txtTckn.Text = _seciliKisi.Tckn;
            txtTelefon.Text = _seciliKisi.Telefon;
            txtEmail.Text = _seciliKisi.Email;
            dtpDogumTarihi.Value = _seciliKisi.DogumTarihi;

            this.Text = $"{_seciliKisi}";

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (_seciliKisi == null) return;

            _seciliKisi.Ad = txtAd.Text;
            _seciliKisi.Soyad = txtSoyad.Text;

            ListeyiDoldur();
        }

        private void ListeyiDoldur()
        {
            lstKisiler.Items.Clear();
            foreach (var kisi in _kisiler)
            {
                lstKisiler.Items.Add(kisi);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (_seciliKisi == null) return;

            _kisiler.Remove(_seciliKisi);

            ListeyiDoldur();
        }
    }
}