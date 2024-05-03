using Microsoft.Data.SqlClient;

namespace WebForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=FROBIGBRAIN\\SQLEXPRESS;Initial Catalog=Loginapp;Integrated Security=True;TrustServerCertificate=True");
            con.Open();
            string query = "SELECT COUNT(*) FROM loginapp WHERE username=@username AND password= @password AND email= @email";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@username", txtUser.Text);
            cmd.Parameters.AddWithValue("@password", txtPass.Text);
            cmd.Parameters.AddWithValue("@email", txtEmail.Text);

            int count = (int)cmd.ExecuteScalar();
            con.Close();

            if (count > 0)
            {
                MessageBox.Show("login success, you are not a caveman!", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("error in login, aint easy fam!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Close(); will close everything!
            this.Close();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtPass.PasswordChar = checkBox1.Checked ? '\0' : '*';

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Email_Click(object sender, EventArgs e)
        {

        }
    }
}
