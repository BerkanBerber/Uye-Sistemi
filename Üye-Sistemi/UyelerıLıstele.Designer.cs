namespace Üye_Sistemi
{
    partial class UyelerıLıstele
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
            txtUyeLıstesı = new TextBox();
            SuspendLayout();
            // 
            // txtUyeLıstesı
            // 
            txtUyeLıstesı.BackColor = SystemColors.ButtonHighlight;
            txtUyeLıstesı.Dock = DockStyle.Fill;
            txtUyeLıstesı.Location = new Point(0, 0);
            txtUyeLıstesı.Multiline = true;
            txtUyeLıstesı.Name = "txtUyeLıstesı";
            txtUyeLıstesı.ReadOnly = true;
            txtUyeLıstesı.Size = new Size(556, 507);
            txtUyeLıstesı.TabIndex = 0;
            txtUyeLıstesı.TextChanged += txtUyeLıstesı_TextChanged;
            // 
            // UyelerıLıstele
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(556, 507);
            Controls.Add(txtUyeLıstesı);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "UyelerıLıstele";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Üyeleri Listele";
            Load += UyelerıLıstele_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUyeLıstesı;
    }
}