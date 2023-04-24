using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArticleApp
{
    public class UserRepository
    {



        //LOGIN OVO ONO
        public static List<Users> GetUsers()
        {
            try
            {
                List<Users> Users = new List<Users>();
                string connectionString = "Data Source=193.198.57.183; Initial Catalog = STUDENTI_PIN;User Id = pin; Password = Vsmti1234!";
                using (DbConnection connection = new SqlConnection(connectionString))
                using (DbCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT *, AA_user_type.name as Uloga FROM AA_users INNER JOIN AA_user_type ON AA_users.user_type_id = AA_user_type.id;";
                    connection.Open();
                    using (DbDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            Users.Add(new Users()
                            {
                                Id = (int)reader["id"],
                                Username = (string)reader["username"],
                                Password = (string)reader["password"],
                                User_type_id = (string)reader["Uloga"]
                            });

                        }
                    }
                }
                return Users;
            }
            catch (Exception)
            {
                return null;
            }
        }


        public static bool RegisterUser(string username, string password, string repeatPassword, string userType)
        {
            try
            {
                // dohvat korisnika iz baze
                List<Users> Users = GetUsers();



                // provjeri postoji li korisnik s tim imenom u bazi
                bool userExists = Users.Exists(u => u.Username == username);
                if (string.IsNullOrEmpty(password) || string.IsNullOrEmpty(repeatPassword))
                {
                    MessageBox.Show("Morate unijeti lozinke.");
                    return false;
                }
                if (string.IsNullOrEmpty(userType))
                {
                    MessageBox.Show("Morate unijeti tip korisnika.");
                    return false;
                }

                if (userExists)
                {
                    MessageBox.Show("Korisnik s tim imenom već postoji.");
                    return false;
                }

                if (password != repeatPassword)
                {
                    MessageBox.Show("Lozinke se ne podudaraju.");
                    return false;
                }

                string connectionString = "Data Source=193.198.57.183; Initial Catalog = STUDENTI_PIN;User Id = pin; Password = Vsmti1234!";
                using (DbConnection connection = new SqlConnection(connectionString))
                using (DbCommand command = connection.CreateCommand())
                {
                    command.CommandText = "INSERT INTO AA_users (id, username, password, user_type_id) VALUES (@id,@username, @password, @userType )";

                    int id = Users.Any() ? Users.Max(u => u.Id) + 1 : 1;

                    SqlParameter parameterId = new SqlParameter("@id", SqlDbType.Int);
                    parameterId.Value = id;
                    command.Parameters.Add(parameterId);

                    SqlParameter parameterUsername = new SqlParameter("@username", SqlDbType.Text);
                    parameterUsername.Value = username;
                    command.Parameters.Add(parameterUsername);

                    SqlParameter parameterPassword = new SqlParameter("@password", SqlDbType.Text);
                    parameterPassword.Value = password;
                    command.Parameters.Add(parameterPassword);

                    int userTypeId = 2;
                    if (userType == "Admin")
                    {
                        userTypeId = 1;
                    }
                    /*   else if (userType == "Korisnik")
                       {
                           userTypeId = 2;
                       }
                    */
                    SqlParameter parameterUserType = new SqlParameter("@userType", SqlDbType.Int);
                    parameterUserType.Value = userTypeId;
                    command.Parameters.Add(parameterUserType);

                    connection.Open();
                    command.ExecuteNonQuery();
                }

                MessageBox.Show("Registracija uspješna.");
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dogodila se greška prilikom registracije: " + ex.Message);
                return false;
            }
        }



        public Article_type GetArticleType()
        {
            try
            {
                string connectionString = "Data Source=193.198.57.183; Initial Catalog = STUDENTI_PIN;User Id = pin; Password = Vsmti1234!";
                using (DbConnection connection = new SqlConnection(connectionString))
                using (DbCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT * FROM article_type WHERE id = ${this.id};";
                    connection.Open();
                    using (DbDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Article_type article_type = new Article_type()
                            {
                                Id = (int)reader["id"],
                                Name = (string)reader["name"]
                            };

                            if (article_type != null)
                            {
                                return article_type;
                            }

                        }

                    }
                }
                return null;

            }
            catch (Exception)
            {
                return null;
            }

        }


        public static List<Article> GetArticles()
        {
            try
            {
                List<Article> articles = new List<Article>();
                string connectionString = "Data Source=193.198.57.183; Initial Catalog = STUDENTI_PIN;User Id = pin; Password = Vsmti1234!";
                using (DbConnection connection = new SqlConnection(connectionString))
                using (DbCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT * FROM AA_article";
                    connection.Open();
                    using (DbDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            articles.Add(new Article()
                            {
                                Id = (int)reader["id"],
                                Article_type_id = (int)reader["article_type_id"],
                                User_id = (int)reader["user_id"],
                                Title = (string)reader["title"],
                                Content = (string)reader["content"],
                                Date_created = (DateTime)reader["date_created"],
                                Date_modified = (DateTime)reader["date_modified"]
                            });
                        }
                    }
                }
              
                
                    return articles;
                
             
            }
            catch (Exception)
            {
                return null;
            }
        }







    }
}










