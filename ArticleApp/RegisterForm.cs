using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ArticleApp
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var myForm1 = new LoginForm();
            this.Hide();
            myForm1.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
       
            string username = textBoxKorisnickoIme.Text;
            string password = textBoxLozinka.Text;
            string repeatPassword = textBoxPonovljenaLozinka.Text;
            string userType = comboBoxTipKorisnika.Text;

            UserRepository repository = new UserRepository();

            bool success = UserRepository.RegisterUser(username, password, repeatPassword, userType);
            if (success)
            {
                // registracija je uspjela, obavijestite korisnika o tome
                MessageBox.Show("Registracija uspješna."); 
                var myForm1 = new LoginForm();
                this.Hide();
                myForm1.ShowDialog();
                this.Close();
            }


            else
            {
            }

        }



    }
}

