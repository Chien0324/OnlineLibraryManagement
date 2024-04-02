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
    public partial class Librarian : Form
    {
        SqlConnection conn;
        public Librarian()
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

        private void Librarian_Load(object sender, EventArgs e)
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
                dgv_Account.DataSource = dt;
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
                dgv_Books.DataSource = dt;
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
                dgv_Book_Management.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in function display_2: " + ex.Message);
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            deleteBrand();
            display();
        }
        private void deleteBrand()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                String sql = "DELETE Account WHERE Account_ID = @value_Account_ID";
                cmd.CommandText = sql;
                cmd.Parameters.Add("@value_Account_ID", SqlDbType.VarChar);
                cmd.Parameters["@value_Account_ID"].Value = tb_Account_ID.Text.ToString();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully removed the new brand!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("There is an error in the deleteBrand() function: " + ex.Message);
            }
            conn.Close();
        }
        private void btn_Updata_Click(object sender, EventArgs e)
        {
            UpdateBrand();
            display();
        }
        private void UpdateBrand()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                String sql = "UPDATE Account SET Account_ID = @value_Account_ID, Dob = @value_Dob, " +
                "Role = @value_Role, Borrow_Books = @value_Borrow_Books, " +
                "Return_Books = @value_Return_Books WHERE Account_ID = @value_Account_ID";
                cmd.CommandText = sql;
                cmd.Parameters.Add("@value_Account_ID", SqlDbType.VarChar);
                cmd.Parameters.Add("@value_Dob", SqlDbType.Date);
                cmd.Parameters.Add("@value_Role", SqlDbType.Int);
                cmd.Parameters.Add("@value_Borrow_Books", SqlDbType.Int);
                cmd.Parameters.Add("@value_Return_Books", SqlDbType.Int);
                cmd.Parameters["@value_Account_ID"].Value = tb_Account_ID.Text.ToString();
                cmd.Parameters["@value_Dob"].Value = DateTime.Parse(tb_Dob.Text);
                cmd.Parameters["@value_Role"].Value = tb_Role.Text.ToString();
                cmd.Parameters["@value_Borrow_Books"].Value = tb_Borrow_Books.Text.ToString();
                cmd.Parameters["@value_Return_Books"].Value = tb_Return_Books.Text.ToString();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Create a new brand successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("There is an error in the UpdateBrand() function: " + ex.Message);
            }
            conn.Close();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            conn.Open();
            string st = "SELECT * FROM Account WHERE Account_ID = @Account_ID";
            SqlCommand cmd = new SqlCommand(st, conn);
            cmd.Parameters.AddWithValue("Account_ID", tb_Search.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgv_Account.DataSource = dt;
            conn.Close();
        }

        private void btn_Add_1_Click(object sender, EventArgs e)
        {
            createNewBrand_1();
            display_1();
        }
        private void createNewBrand_1()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                String sql = "INSERT INTO Books(STT, Book_ID, Book_Name, Author, Genres ) " +
                             "VALUES (@value_STT, @value_Book_ID, @value_Book_Name, @value_Author, @value_Genres)";
                cmd.CommandText = sql;
                cmd.Parameters.Add("@value_STT", SqlDbType.Int);
                cmd.Parameters.Add("@value_Book_ID", SqlDbType.VarChar);
                cmd.Parameters.Add("@value_Book_Name", SqlDbType.VarChar);
                cmd.Parameters.Add("@value_Author", SqlDbType.VarChar);
                cmd.Parameters.Add("@value_Genres", SqlDbType.VarChar);
                cmd.Parameters["@value_STT"].Value = tb_STT_1.Text.ToString();
                cmd.Parameters["@value_Book_ID"].Value = tb_Book_ID.Text.ToString();
                cmd.Parameters["@value_Book_Name"].Value = tb_Book_Name.Text.ToString();
                cmd.Parameters["@value_Author"].Value = tb_Author.Text.ToString();
                cmd.Parameters["@value_Genres"].Value = cbb_Genres.Text.ToString();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Create a new brand successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("There is an error in the CreateNewBrand_1() function: " + ex.Message);
            }
            conn.Close();
        }
        private void btn_Delete_1_Click(object sender, EventArgs e)
        {
            deleteBrand_1();
            display_1();
        }
        private void deleteBrand_1()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                String sql = "DELETE Books WHERE Book_ID = @value_Book_ID";
                cmd.CommandText = sql;
                cmd.Parameters.Add("@value_Book_ID", SqlDbType.VarChar);
                cmd.Parameters["@value_Book_ID"].Value = tb_Book_ID.Text.ToString();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully removed the new brand!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("There is an error in the deleteBrand_1() function: " + ex.Message);
            }
            conn.Close();
        }
        private void btn_Updata_1_Click(object sender, EventArgs e)
        {
            UpdateBrand_1();
            display_1();
        }
        private void UpdateBrand_1()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                String sql = "Update Books SET STT = @value_STT, Book_ID = @value_Book_ID, Book_Name = @value_Book_Name, " +
                             "Author = @value_Author, Genres = @value_Genres WHERE Book_ID = @value_Book_ID ";
                cmd.CommandText = sql;
                cmd.Parameters.Add("@value_STT", SqlDbType.Int);
                cmd.Parameters.Add("@value_Book_ID", SqlDbType.VarChar);
                cmd.Parameters.Add("@value_Book_Name", SqlDbType.VarChar);
                cmd.Parameters.Add("@value_Author", SqlDbType.VarChar);
                cmd.Parameters.Add("@value_Genres", SqlDbType.VarChar);
                cmd.Parameters["@value_STT"].Value = tb_STT_1.Text.ToString();
                cmd.Parameters["@value_Book_ID"].Value = tb_Book_ID.Text.ToString();
                cmd.Parameters["@value_Book_Name"].Value = tb_Book_Name.Text.ToString();
                cmd.Parameters["@value_Author"].Value = tb_Author.Text.ToString();
                cmd.Parameters["@value_Genres"].Value = cbb_Genres.Text.ToString();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Create a new brand successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("There is an error in the UpdateBrand() function: " + ex.Message);
            }
            conn.Close();
        }
        private void btn_Search_1_Click(object sender, EventArgs e)
        {
            conn.Open();
            string st = "SELECT * FROM Books WHERE Book_ID = @Book_ID";
            SqlCommand cmd = new SqlCommand(st, conn);
            cmd.Parameters.AddWithValue("Book_ID", tb_Search_1.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgv_Books.DataSource = dt;
            conn.Close();
        }

        private void btn_Updata_2_Click(object sender, EventArgs e)
        {
            UpdateBrand_2();
            display_2();
        }
        private void UpdateBrand_2()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                String sql = "Update Book_Management SET  " + "Book_Management_ID = @value_Book_Management_ID ," +
                "Return_Date = @value_Return_Date WHERE Book_Management_ID = @value_Book_Management_ID";
                cmd.CommandText = sql;
                cmd.Parameters.Add("@value_Book_Management_ID", SqlDbType.VarChar);
                cmd.Parameters.Add("@value_Return_Date", SqlDbType.Date);
                cmd.Parameters["@value_Book_Management_ID"].Value = tb_Book_Management_ID_1.Text.ToString();
                cmd.Parameters["@value_Return_Date"].Value = DateTime.Parse(tb_Return_Date.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Create a new brand successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("There is an error in the UpdataBrand_2() function: " + ex.Message);
            }
            conn.Close();
        }

        private void btn_Search_2_Click(object sender, EventArgs e)
        {
            conn.Open();
            string st = "SELECT * FROM Book_Management WHERE Account_ID = @Account_ID";
            SqlCommand cmd = new SqlCommand(st, conn);
            cmd.Parameters.AddWithValue("Account_ID", tb_Search_2.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgv_Book_Management.DataSource = dt;
            conn.Close();
        }

        private void btn_Delete_2_Click(object sender, EventArgs e)
        {
            deleteBrand_2();
            display_2();
        }

        private void deleteBrand_2()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                String sql = "DELETE Book_Management WHERE Book_Management_ID = @value_Book_Management_ID";
                cmd.CommandText = sql;
                cmd.Parameters.Add("@value_Book_Management_ID", SqlDbType.VarChar);
                cmd.Parameters["@value_Book_Management_ID"].Value = tb_Book_Management_ID_1.Text.ToString();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully removed the new brand!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("There is an error in the deleteBrand_2() function: " + ex.Message);
            }
            conn.Close();
        }
    }
}
