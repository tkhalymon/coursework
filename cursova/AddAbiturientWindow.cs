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
            string query = @"INSERT INTO abiturients (lastname, name, surname, rating, exam, additional) VALUES
            (@lastname, @name, @surname, @rating, @exam, @additional)";
            SQLiteCommand command = new SQLiteCommand(query, connection);
            command.Parameters.Add(new SQLiteParameter("@lastname", LastnameBox.Text));
            command.Parameters.Add(new SQLiteParameter("@name", NameBox.Text));
            command.Parameters.Add(new SQLiteParameter("@surname", SurnameBox.Text));
            Random r = new Random();
            command.Parameters.Add(new SQLiteParameter("@rating", r.Next(20) + 40));
            command.Parameters.Add(new SQLiteParameter("@exam", r.Next(20) + 10));
            command.Parameters.Add(new SQLiteParameter("@additional", r.Next(10)));
            
            command.ExecuteNonQuery();
            connection.Close();
            Close();
        }
    }
}
