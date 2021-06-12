
namespace ProjeProgramcıHesapMakinesi
{
    partial class Hesap
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbxHesap = new System.Windows.Forms.GroupBox();
            this.btnBolme = new System.Windows.Forms.Button();
            this.btnCikarma = new System.Windows.Forms.Button();
            this.btnBos1 = new System.Windows.Forms.Button();
            this.btnParantez1 = new System.Windows.Forms.Button();
            this.btnKok = new System.Windows.Forms.Button();
            this.btnKalan = new System.Windows.Forms.Button();
            this.btnBos2 = new System.Windows.Forms.Button();
            this.btnParantez = new System.Windows.Forms.Button();
            this.btnUs = new System.Windows.Forms.Button();
            this.btnLog = new System.Windows.Forms.Button();
            this.btnBos3 = new System.Windows.Forms.Button();
            this.btnAc = new System.Windows.Forms.Button();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.btnToplama = new System.Windows.Forms.Button();
            this.btnCarpma = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnAns = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnnokta = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.hesapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.digitalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkındaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lblHesap = new System.Windows.Forms.Label();
            this.lblHesap2 = new System.Windows.Forms.Label();
            this.gbxHesap.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxHesap
            // 
            this.gbxHesap.Controls.Add(this.btnBolme);
            this.gbxHesap.Controls.Add(this.btnCikarma);
            this.gbxHesap.Controls.Add(this.btnBos1);
            this.gbxHesap.Controls.Add(this.btnParantez1);
            this.gbxHesap.Controls.Add(this.btnKok);
            this.gbxHesap.Controls.Add(this.btnKalan);
            this.gbxHesap.Controls.Add(this.btnBos2);
            this.gbxHesap.Controls.Add(this.btnParantez);
            this.gbxHesap.Controls.Add(this.btnUs);
            this.gbxHesap.Controls.Add(this.btnLog);
            this.gbxHesap.Controls.Add(this.btnBos3);
            this.gbxHesap.Controls.Add(this.btnAc);
            this.gbxHesap.Controls.Add(this.btnHesapla);
            this.gbxHesap.Controls.Add(this.btnToplama);
            this.gbxHesap.Controls.Add(this.btnCarpma);
            this.gbxHesap.Controls.Add(this.btnDel);
            this.gbxHesap.Controls.Add(this.btnAns);
            this.gbxHesap.Controls.Add(this.btn3);
            this.gbxHesap.Controls.Add(this.btn6);
            this.gbxHesap.Controls.Add(this.btn9);
            this.gbxHesap.Controls.Add(this.btnnokta);
            this.gbxHesap.Controls.Add(this.btn2);
            this.gbxHesap.Controls.Add(this.btn5);
            this.gbxHesap.Controls.Add(this.btn8);
            this.gbxHesap.Controls.Add(this.btn0);
            this.gbxHesap.Controls.Add(this.btn1);
            this.gbxHesap.Controls.Add(this.btn4);
            this.gbxHesap.Controls.Add(this.btn7);
            this.gbxHesap.Location = new System.Drawing.Point(12, 198);
            this.gbxHesap.Name = "gbxHesap";
            this.gbxHesap.Size = new System.Drawing.Size(471, 299);
            this.gbxHesap.TabIndex = 2;
            this.gbxHesap.TabStop = false;
            this.gbxHesap.Text = "Tuşlar";
            // 
            // btnBolme
            // 
            this.btnBolme.Location = new System.Drawing.Point(270, 96);
            this.btnBolme.Name = "btnBolme";
            this.btnBolme.Size = new System.Drawing.Size(60, 60);
            this.btnBolme.TabIndex = 28;
            this.btnBolme.Text = "/";
            this.btnBolme.UseVisualStyleBackColor = true;
            this.btnBolme.Click += new System.EventHandler(this.dortislemEylem);
            // 
            // btnCikarma
            // 
            this.btnCikarma.Location = new System.Drawing.Point(270, 164);
            this.btnCikarma.Name = "btnCikarma";
            this.btnCikarma.Size = new System.Drawing.Size(60, 60);
            this.btnCikarma.TabIndex = 27;
            this.btnCikarma.Text = "-";
            this.btnCikarma.UseVisualStyleBackColor = true;
            this.btnCikarma.Click += new System.EventHandler(this.dortislemEylem);
            // 
            // btnBos1
            // 
            this.btnBos1.Location = new System.Drawing.Point(270, 230);
            this.btnBos1.Name = "btnBos1";
            this.btnBos1.Size = new System.Drawing.Size(60, 60);
            this.btnBos1.TabIndex = 26;
            this.btnBos1.UseVisualStyleBackColor = true;
            // 
            // btnParantez1
            // 
            this.btnParantez1.Location = new System.Drawing.Point(336, 30);
            this.btnParantez1.Name = "btnParantez1";
            this.btnParantez1.Size = new System.Drawing.Size(60, 60);
            this.btnParantez1.TabIndex = 25;
            this.btnParantez1.Text = "(";
            this.btnParantez1.UseVisualStyleBackColor = true;
            this.btnParantez1.Click += new System.EventHandler(this.dortislemEylem);
            // 
            // btnKok
            // 
            this.btnKok.Location = new System.Drawing.Point(336, 96);
            this.btnKok.Name = "btnKok";
            this.btnKok.Size = new System.Drawing.Size(60, 60);
            this.btnKok.TabIndex = 24;
            this.btnKok.Text = "√";
            this.btnKok.UseVisualStyleBackColor = true;
            this.btnKok.Click += new System.EventHandler(this.btnKok_Click);
            // 
            // btnKalan
            // 
            this.btnKalan.Location = new System.Drawing.Point(336, 162);
            this.btnKalan.Name = "btnKalan";
            this.btnKalan.Size = new System.Drawing.Size(60, 60);
            this.btnKalan.TabIndex = 23;
            this.btnKalan.Text = "%";
            this.btnKalan.UseVisualStyleBackColor = true;
            // 
            // btnBos2
            // 
            this.btnBos2.Location = new System.Drawing.Point(336, 228);
            this.btnBos2.Name = "btnBos2";
            this.btnBos2.Size = new System.Drawing.Size(60, 60);
            this.btnBos2.TabIndex = 22;
            this.btnBos2.UseVisualStyleBackColor = true;
            // 
            // btnParantez
            // 
            this.btnParantez.Location = new System.Drawing.Point(402, 30);
            this.btnParantez.Name = "btnParantez";
            this.btnParantez.Size = new System.Drawing.Size(60, 60);
            this.btnParantez.TabIndex = 21;
            this.btnParantez.Text = ")";
            this.btnParantez.UseVisualStyleBackColor = true;
            this.btnParantez.Click += new System.EventHandler(this.dortislemEylem);
            // 
            // btnUs
            // 
            this.btnUs.Location = new System.Drawing.Point(402, 96);
            this.btnUs.Name = "btnUs";
            this.btnUs.Size = new System.Drawing.Size(60, 60);
            this.btnUs.TabIndex = 20;
            this.btnUs.Text = "x²";
            this.btnUs.UseVisualStyleBackColor = true;
            // 
            // btnLog
            // 
            this.btnLog.Location = new System.Drawing.Point(402, 162);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(60, 60);
            this.btnLog.TabIndex = 19;
            this.btnLog.Text = "log";
            this.btnLog.UseVisualStyleBackColor = true;
            // 
            // btnBos3
            // 
            this.btnBos3.Location = new System.Drawing.Point(402, 228);
            this.btnBos3.Name = "btnBos3";
            this.btnBos3.Size = new System.Drawing.Size(60, 60);
            this.btnBos3.TabIndex = 18;
            this.btnBos3.UseVisualStyleBackColor = true;
            // 
            // btnAc
            // 
            this.btnAc.Location = new System.Drawing.Point(270, 30);
            this.btnAc.Name = "btnAc";
            this.btnAc.Size = new System.Drawing.Size(60, 60);
            this.btnAc.TabIndex = 16;
            this.btnAc.Text = "AC";
            this.btnAc.UseVisualStyleBackColor = true;
            this.btnAc.Click += new System.EventHandler(this.btnAc_Click);
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(204, 230);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(60, 60);
            this.btnHesapla.TabIndex = 15;
            this.btnHesapla.Text = "=";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // btnToplama
            // 
            this.btnToplama.Location = new System.Drawing.Point(204, 164);
            this.btnToplama.Name = "btnToplama";
            this.btnToplama.Size = new System.Drawing.Size(60, 60);
            this.btnToplama.TabIndex = 14;
            this.btnToplama.Text = "+";
            this.btnToplama.UseVisualStyleBackColor = true;
            this.btnToplama.Click += new System.EventHandler(this.dortislemEylem);
            // 
            // btnCarpma
            // 
            this.btnCarpma.Location = new System.Drawing.Point(204, 98);
            this.btnCarpma.Name = "btnCarpma";
            this.btnCarpma.Size = new System.Drawing.Size(60, 60);
            this.btnCarpma.TabIndex = 13;
            this.btnCarpma.Text = "*";
            this.btnCarpma.UseVisualStyleBackColor = true;
            this.btnCarpma.Click += new System.EventHandler(this.dortislemEylem);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(204, 30);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(60, 60);
            this.btnDel.TabIndex = 12;
            this.btnDel.Text = "DEL";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnAns
            // 
            this.btnAns.Location = new System.Drawing.Point(138, 228);
            this.btnAns.Name = "btnAns";
            this.btnAns.Size = new System.Drawing.Size(60, 60);
            this.btnAns.TabIndex = 11;
            this.btnAns.Text = "Ans";
            this.btnAns.UseVisualStyleBackColor = true;
            this.btnAns.Click += new System.EventHandler(this.btnAns_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(138, 162);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(60, 60);
            this.btn3.TabIndex = 10;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.RakamEylem);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(138, 96);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(60, 60);
            this.btn6.TabIndex = 9;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.RakamEylem);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(138, 30);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(60, 60);
            this.btn9.TabIndex = 8;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.RakamEylem);
            // 
            // btnnokta
            // 
            this.btnnokta.Location = new System.Drawing.Point(72, 228);
            this.btnnokta.Name = "btnnokta";
            this.btnnokta.Size = new System.Drawing.Size(60, 60);
            this.btnnokta.TabIndex = 7;
            this.btnnokta.Text = ".";
            this.btnnokta.UseVisualStyleBackColor = true;
            this.btnnokta.Click += new System.EventHandler(this.btnnokta_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(72, 162);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(60, 60);
            this.btn2.TabIndex = 6;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.RakamEylem);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(72, 96);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(60, 60);
            this.btn5.TabIndex = 5;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.RakamEylem);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(72, 30);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(60, 60);
            this.btn8.TabIndex = 4;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.RakamEylem);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(6, 228);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(60, 60);
            this.btn0.TabIndex = 3;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.RakamEylem);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(6, 162);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(60, 60);
            this.btn1.TabIndex = 2;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.RakamEylem);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(6, 96);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(60, 60);
            this.btn4.TabIndex = 1;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.RakamEylem);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(6, 30);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(60, 60);
            this.btn7.TabIndex = 0;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.RakamEylem);
            // 
            // hesapToolStripMenuItem
            // 
            this.hesapToolStripMenuItem.Font = new System.Drawing.Font("HelveticaNeueLT Pro 43 LtEx", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hesapToolStripMenuItem.Name = "hesapToolStripMenuItem";
            this.hesapToolStripMenuItem.Size = new System.Drawing.Size(89, 27);
            this.hesapToolStripMenuItem.Text = "Hesap";
            this.hesapToolStripMenuItem.Click += new System.EventHandler(this.hesapToolStripMenuItem_Click);
            // 
            // digitalToolStripMenuItem
            // 
            this.digitalToolStripMenuItem.Font = new System.Drawing.Font("HelveticaNeueLT Pro 43 LtEx", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.digitalToolStripMenuItem.Name = "digitalToolStripMenuItem";
            this.digitalToolStripMenuItem.Size = new System.Drawing.Size(84, 27);
            this.digitalToolStripMenuItem.Text = "Digital";
            this.digitalToolStripMenuItem.Click += new System.EventHandler(this.digitalToolStripMenuItem_Click);
            // 
            // hakkındaToolStripMenuItem
            // 
            this.hakkındaToolStripMenuItem.Font = new System.Drawing.Font("HelveticaNeueLT Pro 43 LtEx", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hakkındaToolStripMenuItem.Name = "hakkındaToolStripMenuItem";
            this.hakkındaToolStripMenuItem.Size = new System.Drawing.Size(116, 27);
            this.hakkındaToolStripMenuItem.Text = "Hakkında";
            this.hakkındaToolStripMenuItem.Click += new System.EventHandler(this.hakkındaToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Font = new System.Drawing.Font("HelveticaNeueLT Pro 43 LtEx", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(70, 27);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("HelveticaNeueLT Pro 43 LtEx", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hesapToolStripMenuItem,
            this.digitalToolStripMenuItem,
            this.hakkındaToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(13, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(499, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lblHesap
            // 
            this.lblHesap.AutoSize = true;
            this.lblHesap.Location = new System.Drawing.Point(8, 56);
            this.lblHesap.Name = "lblHesap";
            this.lblHesap.Size = new System.Drawing.Size(0, 23);
            this.lblHesap.TabIndex = 3;
            // 
            // lblHesap2
            // 
            this.lblHesap2.AutoSize = true;
            this.lblHesap2.Location = new System.Drawing.Point(8, 33);
            this.lblHesap2.Name = "lblHesap2";
            this.lblHesap2.Size = new System.Drawing.Size(0, 23);
            this.lblHesap2.TabIndex = 4;
            // 
            // Hesap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 503);
            this.Controls.Add(this.lblHesap2);
            this.Controls.Add(this.lblHesap);
            this.Controls.Add(this.gbxHesap);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("HelveticaNeueLT Pro 43 LtEx", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Hesap";
            this.Text = "Hesap";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxHesap.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxHesap;
        private System.Windows.Forms.Button btnBolme;
        private System.Windows.Forms.Button btnCikarma;
        private System.Windows.Forms.Button btnBos1;
        private System.Windows.Forms.Button btnParantez1;
        private System.Windows.Forms.Button btnKok;
        private System.Windows.Forms.Button btnKalan;
        private System.Windows.Forms.Button btnBos2;
        private System.Windows.Forms.Button btnParantez;
        private System.Windows.Forms.Button btnUs;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Button btnBos3;
        private System.Windows.Forms.Button btnAc;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Button btnToplama;
        private System.Windows.Forms.Button btnCarpma;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnAns;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnnokta;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.ToolStripMenuItem hesapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem digitalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hakkındaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label lblHesap;
        private System.Windows.Forms.Label lblHesap2;
    }
}

