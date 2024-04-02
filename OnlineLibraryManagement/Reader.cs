using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineLibraryManagement
{
    public partial class Reader : Form
    {
        SqlConnection conn;
        public Reader()
        {
            InitializeComponent();
            createConection();
        }

        private void createConection()
        {
            try
            {
                String stringConnection = "Server = DESKTOP-JTM46PS\\CHIEN;Database =  OnlineLibraryManagement; Integrated Security = true";
                conn = new SqlConnection(stringConnection);
                MessageBox.Show("Connected successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error at the connection stage with createConection: " + ex.Message);
            }
        }

        private void Reader_Load(object sender, EventArgs e)
        {
            display();
            display_1();
            display_2();
        }
        private void display()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                String sql = "SELECT * FROM Account";
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dgv_Account_1.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in function display: " + ex.Message);
            }
        }
        private void display_1()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                String sql = "SELECT * FROM Books";
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dgv_Books_1.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in function display_1: " + ex.Message);
            }
        }

        private void display_2()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                String sql = "SELECT * FROM Book_Management";
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dgv_Borrow_Books.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in function display_2: " + ex.Message);
            }
        }

        private void btn_Search_3_Click(object sender, EventArgs e)
        {
            conn.Open();
            string st = "SELECT * FROM Books WHERE Book_ID = @Book_ID";
            SqlCommand cmd = new SqlCommand(st, conn);
            cmd.Parameters.AddWithValue("Book_ID", tb_Search_3.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgv_Books_1.DataSource = dt;
            conn.Close();
        }

        private void btn_Add_2_Click(object sender, EventArgs e)
        {
            createNewBrand_2();
            display_2();
        }
        private void createNewBrand_2()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                String sql = "INSERT INTO Book_Management(Book_Management_ID, Account_ID, Book_Name, Borrowed_Date) " +
                             "VALUES ( @value_Book_Management_ID, @value_Account_ID, @value_Book_Name, @value_Borrowed_Date )";
                cmd.CommandText = sql;
                cmd.Parameters.Add("@value_Book_Management_ID", SqlDbType.VarChar);
                cmd.Parameters.Add("@value_Account_ID", SqlDbType.VarChar);
                cmd.Parameters.Add("@value_Book_Name", SqlDbType.VarChar);
                cmd.Parameters.Add("@value_Borrowed_Date", SqlDbType.Date);
                cmd.Parameters["@value_Book_Management_ID"].Value = tb_Book_Management_ID.Text.ToString();
                cmd.Parameters["@value_Account_ID"].Value = tb_Account_ID_1.Text.ToString();
                cmd.Parameters["@value_Book_Name"].Value = tb_Book_Name_1.Text.ToString();
                cmd.Parameters["@value_Borrowed_Date"].Value = DateTime.Parse(tb_Borrowed_Date.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Create a new brand successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("There is an error in the CreateNewBrand_2() function: " + ex.Message);
            }
            conn.Close();
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            createNewBrand();
            display();
        }
        private void createNewBrand()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                String sql = "INSERT INTO Account( Account_ID, Account_Name, Email, " +
                "Phone_Number, Password ) VALUES ( @value_Account_ID, @value_Account_Name, " +
                "@value_Email, @value_Phone_Number, @value_Password )";
                cmd.CommandText = sql;
                cmd.Parameters.Add("@value_Account_ID", SqlDbType.VarChar);
                cmd.Parameters.Add("@value_Account_Name", SqlDbType.VarChar);
                cmd.Parameters.Add("@value_Email", SqlDbType.VarChar);
                cmd.Parameters.Add("@value_Phone_Number", SqlDbType.Int);
                cmd.Parameters.Add("@value_Password", SqlDbType.Int);
                cmd.Parameters["@value_Account_ID"].Value = tb_Account_ID_2.Text.ToString();
                cmd.Parameters["@value_Account_Name"].Value = tb_Account_Name.Text.ToString();
                cmd.Parameters["@value_Email"].Value = tb_Email.Text.ToString();
                cmd.Parameters["@value_Phone_Number"].Value = tb_Phone_Number.Text.ToString();
                cmd.Parameters["@value_Password"].Value = tb_Password.Text.ToString();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Create a new brand successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("There is an error in the CreateNewBrand() function: " + ex.Message);
            }
            conn.Close();
        }
    }
}
