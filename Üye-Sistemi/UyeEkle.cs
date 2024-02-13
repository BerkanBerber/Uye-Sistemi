using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Üye_Sistemi
{
    public partial class UyeEkle : Form
    {
        public UyeEkle()
        {
            InitializeComponent();
        }

        baglanti bgl = new baglanti();


        private void UyeEkle_Load(object sender, EventArgs e)
        {

            bgl.Baglanti();


        }

        private void btnUyeEkle_Click(object sender, EventArgs e)
        {
            if (txtAd.Text != "" && txtSoyad.Text != "" && txtMail.Text != "" ) //ad soyad ve mail ifadeleri boş değilse eğer
            {

                if (txtMail.Text.Contains("@gmail.com"))
                {
                    // Eğer '@gmail.com' ifadesi varsa, kodunuz burada çalışır.
                    bgl.UyeEkle(txtAd.Text, txtSoyad.Text, txtMail.Text); //bu kodlar çalışsın
                    txtAd.Text = ""; //ifadeleri kaydettikten sonra textboxları boş bırakması için
                    txtSoyad.Text = "";
                    txtMail.Text = "";
                }
                else
                {
                    // Eğer '@' ifadesi yoksa, kullanıcıya bir uyarı mesajı gösterilir.
                    MessageBox.Show("Geçersiz e-posta adresi!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Boş alan bırakmayınız!","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Error); //boşsa uyarı veriyor
            }

        }
    }
}
