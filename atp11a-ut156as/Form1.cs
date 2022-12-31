using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace atp11a_ut156as
{
    public partial class Form1 : Form
    {
        string arananKelime = "";

        string kelime;

        string[] kelimeler;

        int resimler = 0;
        Random rd = new Random();
        string acilan;
        string temp;
        int hata = 0;
        int harfLimiti = 10;
        string appPath = Path.GetDirectoryName(Application.ExecutablePath);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        string[] words =
{
                "PORTAKAL",
                "BARDAK",
                "MUSTAFA",
                "PENCERE",
                "PARLAK",
                "KUTU",
                "KUMANDA",
                "TELEFON",
                "BARDAK",
                "EKRAN",
            };

        public void oyunuBaslat()
        {
            acilan = "";

            arananKelime = words[rd.Next(0, words.Length)];


            label1.Text = "";
            for (int i = 0; i < arananKelime.Length; i++)
            {
                label1.Text += "_ ";
                acilan += ' ';
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "";

            arananKelime = words[rd.Next(0,words.Length)];

            for (int i = 0; i < arananKelime.Length; i++)
            {

                label1.Text += "_";

            }

            resimler = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            char aranacakChar = char.Parse(textBox1.Text);

            char[] karakterler = arananKelime.ToCharArray();

            bool varmi = false;

            for (int i = 0; i < karakterler.Length; i++)
            {

                if (karakterler[i] == aranacakChar)
                {

                    label1.Text = label1.Text.Remove(i, 1);

                    label1.Text = label1.Text.Insert(i, aranacakChar.ToString());

                    varmi = true;

                }

            }

            if (label1.Text == arananKelime)
            {

                MessageBox.Show("kelime bilindi");

                label1.Text = arananKelime;

                return;

            }

            textBox1.Text = "";

            if (varmi == false)
            {

                resimler++;

                if (resimler == 1)
                {
                    pictureBox2.Visible = false;
                }
                else if (resimler == 2)
                {
                    pictureBox3.Visible = false;
                }

                else if (resimler == 3)
                {
                    pictureBox4.Visible = false;
                }
                else if (resimler == 4)
                {
                    pictureBox5.Visible = false;
                }
                else if (resimler == 5)
                {
                    pictureBox6.Visible = false;
                }
                else if (resimler == 6)
                {
                    pictureBox7.Visible = false;
                }
                    

            }
        }
    }
}
