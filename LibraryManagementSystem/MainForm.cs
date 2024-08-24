using System;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class MainForm : Form
    {
        private readonly LoginForm loginForm = new LoginForm();
        private readonly Dashboard dashboard = new Dashboard(); 
        private readonly AddBooksForm addBooks = new AddBooksForm();
        private readonly BorrowedBooks borrowedBooks = new BorrowedBooks();
        private readonly  ReturnBooks returnBooks = new ReturnBooks();  
        private readonly AddPerson addPerson = new AddPerson();

        public MainForm()
        {
            InitializeComponent();
        }

        private void DisplayForms<T>(T control) where T : UserControl
        {
            pn_Container.Controls.Clear();
            pn_Container.Controls.Add(control);
        }
        private void dashboard_btn_Click(object sender, EventArgs e)
          =>DisplayForms<Dashboard>(dashboard); 

        private void MainForm_Load(object sender, EventArgs e)
            => DisplayForms<Dashboard>(dashboard);

        private void bn_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void addBooks_btn_Click(object sender, EventArgs e)
            => DisplayForms<AddBooksForm>(addBooks);

        private void Borrowed_Btn_Click(object sender, EventArgs e)
            => DisplayForms<BorrowedBooks>(borrowedBooks);

        private void returnBooks_btn_Click(object sender, EventArgs e)
         =>DisplayForms<ReturnBooks> (returnBooks);

        private void btn_Max_Click(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;   
            }
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            loginForm.Show();
            this.Close();
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
            => DisplayForms<AddPerson>(addPerson);
    }
}

