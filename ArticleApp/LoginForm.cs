using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArticleApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }



        private void textBox1_Click(object sender, EventArgs e)
        {
            textBoxUsername1.Text = "";
        }


        private void textBox2_Click(object sender, EventArgs e)
        {
            textBoxPassword.Text = "";
        }

        private void label2_Click(object sender, EventArgs e)
        {
            var myForm = new RegisterForm();
            this.Hide();
            myForm.ShowDialog();
       
        }




        //kad se logira korisnik spremamo njegov id
       

        private int UserId;

        private void button1_Click(object sender, EventArgs e)
        {
            
            bool validUser = false;


            foreach (Users u in UserRepository.GetUsers())
            {
                if (u.Username.Equals(textBoxUsername1.Text, StringComparison.OrdinalIgnoreCase)
                && u.Password.Equals(textBoxPassword.Text, StringComparison.Ordinal)
                && (u.User_type_id == "Admin" || u.User_type_id == "Korisnik"))
                {
                    validUser = true;
                    UserId = u.Id;
                    break;
                }
            }


            if (validUser)
            {




               MainForm form = new MainForm(UserId);
                this.Hide();
                form.Show();
            }
        
            else
            {
                Label loginStatus = new Label();
                loginStatus.Text = "Login failed!";
                loginStatus.BackColor = Color.Red;
                loginStatus.ForeColor = Color.Black;
                loginStatus.Font = new Font("Nirmala UI", 10.75f, FontStyle.Bold);
                loginStatus.Location = new Point(340, 315);
                loginStatus.AutoSize = true;
                this.Controls.Add(loginStatus);

            }



            textBoxPassword.Text = "";
            textBoxUsername1.Text = "";


        }




        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBoxPassword.UseSystemPasswordChar =false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxPassword.UseSystemPasswordChar = false;

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sTUDENTI_PINDataSet3.AA_users' table. You can move, or remove it, as needed.
            this.aA_usersTableAdapter.Fill(this.sTUDENTI_PINDataSet3.AA_users);

        }
    }
}
