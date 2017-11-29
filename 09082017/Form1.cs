using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _09082017
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstürünler.Items.Clear();
            
            if (comboBox1.SelectedIndex==0)
            {
                lstürünler.Items.Add("Abdo Usulü Et Döner");
                lstürünler.Items.Add("Oruk");
                lstürünler.Items.Add("Sini Kebabaı");
                lstürünler.Items.Add("Kaytaz Böreği");
            }

            else if (comboBox1.SelectedIndex==1)
            {
                lstürünler.Items.Add("Çökelek Salatası");
                lstürünler.Items.Add("Zeytin Öfelemesi");
                lstürünler.Items.Add("Çoban Salata");
            }

            else if (comboBox1.SelectedIndex==2)
            {
                lstürünler.Items.Add("Şerbet");
                lstürünler.Items.Add("Şalgam");
                lstürünler.Items.Add("Limonata");
            }

            else if (comboBox1.SelectedIndex==3)
            {
                lstürünler.Items.Add("Sade Künefe");
                lstürünler.Items.Add("Kaymaklı Künefe");
                lstürünler.Items.Add("Şam Tatlısı");
                lstürünler.Items.Add("Baklava");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int adet = Convert.ToInt32(label4.Text);
            lstsepet.Items.Add(lstürünler.SelectedItem);
            adet++;
            label4.Text = adet.ToString();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int adet = Convert.ToInt32(label4.Text);    
                    
            lstsepet.Items.Remove(lstsepet.SelectedItem);
            adet--;
            label4.Text = adet.ToString();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            int adet;
            adet = Convert.ToInt32(label4.Text);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int adet;

            adet = Convert.ToInt32(label4.Text);

            for (int i = 0; i < lstürünler.SelectedItems.Count; i++)
            {
                lstsepet.Items.Add(lstürünler.SelectedItems[i]);
                adet++;
                
            }
            label4.Text = adet.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int adet;
            int cikarilan = lstsepet.SelectedItems.Count;
            adet = Convert.ToInt32(label4.Text);
            for (int i = 0; i < cikarilan; i++)
            {
                lstsepet.Items.Remove(lstsepet.SelectedItems[0]);


                
            }
            if (adet > 0)
            {
                adet = adet - cikarilan;
            }


            label4.Text = adet.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                lsttümsiparis.Items.Add(textBox1.Text + " " +"ürün sayısı " + label4.Text  + "," + "indirim yüzdesi"+ " " +radioButton1.Text );
            }

            else if (radioButton2.Checked)
            {
                lsttümsiparis.Items.Add(textBox1.Text + " " + "ürün sayısı "  + label4.Text + "," + "indirim yüzdesi"+ " " + radioButton2.Text);
            }
            else if (radioButton3.Checked)
            {
                lsttümsiparis.Items.Add(textBox1.Text + " " + "ürün sayısı "  + label4.Text + "," + "indirim yüzdesi"+ " " + radioButton3.Text);
            }

            else
            {
                lsttümsiparis.Items.Add(textBox1.Text + " " + "ürün sayısı " + label4.Text + ","+ "indirim uygulanmamıştır");
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
