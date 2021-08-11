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

namespace CafeManagement
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Cafedb.mdf;Integrated Security=True;Connect Timeout=30");
        void populate()
        {
            Con.Open();
            string query = "select * from UsersTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query,Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            UsersGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void x_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 login = new Form1();
            login.Show();
        }

        private void Items_Click(object sender, EventArgs e)
        {
            UserOrder uorder = new UserOrder();
            uorder.Show();
            this.Hide();
        }

        private void Users_Click(object sender, EventArgs e)
        {
            ItemForm item = new ItemForm();
            item.Show();
            this.Hide();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            Con.Open();
            string query = "insert into UsersTbl values('" + uname.Text + "','" + Phone.Text + "','" + Password.Text + "')";
            SqlCommand cmd = new SqlCommand(query,Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("User successfully Created");
            Con.Close();
            populate();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void UsersGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //uname.Text = UsersGV.SelectedRows[0].Cells[0].Value.ToString();
            //Phone.Text = UsersGV.SelectedRows[0].Cells[1].Value.ToString();
            //Password.Text = UsersGV.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void Delete_Click(object sender, EventArgs e)   
        {
            if(Phone.Text == "")
            {
                MessageBox.Show("Select the user to be deleted");
            }
            else
            {
                Con.Open();
                string query = "delete from UsersTbl where Phone = '" + Phone.Text + "'";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User Sucessfully deleted");
                Con.Close();
                populate();
            }
        }
    }
}
