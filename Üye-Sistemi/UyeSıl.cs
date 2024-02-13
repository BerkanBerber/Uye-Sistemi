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
    public partial class UyeSıl : Form
    {
        public UyeSıl()
        {
            InitializeComponent();
        }

        baglanti bgl = new baglanti();
        private void btnSıl_Click(object sender, EventArgs e)
        {
            bgl.UyeSil(txtSılınecekUye.Text);
        }
    }
}
