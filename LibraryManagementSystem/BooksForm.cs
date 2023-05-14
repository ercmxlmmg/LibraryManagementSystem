using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class BooksForm : Form
    {
        DataTable table = new DataTable();
        int index;

        public BooksForm()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void BooksForm_Load(object sender, EventArgs e)
        {
            table.Columns.Add("Title");
            table.Columns.Add("Author");
            table.Columns.Add("Qty");
            table.Columns.Add("Status");
            table.Columns.Add("StudNo");
            table.Columns.Add("StudName");
            table.Columns.Add("YearLevel");
            table.Columns.Add("Contact");
            table.Columns.Add("Date & Time");
            dgvTable.DataSource = table;

            lblDate.Text = DateTime.Now.ToString("dd MMMM, yyyy/hh:mm:ss tt");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            txtTitle.Text = "";
            txtAuthor.Text = "";
            nmdQty.Text = "";
            cmbStatus.Text = "";
            txtStudNo.Text = "";
            txtStudName.Text = "";
            txtYn.Text = "";
            txtContact.Text = "";
            lblDate.Text = "";

            table.Rows.Clear();
        }

        private void btnBorrowed_Click(object sender, EventArgs e)
        {
            table.Rows.Add(txtTitle.Text, txtAuthor.Text, nmdQty.Text, cmbStatus.Text, txtStudNo.Text, txtStudName.Text, txtYn.Text, txtContact.Text, lblDate.Text);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtTitle.Text = "";
            txtAuthor.Text = "";
            nmdQty.Text = "";
            cmbStatus.Text = "";
            txtStudNo.Text = "";
            txtStudName.Text = "";
            txtYn.Text = "";
            txtContact.Text = "";
            lblDate.Text = "";
        }


        private void label14_Click(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("dd MMMM, yyyy/hh:mm:ss tt");
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            DataGridViewRow row = dgvTable.Rows[index];

            lblDate.Text = DateTime.Now.ToString("dd MMMM, yyyy/hh:mm:ss tt");
        }
    }
}
