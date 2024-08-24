using LibraryManagementSystem.Data;
using LibraryManagementSystem.Model;
using System;
using System.Linq;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class AddPerson : UserControl
    {
        public AddPerson()
        {
            InitializeComponent();
        }

        ApplicationDbContext context = new ApplicationDbContext();

        private void AddPerson_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].Name = "Id";
            dataGridView1.Columns[0].HeaderText = "Id";
            dataGridView1.Columns[1].Name = "Name";
            dataGridView1.Columns[1].HeaderText = "Name";
            dataGridView1.Columns[2].Name = "Address";
            dataGridView1.Columns[2].HeaderText = "Address";
            dataGridView1.Columns[3].Name = "Phone";
            dataGridView1.Columns[3].HeaderText = "Phone";
            dataGridView1.Rows.Clear();
            GetAllBooks();
        }

        private void GetAllBooks()
        {
            var people = context.Persons.ToList();

            foreach (var person in people)
            {

                dataGridView1.Rows.Add(new string[] { person.ID.ToString(), person.Name, person.Address, person.phone});
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var person = new Person()
                {
                    Name = txtName.Text,
                    Address = txtAddress.Text,
                    phone = txtPhone.Text,
                };

                context.Persons.Add(person);
                context.SaveChanges();
                dataGridView1.Rows.Clear();
                GetAllBooks();
                Clear();
            }
            catch
            {
                MessageBox.Show("Enter valid Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var id = int.Parse(dataGridView1[0, IndexRow].Value.ToString());
            var OldPerson = context.Persons.FirstOrDefault(x => x.ID == id);
            try
            {
                if (OldPerson != null)
                {
                    OldPerson.Name = txtName.Text;
                    OldPerson.Address = txtAddress.Text;
                    OldPerson.phone = txtPhone.Text;

                    context.SaveChanges();
                    dataGridView1.Rows.Clear();
                    GetAllBooks();
                    Clear();
                }
            }
            catch
            {
                MessageBox.Show("Enter valid Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var id = int.Parse(dataGridView1[0, IndexRow].Value.ToString());
            var person = context.Persons.FirstOrDefault(x => x.ID == id);
            var Result = MessageBox.Show("Are you Sure Remove this Person", "Person", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Result == DialogResult.Yes)
            {
                if (person != null)
                {

                    context.Persons.Remove(person);
                    context.SaveChanges();
                    dataGridView1.Rows.Clear();
                    GetAllBooks();
                    Clear();
                }
                else
                {
                    MessageBox.Show("invaild");
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
            => Clear();

        private void Clear()
        {
            txtName.Text = "";
            txtAddress.Text = "";
            txtPhone.Text = "";
        }

        int IndexRow;

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            IndexRow = dataGridView1.SelectedCells[0].RowIndex;

            txtName.Text = dataGridView1[1, IndexRow].Value.ToString();
            txtAddress.Text = dataGridView1[2, IndexRow].Value.ToString();
            txtPhone.Text = dataGridView1[3, IndexRow].Value.ToString();
        }
    }
}
