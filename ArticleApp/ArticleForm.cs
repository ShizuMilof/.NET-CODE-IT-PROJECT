using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.DirectoryServices.AccountManagement;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ArticleApp;


namespace ArticleApp
{
    public partial class ArticleForm : Form
    {
        private int _articleId;
        private int userId;
 
        public ArticleForm(int userId, int articleId)
        {
            this.userId = userId;
            InitializeComponent();

            Console.WriteLine("userId: " + userId);
            _articleId = articleId;
            // Učitaj podatke iz baze i postavljanje vrijednosti polja u formi za uređivanje članka
            LoadData();
          
        }
        private void ArticleForm_Load_1(object sender, EventArgs e)
        {
            ProvjeraButtona();
        }

        string connectionString = "Data Source=193.198.57.183; Initial Catalog = STUDENTI_PIN;User Id = pin; Password = Vsmti1234!";


        public void LoadData()
        {
            int userID = userId; //PODATAK KOJI SMMO UZELI IZ FORME PROSLIJEDENO S LOGINA

            // Ako se radi o uređivanju postojećeg članka, dohvati podatke iz baze
            if (_articleId != 0)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT title, content, article_type_id FROM AA_article WHERE id = @articleId";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@articleId", _articleId);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string title = reader.GetString(0);
                                string content = reader.GetString(1);
                                int article_type_id = reader.GetInt32(2);

                                // Postavi vrijednosti polja u formi za uređivanje članka
                                textBox1.Text = title;
                                richTextBox1.Text = content;
                                comboBox1.SelectedIndex = article_type_id - 1;
                            }
                        }
                    }
                }
            }
        }


        public void ProvjeraButtona()
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(richTextBox1.Text) || string.IsNullOrEmpty(comboBox1.Text))
            {
                button1.Text = "DODAJ";  
            }
            else
            {
                button1.Text = "UREĐIVANJE";
            }
        }


        private void button5_Click(object sender, EventArgs e)
        {
            var myForm1 = new MainForm(userId);
            this.Hide();
            myForm1.ShowDialog();
            this.Close();
        }


        public void Dodavanje()
        {
            int userID = userId; //PODATAK KOJI SMMO UZELI IZ FORME PROSLIJEDENO S LOGINA
            string title = textBox1.Text;
            string content = richTextBox1.Text;
            int article_type_id = 0;
         
            if(comboBox1.Text == "")
            {
              MessageBox.Show("Molimo ispunite sva polja.");
            }
            string category = comboBox1.SelectedItem.ToString();

            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(richTextBox1.Text) || string.IsNullOrWhiteSpace(comboBox1.Text))
            {  
                MessageBox.Show("Molimo ispunite sva polja.");
                return;
            }
            // Provjerite jesu li sva polja popunjena

            // dohvatite trenutni maksimalni id iz baze
            int newArticleId = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string getMaxIdQuery = "SELECT MAX(id) FROM AA_article";
                using (SqlCommand getMaxIdCommand = new SqlCommand(getMaxIdQuery, connection))
                {
                    connection.Open();
                    object result = getMaxIdCommand.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        newArticleId = Convert.ToInt32(result) + 1; // povecajte maksimalni id za 1
                    }
                    else
                    {
                        newArticleId = 1; // ako nema artikala u bazi, postavi id na 1
                    }
                }
            }

            switch (category)
            {
                case "HRANA":
                    article_type_id = 1;
                    break;
                case "GLAZBA":
                    article_type_id = 2;
                    break;
                case "TEHNOLOGIJA":
                    article_type_id = 3;
                    break;
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();


                // prvo dohvatite trenutni maksimalni id iz baze
                string getMaxIdQuery = "SELECT MAX(id) FROM AA_article";
                using (SqlCommand getMaxIdCommand = new SqlCommand(getMaxIdQuery, connection))
                {
                    object result = getMaxIdCommand.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        newArticleId = Convert.ToInt32(result) + 1; // povecajte maksimalni id za 1
                    }
                    else
                    {
                        newArticleId = 1; // ako nema artikala u bazi, postavi id na 1
                    }
                }

                // dodaj novi artikl u bazu podataka
                string insertQuery = "INSERT INTO AA_article (id,article_type_id, user_id,title, content, date_created,date_modified) VALUES (@newArticleId, @articleTypeId,@userID,@title ,@content,@date_Added,@dateAdded2)";
                using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                {
                    insertCommand.Parameters.AddWithValue("@newArticleId", newArticleId);
                    insertCommand.Parameters.AddWithValue("@articleTypeId", article_type_id);
                    insertCommand.Parameters.AddWithValue("@userID", userID);
                    insertCommand.Parameters.AddWithValue("@title", title);
                    insertCommand.Parameters.AddWithValue("@content", content);
                    insertCommand.Parameters.AddWithValue("@date_Added", DateTime.Now);
                    insertCommand.Parameters.AddWithValue("@dateAdded2", DateTime.Now);


                    int rowsAffected = insertCommand.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Artikl uspješno dodan u bazu podataka.");
                        this.Hide(); // skrivanje obrasca za unos
                        MainForm mainForm = new MainForm(userID);
                        mainForm.Show(); // prikazivanje glavnog obrasca
                    }
                    else
                    {
                        MessageBox.Show("Došlo je do pogreške prilikom dodavanja artikla u bazu podataka.");
                    }

                }
            }
        }


        public void Azuriranje()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE AA_article SET title = @title,date_modified=@dateAdded2, content = @content, article_type_id = @article_type_id WHERE id = @articleId";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@title", textBox1.Text);
                    command.Parameters.AddWithValue("@content", richTextBox1.Text);
                    command.Parameters.AddWithValue("@article_type_id", comboBox1.SelectedIndex + 1);
                    command.Parameters.AddWithValue("@articleId", _articleId);
                    command.Parameters.AddWithValue("@dateAdded2", DateTime.Now);
                    command.ExecuteNonQuery();
                }

            }
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(richTextBox1.Text) || string.IsNullOrWhiteSpace(comboBox1.Text))
            {
                MessageBox.Show("Molimo ispunite sva polja kako bi se ažuriranje izvršilo.");
                return;
            }
            MessageBox.Show("AŽURIRANJE....");

            this.Close();
            MainForm mainForm = new MainForm(userId);
            mainForm.Show(); // prikazivanje glavnog obrasca



        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(button1.Text=="DODAJ")
            {
                if (comboBox1.Text == "")
                {
                    MessageBox.Show("Molimo ispunite sva polja.");
                }
                else 
                {
                Dodavanje();
                }
            }
            else
            {
                Azuriranje();
            }
        }
    }      

    }

