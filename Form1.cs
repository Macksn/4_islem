using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace dört_işlem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sayı1, sayı2, sonuç;
            sayı1 = Convert.ToInt16(textBox1.Text);
            sayı2 = Convert.ToInt16(textBox2.Text);
            sonuç = sayı1 + sayı2;
            label3.Text = sonuç.ToString();
            sonuç = sayı1 - sayı2;
            label4.Text = sonuç.ToString();
            sonuç = sayı1 * sayı2;
            label5.Text = sonuç.ToString();
            sonuç = sayı1 / sayı2;
            label6.Text = sonuç.ToString();



        }
    }
}
