using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otel_Rezervasyonu
{
    public partial class Form1 : Form
    {

        private string radiobutton = null;


        Rezervasyon rezervasyon = new Rezervasyon();

        public Form1()
        {
            InitializeComponent();


        }
        private void denizTek_CheckedChanged(object sender, EventArgs e)
        {
            if (denizTek.Checked == true)
            {
                radiobutton = "denizTek";
                listBox1.Visible = true;
                listBox2.Visible = false;
                listBox3.Visible = false;
                listBox4.Visible = false;
                listBox5.Visible = false;
                listBox6.Visible = false;

                labelDoluluk.Text = rezervasyon.odaDoluluk(radiobutton).ToString();
            }

        }

        private void denizCift_CheckedChanged(object sender, EventArgs e)
        {
            if (denizCift.Checked == true)
            {
                radiobutton = "denizCift";

                listBox1.Visible = false;
                listBox2.Visible = true;
                listBox3.Visible = false;
                listBox4.Visible = false;
                listBox5.Visible = false;
                listBox6.Visible = false;
            }
        }

        private void denizIkiz_CheckedChanged(object sender, EventArgs e)
        {
            if (denizIkiz.Checked == true)
            {
                radiobutton = "denizIkiz";
                listBox1.Visible = false;
                listBox2.Visible = false;
                listBox3.Visible = true;
                listBox4.Visible = false;
                listBox5.Visible = false;
                listBox6.Visible = false;
            }
        }



        private void havuzTek_CheckedChanged(object sender, EventArgs e)
        {
            if (havuzTek.Checked == true)
            {
                radiobutton = "havuzTek";
                listBox1.Visible = false;
                listBox2.Visible = false;
                listBox3.Visible = false;
                listBox4.Visible = true;
                listBox5.Visible = false;
                listBox6.Visible = false;
            }
        }

        private void havuzCift_CheckedChanged(object sender, EventArgs e)
        {
            if (havuzCift.Checked == true)
            {
                radiobutton = "havuzCift";
                listBox1.Visible = false;
                listBox2.Visible = false;
                listBox3.Visible = false;
                listBox4.Visible = false;
                listBox5.Visible = true;
                listBox6.Visible = false;
            }
        }
        private void havuzIkiz_CheckedChanged(object sender, EventArgs e)
        {
            if (havuzIkiz.Checked == true)
            {
                radiobutton = "havuzIkiz";
                listBox1.Visible = false;
                listBox2.Visible = false;
                listBox3.Visible = false;
                listBox4.Visible = false;
                listBox5.Visible = false;
                listBox6.Visible = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }


        private void rezervasyonYap_Click(object sender, EventArgs e)
        {
            DateTime baslangic = new DateTime(Int32.Parse(yilBaslangic.Text), Int32.Parse(ayBaslangic.Text), Int32.Parse(gunBaslangic.Text));
            DateTime bitis = new DateTime(Int32.Parse(yilBitis.Text), Int32.Parse(ayBitis.Text), Int32.Parse(gunBitis.Text));
            int result = rezervasyon.odaDurumSorgula(baslangic, bitis, radiobutton);

            if (result == 1)
            {
                string date;
                date = rezervasyon.rezervasyonIstekIlet(baslangic, bitis, radiobutton);
                listBoxEkle(date);
                MessageBox.Show("Başarıyla yapıldı");
            }
            else if (result == 3) MessageBox.Show("Geçersiz tarih");
            else if (result == 4) MessageBox.Show("Oda tipi seçiniz");
            else
            {
                MessageBox.Show("Oda geçerli tarihler arasında dolu");
            }

        }

       

        public void listBoxEkle(string data)
        {
            //Console.WriteLine("listbozekle çalıştı ve değer = " + data);

            if (listBox1.Visible == true)
                listBox1.Items.Add(data);
            else if (listBox2.Visible == true)
                listBox2.Items.Add(data);
            else if (listBox3.Visible == true)
                listBox3.Items.Add(data);
            else if (listBox4.Visible == true)
                listBox4.Items.Add(data);
            else if (listBox5.Visible == true)
                listBox5.Items.Add(data);
            else if (listBox6.Visible == true)
                listBox6.Items.Add(data);
            else MessageBox.Show("Oda türü seçiniz..!");





        }

        































        private void textBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


    }
}
