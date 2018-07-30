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
    public partial class update : Form
    {
        SqlConnection con = new SqlConnection(Properties.Settings.Default.constr);
        public update()
        {
            InitializeComponent();
        }

        private void update_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select id,name,numb,chin,chout,nigth From dbclient Where resv=" +res_box.Text, con);

                SqlDataReader dr;
                dr = cmd.ExecuteReader();

                dr.Read();
                id_box.Text = dr["id"].ToString();
                textbox0.Text = dr["name"].ToString();
                num_box.Text = dr["numb"].ToString();
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Main_Menu mn = new Main_Menu();
            mn.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Update dbclient Set resv=" + res_box.Text + " ,name='" + textbox0.Text + "' , numb=" + num_box.Text + " , chin='" + dateTimePicker1.Value + "' , chout='" + dateTimePicker2.Value + "' ,nigth= " + nights_box.Text + " Where id=" + id_box.Text + "", con);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Update successfully!!! ", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            { MessageBox.Show("some error\n" + ex.Message); }
            con.Close();
       
        
        }
    }
}
