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
        string id;
        public EditAbiturientWindow(string id, string lastname, string name, string surname)
        {
            InitializeComponent();
            this.id = id;
            LastnameBox.Text = lastname; 
            NameBox.Text = name;
            SurnameBox.Text = surname;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var connectionString = @"data source=database.sqlite; Version=3;";
            SQLiteConnection connection = new SQLiteConnection(connectionString);
            connection = new SQLiteConnection(connectionString);
            connection.Open();
            string query = "UPDATE abiturients SET lastname = @lastname, name = @name, surname = @surname WHERE id = " + id;
            SQLiteCommand command = new SQLiteCommand(query, connection);
            command.Parameters.Add(new SQLiteParameter("@lastname", LastnameBox.Text));
            command.Parameters.Add(new SQLiteParameter("@name", NameBox.Text));
            command.Parameters.Add(new SQLiteParameter("@surname", SurnameBox.Text));
            command.ExecuteNonQuery();
            connection.Close();
            Close();
        }

        private void EditAbiturientWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
