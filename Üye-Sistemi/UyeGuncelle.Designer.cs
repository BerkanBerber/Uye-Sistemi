namespace Üye_Sistemi
{
    partial class UyeGuncelle
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
            btnUyeGuncelle = new Button();
            txtMail = new TextBox();
            txtSoyad = new TextBox();
            txtAd = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            chckOnay = new CheckBox();
            txtID = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // btnUyeGuncelle
            // 
            btnUyeGuncelle.Location = new Point(120, 293);
            btnUyeGuncelle.Name = "btnUyeGuncelle";
            btnUyeGuncelle.Size = new Size(174, 85);
            btnUyeGuncelle.TabIndex = 13;
            btnUyeGuncelle.Text = "Üye Güncelle";
            btnUyeGuncelle.UseVisualStyleBackColor = true;
            btnUyeGuncelle.Click += btnUyeGuncelle_Click;
            // 
            // txtMail
            // 
            txtMail.Location = new Point(176, 222);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(201, 29);
            txtMail.TabIndex = 12;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(176, 162);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(201, 29);
            txtSoyad.TabIndex = 11;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(176, 99);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(201, 29);
            txtAd.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 227);
            label3.Name = "label3";
            label3.Size = new Size(138, 21);
            label3.TabIndex = 9;
            label3.Text = "E-Posta'nızı Giriniz";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 163);
            label2.Name = "label2";
            label2.Size = new Size(133, 21);
            label2.TabIndex = 8;
            label2.Text = "Soyadınızı Giriniz:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 99);
            label1.Name = "label1";
            label1.Size = new Size(109, 21);
            label1.TabIndex = 7;
            label1.Text = "Adınızı Giriniz:";
            // 
            // chckOnay
            // 
            chckOnay.AutoSize = true;
            chckOnay.Location = new Point(72, 262);
            chckOnay.Name = "chckOnay";
            chckOnay.Size = new Size(279, 25);
            chckOnay.TabIndex = 14;
            chckOnay.Text = "Bilgileri Güncellemeyi Onaylıyorum!";
            chckOnay.UseVisualStyleBackColor = true;
            // 
            // txtID
            // 
            txtID.Location = new Point(202, 12);
            txtID.Name = "txtID";
            txtID.Size = new Size(135, 29);
            txtID.TabIndex = 16;
            txtID.TextChanged += textBox1_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(119, 15);
            label4.Name = "label4";
            label4.Size = new Size(77, 21);
            label4.TabIndex = 15;
            label4.Text = "ID Giriniz:";
            // 
            // UyeGuncelle
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(446, 390);
            Controls.Add(txtID);
            Controls.Add(label4);
            Controls.Add(chckOnay);
            Controls.Add(btnUyeGuncelle);
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
            Name = "UyeGuncelle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Üye Güncelle";
            Load += UyeGuncelle_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnUyeGuncelle;
        private TextBox txtMail;
        private TextBox txtSoyad;
        private TextBox txtAd;
        private Label label3;
        private Label label2;
        private Label label1;
        private CheckBox chckOnay;
        private TextBox txtID;
        private Label label4;
    }
}