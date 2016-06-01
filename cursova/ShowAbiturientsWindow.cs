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
    public partial class ShowAbiturientsWindow : Form
    {
        public ShowAbiturientsWindow()
        {
            InitializeComponent();
        }

        private void ShowAbitList_Load(object sender, EventArgs e)
        {
            var connectionString = @"data source=database.sqlite; Version=3;";
            SQLiteConnection connection = new SQLiteConnection(connectionString);
            connection = new SQLiteConnection(connectionString);
            connection.Open();
            //string query = @"ALTER TABLE abiturients
            //	ADD rating int not null DEFAULT 0,
            //	ADD exam int not null DEFAULT 0,
            //	ADD additional int not null DEFAULT 0
            //";
            string query = "SELECT * FROM abiturients";
            //string query = "INSERT INTO abiturients (name, surname, lastname) VALUES ('a', 'b', 'c')";
            SQLiteCommand command = new SQLiteCommand(query, connection);
            //command.ExecuteNonQuery();
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ShowAbitListView.Rows.Add(new object[]
                {
                    reader.GetValue(reader.GetOrdinal("id")),
                    reader.GetValue(reader.GetOrdinal("lastname")),
                    reader.GetValue(reader.GetOrdinal("name")),
                    reader.GetValue(reader.GetOrdinal("surname"))
                });
            }
            connection.Close();
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (ShowAbitListView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Немає записів для видалення", "Порожня таблиця", MessageBoxButtons.OK);
                return;
            }
            string dialogContent = "Ви дійсно хочете видалити абітурієнта \"";
            dialogContent += ShowAbitListView.CurrentRow.Cells["lastname"].Value + " ";
            dialogContent += ShowAbitListView.CurrentRow.Cells["name"].Value + " ";
            dialogContent += ShowAbitListView.CurrentRow.Cells["surname"].Value + "\"?";
            if (MessageBox.Show(dialogContent, "Видалення абітурієнта", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var connectionString = @"data source=database.sqlite; Version=3;";
                SQLiteConnection connection = new SQLiteConnection(connectionString);
                connection = new SQLiteConnection(connectionString);
                connection.Open();
                string query = "DELETE FROM abiturients WHERE id = " + ShowAbitListView.CurrentRow.Cells["id"].Value;
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.ExecuteNonQuery();
                connection.Close();
                ShowAbitListView.Rows.Remove(ShowAbitListView.CurrentRow);
                ShowAbitListView.Refresh();
                ShowAbitListView.Update();
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddAbiturientWindow addAbiturientWindow = new AddAbiturientWindow();
            addAbiturientWindow.ShowDialog();
            var connectionString = @"data source=database.sqlite; Version=3;";
            SQLiteConnection connection = new SQLiteConnection(connectionString);
            connection = new SQLiteConnection(connectionString);
            connection.Open();
            string query = "SELECT * FROM abiturients WHERE id = (SELECT MAX (id) FROM abiturients)";
            SQLiteCommand command = new SQLiteCommand(query, connection);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ShowAbitListView.Rows.Add(new object[]
                {
                    reader.GetValue(reader.GetOrdinal("id")),
                    reader.GetValue(reader.GetOrdinal("lastname")),
                    reader.GetValue(reader.GetOrdinal("name")),
                    reader.GetValue(reader.GetOrdinal("surname"))
                    
                });
            }
            ShowAbitListView.Refresh();
            ShowAbitListView.Update();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (ShowAbitListView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Немає записів для редагування", "Порожня таблиця", MessageBoxButtons.OK);
                return;
            }
            string id = ShowAbitListView.CurrentRow.Cells["id"].Value.ToString();
            string lastname= ShowAbitListView.CurrentRow.Cells["lastname"].Value.ToString();
            string name = ShowAbitListView.CurrentRow.Cells["name"].Value.ToString();
            string surname = ShowAbitListView.CurrentRow.Cells["surname"].Value.ToString();
            EditAbiturientWindow editAbiturientWindow = new EditAbiturientWindow(id, lastname, name, surname);
            editAbiturientWindow.ShowDialog();
            var connectionString = @"data source=database.sqlite; Version=3;";
            SQLiteConnection connection = new SQLiteConnection(connectionString);
            connection = new SQLiteConnection(connectionString);
            connection.Open();
            string query = "SELECT * FROM abiturients WHERE id = " + ShowAbitListView.CurrentRow.Cells["id"].Value.ToString();
            SQLiteCommand command = new SQLiteCommand(query, connection);
            SQLiteDataReader reader = command.ExecuteReader();
            reader.Read();
            ShowAbitListView.CurrentRow.Cells["lastname"].Value = reader.GetValue(reader.GetOrdinal("lastname"));
            ShowAbitListView.CurrentRow.Cells["name"].Value = reader.GetValue(reader.GetOrdinal("name"));
            ShowAbitListView.CurrentRow.Cells["surname"].Value = reader.GetValue(reader.GetOrdinal("surname"));
            connection.Close();
            ShowAbitListView.Refresh();
            ShowAbitListView.Update();
        }

        private void ShowAbitListView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
