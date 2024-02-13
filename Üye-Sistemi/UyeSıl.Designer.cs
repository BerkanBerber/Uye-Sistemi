namespace Üye_Sistemi
{
    partial class UyeSıl
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
            txtSılınecekUye = new TextBox();
            btnSıl = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 70);
            label1.Name = "label1";
            label1.Size = new Size(151, 21);
            label1.TabIndex = 0;
            label1.Text = "Silinecek Kişinin Adı:";
            // 
            // txtSılınecekUye
            // 
            txtSılınecekUye.Location = new Point(199, 67);
            txtSılınecekUye.Name = "txtSılınecekUye";
            txtSılınecekUye.Size = new Size(200, 29);
            txtSılınecekUye.TabIndex = 1;
            // 
            // btnSıl
            // 
            btnSıl.Location = new Point(90, 157);
            btnSıl.Name = "btnSıl";
            btnSıl.Size = new Size(255, 107);
            btnSıl.TabIndex = 2;
            btnSıl.Text = "Üyeyi Sil";
            btnSıl.UseVisualStyleBackColor = true;
            btnSıl.Click += btnSıl_Click;
            // 
            // UyeSıl
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(481, 380);
            Controls.Add(btnSıl);
            Controls.Add(txtSılınecekUye);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "UyeSıl";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Üye Sil";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtSılınecekUye;
        private Button btnSıl;
    }
}