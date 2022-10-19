using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace crud
{
    public partial class BodyOn : Form
    {

        private string id = "";
        private int intRow = 0;

        public BodyOn()
        {
            InitializeComponent();
            resetMe();
        }

        private void resetMe() 
        {
            this.id = string.Empty;

            UpdateButton.Text = "Update";
            DeleteButton.Text = "Delete";

            SearchString.Clear();

            if (SearchString.CanSelect) {
                SearchString.Select();
            }
        }

        private void loadData()
        {
            // TODO
        }

        private void execute(string query, string param) 
        {
            DbFunctions.cmd = new NpgsqlCommand(query, DbFunctions.con);
            addParameters(param);
            DbFunctions.performCRUD(DbFunctions.cmd);
        }

        private void addParameters(string str)
        {
         
            DbFunctions.cmd.Parameters.Clear();

            if (str == "Update" || str == "Delete" && !string.IsNullOrEmpty(this.id)) {
                DbFunctions.cmd.Parameters.AddWithValue("id", this.id);
            }

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormClient cliente = new FormClient();
            cliente.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BodyOn_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
