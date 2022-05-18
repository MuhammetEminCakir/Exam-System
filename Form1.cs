using System.Data;
using System.Data.SqlClient;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=VIVOBOOKPRO;Initial Catalog=güvenlik;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                string sql = "Select * From parola Where KullaniciAd=@adi AND Sifre=@sifresi";
                SqlParameter prm1 = new SqlParameter("adi", textBox1.Text.Trim());
                SqlParameter prm2 = new SqlParameter("sifresi", textBox2.Text.Trim());
                SqlCommand komut = new SqlCommand(sql, baglanti);
                komut.Parameters.Add(prm1);
                komut.Parameters.Add(prm2);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(komut);
                da.Fill(dt);

                if(dt.Rows.Count>0)
                {
                    Form2 fr=new Form2();
                    fr.Show();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hatalý giriþ!");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Kullanýcý adý: admin Þifre: 12345");
        }
        SqlConnection baglanti2 = new SqlConnection(@"Data Source=VIVOBOOKPRO;Initial Catalog=ogretmen;Integrated Security=True");
private void button2_Click(object sender, EventArgs e)
{
   try
   {
       baglanti2.Open();
       string sql = "Select * From parola Where KullaniciAd=@adi2 AND Sifre=@sifresi2";
       SqlParameter prm3 = new SqlParameter("adi2", textBox1.Text.Trim());
       SqlParameter prm4 = new SqlParameter("sifresi2", textBox2.Text.Trim());
       SqlCommand komut2 = new SqlCommand(sql, baglanti2);
       komut2.Parameters.Add(prm3);
       komut2.Parameters.Add(prm4);
       DataTable dt = new DataTable();
       SqlDataAdapter da = new SqlDataAdapter(komut2);
       da.Fill(dt);

       if (dt.Rows.Count > 0)
       {
           Form3 fr = new Form3();
           fr.Show();
       }
   }
   catch (Exception)
   {

   }
}
SqlConnection baglanti3 = new SqlConnection(@"Data Source=VIVOBOOKPRO;Initial Catalog=ogrenci;Integrated Security=True");
private void button3_Click(object sender, EventArgs e)
{
   try
   {
       baglanti3.Open();
       string sql = "Select * From parola Where KullaniciAd=@adi AND Sifre=@sifresi";
       SqlParameter prm5 = new SqlParameter("adi", textBox1.Text.Trim());
       SqlParameter prm6 = new SqlParameter("sifresi", textBox2.Text.Trim());
       SqlCommand komut3 = new SqlCommand(sql, baglanti3);
       komut3.Parameters.Add(prm5);
       komut3.Parameters.Add(prm6);
       DataTable dt = new DataTable();
       SqlDataAdapter da = new SqlDataAdapter(komut3);
       da.Fill(dt);

       if (dt.Rows.Count > 0)
       {
           Form4 fr = new Form4();
           fr.Show();
       }
   }
   catch (Exception)
   {
       MessageBox.Show("Hatalý giriþ!");
   }
}
    }
}