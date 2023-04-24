using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArticleApp
{
    public class Article
    {
        public int Id { get; set; }
        public int Article_type_id { get; set; }
        public int User_id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime Date_created { get; set; }
        public DateTime Date_modified { get; set; }




        public Users GetUser()
        {
            try
            {
                string connectionString = "Data Source=193.198.57.183; Initial Catalog = STUDENTI_PIN;User Id = pin; Password = Vsmti1234!";
                using (DbConnection connection = new SqlConnection(connectionString))
                using (DbCommand command = connection.CreateCommand())
                {
                    command.CommandText = $"SELECT * FROM AA_users WHERE id = {User_id};";
                    connection.Open();
                    using (DbDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Users user = new Users()
                            {
                                Id = (int)reader["id"],
                                Username = (string)reader["username"],
                                Password = (string)reader["password"],
                                User_type_id = $"{(int)reader["user_type_id"]}"
                            };

                           
                                return user;
                            

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





        public Article_type GetArticleType()
        {
            try
            {
                string connectionString = "Data Source=193.198.57.183; Initial Catalog = STUDENTI_PIN;User Id = pin; Password = Vsmti1234!";
                using (DbConnection connection = new SqlConnection(connectionString))
                using (DbCommand command = connection.CreateCommand())
                {
                    command.CommandText = $"SELECT * FROM AA_article_type WHERE id = {Article_type_id};";
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








        public User_type GetUserType()
        {
            try
            {
                string connectionString = "Data Source=193.198.57.183; Initial Catalog = STUDENTI_PIN;User Id = pin; Password = Vsmti1234!";
                using (DbConnection connection = new SqlConnection(connectionString))
                using (DbCommand command = connection.CreateCommand())
                {
                    command.CommandText = $"SELECT * FROM AA_user_type WHERE id = {this.GetUser().User_type_id};";
                    connection.Open();
                    using (DbDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            User_type user_type = new User_type()
                            {
                                Id = (int)reader["id"],
                                Name = (string)reader["name"],
                            };
                            if (user_type != null)
                            {
                                return user_type;
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

    }



}

