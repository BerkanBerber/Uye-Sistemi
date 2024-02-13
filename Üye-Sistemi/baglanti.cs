using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace Üye_Sistemi
{
    internal class baglanti
    {
        MySqlConnection bag = new MySqlConnection
               ("Server=localhost;Database=udemyprojesi;Uid=root;pwd='H*Ry@F.lX(Ro!po/'");

        public void Baglanti()
        {
           
            try
            {
                bag.Open();

                if (bag.State != System.Data.ConnectionState.Closed)
                {
                    System.Windows.Forms.MessageBox.Show("Veritabanına Bağlantı Başarılı","Bilgi",System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Veritabanına Bağlanılamadı","Uyarı", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                }

            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("HATA");
            }
        }

        public void UyeEkle(string ad,string soyad,string mail) //aşagıda kullanacağız
        {

            bag.Close(); //Önceki BAĞLANTIYI kapattık
            bag.Open(); //Kendi bağlantımızı openladık

            MySqlCommand komut = new MySqlCommand("insert into uyeler (ad,soyad,mail) values(@p1,@p2,@p3)",bag); ///////////////*1////////////*2/////*3////////////

            //sorgumuzu oluştutduk daha sonra parantez içine sorguyu yazacağız.
            //*1insert ekleme komutu
            //*2uyeler tablosuna ekleyeceğimiz için uyeler yazdık
            //*3ne ekleyeceğimizi yeni parantez içinde yazdık
            //values içerisine değerlerin nereden geleceğini gösteren parametreleri tanımladık ve bag yazıp bağlanacağımız bağlantıyı vermiş olduk.Bu üstte yazdığımız veri tabanı bilgileri vs olduğu bag kısmı..

            komut.Parameters.AddWithValue("@p1", ad); //Komutumuzda ki parametrelerin değerini atayacağız.p1 e ad değerini ata

            komut.Parameters.AddWithValue("@p2", soyad); //Komutlarımın parametresine bir değer ekleyeceğim

            komut.Parameters.AddWithValue("@p3", mail);

            komut.ExecuteNonQuery(); //Burada ki komutların derlenmesi için yazdık.Çalıştır demiş olduk


            bag.Close(); //Bağlantımızı kestik

            System.Windows.Forms.MessageBox.Show("Üye sisteme eklendi", "Bilgi",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Information);

            //Üyenin eklendiği mesajını verdik.


        }

        public void UyeleriListelefun()
        {
            bag.Close ();   //bağlantı açıksa kapattık
            bag.Open(); //kendi bağlantımızı açtık
            MySqlCommand komut = new MySqlCommand("select * from uyeler", bag); //yeni listeleme komutu oluşturmak için command yazdık.. select listelemekti neyi listeleyeceğimizi yanına yazdık.. hepsini seçmel için * işaretini koyduk uyeler tablosunun tamanmını seçtik,, verileri bag dan secsin diye sonuna mutlaka veri tabanı yazdık
            MySqlDataReader dr = komut.ExecuteReader(); //sorgunun düzgün çalışması için oluşturduk..Anlamı dr isminde oluşt. değişken.. verileri okuyacak değişken oluşturduk..
            while (dr.Read()) //yani değer varsa // değer okunuyorsa //dr okunuyorsa yani değer varsa kodları çalıştır
            {
                UyelerıLıstele.uyeler.Add(dr["ad"] + " " + dr["soyad"] + " " + dr["mail"] + Environment.NewLine); //en son yazdığımız envnewline alt satıra geçirir
                    //uyeler listele formuna gidip oradan uyeleri al//biz bu listeye ekleyeceğimiz için .Add dedik 

                //while da eğer veri okunuyorsa yani üyemiz varsa buraya girdik .. Üyeleri Listele formuna ulaştık oradan uyeler listesine ulaştık.. .ADD oraya eleman ekle demek.. Ne ekleyeceğimizi de dr de okunan değerin adı soyadı ve maili..
                //aralarında da boşluk bıraktık
            }
        }

        public void UyeGuncelle(string ad, string soyad, string mail,string id) //yeni fonk.
        {
            bag.Close(); //..
            bag.Open(); //..
            MySqlCommand komut = new MySqlCommand("update uyeler set ad=@p1,soyad=@p2,mail=@p3 where id=@p4",bag); //update güncelleme

            komut.Parameters.AddWithValue("@p1", ad);
            komut.Parameters.AddWithValue("@p2", soyad);
            komut.Parameters.AddWithValue("@p3", mail);
            komut.Parameters.AddWithValue("@p4", id);
            komut.ExecuteNonQuery();

            System.Windows.Forms.MessageBox.Show("Üye başarılı bir şekilde güncellendi","Bilgilendirme",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Information); 


        }

        public void UyeSil(string ad)
        {
            bag.Close();
            bag.Open();
            MySqlCommand komut = new MySqlCommand("delete from uyeler where ad=@p1", bag);
            komut.Parameters.AddWithValue("@p1", ad);
            komut.ExecuteNonQuery();
            System.Windows.Forms.MessageBox.Show("Üye başarıyla silindi","Bilgi", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand);
            
        }
    }
}
