using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bakery
{
    public partial class KullaniciGirisi : Form
    {
        //string baglanti = "Data Source=DESKTOP-TQ8FN5C\\SQLDERS;Initial Catalog=Bakery;User ID=sa;Password=1";
        string connection = " Server = DESKTOP-TQ8FN5C\\SQLDERS; Database=Bakery;User Id=sa;Password=1;TrustServerCertificate=True;";
   
        
        private bool isTextbox1Active;

        public KullaniciGirisi()
        {
            InitializeComponent();
            txtsifre.LostFocus += new EventHandler(TextBox_LostFocus);
            btn1.Click += new EventHandler(btnClick);
            btn2.Click += new EventHandler(btnClick);
            btn3.Click += new EventHandler(btnClick);
            btn4.Click += new EventHandler(btnClick);
            btn5.Click += new EventHandler(btnClick);
            btn6.Click += new EventHandler(btnClick);
            btn7.Click += new EventHandler(btnClick);
            btn8.Click += new EventHandler(btnClick);
            btn9.Click += new EventHandler(btnClick);
            btn0.Click += new EventHandler(btnClick);
        }

        private void btnClick(object sender, EventArgs e)
        {
            string number = (sender as Button).Text;
            if (isTextbox1Active)
            {
                txtsifre.Text += number;
            }
            else
            {
                txtsifre.Text += number;
            }
        }

        private void TextBox_LostFocus(object sender, EventArgs e)
        {
            if ((sender as TextBox).Name == "txtNumara1")
            {
                isTextbox1Active = true;
            }
            else
            {
                isTextbox1Active = false;
            }
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            try
            {
                
                SqlConnection con = new SqlConnection(connection);
                string sfr = txtsifre.Text;
                con.Open();

                string query = $"SELECT * FROM Kullanicilar where KullanıcıŞifresi='{sfr}' ";
                SqlCommand cmd = new SqlCommand(query,con);
                


               
                int sfrkontrol = (int)cmd.ExecuteScalar();

               if(sfrkontrol>0)
               {
                    MessageBox.Show("GİRİŞ BAŞARILI");
                    this.Hide();
                    Ana_Ekran Aekran = new Ana_Ekran();
                    Aekran.Show();
               }
               else
               {
                    MessageBox.Show("Şifre Hatalı!");
               }
                    
                
              

            }
            catch
            {
                MessageBox.Show("HATA!");
            }

        }
            
        
    }
}
