using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace cursova
{
    public partial class EditAbiturientWindow : Form
    {
        DataGridView grid;
        bool add;
        
        public EditAbiturientWindow(DataGridView grid, bool add)
        {
            InitializeComponent();
            this.grid = grid;
            this.add = add;
            if (!add)
            {
                LastnameBox.Text = grid.CurrentRow.Cells["lastname"].Value.ToString();
                NameBox.Text = grid.CurrentRow.Cells["name"].Value.ToString();
                SurnameBox.Text = grid.CurrentRow.Cells["surname"].Value.ToString();
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var connectionString = @"data source=database.sqlite3; Version=3;";
            SQLiteConnection connection = new SQLiteConnection(connectionString);
            connection = new SQLiteConnection(connectionString);
            connection.Open();
            if (add)
            {
                string query = @"INSERT INTO abiturients (lastname, name, surname)
                    VALUES (@lastname, @name, @surname); SELECT MAX(id) FROM abiturients";
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.Add(new SQLiteParameter("@lastname", LastnameBox.Text));
                command.Parameters.Add(new SQLiteParameter("@name", NameBox.Text));
                command.Parameters.Add(new SQLiteParameter("@surname", SurnameBox.Text));
                string id_str = command.ExecuteScalar().ToString();
                grid.Rows.Add(new object[]
                {
                    id_str,
                    LastnameBox.Text,
                    NameBox.Text,
                    SurnameBox.Text
                });
            }
            else
            {
                string query = "UPDATE abiturients SET lastname = @lastname, name = @name, surname = @surname WHERE id = " + grid.CurrentRow.Cells["id"].Value;
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.Add(new SQLiteParameter("@lastname", LastnameBox.Text));
                command.Parameters.Add(new SQLiteParameter("@name", NameBox.Text));
                command.Parameters.Add(new SQLiteParameter("@surname", SurnameBox.Text));
                grid.CurrentRow.Cells["lastname"].Value = LastnameBox.Text;
                grid.CurrentRow.Cells["name"].Value = NameBox.Text;
                grid.CurrentRow.Cells["surname"].Value = SurnameBox.Text;
                command.ExecuteNonQuery();
            }
            connection.Close();
            Close();
        }

        private void EditAbiturientWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
