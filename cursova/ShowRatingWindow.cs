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
    public partial class ShowRatingWindow : Form
    {
        public ShowRatingWindow()
        {
            InitializeComponent();
        }

        private void ShowRatingWindow_Load(object sender, EventArgs e)
        {
            var connectionString = @"data source=database.sqlite; Version=3;";
            SQLiteConnection connection = new SQLiteConnection(connectionString);
            connection = new SQLiteConnection(connectionString);
            connection.Open();
            string query = "SELECT * FROM abiturients";
            SQLiteCommand command = new SQLiteCommand(query, connection);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                AbiturientsRatingView.Rows.Add(new object[]
                {
                    reader.GetValue(reader.GetOrdinal("id")),
                    reader.GetValue(reader.GetOrdinal("lastname")).ToString() + " " +
                    reader.GetValue(reader.GetOrdinal("name")).ToString() + " " +
                    reader.GetValue(reader.GetOrdinal("surname")).ToString(),
                    reader.GetValue(reader.GetOrdinal("rating")),
                    reader.GetValue(reader.GetOrdinal("exam")),
                    reader.GetValue(reader.GetOrdinal("additional")),
                    (int)reader.GetValue(reader.GetOrdinal("rating")) + (int)reader.GetValue(reader.GetOrdinal("exam")) + (int)reader.GetValue(reader.GetOrdinal("additional")),
                });
            }
            connection.Close();
            AbiturientsRatingView.Refresh();
            AbiturientsRatingView.Update();
        }
    }
}
