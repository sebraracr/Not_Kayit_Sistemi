using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Not_Kayit_Sistemi
{
    public partial class FrmOgretmenDetay : Form
    {
        public FrmOgretmenDetay()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=localhost\SQLEXPRESS01;Initial Catalog=DbNotKayit;Integrated Security=True;");
        private void FrmOgretmenDetay_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbNotKayitDataSet.TblDers' table. You can move, or remove it, as needed.
            this.tblDersTableAdapter.Fill(this.dbNotKayitDataSet.TblDers);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TblDers (OgrNumara,OgrAd,OgrSoyad) values (@P1,@P2,@P3)", baglanti);
            komut.Parameters.AddWithValue("@P1", mskNum.Text);   
            komut.Parameters.AddWithValue("@P2", txtAd.Text);   
            komut.Parameters.AddWithValue("@P3", txtSoyad.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Öğrenci Sisteme Eklendi");
            this.tblDersTableAdapter.Fill(this.dbNotKayitDataSet.TblDers);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            mskNum.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtAd.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txtSoyad.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txtS1.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txtS2.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            txtS3.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            double ort, s1, s2, s3;
            string durum;
            s1= Convert.ToDouble(txtS1.Text);
            s2= Convert.ToDouble(txtS2.Text);
            s3=Convert.ToDouble(txtS3.Text);

            ort=(s1+s2 + s3)/3;
            lblOrt.Text = ort.ToString();
            if(ort>=50)
            {
                durum = "true";
            }
            else
            {
                durum="false";
            }

            baglanti.Open();
            SqlCommand komut = new SqlCommand("update TblDers set OgrS1=@P1 ,OgrS2=@P2,OgrS3=@P3,Ortalama=@P4,Durum=@P5 where OgrNumara=@P6",baglanti);

            komut.Parameters.AddWithValue("@P1",txtS1.Text);
            komut.Parameters.AddWithValue("@P2",txtS2.Text);
            komut.Parameters.AddWithValue("@P3",txtS3.Text);
            komut.Parameters.AddWithValue("@P4",decimal.Parse(lblOrt.Text));
            komut.Parameters.AddWithValue("@P5",durum);
            komut.Parameters.AddWithValue("@P6",mskNum.Text);
            komut.ExecuteNonQuery();
            // Geçen sayısı
            SqlCommand komut1 = new SqlCommand("select count(*) from TblDers where Durum=1", baglanti);
            lblGecenSayisi.Text = komut1.ExecuteScalar().ToString();

            // Kalan sayısı
            SqlCommand komut2 = new SqlCommand("select count(*) from TblDers where Durum=0", baglanti);
            lblKalanSayisi.Text = komut2.ExecuteScalar().ToString();

            // Sınıf ortalaması
            SqlCommand komut3 = new SqlCommand("select avg(Ortalama) from TblDers", baglanti);
            object sonuc = komut3.ExecuteScalar();
            if (sonuc != DBNull.Value)
            {
                lblSnfOrt.Text = Convert.ToDouble(sonuc).ToString("0.00");
            }
            baglanti.Close();
            MessageBox.Show("Öğrenci Notları Güncellendi");

           
            this.tblDersTableAdapter.Fill(this.dbNotKayitDataSet.TblDers);
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
