
namespace CafeManagement
{
    partial class ItemForm
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
            this.Users = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.Itemname = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.quantity = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Logout = new System.Windows.Forms.Button();
            this.ItemGV = new System.Windows.Forms.Panel();
            this.Itemnum = new System.Windows.Forms.Label();
            this.OrderNum = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Category = new System.Windows.Forms.ComboBox();
            this.MyCafe = new System.Windows.Forms.Label();
            this.Items = new System.Windows.Forms.Button();
            this.x = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Edit = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.ItemGV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Users
            // 
            this.Users.BackColor = System.Drawing.Color.White;
            this.Users.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Users.ForeColor = System.Drawing.Color.DeepPink;
            this.Users.Location = new System.Drawing.Point(19, 112);
            this.Users.Name = "Users";
            this.Users.Size = new System.Drawing.Size(98, 34);
            this.Users.TabIndex = 30;
            this.Users.Text = "Users";
            this.Users.UseVisualStyleBackColor = false;
            this.Users.Click += new System.EventHandler(this.Users_Click);
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
            // 
            // Itemname
            // 
            this.Itemname.AutoSize = true;
            this.Itemname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Itemname.ForeColor = System.Drawing.Color.DeepPink;
            this.Itemname.Location = new System.Drawing.Point(29, 149);
            this.Itemname.Name = "Itemname";
            this.Itemname.Size = new System.Drawing.Size(87, 20);
            this.Itemname.TabIndex = 20;
            this.Itemname.Text = "Item Name";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(132, 149);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(127, 20);
            this.textBox2.TabIndex = 19;
            // 
            // quantity
            // 
            this.quantity.AutoSize = true;
            this.quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantity.ForeColor = System.Drawing.Color.DeepPink;
            this.quantity.Location = new System.Drawing.Point(29, 188);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(68, 20);
            this.quantity.TabIndex = 18;
            this.quantity.Text = "Quantity";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(132, 188);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(127, 20);
            this.textBox1.TabIndex = 17;
            // 
            // Logout
            // 
            this.Logout.BackColor = System.Drawing.Color.DeepPink;
            this.Logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout.ForeColor = System.Drawing.Color.Transparent;
            this.Logout.Location = new System.Drawing.Point(18, 492);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(115, 34);
            this.Logout.TabIndex = 27;
            this.Logout.Text = "LogOut";
            this.Logout.UseVisualStyleBackColor = false;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // ItemGV
            // 
            this.ItemGV.BackColor = System.Drawing.Color.White;
            this.ItemGV.Controls.Add(this.Delete);
            this.ItemGV.Controls.Add(this.Edit);
            this.ItemGV.Controls.Add(this.label1);
            this.ItemGV.Controls.Add(this.Add);
            this.ItemGV.Controls.Add(this.Itemname);
            this.ItemGV.Controls.Add(this.textBox2);
            this.ItemGV.Controls.Add(this.quantity);
            this.ItemGV.Controls.Add(this.textBox1);
            this.ItemGV.Controls.Add(this.Itemnum);
            this.ItemGV.Controls.Add(this.OrderNum);
            this.ItemGV.Controls.Add(this.dataGridView1);
            this.ItemGV.Controls.Add(this.Category);
            this.ItemGV.Controls.Add(this.MyCafe);
            this.ItemGV.Location = new System.Drawing.Point(144, 55);
            this.ItemGV.Name = "ItemGV";
            this.ItemGV.Size = new System.Drawing.Size(812, 445);
            this.ItemGV.TabIndex = 26;
            // 
            // Itemnum
            // 
            this.Itemnum.AutoSize = true;
            this.Itemnum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Itemnum.ForeColor = System.Drawing.Color.DeepPink;
            this.Itemnum.Location = new System.Drawing.Point(29, 113);
            this.Itemnum.Name = "Itemnum";
            this.Itemnum.Size = new System.Drawing.Size(78, 20);
            this.Itemnum.TabIndex = 16;
            this.Itemnum.Text = "Item Num";
            // 
            // OrderNum
            // 
            this.OrderNum.Location = new System.Drawing.Point(132, 113);
            this.OrderNum.Name = "OrderNum";
            this.OrderNum.Size = new System.Drawing.Size(127, 20);
            this.OrderNum.TabIndex = 13;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(303, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(410, 275);
            this.dataGridView1.TabIndex = 12;
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
            this.MyCafe.Size = new System.Drawing.Size(159, 25);
            this.MyCafe.TabIndex = 11;
            this.MyCafe.Text = "Manage Items";
            // 
            // Items
            // 
            this.Items.BackColor = System.Drawing.Color.White;
            this.Items.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Items.ForeColor = System.Drawing.Color.DeepPink;
            this.Items.Location = new System.Drawing.Point(18, 68);
            this.Items.Name = "Items";
            this.Items.Size = new System.Drawing.Size(98, 34);
            this.Items.TabIndex = 29;
            this.Items.Text = "Orders";
            this.Items.UseVisualStyleBackColor = false;
            this.Items.Click += new System.EventHandler(this.Items_Click);
            // 
            // x
            // 
            this.x.AutoSize = true;
            this.x.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x.ForeColor = System.Drawing.Color.Transparent;
            this.x.Location = new System.Drawing.Point(974, 23);
            this.x.Name = "x";
            this.x.Size = new System.Drawing.Size(33, 31);
            this.x.TabIndex = 28;
            this.x.Text = "X";
            this.x.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.x.Click += new System.EventHandler(this.x_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepPink;
            this.label1.Location = new System.Drawing.Point(415, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 25);
            this.label1.TabIndex = 22;
            this.label1.Text = "Item List";
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
            // 
            // ItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepPink;
            this.ClientSize = new System.Drawing.Size(1024, 548);
            this.Controls.Add(this.Users);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.ItemGV);
            this.Controls.Add(this.Items);
            this.Controls.Add(this.x);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ItemForm";
            this.Text = "ItemForm";
            this.ItemGV.ResumeLayout(false);
            this.ItemGV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Users;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Label Itemname;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label quantity;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.Panel ItemGV;
        private System.Windows.Forms.Label Itemnum;
        private System.Windows.Forms.TextBox OrderNum;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox Category;
        private System.Windows.Forms.Label MyCafe;
        private System.Windows.Forms.Button Items;
        private System.Windows.Forms.Label x;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Label label1;
    }
}