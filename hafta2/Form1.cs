using System.Data;
using Microsoft.Data.SqlClient;

namespace hafta2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            list_results();
        }

        //SqlConnection conn = new SqlConnection("Data Source=DESKTOP-2FRKVQK\\SQLEXPRESS; initial catalog=StudentDB; integrated security=true; Trusted_Connection=True; TrustServerCertificate=True;");
        SqlConnection conn = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB; initial catalog=Students; integrated security=true");

        void list_results()
        {
            conn.Open();

            var command = new SqlCommand("SELECT * FROM Students", conn);
            var reader = command.ExecuteReader();
            var dt = new DataTable();
            dt.Load(reader);

            conn.Close();

            dataGridView1.DataSource = dt;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            conn.Open();

            var command = new SqlCommand("INSERT INTO Students (Name, Surname, Email) VALUES (@name, @surname, @email)", conn);

            command.Parameters.AddWithValue("@name", txtName.Text);
            command.Parameters.AddWithValue("@surname", txtSurname.Text);
            command.Parameters.AddWithValue("@email", txtEmail.Text);

            command.ExecuteNonQuery();

            conn.Close();

            list_results();
        }

        int selectedId;

        private void btnDelete_Click(object sender, EventArgs e)
        {
            conn.Open();

            var command = new SqlCommand("DELETE FROM Students WHERE Id = @id ", conn);

            command.Parameters.AddWithValue("id", selectedId);

            command.ExecuteNonQuery();

            conn.Close();

            list_results();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            conn.Open();

            var command = new SqlCommand("UPDATE Students SET Name = @name, Surname = @surname, Email = @email WHERE Id = @id", conn);

            command.Parameters.AddWithValue("id", selectedId);
            command.Parameters.AddWithValue("name", txtName.Text);
            command.Parameters.AddWithValue("surname", txtSurname.Text);
            command.Parameters.AddWithValue("email", txtEmail.Text);

            command.ExecuteNonQuery();

            conn.Close();

            list_results();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var sql = @"
                SELECT * FROM Students
                WHERE Name LIKE @name
                AND Surname LIKE @surname
                AND Email LIKE @email
            ";

            var command = new SqlCommand(sql, conn);

            command.Parameters.AddWithValue("@name", "%" + txtName.Text + "%");
            command.Parameters.AddWithValue("@surname", "%" + txtSurname.Text + "%");
            command.Parameters.AddWithValue("@email", "%" + txtEmail.Text + "%");

            conn.Open();

            var reader = command.ExecuteReader();
            var dt = new DataTable();
            dt.Load(reader);
            dataGridView1.DataSource = dt;

            conn.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedId = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            txtName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtSurname.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtEmail.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
