using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinemaBufeSatis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, sayi3, sayi4;

            sayi1 = Convert.ToInt32(textBox1.Text);
            sayi2 = Convert.ToInt32(textBox2.Text);
            sayi3 = Convert.ToInt32(textBox3.Text);
            sayi4 = Convert.ToInt32(textBox4.Text);

            int toplam;
            toplam = sayi1 * 25 + sayi2 * 5 + sayi3 * 2 + sayi4 * 6;
            label9.Text = "Toplam= " + Convert.ToString(toplam)  +"TL";
           
        }
    }
}
