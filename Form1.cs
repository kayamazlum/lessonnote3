using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tekrar3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // [1] 1-100 arasında  5 ve 7'ye bölünebilen sayılar
        private void button1_Click(object sender, EventArgs e)
        {
            for(int i=1 ; i <= 100 ; i++)
            {
                if (i % 5 == 0 && i % 7 == 0)
                {
                    listBox1.Items.Add(i);
                }
            }
        }

        // [2] while - 0-10'a kadar listbox'a ekleme 
        private void button2_Click(object sender, EventArgs e)
        {
            int i = 0;
            while (i <= 10)
            {
                listBox2.Items.Add(i);
                i++;
            }
        }

        // [3] while - 0-10 arası sayılar toplamı
        private void button3_Click(object sender, EventArgs e)
        {
            int i = 0, sum = 0;
            while (i < 11)
            {
                sum += i;
                i++;
            }
            listBox3.Items.Add(sum);
        }

        // [4] do while - 0-10'a kadar listbox'a ekleme
        private void button4_Click(object sender, EventArgs e)
        {
            int i = 0;
            do
            {
                listBox4.Items.Add(i);
                i++;
            }
            while (i <= 10);
        }

        // [5] Aranan ismi bulma
        private void button5_Click(object sender, EventArgs e)
        {
            String aranan = textBox1.Text;
            for(int i=0; i< listBox5.Items.Count; i++)
            {
                if (aranan == listBox5.Items[i].ToString())
                {
                    MessageBox.Show(listBox5.Items[i] + " değeri bulundu");
                }
            }
        }

        // [6] 3 nolu indeksteki değeri getir
        private void button6_Click(object sender, EventArgs e)
        {
            int[] a = { 1, 5, 10, 20, 40, 80, 100 };
            label1.Text = a[3].ToString();
        }

        // [7] for ile diziyi listbox'a yazdır
        private void button7_Click(object sender, EventArgs e)
        {
            int[] a = { 1, 5, 10, 20, 40, 80, 100 };
            for(int i=0; i<a.Length; i++)
            {
                listBox6.Items.Add(a[i].ToString());
            }
        }

        // [8] dizinin toplamı ve ortalamsı
        private void button8_Click(object sender, EventArgs e)
        {
            int[] a = { 1, 5, 10, 20, 40, 80, 100 };
            double sum = 0 , avg = 0;
            for(int i = 0; i < a.Length; i++)
            {
                sum += a[i];
            }
            avg = sum / a.Length;
            label2.Text = sum.ToString();
            label3.Text = avg.ToString();
        }

        // [9] girilen sayıdan küçük değerleri verir
        private void button9_Click(object sender, EventArgs e)
        {
            int[] a = { 1, 5, 10, 20, 40, 80, 100 };
            int sayi = Convert.ToInt32(textBox2.Text);
            for(int i = 0; i < a.Length; i++)
            {
                if(sayi > a[i])
                {
                    listBox7.Items.Add(a[i].ToString());
                }
            }
        }

        // [10] foreach ile diziyi yazdırma
        private void button10_Click(object sender, EventArgs e)
        {
            int[] liste1 = { 1, 5, 10, 20, 40, 80, 100 };
            foreach(int m in liste1)
            {
                listBox8.Items.Add(m.ToString());
            }
        }

        // [11] sınırlı sayıdaki liste elemanlarını sıralama
        private void button11_Click(object sender, EventArgs e)
        {
            int[] liste = new int[3];
            liste[0] = 1;
            liste[1] = 2;
            liste[2] = 3;

            //for(int i = 0; i < liste.Length; i++)
            //{
            //    listBox9.Items.Add(liste[i]);
            //}

            foreach(int i in liste)
            {
                listBox9.Items.Add(i.ToString());
            }
        }
    }
}
