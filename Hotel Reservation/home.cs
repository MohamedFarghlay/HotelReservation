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
    public partial class Main_Menu : Form
    {
        public Main_Menu()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Check_in ch = new Check_in();
            ch.ShowDialog();
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Check_out co = new Check_out();
            co.ShowDialog();
            this.Close();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Visible=false;
            update up = new update();
            up.ShowDialog();
            this.Close();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
