namespace Üye_Sistemi
{
    partial class UyeSıstemı
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14.25F);
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(254, 106);
            button1.TabIndex = 0;
            button1.Text = "Üye Ekle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 14.25F);
            button2.Location = new Point(283, 12);
            button2.Name = "button2";
            button2.Size = new Size(254, 106);
            button2.TabIndex = 1;
            button2.Text = "Üye Sil";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 14.25F);
            button3.Location = new Point(12, 134);
            button3.Name = "button3";
            button3.Size = new Size(254, 106);
            button3.TabIndex = 2;
            button3.Text = "Üye Güncelle";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 14.25F);
            button4.Location = new Point(283, 134);
            button4.Name = "button4";
            button4.Size = new Size(254, 106);
            button4.TabIndex = 3;
            button4.Text = "Üyeleri Listele";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // UyeSıstemı
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(566, 289);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "UyeSıstemı";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ana Ekran";
            Load += UyeSıstemı_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}
