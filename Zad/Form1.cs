using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static public string haslo { get; set; }
        public int iloscznakow { get; set; }
        static public string alfabetm = "qwertyuiopasdfghjklzxcvbnm";
        static public string alfabetd = "QWERTYUIOPASDFGHJKLZXCVBNM";
        static public string cyfry = "0123456789";
        static public string znaki = "!@#$%^&*()_+-=";
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dane pracownika: "+textBox2.Text+" "+ textBox3.Text+" "+comboBox1.Text+" Hasło: "+haslo);
          
        }
        /// <summary>
        /// Po wywołaniu zdarzenie genereuje haslo według preferencji uzytkownika a następnie wyświetla je na ekranie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            haslo = "";
            iloscznakow = Convert.ToInt32(textBox1.Text);
            var random = new Random();
            var x = new List<char>();
            var rand = random.Next(0, 26);
            if (checkBox1.Checked==true)
            {

                 rand = random.Next(0, 26);
                x.Add(alfabetd[rand]);
         
            }

            if (checkBox3.Checked == true)
            {

                 rand = random.Next(0, 10);
                x.Add(cyfry[rand]);
                
            }

            if (checkBox2.Checked == true)
            {

                 rand = random.Next(0, 13);
                x.Add(znaki[rand]);
           
            }

            for (int i = 0; i < iloscznakow; i++)
            {
                rand= random.Next(0, 26);
                x.Add(alfabetm[rand]);
            }

            for (int i = 0; i < iloscznakow; i++)
            {
                haslo += x[i];
            }

            MessageBox.Show(haslo);
         

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
