using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeManagement
{
    public partial class UserOrder : Form
    {
        public UserOrder()
        {
            InitializeComponent();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 login = new Form1();
            login.Show();
        }

        private void x_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Items_Click(object sender, EventArgs e)
        {
            this.Hide();
            ItemForm item = new ItemForm();
            item.Show();
        }

        private void Users_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserForm item = new UserForm();
            item.Show();
        }
    }
}
