using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Hotel_Reservation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value == 100)
            {

                timer1.Stop();
                this.Visible = false;
                Main_Menu mn = new Main_Menu();
                mn.ShowDialog();
              
            }

            else
            {
              
                label3.ForeColor= Color.Azure;
                progressBar1.Value+=1;
                label1.Text = progressBar1.Value.ToString() + "%";
                if (progressBar1.Value % 8 == 2)
                { label2.Text = "Please wait.";
               // label3.ForeColor = Color.Azure;
                }
                else if (progressBar1.Value % 8 == 5)
                { label2.Text = "Please wait..";
                label3.ForeColor = Color.AliceBlue;
                }
                else if (progressBar1.Value % 8 == 7)
                { label2.Text = "Please wait...";
               // label3.ForeColor = Color.Black;
               
                }
                if(progressBar1.Value%25==0)
                {
                    label3.ForeColor=Color.Gray;
                }
                else if(progressBar1.Value%25==1)
                {
                    label3.ForeColor = Color.Pink;
                }
                else if (progressBar1.Value%25==2)
                {
                    label3.ForeColor = Color.Snow;
                }
                else  if(progressBar1.Value%50==0)
                {
                    label3.ForeColor = Color.Black;
                }
                else if(progressBar1.Value%50==1)
                {
                    label3.ForeColor = Color.Violet;
                }
               

               
                
                
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void label3_SystemColorsChanged(object sender, EventArgs e)
        {

        }

        private void label3_ForeColorChanged(object sender, EventArgs e)
        {
            if (progressBar1.Value != 100)
            {

                ForeColorChanged += Form1_ForeColorChanged;
            }
           
        }

        void Form1_ForeColorChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
