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

        private void rezervasyonIptal_Click(object sender, EventArgs e)
        {
            //Console.WriteLine(listBox1.SelectedIndex);

            if (listBox1.Visible == true)
                rezervasyon.rezervasyonIptalIlet(listBox1.SelectedIndex, radiobutton);
            else if (listBox2.Visible == true)
                rezervasyon.rezervasyonIptalIlet(listBox2.SelectedIndex, radiobutton);
            else if (listBox3.Visible == true)
                rezervasyon.rezervasyonIptalIlet(listBox3.SelectedIndex, radiobutton);
            else if (listBox4.Visible == true)
                rezervasyon.rezervasyonIptalIlet(listBox4.SelectedIndex, radiobutton);
            else if (listBox5.Visible == true)
                rezervasyon.rezervasyonIptalIlet(listBox5.SelectedIndex, radiobutton);
            else if (listBox6.Visible == true)
                rezervasyon.rezervasyonIptalIlet(listBox6.SelectedIndex, radiobutton);


            listBoxSil();
            MessageBox.Show("Silindi");

        }
        public void listBoxSil()
        {
            //Console.WriteLine("sil çalıştı");



            if (listBox1.Visible == true)
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            else if (listBox2.Visible == true)
                listBox2.Items.RemoveAt(listBox2.SelectedIndex);
            else if (listBox3.Visible == true)
                listBox3.Items.RemoveAt(listBox3.SelectedIndex);
            else if (listBox4.Visible == true)
                listBox4.Items.RemoveAt(listBox4.SelectedIndex);
            else if (listBox5.Visible == true)
                listBox5.Items.RemoveAt(listBox5.SelectedIndex);
            else if (listBox6.Visible == true)
                listBox6.Items.RemoveAt(listBox6.SelectedIndex);
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
