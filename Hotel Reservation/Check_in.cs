using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hotel_Reservation
{
    public partial class Check_in : Form
    {
        SqlConnection con = new SqlConnection(Properties.Settings.Default.constr);
        public Check_in()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Main_Menu mn = new Main_Menu();
            mn.ShowDialog();
        }
       

        private void Check_in_Load(object sender, EventArgs e)
        {

        }

        private void save_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Insert into dbclient (id,resv,name,numb,chin,chout,nigth) values (" + id_box.Text + " , " + res_box.Text + " , '" + textbox0.Text + "' , " + num_box.Text + " , '" + dateTimePicker1.Value + "' , '" + dateTimePicker2.Value + "' , " + nights_box.Text + ")", con);

                cmd.ExecuteNonQuery();
                MessageBox.Show("successfully!! checked-in", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (SqlException ex)
            { MessageBox.Show("some error\n" + ex.Message); }

            finally { con.Close(); }
          
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.constr);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select max (id) from dbclient ";
            try
            {
                string id=cmd.ExecuteScalar().ToString();
               int n= int.Parse(id);
                id_box.Text = (n + 1).ToString();
            }
            catch { id_box.Text = "1"; }
            finally { con.Close(); }
        }
    }
}
