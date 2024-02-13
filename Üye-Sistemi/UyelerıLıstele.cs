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
    public partial class UyelerıLıstele : Form
    {
        public UyelerıLıstele()
        {
            InitializeComponent();
        }

        baglanti bgl = new baglanti();  //veritabanı bağlantısı için
        static public List<string> uyeler = new List<string>(); //baglantı sınıfının içinde ki verileri listede tutmak için //başına static public yazdık ki diğer sınıftan da erişelim


        private void txtUyeLıstesı_TextChanged(object sender, EventArgs e)
        {


        }

        private void UyelerıLıstele_Load(object sender, EventArgs e)
        {
            bgl.UyeleriListelefun(); //bglden üyelerilistele fonksiyonunu çağırdık
            for (int i = 0; i < uyeler.Count; i++) //üyelerin length ine kadar gidecek ama listeler de length yok onun yerine count var count adet demek..
            {
                txtUyeLıstesı.Text += uyeler[i];  // bu dongu çalıştığı sürece txtuyelistesine yaz üyelerin i. elemanını yaz ... += yapmamızın nedeni döngüde yeni elemanı listelerken öncekini siliyordu sadece = olsaydı öncekiler silindiği için hep sonuncu elemanı görürdük.. aslında burada ki + kısaca her döndüğün elemmanı yazdır demek..
            }
            uyeler.Clear();//Tüm elemanları yazdırdıktan sonra listeyi temizle ki yeni kişi ekleyip listeleyince az önce yazdırdığı değerleri tekrar yazmasın.
        }
    }
}
