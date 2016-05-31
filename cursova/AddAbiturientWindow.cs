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
    public partial class AddAbiturientWindow : Form
    {
        public AddAbiturientWindow()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var connectionString = @"data source=database.sqlite; Version=3;";
            SQLiteConnection connection = new SQLiteConnection(connectionString);
            connection = new SQLiteConnection(connectionString);
            connection.Open();
            string query = "INSERT INTO abiturients (name, surname, lastname) VALUES ('"
                + LastnameBox.Text + "', '" + NameBox.Text + "', '" + SurnameBox.Text + "')";
            SQLiteCommand command = new SQLiteCommand(query, connection);
            command.ExecuteNonQuery();
            connection.Close();
            Close();
        }
    }
}
