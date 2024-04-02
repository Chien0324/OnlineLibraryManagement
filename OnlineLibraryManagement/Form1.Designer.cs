namespace OnlineLibraryManagement
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            tb_Email = new TextBox();
            tb_Password = new TextBox();
            btn_Login = new Button();
            btn_Exit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Silver;
            label1.Location = new Point(168, 126);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 0;
            label1.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Silver;
            label2.Location = new Point(168, 183);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // tb_Email
            // 
            tb_Email.BackColor = SystemColors.Info;
            tb_Email.Location = new Point(272, 126);
            tb_Email.Name = "tb_Email";
            tb_Email.Size = new Size(238, 27);
            tb_Email.TabIndex = 2;
            // 
            // tb_Password
            // 
            tb_Password.BackColor = SystemColors.Info;
            tb_Password.Location = new Point(272, 183);
            tb_Password.Name = "tb_Password";
            tb_Password.Size = new Size(238, 27);
            tb_Password.TabIndex = 3;
            // 
            // btn_Login
            // 
            btn_Login.BackColor = Color.Peru;
            btn_Login.Location = new Point(226, 238);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(94, 29);
            btn_Login.TabIndex = 4;
            btn_Login.Text = "Login";
            btn_Login.UseVisualStyleBackColor = false;
            btn_Login.Click += btn_Login_Click;
            // 
            // btn_Exit
            // 
            btn_Exit.BackColor = Color.Peru;
            btn_Exit.Location = new Point(367, 238);
            btn_Exit.Name = "btn_Exit";
            btn_Exit.Size = new Size(94, 29);
            btn_Exit.TabIndex = 5;
            btn_Exit.Text = "Exit";
            btn_Exit.UseVisualStyleBackColor = false;
            btn_Exit.Click += btn_Exit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Screenshot_2024_03_27_132110;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(676, 394);
            Controls.Add(btn_Exit);
            Controls.Add(btn_Login);
            Controls.Add(tb_Password);
            Controls.Add(tb_Email);
            Controls.Add(label2);
            Controls.Add(label1);
            DoubleBuffered = true;
            Name = "Form1";
            Text = "Login( library )";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tb_Email;
        private TextBox tb_Password;
        private Button btn_Login;
        private Button btn_Exit;
    }
}