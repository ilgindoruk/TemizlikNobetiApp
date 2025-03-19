using System.ComponentModel;

namespace TemizlikNobetiApp
{
    public partial class Form1 : Form
    {
        BindingList<Ogrenci> SeciliOgrenciListesi = new();
        public Form1()
        {
            InitializeComponent();

            //ilk açılışta verileri yükle 
            KayitYoneticisi.Yukle();

            cbSinif.DisplayMember = "Ad";
            cbSinif.ValueMember = "Id";
            cbSinif.DataSource = KayitYoneticisi.Siniflar;

            lbOgrenciler.DisplayMember = "AdSoyad";
            lbOgrenciler.ValueMember = "Id";
            lbOgrenciler.DataSource = KayitYoneticisi.Ogrenciler;

            lbSecilenler.DisplayMember = "AdSoyad";
            lbSecilenler.ValueMember = "Id";
            lbSecilenler.DataSource = SeciliOgrenciListesi;

            Filtrele();
        }

        private void btnYeniSinif_Click(object sender, EventArgs e)
        {
            FrmYeniSinif form = new();
            var cevap = form.ShowDialog();

            if (cevap == DialogResult.OK)
            {
                MessageBox.Show("Yeni Sınıf kayıt edildi.");
            }
        }

        private void btnYeniOgrenci_Click(object sender, EventArgs e)
        {
            FrmYeniOgrenci form = new();
            var cevap = form.ShowDialog();

            if (cevap == DialogResult.OK)
            {
                Filtrele();
            }
        }

        private void Filtrele()
        {
            if (cbSinif.SelectedValue == null)
            {
                //S?n?f seçili de?ilse
                lbOgrenciler.DataSource = null;
                return;
            }

            //S?n?f seçili
            string sinifId = cbSinif.SelectedValue.ToString();

            //LINQ ile sorgulama
            //Lambda x => x.....
            var liste = KayitYoneticisi.
                Ogrenciler.Where(x => x.SinifId == sinifId).ToList();

            lbOgrenciler.DisplayMember = "AdSoyad";
            lbOgrenciler.ValueMember = "Id";
            lbOgrenciler.DataSource = liste;
        }

        private void cbSinif_SelectedValueChanged(object sender, EventArgs e)
        {
            Filtrele();
            BuHaftaTemizlikYapacaklar();
        }

        private void btnAta_Click(object sender, EventArgs e)
        {
            Ogrenci ogr = lbOgrenciler.SelectedItem as Ogrenci;

            if (ogr != null)
            {

                if (SeciliOgrenciListesi.Contains(ogr))
                {
                    MessageBox.Show("Öğrenci zaten seçili");
                    return;
                }

                SeciliOgrenciListesi.Add(ogr);
            }

        }
        void BuHaftaTemizlikYapacaklar()
        {

            if (cbSinif.SelectedValue == null)
            {

                return;
            }

            string sinifId =
                   cbSinif.SelectedValue.ToString();

            var liste = KayitYoneticisi.Ogrenciler
                .Where(x => x.SinifId == sinifId)
                .OrderBy(x => x.TemizlikPuani)
                .Take(2);
            lblBuhaftaSira.Text = "Bu haftaki sıra \n";

            if (liste.Count() == 0)
            {
                lblBuhaftaSira.Text += "Temizlik yapacak öğrenci yok";
            }
            foreach (Ogrenci ogr in liste)
            {
                lblBuhaftaSira.Text += $"{ogr.AdSoyad}\n";
            }

        }
        private void btnCikar_Click(object sender, EventArgs e)
        {
            //Seçili olanı öğrenci gibi al (as=gibi)
            //Alamazsan null değer ver
            Ogrenci ogr = lbSecilenler.SelectedItem as Ogrenci;

            if (ogr != null)
            {
                SeciliOgrenciListesi.Remove(ogr);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void bttnSec_Click(object sender, EventArgs e)
        {
            if (cbSinif.SelectedValue == null)
            {

                lbOgrenciler.DataSource = null;
                return;
            }


            string sinifId = cbSinif.SelectedValue.ToString();

            var liste = KayitYoneticisi.Ogrenciler
                .Where(x => x.SinifId == sinifId)
                .OrderBy(x => x.TemizlikPuani)
                .Take(2);

            foreach (Ogrenci ogr in liste)
            {
                if (!SeciliOgrenciListesi.Contains(ogr))
                    SeciliOgrenciListesi.Add(ogr);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            lblTarih.Text = $"Bugün {dt:dd} {dt:MMMM} {dt:yyyy} Saat: {dt:HH}:{dt:mm}";
        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            if (SeciliOgrenciListesi.Count == 0)
            {
                MessageBox.Show("Öğrenci Seçimi Yapınız");
                return;
            }


            foreach (Ogrenci ogr in SeciliOgrenciListesi)
            {
                TemizlikKayit kayit = new();
                kayit.Id = Guid.NewGuid().ToString();
                kayit.OgrenciId = ogr.Id;
                kayit.Tarih = dtpTarih.Value;

                KayitYoneticisi.TemizlikKayitlari.Add(kayit);
            }

            SeciliOgrenciListesi.Clear();

            KayitYoneticisi.Kaydet();
            Filtrele();
            BuHaftaTemizlikYapacaklar();
            MessageBox.Show("Kayıt oluşturuldu");

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}