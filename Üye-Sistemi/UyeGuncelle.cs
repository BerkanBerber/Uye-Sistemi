using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design.Behavior;

namespace Üye_Sistemi
{
    public partial class UyeGuncelle : Form
    {
        public UyeGuncelle()
        {
            InitializeComponent();
        }



        private void UyeGuncelle_Load(object sender, EventArgs e)
        {
            /*aşağıdaki ifadeleri form yüklenir yüklenmez pasif yaptık ki istediğimiz if sartını sağlıyorsa açılsın*/

            txtAd.Enabled=false;
            txtMail.Enabled=false;
            txtSoyad.Enabled=false;
            btnUyeGuncelle.Enabled=false;
            chckOnay.Enabled=false;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


            if (txtID.Text!="") //id kısmı boş değilse aşağıda ki ifadeler true olacak
            {
                txtAd.Enabled=true;
                txtMail.Enabled=true;
                txtSoyad.Enabled=true;
                btnUyeGuncelle.Enabled=true;
                chckOnay.Enabled=true;

            }
            else
            {
                txtAd.Enabled=false;
                txtMail.Enabled=false;
                txtSoyad.Enabled=false;
                btnUyeGuncelle.Enabled=false;
                chckOnay.Enabled=false;

            }
        }
        baglanti bgl = new baglanti();
        private void btnUyeGuncelle_Click(object sender, EventArgs e)
        {
            if (chckOnay.Checked==true) //chckbox onaylandımı kontrol et
            {
                bgl.UyeGuncelle(txtAd.Text, txtSoyad.Text, txtMail.Text, txtID.Text); //butona tıklanınca bgl clasına bağlan üye güncelleyi çağırıp ( içine de vereceğimiz değerleri yazdık)
           
            }
            else
            {
                MessageBox.Show("Onaylamadan güncelleme işlemi yapamazsınız!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
