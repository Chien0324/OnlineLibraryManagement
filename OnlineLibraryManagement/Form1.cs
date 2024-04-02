using System.Data.SqlClient;

namespace OnlineLibraryManagement
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        public Form1()
        {
            InitializeComponent();
            createConection();
        }

        private void createConection()
        {
            try
            {
                String stringConnection = "Server = DESKTOP-JTM46PS\\CHIEN;Database =  OnlineLibraryManagement; " +
                "Integrated Security = true";
                conn = new SqlConnection(stringConnection);
                MessageBox.Show("Connected successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error at the connection stage with createConection: " + ex.Message);
            }
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            try
            {
                String email = tb_Email.Text;
                String password = tb_Password.Text;
                conn.Open();

                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                String sql = "SELECT TOP 1 * FROM Account Where Account.password ='" + password + 
                "' AND Account.email = '" + email + "'";
                cmd.CommandText = sql;
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    Appdata.isLogin = true;
                    Appdata.email = email;

                    Appdata.email = reader["Email"].ToString();
                    Appdata.role = Int32.Parse(reader["Role"].ToString());
                    Close();
                }
                else
                {
                    MessageBox.Show("Does not exist");
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error at the connection stage with btnLogin_Click : " + ex.Message);
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you really want to escape ?", "Confirm", 
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}