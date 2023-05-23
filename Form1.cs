using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{

  
    public partial class Form1 : Form
    {
        int seconds = 0;
        int poz=0;
        int tocni = 0;
        int netocni = 0;
        string[] izraz1 = new string[] { "3+3", "3-2", "1+1", "4*3" ,"5+5","15-7*2"," 9*8/2","3+5*3/2","30-8*2","5*8-20","10-4*2"};
        string[] izraz2 = new string[] { "6", "1", "2", "12" ,"10","1","36","9","14","20","2"};
        string[] vnes = new string[100];
        int pozvnez = 0;



        public Form1()
        {

            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            vnes[pozvnez] = "1";
            pozvnez++;
            for (int i = 0; i < pozvnez; i++)
                
                textBox2.Text = vnes[i];
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            vnes[pozvnez] = "2";
            pozvnez++;
            for (int i = 0; i < pozvnez; i++)
                textBox2.Text = vnes[i];
        }

        private void button4_Click(object sender, EventArgs e)
        {
            vnes[pozvnez] = "3";
            pozvnez++;
            for (int i = 0; i < pozvnez; i++)
                textBox2.Text = vnes[i];
        }

        private void button11_Click(object sender, EventArgs e)
        {
            vnes[pozvnez] = "4";
            pozvnez++;
            for (int i = 0; i < pozvnez; i++)
                textBox2.Text = vnes[i];
        }

        private void button7_Click(object sender, EventArgs e)
        {
            vnes[pozvnez] = "7";
            pozvnez++;
            for (int i = 0; i < pozvnez; i++)
                textBox2.Text = vnes[i];
        }

        private void button9_Click(object sender, EventArgs e)
        {
            vnes[pozvnez] = "9";
            pozvnez++;
            for (int i = 0; i < pozvnez; i++)
                textBox2.Text = vnes[i];
        }

        private void label4_Click(object sender, EventArgs e)
        {
           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            

        }

        private void btnnova_Click(object sender, EventArgs e)
        {
            seconds = 180;
            timer1.Start();
           
            textBox1.Text = izraz1[0];
            


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbltimer.Text = seconds--.ToString();
            if(seconds<0)
                timer1.Stop();
        }

        private void btnpotvrdi_Click(object sender, EventArgs e)
        {
          

            if (textBox2.Text == izraz2[poz])

                tocni++;

            else
                netocni++;
            lbltocni.Text=tocni.ToString();
            lblnetocni.Text=netocni.ToString();
            poz++;
            textBox1.Text = izraz1[poz];
            textBox2.Text = "";
            pozvnez = 0;    
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void lblnetocni_Click(object sender, EventArgs e)
        {

        }

        private void btn5_Click(object sender, EventArgs e)
        {
            vnes[pozvnez] = "5";
            pozvnez++;
            for (int i = 0; i < pozvnez; i++)
                textBox2.Text = vnes[i];


        }

        private void btn6_Click(object sender, EventArgs e)
        {
            vnes[pozvnez] = "6";
            pozvnez++;
            for (int i = 0; i < pozvnez; i++)
                textBox2.Text = vnes[i];
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            vnes[pozvnez] = "8";
            pozvnez++;
            for (int i = 0; i < pozvnez; i++)
                textBox2.Text = vnes[i];
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            vnes[pozvnez] = "0";
            pozvnez++;
            for (int i = 0; i < pozvnez; i++)
                textBox2.Text = vnes[i];
        }

        private void btntocka_Click(object sender, EventArgs e)
        {
            vnes[pozvnez] = ".";
            pozvnez++;
            for (int i = 0; i < pozvnez; i++)
                textBox2.Text = vnes[i];
        }

        private void btn6_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            pozvnez--;
            for (int i = 0; i < pozvnez; i++)
                textBox2.Text = vnes[i];
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
