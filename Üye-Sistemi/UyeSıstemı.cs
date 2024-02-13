namespace Üye_Sistemi
{
    public partial class UyeSıstemı : Form
    {
        public UyeSıstemı()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            UyeSıl frm = new UyeSıl();

            frm.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            UyeEkle frm = new UyeEkle();

            frm.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            UyeGuncelle frm = new UyeGuncelle();

            frm.ShowDialog();

        }

        private void button4_Click(object sender, EventArgs e)
        {

            UyelerıLıstele frm = new UyelerıLıstele();

            frm.ShowDialog();

        }

        private void UyeSıstemı_Load(object sender, EventArgs e)
        {

        }
    }
}
