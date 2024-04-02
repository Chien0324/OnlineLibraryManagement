namespace OnlineLibraryManagement
{
    partial class Librarian
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Librarian));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label11 = new Label();
            tb_Search = new TextBox();
            btn_Search = new Button();
            btn_Updata = new Button();
            btn_Delete = new Button();
            tb_Return_Books = new TextBox();
            tb_Borrow_Books = new TextBox();
            tb_Role = new TextBox();
            tb_Dob = new TextBox();
            tb_Account_ID = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            dgv_Account = new DataGridView();
            tabPage2 = new TabPage();
            cbb_Genres = new ComboBox();
            label17 = new Label();
            tb_Search_1 = new TextBox();
            btn_Search_1 = new Button();
            btn_Updata_1 = new Button();
            btn_Delete_1 = new Button();
            tb_Author = new TextBox();
            btn_Add_1 = new Button();
            tb_Book_Name = new TextBox();
            tb_Book_ID = new TextBox();
            tb_STT_1 = new TextBox();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            dgv_Books = new DataGridView();
            tabPage3 = new TabPage();
            tb_Book_Management_ID_1 = new TextBox();
            label19 = new Label();
            btn_Delete_2 = new Button();
            label20 = new Label();
            tb_Return_Date = new TextBox();
            btn_Search_2 = new Button();
            btn_Updata_2 = new Button();
            tb_Search_2 = new TextBox();
            label18 = new Label();
            dgv_Book_Management = new DataGridView();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Account).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Books).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Book_Management).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(1, -2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(799, 451);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackgroundImage = (Image)resources.GetObject("tabPage1.BackgroundImage");
            tabPage1.BackgroundImageLayout = ImageLayout.Stretch;
            tabPage1.Controls.Add(label11);
            tabPage1.Controls.Add(tb_Search);
            tabPage1.Controls.Add(btn_Search);
            tabPage1.Controls.Add(btn_Updata);
            tabPage1.Controls.Add(btn_Delete);
            tabPage1.Controls.Add(tb_Return_Books);
            tabPage1.Controls.Add(tb_Borrow_Books);
            tabPage1.Controls.Add(tb_Role);
            tabPage1.Controls.Add(tb_Dob);
            tabPage1.Controls.Add(tb_Account_ID);
            tabPage1.Controls.Add(label10);
            tabPage1.Controls.Add(label9);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(dgv_Account);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(791, 418);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Account";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Silver;
            label11.Location = new Point(372, 66);
            label11.Name = "label11";
            label11.Size = new Size(53, 20);
            label11.TabIndex = 26;
            label11.Text = "Search";
            // 
            // tb_Search
            // 
            tb_Search.BackColor = SystemColors.Info;
            tb_Search.Location = new Point(458, 66);
            tb_Search.Name = "tb_Search";
            tb_Search.Size = new Size(252, 27);
            tb_Search.TabIndex = 25;
            // 
            // btn_Search
            // 
            btn_Search.BackColor = Color.Peru;
            btn_Search.Location = new Point(616, 18);
            btn_Search.Name = "btn_Search";
            btn_Search.Size = new Size(94, 29);
            btn_Search.TabIndex = 24;
            btn_Search.Text = "Search";
            btn_Search.UseVisualStyleBackColor = false;
            btn_Search.Click += btn_Search_Click;
            // 
            // btn_Updata
            // 
            btn_Updata.BackColor = Color.Peru;
            btn_Updata.Location = new Point(493, 17);
            btn_Updata.Name = "btn_Updata";
            btn_Updata.Size = new Size(94, 29);
            btn_Updata.TabIndex = 23;
            btn_Updata.Text = "Updata";
            btn_Updata.UseVisualStyleBackColor = false;
            btn_Updata.Click += btn_Updata_Click;
            // 
            // btn_Delete
            // 
            btn_Delete.BackColor = Color.Peru;
            btn_Delete.Location = new Point(372, 16);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.Size = new Size(94, 29);
            btn_Delete.TabIndex = 22;
            btn_Delete.Text = "Delete";
            btn_Delete.UseVisualStyleBackColor = false;
            btn_Delete.Click += btn_Delete_Click;
            // 
            // tb_Return_Books
            // 
            tb_Return_Books.BackColor = SystemColors.Info;
            tb_Return_Books.Location = new Point(117, 179);
            tb_Return_Books.Name = "tb_Return_Books";
            tb_Return_Books.Size = new Size(173, 27);
            tb_Return_Books.TabIndex = 20;
            // 
            // tb_Borrow_Books
            // 
            tb_Borrow_Books.BackColor = SystemColors.Info;
            tb_Borrow_Books.Location = new Point(117, 136);
            tb_Borrow_Books.Name = "tb_Borrow_Books";
            tb_Borrow_Books.Size = new Size(173, 27);
            tb_Borrow_Books.TabIndex = 19;
            // 
            // tb_Role
            // 
            tb_Role.BackColor = SystemColors.Info;
            tb_Role.Location = new Point(80, 95);
            tb_Role.Name = "tb_Role";
            tb_Role.Size = new Size(210, 27);
            tb_Role.TabIndex = 15;
            // 
            // tb_Dob
            // 
            tb_Dob.BackColor = SystemColors.Info;
            tb_Dob.Location = new Point(80, 56);
            tb_Dob.Name = "tb_Dob";
            tb_Dob.Size = new Size(210, 27);
            tb_Dob.TabIndex = 14;
            // 
            // tb_Account_ID
            // 
            tb_Account_ID.BackColor = SystemColors.Info;
            tb_Account_ID.Location = new Point(80, 18);
            tb_Account_ID.Name = "tb_Account_ID";
            tb_Account_ID.Size = new Size(210, 27);
            tb_Account_ID.TabIndex = 12;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Silver;
            label10.Location = new Point(6, 179);
            label10.Name = "label10";
            label10.Size = new Size(96, 20);
            label10.TabIndex = 10;
            label10.Text = "Return books";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Silver;
            label9.Location = new Point(6, 136);
            label9.Name = "label9";
            label9.Size = new Size(101, 20);
            label9.TabIndex = 9;
            label9.Text = "Borrow books";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Silver;
            label5.Location = new Point(6, 95);
            label5.Name = "label5";
            label5.Size = new Size(39, 20);
            label5.TabIndex = 5;
            label5.Text = "Role";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Silver;
            label4.Location = new Point(6, 56);
            label4.Name = "label4";
            label4.Size = new Size(38, 20);
            label4.TabIndex = 4;
            label4.Text = "Dob";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Silver;
            label2.Location = new Point(6, 18);
            label2.Name = "label2";
            label2.Size = new Size(24, 20);
            label2.TabIndex = 2;
            label2.Text = "ID";
            // 
            // dgv_Account
            // 
            dgv_Account.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Account.Location = new Point(310, 117);
            dgv_Account.Name = "dgv_Account";
            dgv_Account.RowHeadersWidth = 51;
            dgv_Account.RowTemplate.Height = 29;
            dgv_Account.Size = new Size(473, 294);
            dgv_Account.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.BackgroundImage = (Image)resources.GetObject("tabPage2.BackgroundImage");
            tabPage2.BackgroundImageLayout = ImageLayout.Stretch;
            tabPage2.Controls.Add(cbb_Genres);
            tabPage2.Controls.Add(label17);
            tabPage2.Controls.Add(tb_Search_1);
            tabPage2.Controls.Add(btn_Search_1);
            tabPage2.Controls.Add(btn_Updata_1);
            tabPage2.Controls.Add(btn_Delete_1);
            tabPage2.Controls.Add(tb_Author);
            tabPage2.Controls.Add(btn_Add_1);
            tabPage2.Controls.Add(tb_Book_Name);
            tabPage2.Controls.Add(tb_Book_ID);
            tabPage2.Controls.Add(tb_STT_1);
            tabPage2.Controls.Add(label16);
            tabPage2.Controls.Add(label15);
            tabPage2.Controls.Add(label14);
            tabPage2.Controls.Add(label13);
            tabPage2.Controls.Add(label12);
            tabPage2.Controls.Add(dgv_Books);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(791, 418);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Books";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // cbb_Genres
            // 
            cbb_Genres.BackColor = SystemColors.Info;
            cbb_Genres.FormattingEnabled = true;
            cbb_Genres.Items.AddRange(new object[] { "Novels", "Mysteries", "Thrillers", "Romance", "Science Fiction", "Short Stories", "Biographies", "Autobiographies", "Travel", "Memoirs", "Self-Help" });
            cbb_Genres.Location = new Point(87, 189);
            cbb_Genres.Name = "cbb_Genres";
            cbb_Genres.Size = new Size(191, 28);
            cbb_Genres.TabIndex = 17;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = Color.Silver;
            label17.Location = new Point(376, 83);
            label17.Name = "label17";
            label17.Size = new Size(53, 20);
            label17.TabIndex = 16;
            label17.Text = "Search";
            // 
            // tb_Search_1
            // 
            tb_Search_1.BackColor = SystemColors.Info;
            tb_Search_1.Location = new Point(465, 83);
            tb_Search_1.Name = "tb_Search_1";
            tb_Search_1.Size = new Size(225, 27);
            tb_Search_1.TabIndex = 15;
            // 
            // btn_Search_1
            // 
            btn_Search_1.BackColor = Color.Peru;
            btn_Search_1.Location = new Point(672, 27);
            btn_Search_1.Name = "btn_Search_1";
            btn_Search_1.Size = new Size(94, 29);
            btn_Search_1.TabIndex = 14;
            btn_Search_1.Text = "Search";
            btn_Search_1.UseVisualStyleBackColor = false;
            btn_Search_1.Click += btn_Search_1_Click;
            // 
            // btn_Updata_1
            // 
            btn_Updata_1.BackColor = Color.Peru;
            btn_Updata_1.Location = new Point(546, 27);
            btn_Updata_1.Name = "btn_Updata_1";
            btn_Updata_1.Size = new Size(94, 29);
            btn_Updata_1.TabIndex = 13;
            btn_Updata_1.Text = "Updata";
            btn_Updata_1.UseVisualStyleBackColor = false;
            btn_Updata_1.Click += btn_Updata_1_Click;
            // 
            // btn_Delete_1
            // 
            btn_Delete_1.BackColor = Color.Peru;
            btn_Delete_1.Location = new Point(426, 26);
            btn_Delete_1.Name = "btn_Delete_1";
            btn_Delete_1.Size = new Size(94, 29);
            btn_Delete_1.TabIndex = 11;
            btn_Delete_1.Text = "Delete";
            btn_Delete_1.UseVisualStyleBackColor = false;
            btn_Delete_1.Click += btn_Delete_1_Click;
            // 
            // tb_Author
            // 
            tb_Author.BackColor = SystemColors.Info;
            tb_Author.Location = new Point(87, 147);
            tb_Author.Name = "tb_Author";
            tb_Author.Size = new Size(191, 27);
            tb_Author.TabIndex = 10;
            // 
            // btn_Add_1
            // 
            btn_Add_1.BackColor = Color.Peru;
            btn_Add_1.Location = new Point(311, 25);
            btn_Add_1.Name = "btn_Add_1";
            btn_Add_1.Size = new Size(94, 29);
            btn_Add_1.TabIndex = 9;
            btn_Add_1.Text = "Add";
            btn_Add_1.UseVisualStyleBackColor = false;
            btn_Add_1.Click += btn_Add_1_Click;
            // 
            // tb_Book_Name
            // 
            tb_Book_Name.BackColor = SystemColors.Info;
            tb_Book_Name.Location = new Point(87, 105);
            tb_Book_Name.Name = "tb_Book_Name";
            tb_Book_Name.Size = new Size(191, 27);
            tb_Book_Name.TabIndex = 8;
            // 
            // tb_Book_ID
            // 
            tb_Book_ID.BackColor = SystemColors.Info;
            tb_Book_ID.Location = new Point(87, 66);
            tb_Book_ID.Name = "tb_Book_ID";
            tb_Book_ID.Size = new Size(191, 27);
            tb_Book_ID.TabIndex = 7;
            // 
            // tb_STT_1
            // 
            tb_STT_1.BackColor = SystemColors.Info;
            tb_STT_1.Location = new Point(87, 27);
            tb_STT_1.Name = "tb_STT_1";
            tb_STT_1.Size = new Size(191, 27);
            tb_STT_1.TabIndex = 6;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.Silver;
            label16.Location = new Point(3, 189);
            label16.Name = "label16";
            label16.Size = new Size(54, 20);
            label16.TabIndex = 5;
            label16.Text = "Genres";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.Silver;
            label15.Location = new Point(6, 147);
            label15.Name = "label15";
            label15.Size = new Size(54, 20);
            label15.TabIndex = 4;
            label15.Text = "Author";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Silver;
            label14.Location = new Point(6, 105);
            label14.Name = "label14";
            label14.Size = new Size(49, 20);
            label14.TabIndex = 3;
            label14.Text = "Name";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Silver;
            label13.Location = new Point(6, 66);
            label13.Name = "label13";
            label13.Size = new Size(24, 20);
            label13.TabIndex = 2;
            label13.Text = "ID";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Silver;
            label12.Location = new Point(7, 27);
            label12.Name = "label12";
            label12.Size = new Size(33, 20);
            label12.TabIndex = 1;
            label12.Text = "STT";
            // 
            // dgv_Books
            // 
            dgv_Books.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Books.Location = new Point(301, 147);
            dgv_Books.Name = "dgv_Books";
            dgv_Books.RowHeadersWidth = 51;
            dgv_Books.RowTemplate.Height = 29;
            dgv_Books.Size = new Size(482, 264);
            dgv_Books.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.BackgroundImage = (Image)resources.GetObject("tabPage3.BackgroundImage");
            tabPage3.BackgroundImageLayout = ImageLayout.Stretch;
            tabPage3.Controls.Add(tb_Book_Management_ID_1);
            tabPage3.Controls.Add(label19);
            tabPage3.Controls.Add(btn_Delete_2);
            tabPage3.Controls.Add(label20);
            tabPage3.Controls.Add(tb_Return_Date);
            tabPage3.Controls.Add(btn_Search_2);
            tabPage3.Controls.Add(btn_Updata_2);
            tabPage3.Controls.Add(tb_Search_2);
            tabPage3.Controls.Add(label18);
            tabPage3.Controls.Add(dgv_Book_Management);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(791, 418);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Book management";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tb_Book_Management_ID_1
            // 
            tb_Book_Management_ID_1.BackColor = SystemColors.Info;
            tb_Book_Management_ID_1.Location = new Point(160, 19);
            tb_Book_Management_ID_1.Name = "tb_Book_Management_ID_1";
            tb_Book_Management_ID_1.Size = new Size(175, 27);
            tb_Book_Management_ID_1.TabIndex = 11;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.BackColor = Color.Silver;
            label19.Location = new Point(46, 22);
            label19.Name = "label19";
            label19.Size = new Size(24, 20);
            label19.TabIndex = 10;
            label19.Text = "ID";
            // 
            // btn_Delete_2
            // 
            btn_Delete_2.BackColor = Color.Peru;
            btn_Delete_2.Location = new Point(413, 22);
            btn_Delete_2.Name = "btn_Delete_2";
            btn_Delete_2.Size = new Size(94, 29);
            btn_Delete_2.TabIndex = 9;
            btn_Delete_2.Text = "Delete";
            btn_Delete_2.UseVisualStyleBackColor = false;
            btn_Delete_2.Click += btn_Delete_2_Click;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.BackColor = Color.Silver;
            label20.Location = new Point(46, 68);
            label20.Name = "label20";
            label20.Size = new Size(88, 20);
            label20.TabIndex = 8;
            label20.Text = "Return Date";
            // 
            // tb_Return_Date
            // 
            tb_Return_Date.Location = new Point(160, 68);
            tb_Return_Date.Name = "tb_Return_Date";
            tb_Return_Date.Size = new Size(175, 27);
            tb_Return_Date.TabIndex = 7;
            // 
            // btn_Search_2
            // 
            btn_Search_2.BackColor = Color.Peru;
            btn_Search_2.Location = new Point(656, 22);
            btn_Search_2.Name = "btn_Search_2";
            btn_Search_2.Size = new Size(94, 29);
            btn_Search_2.TabIndex = 6;
            btn_Search_2.Text = "Search";
            btn_Search_2.UseVisualStyleBackColor = false;
            btn_Search_2.Click += btn_Search_2_Click;
            // 
            // btn_Updata_2
            // 
            btn_Updata_2.BackColor = Color.Peru;
            btn_Updata_2.Location = new Point(534, 22);
            btn_Updata_2.Name = "btn_Updata_2";
            btn_Updata_2.Size = new Size(94, 29);
            btn_Updata_2.TabIndex = 5;
            btn_Updata_2.Text = "Updata";
            btn_Updata_2.UseVisualStyleBackColor = false;
            btn_Updata_2.Click += btn_Updata_2_Click;
            // 
            // tb_Search_2
            // 
            tb_Search_2.Location = new Point(450, 68);
            tb_Search_2.Name = "tb_Search_2";
            tb_Search_2.Size = new Size(281, 27);
            tb_Search_2.TabIndex = 4;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.BackColor = Color.Silver;
            label18.Location = new Point(376, 68);
            label18.Name = "label18";
            label18.Size = new Size(53, 20);
            label18.TabIndex = 1;
            label18.Text = "Search";
            // 
            // dgv_Book_Management
            // 
            dgv_Book_Management.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Book_Management.Location = new Point(113, 121);
            dgv_Book_Management.Name = "dgv_Book_Management";
            dgv_Book_Management.RowHeadersWidth = 51;
            dgv_Book_Management.RowTemplate.Height = 29;
            dgv_Book_Management.Size = new Size(582, 252);
            dgv_Book_Management.TabIndex = 0;
            // 
            // Librarian
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Librarian";
            Text = "Librarian";
            Load += Librarian_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Account).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Books).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Book_Management).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private DataGridView dgv_Account;
        private DataGridView dgv_Books;
        private DataGridView dgv_Book_Management;
        private TextBox tb_Return_Books;
        private TextBox tb_Borrow_Books;
        private TextBox tb_Role;
        private TextBox tb_Dob;
        private TextBox tb_Account_ID;
        private Label label10;
        private Label label9;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label11;
        private TextBox tb_Search;
        private Button btn_Search;
        private Button btn_Updata;
        private Button btn_Delete;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label17;
        private TextBox tb_Search_1;
        private Button btn_Search_1;
        private Button btn_Updata_1;
        private Button btn_Delete_1;
        private TextBox tb_Author;
        private Button btn_Add_1;
        private TextBox tb_Book_Name;
        private TextBox tb_Book_ID;
        private TextBox tb_STT_1;
        private ComboBox cbb_Genres;
        private Button btn_Search_2;
        private Button btn_Updata_2;
        private TextBox tb_Search_2;
        private Label label18;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label20;
        private TextBox tb_Return_Date;
        private Button btn_Delete_2;
        private TextBox tb_Book_Management_ID_1;
        private Label label19;
    }
}