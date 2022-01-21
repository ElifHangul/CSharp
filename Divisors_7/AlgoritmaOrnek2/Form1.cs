using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgoritmaOrnek2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int toplam = 0;
        int bolunenSayisi = 0;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 25; i++)
            {
                if (i % 7 == 0)
                {
                    bolunenSayisi++;
                    label3.Text = bolunenSayisi.ToString();
                    toplam += i;
                    label4.Text = toplam.ToString();
                }

            }
        }
    }
}