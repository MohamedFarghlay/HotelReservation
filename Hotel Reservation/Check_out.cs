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
    public partial class Check_out : Form
    {
        SqlConnection con = new SqlConnection(Properties.Settings.Default.constr);
        public Check_out()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Main_Menu mn = new Main_Menu();
            mn.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("Delete from dbclient where id=" + textBox2.Text, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Checked out successfully !", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            { MessageBox.Show("some error\n" + ex.Message); }
            finally
            { con.Close(); }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select id,name,numb,chin,chout,nigth From dbclient Where resv=" + codebox.Text, con);

                SqlDataReader dr;
                dr = cmd.ExecuteReader();

                dr.Read();
                textBox2.Text = dr["id"].ToString();
                rnbox.Text = dr["name"].ToString();
                nmbox.Text = dr["numb"].ToString();
                dateTimePicker1.Text = dr["chin"].ToString();
                dateTimePicker2.Text = dr["chout"].ToString();
                nights_box.Text = dr["nigth"].ToString();
                dr.Close();
            }

            catch { MessageBox.Show("Not Found!"); }
            finally
            {

                con.Close();
            }


        }

        private void Check_out_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
