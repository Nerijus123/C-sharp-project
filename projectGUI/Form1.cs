using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectGUI
{
    public partial class Form1 : Form
    {
        int PW;
        
        public Form1()
        {
            InitializeComponent();
            PW = slidePanel.Width;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            /// close form
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /// hide menu bar on start form
            
            slidePanel.Hide();
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            /// show hide menu bar
            if (slidePanel.Visible)
            {
                slidePanel.Hide();
            }
            else
            {
                slidePanel.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pagrindinis.Visible = true;
            savokos.Visible = false;
            apie.Visible = false;
            kontaktai.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pagrindinis.Visible = false;
            savokos.Visible = false;
            apie.Visible = true;
            kontaktai.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pagrindinis.Visible = false;
            savokos.Visible = true;
            apie.Visible = false;
            kontaktai.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pagrindinis.Visible = false;
            savokos.Visible = false;
            apie.Visible = false;
            kontaktai.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pagrindinis.Visible = false;
            savokos.Visible = false;
            apie.Visible = false;
            kontaktai.Visible = false;
            pnl2.Visible = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            pagrindinis.Visible = false;
            savokos.Visible = false;
            apie.Visible = false;
            kontaktai.Visible = false;
            pnl2.Visible = false;
            pnl3.Visible = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            pagrindinis.Visible = false;
            savokos.Visible = false;
            apie.Visible = false;
            kontaktai.Visible = false;
            pnl2.Visible = false;
            pnl3.Visible = false;
            pnl4.Visible = true;
        }

        private void btn4langas_Click(object sender, EventArgs e)
        {
            pagrindinis.Visible = false;
            savokos.Visible = false;
            apie.Visible = false;
            kontaktai.Visible = false;
            pnl2.Visible = false;
            pnl3.Visible = false;
            pnl4.Visible = false;
            pnl5.Visible = true;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            pagrindinis.Visible = false;
            savokos.Visible = false;
            apie.Visible = false;
            kontaktai.Visible = false;
            pnl2.Visible = false;
            pnl3.Visible = false;
            pnl4.Visible = false;
            pnl5.Visible = false;
            pnl6.Visible = true;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            pagrindinis.Visible = true;
            savokos.Visible = false;
            apie.Visible = false;
            kontaktai.Visible = false;
            pnl2.Visible = false;
            pnl3.Visible = false;
            pnl4.Visible = false;
            pnl5.Visible = false;
            pnl6.Visible = false;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            pagrindinis.Visible = false;
            savokos.Visible = false;
            apie.Visible = false;
            kontaktai.Visible = false;
            pnl2.Visible = true;
            pnl3.Visible = false;
            pnl4.Visible = false;
            pnl5.Visible = false;
            pnl6.Visible = false;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            pagrindinis.Visible = false;
            savokos.Visible = false;
            apie.Visible = false;
            kontaktai.Visible = false;
            pnl2.Visible = false;
            pnl3.Visible = true;
            pnl4.Visible = false;
            pnl5.Visible = false;
            pnl6.Visible = false;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            pagrindinis.Visible = false;
            savokos.Visible = false;
            apie.Visible = false;
            kontaktai.Visible = false;
            pnl2.Visible = false;
            pnl3.Visible = false;
            pnl4.Visible = true;
            pnl5.Visible = false;
            pnl6.Visible = false;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            pagrindinis.Visible = false;
            savokos.Visible = false;
            apie.Visible = false;
            kontaktai.Visible = false;
            pnl2.Visible = false;
            pnl3.Visible = false;
            pnl4.Visible = false;
            pnl5.Visible = true;
            pnl6.Visible = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            pagrindinis.Visible = true;
            savokos.Visible = false;
            apie.Visible = false;
            kontaktai.Visible = false;
            pnl2.Visible = false;
            pnl3.Visible = false;
            pnl4.Visible = false;
            pnl5.Visible = false;
            pnl6.Visible = false;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            pagrindinis.Visible = true;
            savokos.Visible = false;
            apie.Visible = false;
            kontaktai.Visible = false;
            pnl2.Visible = false;
            pnl3.Visible = false;
            pnl4.Visible = false;
            pnl5.Visible = false;
            pnl6.Visible = false;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pagrindinis.Visible = false;
            savokos.Visible = false;
            apie.Visible = true;
            kontaktai.Visible = false;
            pnl2.Visible = false;
            pnl3.Visible = false;
            pnl4.Visible = false;
            pnl5.Visible = false;
            pnl6.Visible = false;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            pagrindinis.Visible = false;
            savokos.Visible = true;
            apie.Visible = false;
            kontaktai.Visible = true;
            pnl2.Visible = false;
            pnl3.Visible = false;
            pnl4.Visible = false;
            pnl5.Visible = false;
            pnl6.Visible = false;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            pagrindinis.Visible = false;
            savokos.Visible = false;
            apie.Visible = false;
            kontaktai.Visible = true;
            pnl2.Visible = false;
            pnl3.Visible = false;
            pnl4.Visible = false;
            pnl5.Visible = false;
            pnl6.Visible = false;
        }

        private void kontaktai_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
