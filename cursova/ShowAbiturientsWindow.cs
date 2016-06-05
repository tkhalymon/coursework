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
            var connectionString = @"data source=database.sqlite3; Version=3;";
            SQLiteConnection connection = new SQLiteConnection(connectionString);
            connection = new SQLiteConnection(connectionString);
            connection.Open();
            string query = "SELECT * FROM abiturients";
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
                var connectionString = @"data source=database.sqlite3; Version=3;";
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
            EditAbiturientWindow editAbiturientWindow = new EditAbiturientWindow(ShowAbitListView, true);
            editAbiturientWindow.ShowDialog();
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
            EditAbiturientWindow editAbiturientWindow = new EditAbiturientWindow(ShowAbitListView, false);
            editAbiturientWindow.ShowDialog();
            ShowAbitListView.Refresh();
            ShowAbitListView.Update();
        }

        private void ShowAbitListView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
