using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjeProgramcıHesapMakinesi
{
    public partial class Hesap : Form
    {
        bool optDurum = false; //Dört işleme basıldığının kontrolü
        bool optDurum1 = false; // Diğer işlemlere basıldığının kontolü
        bool hataliIslem = false;
        double kok = 0;
        double Ans = 0;
        double sonuc = 0;
        public Hesap()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        double Evaluate(string expression) // Bu fonksiyonu string halindeki bir işlemin sonucunu hesaplamak için kullanıyoruz.
        {
            string _expression = expression;
            
            try // Yanlış işlem yaptığımızda programın kapanmaması için hata yakalama işlemi yapıyoruz.
            {
                var loDataTable = new DataTable();
                var loDataColumn = new DataColumn("Eval", typeof(double), _expression);
                loDataTable.Columns.Add(loDataColumn);
                loDataTable.Rows.Add(0);
                return (double)(loDataTable.Rows[0]["Eval"]);


            }
            catch
            {
                MessageBox.Show("Hatalı işlem yaptınız. Lütfen Düzeltin!");
                hataliIslem = true;
                return 0;
            }

            
        }

        private void hesapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }

        private void digitalToolStripMenuItem_Click(object sender, EventArgs e) // digital menüsüne basınca geçiş yapmamızı sağlar.
        {
            Digital digi = new Digital();
            this.Hide();
            digi.Show();
            
            
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e) // Çıkış menüsüne basınca uygulamadan çıkmamızı sağlar.
        {
            DialogResult secenek = MessageBox.Show(
                "Programımızı kullandığınız için teşekkürler. " +
                "\nÇıkmak istediğinize emin misiniz?","Çıkış",
                MessageBoxButtons.YesNo);
            if (secenek == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void hakkındaToolStripMenuItem_Click(object sender, EventArgs e) // Hakkında menüsüne basınca bilgiler çıkar.
        {
            MessageBox.Show("Hesap Makinesi Prpgramı V1.0" +
                "\n\nMustafa Yılmaz tarafından geliştirilmiştir." +
                "\nHarran Üniversitesi" +
                "\nHaziran 2021 Şanlıurfa");
        }

        private void RakamEylem(object sender, EventArgs e) // Hangi rakama basmışsak o rakamı işlem stringine ekler.
        {
            Button btnRakam = (Button)sender;
            lblHesap.Text += btnRakam.Text;
        }

        private void btnDel_Click(object sender, EventArgs e) // Del tuşuna basılınca bir karakter siler.
        {
            if (lblHesap.Text.Length >= 1) // Bu if'i ekranda bir şey yazılı değilken hata vermemesi için yazıldı.
            {
                lblHesap.Text = lblHesap.Text.Substring(0, lblHesap.Text.Length - 1);
            }
        }

        private void btnAc_Click(object sender, EventArgs e) // Ac tuşuna basılınca ekrandaki herşeyi siler.
        {
            lblHesap.Text = "";
            lblHesap2.Text = "";
        }

        private void dortislemEylem(object sender, EventArgs e) // Dört işlemden basılanı işlem stringine ekler.
        {
            Button btnDortIslem = (Button)sender;
            lblHesap.Text += btnDortIslem.Text;
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            sonuc = Evaluate(lblHesap.Text);
            if (hataliIslem == false) // Bu koşulu hatalı işlem yapıldığında sonuç ekrana yazmasın diye yapıyoruz.
            {
                
                lblHesap.Text += "=";
                Ans = sonuc;
                lblHesap.Text += Convert.ToString(sonuc);
                sonuc = 0;
                lblHesap2.Text = lblHesap.Text; // Önceki yaptığımız işlemler gitmesin diye farklı bir label e yazdırıp ana labelimizi temizliyoruz
                lblHesap.Text = "";
            }
            hataliIslem = false;
        }

        private void btnAns_Click(object sender, EventArgs e)
        {
            string Ans1 = Convert.ToString(Ans);
            lblHesap.Text += Ans1;
        }

        private void btnKok_Click(object sender, EventArgs e)
        {
            try
            {
                kok = Convert.ToDouble(lblHesap.Text);
            }
            catch
            {

                MessageBox.Show("Hatalı işlem yaptınız. Lütfen Düzeltin!");
            }
            sonuc = Math.Sqrt(kok);
            string kok1 = Convert.ToString(kok);
            Ans = sonuc;
            lblHesap.Text = "√" + kok1 + "=" + Convert.ToString(sonuc);
            sonuc = 0;
            lblHesap2.Text = lblHesap.Text; // Önceki yaptığımız işlemler gitmesin diye farklı bir label e yazdırıp ana labelimizi temizliyoruz
            lblHesap.Text = "";
        }

        private void btnnokta_Click(object sender, EventArgs e)
        {
            lblHesap.Text += ".";
        }
    }
}
