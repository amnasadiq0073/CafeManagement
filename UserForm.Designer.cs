
namespace CafeManagement
{
    partial class UserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Delete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Add = new System.Windows.Forms.Button();
            this.Phone = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.x = new System.Windows.Forms.Label();
            this.Edit = new System.Windows.Forms.Button();
            this.Items = new System.Windows.Forms.Button();
            this.Username = new System.Windows.Forms.Label();
            this.uname = new System.Windows.Forms.TextBox();
            this.Category = new System.Windows.Forms.ComboBox();
            this.MyCafe = new System.Windows.Forms.Label();
            this.Users = new System.Windows.Forms.Button();
            this.ItemGV = new System.Windows.Forms.Panel();
            this.UsersGV = new System.Windows.Forms.DataGridView();
            this.Logout = new System.Windows.Forms.Button();
            this.ItemGV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsersGV)).BeginInit();
            this.SuspendLayout();
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.DeepPink;
            this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.ForeColor = System.Drawing.Color.Transparent;
            this.Delete.Location = new System.Drawing.Point(77, 298);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(72, 34);
            this.Delete.TabIndex = 24;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepPink;
            this.label1.Location = new System.Drawing.Point(415, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 25);
            this.label1.TabIndex = 22;
            this.label1.Text = "User List";
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.Color.DeepPink;
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.ForeColor = System.Drawing.Color.Transparent;
            this.Add.Location = new System.Drawing.Point(9, 298);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(62, 34);
            this.Add.TabIndex = 11;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Phone
            // 
            this.Phone.AutoSize = true;
            this.Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phone.ForeColor = System.Drawing.Color.DeepPink;
            this.Phone.Location = new System.Drawing.Point(29, 149);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(55, 20);
            this.Phone.TabIndex = 20;
            this.Phone.Text = "Phone";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(132, 149);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(127, 20);
            this.textBox2.TabIndex = 19;
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.ForeColor = System.Drawing.Color.DeepPink;
            this.Password.Location = new System.Drawing.Point(29, 188);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(78, 20);
            this.Password.TabIndex = 18;
            this.Password.Text = "Password";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(132, 188);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(127, 20);
            this.textBox1.TabIndex = 17;
            // 
            // x
            // 
            this.x.AutoSize = true;
            this.x.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x.ForeColor = System.Drawing.Color.Transparent;
            this.x.Location = new System.Drawing.Point(983, 22);
            this.x.Name = "x";
            this.x.Size = new System.Drawing.Size(33, 31);
            this.x.TabIndex = 33;
            this.x.Text = "X";
            this.x.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.x.Click += new System.EventHandler(this.x_Click);
            // 
            // Edit
            // 
            this.Edit.BackColor = System.Drawing.Color.DeepPink;
            this.Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edit.ForeColor = System.Drawing.Color.Transparent;
            this.Edit.Location = new System.Drawing.Point(155, 298);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(62, 34);
            this.Edit.TabIndex = 23;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = false;
            // 
            // Items
            // 
            this.Items.BackColor = System.Drawing.Color.White;
            this.Items.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Items.ForeColor = System.Drawing.Color.DeepPink;
            this.Items.Location = new System.Drawing.Point(27, 67);
            this.Items.Name = "Items";
            this.Items.Size = new System.Drawing.Size(98, 34);
            this.Items.TabIndex = 34;
            this.Items.Text = "Orders";
            this.Items.UseVisualStyleBackColor = false;
            this.Items.Click += new System.EventHandler(this.Items_Click);
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.ForeColor = System.Drawing.Color.DeepPink;
            this.Username.Location = new System.Drawing.Point(29, 113);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(83, 20);
            this.Username.TabIndex = 16;
            this.Username.Text = "Username";
            // 
            // uname
            // 
            this.uname.Location = new System.Drawing.Point(132, 113);
            this.uname.Name = "uname";
            this.uname.Size = new System.Drawing.Size(127, 20);
            this.uname.TabIndex = 13;
            // 
            // Category
            // 
            this.Category.FormattingEnabled = true;
            this.Category.Items.AddRange(new object[] {
            "Food",
            "Bevarage"});
            this.Category.Location = new System.Drawing.Point(83, 229);
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(127, 21);
            this.Category.TabIndex = 11;
            this.Category.Text = "Category";
            // 
            // MyCafe
            // 
            this.MyCafe.AutoSize = true;
            this.MyCafe.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyCafe.ForeColor = System.Drawing.Color.DeepPink;
            this.MyCafe.Location = new System.Drawing.Point(286, 5);
            this.MyCafe.Name = "MyCafe";
            this.MyCafe.Size = new System.Drawing.Size(164, 25);
            this.MyCafe.TabIndex = 11;
            this.MyCafe.Text = "Manage Users";
            // 
            // Users
            // 
            this.Users.BackColor = System.Drawing.Color.White;
            this.Users.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Users.ForeColor = System.Drawing.Color.DeepPink;
            this.Users.Location = new System.Drawing.Point(28, 111);
            this.Users.Name = "Users";
            this.Users.Size = new System.Drawing.Size(98, 34);
            this.Users.TabIndex = 35;
            this.Users.Text = "Items";
            this.Users.UseVisualStyleBackColor = false;
            this.Users.Click += new System.EventHandler(this.Users_Click);
            // 
            // ItemGV
            // 
            this.ItemGV.BackColor = System.Drawing.Color.White;
            this.ItemGV.Controls.Add(this.Delete);
            this.ItemGV.Controls.Add(this.Edit);
            this.ItemGV.Controls.Add(this.label1);
            this.ItemGV.Controls.Add(this.Add);
            this.ItemGV.Controls.Add(this.Phone);
            this.ItemGV.Controls.Add(this.textBox2);
            this.ItemGV.Controls.Add(this.Password);
            this.ItemGV.Controls.Add(this.textBox1);
            this.ItemGV.Controls.Add(this.Username);
            this.ItemGV.Controls.Add(this.uname);
            this.ItemGV.Controls.Add(this.UsersGV);
            this.ItemGV.Controls.Add(this.Category);
            this.ItemGV.Controls.Add(this.MyCafe);
            this.ItemGV.Location = new System.Drawing.Point(153, 54);
            this.ItemGV.Name = "ItemGV";
            this.ItemGV.Size = new System.Drawing.Size(812, 445);
            this.ItemGV.TabIndex = 31;
            // 
            // UsersGV
            // 
            this.UsersGV.BackgroundColor = System.Drawing.Color.White;
            this.UsersGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsersGV.GridColor = System.Drawing.Color.DarkTurquoise;
            this.UsersGV.Location = new System.Drawing.Point(303, 90);
            this.UsersGV.Name = "UsersGV";
            this.UsersGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.UsersGV.RowTemplate.Height = 30;
            this.UsersGV.Size = new System.Drawing.Size(410, 275);
            this.UsersGV.TabIndex = 12;
            this.UsersGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UsersGV_CellContentClick);
            // 
            // Logout
            // 
            this.Logout.BackColor = System.Drawing.Color.DeepPink;
            this.Logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout.ForeColor = System.Drawing.Color.Transparent;
            this.Logout.Location = new System.Drawing.Point(27, 491);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(115, 34);
            this.Logout.TabIndex = 32;
            this.Logout.Text = "LogOut";
            this.Logout.UseVisualStyleBackColor = false;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepPink;
            this.ClientSize = new System.Drawing.Size(1042, 546);
            this.Controls.Add(this.x);
            this.Controls.Add(this.Items);
            this.Controls.Add(this.Users);
            this.Controls.Add(this.ItemGV);
            this.Controls.Add(this.Logout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.ItemGV.ResumeLayout(false);
            this.ItemGV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsersGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Label Phone;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label x;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Button Items;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.TextBox uname;
        private System.Windows.Forms.ComboBox Category;
        private System.Windows.Forms.Label MyCafe;
        private System.Windows.Forms.Button Users;
        private System.Windows.Forms.Panel ItemGV;
        private System.Windows.Forms.DataGridView UsersGV;
        private System.Windows.Forms.Button Logout;
    }
}