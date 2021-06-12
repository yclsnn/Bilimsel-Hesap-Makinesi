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
    public partial class Digital : Form
    {
        string optDurum = "empty";
        string firsNumber ;
        string secondNumber ;
        int sonuc = 0;
        public Digital()
        {
            InitializeComponent();
        }

        private void Digital_Load(object sender, EventArgs e)
        {

        }

        private void hesapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hesap hesap = new Hesap();
            this.Hide();
            hesap.Show();
            
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult secenek = MessageBox.Show(
                "Programımızı kullandığınız için teşekkürler. " +
                "\nÇıkmak istediğinize emin misiniz?", "Çıkış",
                MessageBoxButtons.YesNo);
            if (secenek == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void hakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hesap Makinesi Prpgramı V1.0" +
                "\n\nMustafa Yılmaz tarafından geliştirilmiştir." +
                "\nHarran Üniversitesi" +
                "\nHaziran 2021 Şanlıurfa");
        }

        private void RakamEylemDigital(object sender, EventArgs e)
        {
            if(rbtnDecimal.Checked == true)
            {
                Button btnRakam = (Button)sender;
                lblDecimal1.Text += btnRakam.Text;
                if(optDurum == "empty")
                {
                    firsNumber += btnRakam.Text;
                }
                else
                {
                    secondNumber += btnRakam.Text;
                }
            }
            
        }

        private void btnAndD_Click(object sender, EventArgs e)
        {
            if (rbtnDecimal.Checked == true)
            {
                optDurum = "and";
                lblDecimal1.Text += " AND ";
            }
        }

        private void btnOrD_Click(object sender, EventArgs e)
        {
            if (rbtnDecimal.Checked == true)
            {
                optDurum = "or";
                lblDecimal1.Text += " OR ";
            }
        }

        private void btnXorD_Click(object sender, EventArgs e)
        {
            if (rbtnDecimal.Checked == true)
            {
                optDurum = "xor";
                lblDecimal1.Text += " XOR ";
            }
        }

        private void btnHesaplaD_Click(object sender, EventArgs e)
        {
            if (rbtnDecimal.Checked == true)
            {
                if(optDurum == "and") 
                {
                    sonuc = Convert.ToInt32(firsNumber) & Convert.ToInt32(secondNumber);
                    lblDecimal1.Text += " = ";
                    lblDecimal1.Text += Convert.ToString(sonuc);
                    lblDecimal2.Text = lblDecimal1.Text;
                    lblDecimal1.Text = "";
                }
                else if (optDurum == "or")
                {
                    sonuc = Convert.ToInt32(firsNumber) | Convert.ToInt32(secondNumber);
                    lblDecimal1.Text += " = ";
                    lblDecimal1.Text += Convert.ToString(sonuc);
                    lblDecimal2.Text = lblDecimal1.Text;
                    lblDecimal1.Text = "";
                }
                else if (optDurum == "xor")
                {
                    sonuc = Convert.ToInt32(firsNumber) ^ Convert.ToInt32(secondNumber);
                    lblDecimal1.Text += " = ";
                    lblDecimal1.Text += Convert.ToString(sonuc);
                    lblDecimal2.Text = lblDecimal1.Text;
                    lblDecimal1.Text = "";
                }
                firsNumber = "";
                secondNumber = "";
            }
        }

        private void btnAndB_Click(object sender, EventArgs e)
        {
            if (rbtnBinary.Checked == true)
            {
                optDurum = "and";
                lblBinary1.Text += " AND ";
            }
        }

        private void btnOrB_Click(object sender, EventArgs e)
        {
            if (rbtnBinary.Checked == true)
            {
                optDurum = "or";
                lblBinary1.Text += " OR ";
            }
        }

        private void btnXorB_Click(object sender, EventArgs e)
        {
            if (rbtnBinary.Checked == true)
            {
                optDurum = "xor";
                lblBinary1.Text += " XOR ";
            }
        }

        private void RakamEylemBinary(object sender, EventArgs e)
        {
            if (rbtnBinary.Checked == true)
            {
                Button btnRakam = (Button)sender;
                lblBinary1.Text += btnRakam.Text;
                if (optDurum == "empty")
                {
                    firsNumber += btnRakam.Text;
                }
                else
                {
                    secondNumber += btnRakam.Text;
                }
            }
        }

        private void btnHesaplaB_Click(object sender, EventArgs e)
        {
            if (rbtnBinary.Checked == true)
            {
                if (optDurum == "and")
                {
                    sonuc = Convert.ToInt32(firsNumber,2) & Convert.ToInt32(secondNumber,2);
                    lblBinary1.Text += " = ";
                    lblBinary1.Text += Convert.ToString(sonuc,2);
                    lblBinary2.Text = lblBinary1.Text;
                    lblBinary1.Text = "";
                }
                else if (optDurum == "or")
                {
                    sonuc = Convert.ToInt32(firsNumber,2) | Convert.ToInt32(secondNumber,2);
                    lblBinary1.Text += " = ";
                    lblBinary1.Text += Convert.ToString(sonuc,2);
                    lblBinary2.Text = lblBinary1.Text;
                    lblBinary1.Text = "";
                }
                else if (optDurum == "xor")
                {
                    sonuc = Convert.ToInt32(firsNumber,2) ^ Convert.ToInt32(secondNumber,2);
                    lblBinary1.Text += " = ";
                    lblBinary1.Text += Convert.ToString(sonuc,2);
                    lblBinary2.Text = lblBinary1.Text;
                    lblBinary1.Text = "";
                }
                firsNumber = "";
                secondNumber = "";

            }
        }

        private void RakamEylemHexa(object sender, EventArgs e)
        {
            if (rbtnHexedecimal.Checked == true)
            {
                Button btnRakam = (Button)sender;
                lblHexedecimal1.Text += btnRakam.Text;
                if (optDurum == "empty")
                {
                    firsNumber += btnRakam.Text;
                }
                else
                {
                    secondNumber += btnRakam.Text;
                }
            }
        }

        private void btnAndH_Click(object sender, EventArgs e)
        {
            if (rbtnHexedecimal.Checked == true)
            {
                optDurum = "and";
                lblHexedecimal1.Text += " AND ";
            }
        }

        private void btnOrH_Click(object sender, EventArgs e)
        {
            if (rbtnHexedecimal.Checked == true)
            {
                optDurum = "or";
                lblHexedecimal1.Text += " OR ";
            }
        }

        private void btnXorH_Click(object sender, EventArgs e)
        {
            if (rbtnHexedecimal.Checked == true)
            {
                optDurum = "xor";
                lblHexedecimal1.Text += " XOR ";
            }
        }

        private void btnHesaplaH_Click(object sender, EventArgs e)
        {
            if (rbtnHexedecimal.Checked == true)
            {
                if (optDurum == "and")
                {
                    sonuc = Convert.ToInt32(firsNumber, 16) & Convert.ToInt32(secondNumber, 16);
                    string hexa = string.Format("{0:x}", sonuc);
                    lblHexedecimal1.Text += " = ";
                    lblHexedecimal1.Text += hexa;
                    lblHexedecimal2.Text = lblHexedecimal1.Text;
                    lblHexedecimal1.Text = "";
                }
                else if (optDurum == "or")
                {
                    sonuc = Convert.ToInt32(firsNumber, 16) & Convert.ToInt32(secondNumber, 16);
                    string hexa = string.Format("{0:x}", sonuc);
                    lblHexedecimal1.Text += " = ";
                    lblHexedecimal1.Text += hexa;
                    lblHexedecimal2.Text = lblHexedecimal1.Text;
                    lblHexedecimal1.Text = "";
                }
                else if (optDurum == "xor")
                {
                    sonuc = Convert.ToInt32(firsNumber, 16) & Convert.ToInt32(secondNumber, 16);
                    string hexa = string.Format("{0:x}", sonuc);
                    lblHexedecimal1.Text += " = ";
                    lblHexedecimal1.Text += hexa;
                    lblHexedecimal2.Text = lblHexedecimal1.Text;
                    lblHexedecimal1.Text = "";
                }
                firsNumber = "";
                secondNumber = "";
            }
        }

        private void btnAcDigital_Click(object sender, EventArgs e)
        {
            lblHexedecimal1.Text = "";
            lblHexedecimal2.Text = "";
            lblBinary1.Text = "";
            lblBinary2.Text = "";
            lblDecimal1.Text = "";
            lblDecimal2.Text = "";
        }
    }
}
