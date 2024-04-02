namespace OnlineLibraryManagement
{
    partial class Reader
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reader));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            btn_Search_3 = new Button();
            tb_Search_3 = new TextBox();
            label1 = new Label();
            dgv_Books_1 = new DataGridView();
            tabPage2 = new TabPage();
            tb_Book_Management_ID = new TextBox();
            label5 = new Label();
            tb_Borrowed_Date = new TextBox();
            tb_Book_Name_1 = new TextBox();
            tb_Account_ID_1 = new TextBox();
            btn_Add_2 = new Button();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            dgv_Borrow_Books = new DataGridView();
            tabPage3 = new TabPage();
            btn_Add = new Button();
            tb_Password = new TextBox();
            tb_Phone_Number = new TextBox();
            tb_Email = new TextBox();
            tb_Account_Name = new TextBox();
            tb_Account_ID_2 = new TextBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            dgv_Account_1 = new DataGridView();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Books_1).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Borrow_Books).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Account_1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(1, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(799, 446);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackgroundImage = (Image)resources.GetObject("tabPage1.BackgroundImage");
            tabPage1.BackgroundImageLayout = ImageLayout.Stretch;
            tabPage1.Controls.Add(btn_Search_3);
            tabPage1.Controls.Add(tb_Search_3);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(dgv_Books_1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(791, 413);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Books";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_Search_3
            // 
            btn_Search_3.BackColor = Color.Peru;
            btn_Search_3.Location = new Point(538, 326);
            btn_Search_3.Name = "btn_Search_3";
            btn_Search_3.Size = new Size(94, 29);
            btn_Search_3.TabIndex = 3;
            btn_Search_3.Text = "Search";
            btn_Search_3.UseVisualStyleBackColor = false;
            btn_Search_3.Click += btn_Search_3_Click;
            // 
            // tb_Search_3
            // 
            tb_Search_3.BackColor = SystemColors.Info;
            tb_Search_3.Location = new Point(232, 327);
            tb_Search_3.Name = "tb_Search_3";
            tb_Search_3.Size = new Size(270, 27);
            tb_Search_3.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Silver;
            label1.Location = new Point(151, 326);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 1;
            label1.Text = "Search";
            // 
            // dgv_Books_1
            // 
            dgv_Books_1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Books_1.Location = new Point(102, 34);
            dgv_Books_1.Name = "dgv_Books_1";
            dgv_Books_1.RowHeadersWidth = 51;
            dgv_Books_1.RowTemplate.Height = 29;
            dgv_Books_1.Size = new Size(582, 263);
            dgv_Books_1.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.BackgroundImage = (Image)resources.GetObject("tabPage2.BackgroundImage");
            tabPage2.BackgroundImageLayout = ImageLayout.Stretch;
            tabPage2.Controls.Add(tb_Book_Management_ID);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(tb_Borrowed_Date);
            tabPage2.Controls.Add(tb_Book_Name_1);
            tabPage2.Controls.Add(tb_Account_ID_1);
            tabPage2.Controls.Add(btn_Add_2);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(dgv_Borrow_Books);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(791, 413);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Borrow books";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tb_Book_Management_ID
            // 
            tb_Book_Management_ID.BackColor = SystemColors.Info;
            tb_Book_Management_ID.Location = new Point(220, 14);
            tb_Book_Management_ID.Name = "tb_Book_Management_ID";
            tb_Book_Management_ID.Size = new Size(177, 27);
            tb_Book_Management_ID.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Silver;
            label5.Location = new Point(118, 14);
            label5.Name = "label5";
            label5.Size = new Size(24, 20);
            label5.TabIndex = 10;
            label5.Text = "ID";
            // 
            // tb_Borrowed_Date
            // 
            tb_Borrowed_Date.BackColor = SystemColors.Info;
            tb_Borrowed_Date.Location = new Point(553, 17);
            tb_Borrowed_Date.Name = "tb_Borrowed_Date";
            tb_Borrowed_Date.Size = new Size(177, 27);
            tb_Borrowed_Date.TabIndex = 9;
            // 
            // tb_Book_Name_1
            // 
            tb_Book_Name_1.BackColor = SystemColors.Info;
            tb_Book_Name_1.Location = new Point(220, 94);
            tb_Book_Name_1.Name = "tb_Book_Name_1";
            tb_Book_Name_1.Size = new Size(177, 27);
            tb_Book_Name_1.TabIndex = 8;
            // 
            // tb_Account_ID_1
            // 
            tb_Account_ID_1.BackColor = SystemColors.Info;
            tb_Account_ID_1.Location = new Point(220, 57);
            tb_Account_ID_1.Name = "tb_Account_ID_1";
            tb_Account_ID_1.Size = new Size(177, 27);
            tb_Account_ID_1.TabIndex = 7;
            // 
            // btn_Add_2
            // 
            btn_Add_2.BackColor = Color.Peru;
            btn_Add_2.Location = new Point(516, 76);
            btn_Add_2.Name = "btn_Add_2";
            btn_Add_2.Size = new Size(94, 29);
            btn_Add_2.TabIndex = 6;
            btn_Add_2.Text = "Add";
            btn_Add_2.UseVisualStyleBackColor = false;
            btn_Add_2.Click += btn_Add_2_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(11, 184);
            label6.Name = "label6";
            label6.Size = new Size(0, 20);
            label6.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Silver;
            label4.Location = new Point(425, 17);
            label4.Name = "label4";
            label4.Size = new Size(110, 20);
            label4.TabIndex = 3;
            label4.Text = "Borrowed Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Silver;
            label3.Location = new Point(118, 94);
            label3.Name = "label3";
            label3.Size = new Size(84, 20);
            label3.TabIndex = 2;
            label3.Text = "Book name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Silver;
            label2.Location = new Point(118, 57);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 1;
            label2.Text = "Account ID";
            // 
            // dgv_Borrow_Books
            // 
            dgv_Borrow_Books.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Borrow_Books.Location = new Point(159, 138);
            dgv_Borrow_Books.Name = "dgv_Borrow_Books";
            dgv_Borrow_Books.RowHeadersWidth = 51;
            dgv_Borrow_Books.RowTemplate.Height = 29;
            dgv_Borrow_Books.Size = new Size(486, 269);
            dgv_Borrow_Books.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.BackgroundImage = (Image)resources.GetObject("tabPage3.BackgroundImage");
            tabPage3.BackgroundImageLayout = ImageLayout.Stretch;
            tabPage3.Controls.Add(btn_Add);
            tabPage3.Controls.Add(tb_Password);
            tabPage3.Controls.Add(tb_Phone_Number);
            tabPage3.Controls.Add(tb_Email);
            tabPage3.Controls.Add(tb_Account_Name);
            tabPage3.Controls.Add(tb_Account_ID_2);
            tabPage3.Controls.Add(label11);
            tabPage3.Controls.Add(label10);
            tabPage3.Controls.Add(label9);
            tabPage3.Controls.Add(label8);
            tabPage3.Controls.Add(label7);
            tabPage3.Controls.Add(dgv_Account_1);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(791, 413);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Register an account";
            tabPage3.UseVisualStyleBackColor = true;
            tabPage3.Click += tabPage3_Click;
            // 
            // btn_Add
            // 
            btn_Add.BackColor = Color.Peru;
            btn_Add.Location = new Point(471, 98);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(94, 29);
            btn_Add.TabIndex = 11;
            btn_Add.Text = "Add";
            btn_Add.UseVisualStyleBackColor = false;
            btn_Add.Click += btn_Add_Click;
            // 
            // tb_Password
            // 
            tb_Password.BackColor = SystemColors.Info;
            tb_Password.Location = new Point(513, 52);
            tb_Password.Name = "tb_Password";
            tb_Password.Size = new Size(160, 27);
            tb_Password.TabIndex = 10;
            // 
            // tb_Phone_Number
            // 
            tb_Phone_Number.BackColor = SystemColors.Info;
            tb_Phone_Number.Location = new Point(513, 14);
            tb_Phone_Number.Name = "tb_Phone_Number";
            tb_Phone_Number.Size = new Size(160, 27);
            tb_Phone_Number.TabIndex = 9;
            // 
            // tb_Email
            // 
            tb_Email.BackColor = SystemColors.Info;
            tb_Email.Location = new Point(205, 98);
            tb_Email.Name = "tb_Email";
            tb_Email.Size = new Size(166, 27);
            tb_Email.TabIndex = 8;
            // 
            // tb_Account_Name
            // 
            tb_Account_Name.BackColor = SystemColors.Info;
            tb_Account_Name.Location = new Point(205, 56);
            tb_Account_Name.Name = "tb_Account_Name";
            tb_Account_Name.Size = new Size(166, 27);
            tb_Account_Name.TabIndex = 7;
            // 
            // tb_Account_ID_2
            // 
            tb_Account_ID_2.BackColor = SystemColors.Info;
            tb_Account_ID_2.Location = new Point(205, 17);
            tb_Account_ID_2.Name = "tb_Account_ID_2";
            tb_Account_ID_2.Size = new Size(166, 27);
            tb_Account_ID_2.TabIndex = 6;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Silver;
            label11.Location = new Point(402, 59);
            label11.Name = "label11";
            label11.Size = new Size(70, 20);
            label11.TabIndex = 5;
            label11.Text = "Password";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Silver;
            label10.Location = new Point(402, 17);
            label10.Name = "label10";
            label10.Size = new Size(105, 20);
            label10.TabIndex = 4;
            label10.Text = "Phone number";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Silver;
            label9.Location = new Point(117, 98);
            label9.Name = "label9";
            label9.Size = new Size(46, 20);
            label9.TabIndex = 3;
            label9.Text = "Email";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Silver;
            label8.Location = new Point(117, 59);
            label8.Name = "label8";
            label8.Size = new Size(49, 20);
            label8.TabIndex = 2;
            label8.Text = "Name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Silver;
            label7.Location = new Point(117, 17);
            label7.Name = "label7";
            label7.Size = new Size(24, 20);
            label7.TabIndex = 1;
            label7.Text = "ID";
            // 
            // dgv_Account_1
            // 
            dgv_Account_1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Account_1.Location = new Point(144, 151);
            dgv_Account_1.Name = "dgv_Account_1";
            dgv_Account_1.RowHeadersWidth = 51;
            dgv_Account_1.RowTemplate.Height = 29;
            dgv_Account_1.Size = new Size(502, 244);
            dgv_Account_1.TabIndex = 0;
            // 
            // Reader
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Reader";
            Text = "Reader";
            Load += Reader_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Books_1).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Borrow_Books).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Account_1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView dgv_Books_1;
        private DataGridView dgv_Borrow_Books;
        private Button btn_Search_3;
        private TextBox tb_Search_3;
        private Label label1;
        private Label label6;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox tb_Borrowed_Date;
        private TextBox tb_Book_Name_1;
        private TextBox tb_Account_ID_1;
        private Button btn_Add_2;
        private TextBox tb_Book_Management_ID;
        private Label label5;
        private TabPage tabPage3;
        private DataGridView dgv_Account_1;
        private Button btn_Add;
        private TextBox tb_Password;
        private TextBox tb_Phone_Number;
        private TextBox tb_Email;
        private TextBox tb_Account_Name;
        private TextBox tb_Account_ID_2;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
    }
}