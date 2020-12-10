using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ucus_Paneli
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Nereden: " + comboBox1.Text + " Nereye:" + comboBox2.Text + " Tarih:" + dateTimePicker1.Text + " Saat:" + maskedTextBox1.Text + " ~Yolcu Bilgileri~ Yolcu Ad Soyad:" + maskedTextBox2.Text + " Tc:" + maskedTextBox3.Text + " Telefon:" + maskedTextBox4.Text);
        }
    }
}
