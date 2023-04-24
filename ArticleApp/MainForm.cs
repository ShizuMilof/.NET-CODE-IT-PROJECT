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
using static System.Net.Mime.MediaTypeNames;


namespace ArticleApp
{
    public partial class MainForm : Form
    {
        public int userId;
        public MainForm(int userId)
        {
            InitializeComponent();

            this.userId = userId;

            dataGridView1.AutoGenerateColumns = false; //Ne generira extra stupce
            dataGridView1.AllowUserToAddRows = false;
            textBox1.AutoSize = false;

            dataGridView1.ColumnCount = 5;


            dataGridView1.Columns[0].Name = "DATUM";
            dataGridView1.Columns[1].Name = "NASLOV";
            dataGridView1.Columns[2].Name = "TIP";
            dataGridView1.Columns[3].Name = "KORISNIK";
            dataGridView1.Columns[4].Name = "id";


            List<Article> articles = UserRepository.GetArticles();
            if (articles != null && articles.Count > 0)
            {
                Article b = articles[0];
            }
            else
            {
            }


            var myForm = new ArticleForm(userId, articleId);
            myForm.LoadData();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sTUDENTI_PINDataSet2.AA_article' table. You can move, or remove it, as needed.
            this.aA_articleTableAdapter.Fill(this.sTUDENTI_PINDataSet2.AA_article);
            comboBox1.Text = "Odaberite stupac za pretragu";

            foreach (Article a in new List<Article>(UserRepository.GetArticles()))
            {

                dataGridView1.Rows.Add(a.Date_created, a.Title, a.GetArticleType().Name, a.GetUser().Username, a.Id);

            }
            Console.WriteLine("userId: " + userId);


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Resetiraj DataGridView
            dataGridView1.ClearSelection();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Visible = true;
            }

            button4_Click(sender, e);
        }




        string connectionString = "Data Source=193.198.57.183; Initial Catalog = STUDENTI_PIN;User Id = pin; Password = Vsmti1234!";



        private void button4_Click(object sender, EventArgs e)
        {
            // Provjera je li odabran stupac za pretraživanje
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Odaberite stupac za pretraživanje.");
                return;
            }

            // Provjera je li unesen tekst za pretraživanje
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Molimo unesite tekst za pretraživanje.");
                return;
            }

            // Dohvaćanje naziva stupca za pretraživanje i teksta za pretraživanje
            string columnName = comboBox1.SelectedItem.ToString();
            string searchText = textBox1.Text.Trim().ToLower();

            // Poništavanje označenih ćelija
            dataGridView1.ClearSelection();

            // Traženje redka koji sadrži traženi tekst
            DataGridViewRow foundRow = null;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                DataGridViewCell cell = row.Cells[columnName];
                if (cell.Value != null && cell.Value.ToString().ToLower().Contains(searchText))
                {
                    row.Selected = true;
                    foundRow = row;
                }
            }
            if (foundRow == null)
            {

                return;
            }

            if (!foundRow.Visible)
            {
                foundRow.Visible = true;
            }

            dataGridView1.CurrentCell = foundRow.Cells[0];
            dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.Rows.IndexOf(foundRow);
        }



        private void AdjustDataGridViewSizing()
        {
            dataGridView1.ColumnHeadersHeightSizeMode =
             DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }




        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Jeste li sigurni da želite izbrisati označeni redak?", "Upozorenje", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    string user_type_id = "";
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        string query = "SELECT user_type_id FROM AA_users WHERE ID = @userId";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@userId", userId);
                        connection.Open();
                        object result2 = command.ExecuteScalar();
                        if (result2 != null)
                        {
                            user_type_id = result2.ToString();
                        }
                    }

                    foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                    {
                        int id = Convert.ToInt32(row.Cells["ID"].Value);
                        int authorId;
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            string query = "SELECT user_id FROM AA_article WHERE ID = @id";
                            SqlCommand command = new SqlCommand(query, connection);
                            command.Parameters.AddWithValue("@id", id);
                            connection.Open();
                            object result2 = command.ExecuteScalar();
                            if (result2 != null)
                            {
                                authorId = Convert.ToInt32(result2);
                            }
                            else
                            {
                                MessageBox.Show("Članak ne postoji.");
                                continue;
                            }
                        }

                        if (userId == authorId || user_type_id == "1")
                        {
                            string query = "DELETE FROM AA_article WHERE ID = @id";
                            using (SqlConnection connection = new SqlConnection(connectionString))
                            {
                                SqlCommand command = new SqlCommand(query, connection);
                                command.Parameters.AddWithValue("@id", id);
                                connection.Open();
                                command.ExecuteNonQuery();
                            }
                            dataGridView1.Rows.Remove(row);
                        }
                        else
                        {
                            MessageBox.Show("Nemate ovlasti za brisanje ovog članka.");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Odaberite redak za brisanje.");
            }
        }








        private int articleId = -1; // Inicijalno postavljamo ID na -1 kako bismo znali da članak nije odabran

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Provjeravamo je li kliknut stvarni redak, a ne zaglavlje stupca
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                articleId = Convert.ToInt32(row.Cells["id"].Value); // Preuzimamo ID članka iz stupca "id"
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            var myForm = new ArticleForm(userId, articleId);
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }



        public void UpdateDataGridView1()
        {
            string query = "SELECT ID, Title, Category FROM AA_article";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var myForm1 = new LoginForm();
            this.Hide();
            myForm1.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {


            if (dataGridView1.SelectedRows.Count > 0)
            {

                //user_type_id uzeli
                string user_type_id = "";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT user_type_id FROM AA_users WHERE ID = @userId";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@userId", userId);
                    connection.Open();
                    object result2 = command.ExecuteScalar();
                    if (result2 != null)
                    {
                        user_type_id = result2.ToString();
                    }
                }

                //user_id uzeli
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    int id = Convert.ToInt32(row.Cells["ID"].Value);
                    int authorId;
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        string query = "SELECT user_id FROM AA_article WHERE ID = @id";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@id", id);
                        connection.Open();
                        object result2 = command.ExecuteScalar();
                        if (result2 != null)
                        {
                            authorId = Convert.ToInt32(result2);
                        }
                        else
                        {
                            MessageBox.Show("Članak ne postoji.");
                            continue;
                        }
                    }



                    // Dohvati id odabranog retka

                    int articleId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id"].Value);
                    this.Close();
                    // Stvori novu instancu ArticleForm i proslijedi joj id odabranog retka
                    ArticleForm articleForm = new ArticleForm(userId, articleId);
                    if (userId == authorId || user_type_id == "1")
                    {
                        if (articleForm.ShowDialog() == DialogResult.OK)
                        {
                            this.Hide();
                            var myForm = new ArticleForm(userId, articleId);
                            myForm.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            // Do nothing
                        }
                    }
                    else
                    {

                        this.Close();
                        MessageBox.Show("Nemate ovlasti za uređivanje ovog članka.");
                        this.Close();
                        var myForm = new MainForm(articleId);
                        myForm.ShowDialog();


                    }

                }

            }
            else
            {
                MessageBox.Show("Odaberite članak koji želite urediti.");
            }
        }


    }
}