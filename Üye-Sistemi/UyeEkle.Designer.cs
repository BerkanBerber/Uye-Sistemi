namespace Üye_Sistemi
{
    partial class UyeEkle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            txtMail = new TextBox();
            btnUyeEkle = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, 40);
            label1.Name = "label1";
            label1.Size = new Size(109, 21);
            label1.TabIndex = 4;
            label1.Text = "Adınızı Giriniz:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 104);
            label2.Name = "label2";
            label2.Size = new Size(133, 21);
            label2.TabIndex = 5;
            label2.Text = "Soyadınızı Giriniz:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 168);
            label3.Name = "label3";
            label3.Size = new Size(138, 21);
            label3.TabIndex = 6;
            label3.Text = "E-Posta'nızı Giriniz";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(184, 40);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(201, 29);
            txtAd.TabIndex = 0;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(184, 103);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(201, 29);
            txtSoyad.TabIndex = 1;
            // 
            // txtMail
            // 
            txtMail.Location = new Point(184, 163);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(201, 29);
            txtMail.TabIndex = 2;
            // 
            // btnUyeEkle
            // 
            btnUyeEkle.Location = new Point(125, 240);
            btnUyeEkle.Name = "btnUyeEkle";
            btnUyeEkle.Size = new Size(174, 85);
            btnUyeEkle.TabIndex = 3;
            btnUyeEkle.Text = "Üye Ekle";
            btnUyeEkle.UseVisualStyleBackColor = true;
            btnUyeEkle.Click += btnUyeEkle_Click;
            // 
            // UyeEkle
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(448, 392);
            Controls.Add(btnUyeEkle);
            Controls.Add(txtMail);
            Controls.Add(txtSoyad);
            Controls.Add(txtAd);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "UyeEkle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Üye Ekle";
            Load += UyeEkle_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtAd;
        private TextBox txtSoyad;
        private TextBox txtMail;
        private Button btnUyeEkle;
    }
}