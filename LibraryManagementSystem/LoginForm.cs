using System;
using System.Linq;
using System.Windows.Forms;
using LibraryManagementSystem.Data;

namespace LibraryManagementSystem
{
    public partial class LoginForm : Form
    {
        private ApplicationDbContext context = new ApplicationDbContext();
        private  RegisterationForm registerForm;
        private  MainForm mainForm;

        public LoginForm()
        {
            InitializeComponent();
        }


        private void signupBtn_Click(object sender, EventArgs e)
        {
            registerForm = new RegisterationForm();
            registerForm.Show();
            this.Close();
        }

  
        private void btn_Close_Click_1(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void login_showPass_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = login_showPass.Checked ? '\0' : '*'; 
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text !=  "" && txtPassword.Text != "")
            {
                var usernameResult = context.Users.FirstOrDefault(u => u.UserName == txtUsername.Text);

                if(usernameResult != null && usernameResult.Password == txtPassword.Text)
                {
                    mainForm = new MainForm();
                    mainForm.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid Username Or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("Please fill in all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
