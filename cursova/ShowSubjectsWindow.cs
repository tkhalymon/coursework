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
    public partial class ShowSubjectsWindow : Form
    {
        bool edit = false;
        public ShowSubjectsWindow()
        {
            InitializeComponent();
        }

        private void ShowSubjectsWindow_Load(object sender, EventArgs e)
        {
            var connectionString = @"data source=database.sqlite3; Version=3;";
            SQLiteConnection connection = new SQLiteConnection(connectionString);
            connection = new SQLiteConnection(connectionString);
            connection.Open();
            string query = "SELECT * FROM subjects";
            SQLiteCommand command = new SQLiteCommand(query, connection);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                SubjectsGrig.Rows.Add(new object[]
                {
                    reader.GetValue(reader.GetOrdinal("subj_id")),
                    reader.GetValue(reader.GetOrdinal("subj_name"))
                });
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(SubjectNameBox.Text))
            {
                MessageBox.Show("Введіть назву предмета", "", MessageBoxButtons.OK);
                SubjectNameBox.Focus();
            }
            else
            {
                var connectionString = @"data source=database.sqlite3; Version=3;";
                SQLiteConnection connection = new SQLiteConnection(connectionString);
                connection = new SQLiteConnection(connectionString);
                connection.Open();
                if (edit)
                {
                    string query = "UPDATE subjects SET subj_name = @subj_name WHERE subj_id = " + SubjectsGrig.CurrentRow.Cells["subj_id"].Value;
                    SQLiteCommand command = new SQLiteCommand(query, connection);
                    command.Parameters.Add(new SQLiteParameter("@subj_name", SubjectNameBox.Text));
                    SubjectsGrig.CurrentRow.Cells["subj_name"].Value = SubjectNameBox.Text;
                    SubjectNameBox.Text = "";
                    AddButton.Text = "Додати";
                    RemoveButton.Text = "Видалити";
                    command.ExecuteNonQuery();
                    SubjectsGrig.Refresh();
                    SubjectsGrig.Update();
                    edit = false;
                }
                else
                {
                    string query = @"INSERT INTO subjects (subj_name)
                    VALUES (@subj_name); SELECT MAX(subj_id) FROM subjects";
                    SQLiteCommand command = new SQLiteCommand(query, connection);
                    command.Parameters.Add(new SQLiteParameter("@subj_name", SubjectNameBox.Text));
                    string id_str = command.ExecuteScalar().ToString();
                    SubjectsGrig.Rows.Add(new object[]
                    {
                        id_str,
                        SubjectNameBox.Text
                    });
                    SubjectsGrig.Refresh();
                    SubjectsGrig.Update();
                    SubjectNameBox.Text = "";
                }
                connection.Close();
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            SubjectNameBox.Text = SubjectsGrig.CurrentRow.Cells["subj_name"].Value.ToString();
            AddButton.Text = "Зберегти";
            RemoveButton.Text = "Відмінити";
            edit = true;
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (edit)
            {
                SubjectNameBox.Text = "";
                AddButton.Text = "Додати";
                RemoveButton.Text = "Видалити";
                edit = false;
            }
            else
            {
                if (SubjectsGrig.Rows.Count > 0)
                {
                    var connectionString = @"data source=database.sqlite3; Version=3;";
                    SQLiteConnection connection = new SQLiteConnection(connectionString);
                    connection = new SQLiteConnection(connectionString);
                    connection.Open();
                    string query = @"DELETE FROM subjects WHERE subj_id = " + SubjectsGrig.CurrentRow.Cells["subj_id"].Value.ToString();
                    SQLiteCommand command = new SQLiteCommand(query, connection);
                    command.ExecuteNonQuery();
                    SubjectsGrig.Rows.Remove(SubjectsGrig.CurrentRow);
                    SubjectsGrig.Refresh();
                    SubjectsGrig.Update();
                    connection.Close();
                }
            }
        }
    }
}
