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

        struct Subject
        {
            public Subject(int id, string name)
            {
                subj_id = id;
                subj_name = name;
            }
            public int subj_id;
            public string subj_name;
        }

        private void ShowRatingWindow_Load(object sender, EventArgs e)
        {
            // load rating
            var connectionString = @"data source=database.sqlite3; Version=3;";
            SQLiteConnection connection = new SQLiteConnection(connectionString);
            connection = new SQLiteConnection(connectionString);
            connection.Open();
            string query = "SELECT * FROM subjects";
            SQLiteCommand command = new SQLiteCommand(query, connection);
            SQLiteDataReader reader = command.ExecuteReader();
            List<Subject> subjects = new List<Subject>();
            while (reader.Read())
            {
                int subj_id;
                int.TryParse(reader.GetValue(reader.GetOrdinal("subj_id")).ToString(), out subj_id);
                subjects.Add(new Subject(subj_id, reader.GetValue(reader.GetOrdinal("subj_name")).ToString()));
                ShowRatingGrid.Columns.Add(subj_id.ToString(), subjects.Last().subj_name);
            }
            query = "SELECT * FROM abiturients";
            command = new SQLiteCommand(query, connection);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                ShowRatingGrid.Rows.Add();
                ShowRatingGrid.Rows[ShowRatingGrid.Rows.Count - 1].Cells["rateid"].Value =
                    reader.GetValue(reader.GetOrdinal("id"));
                ShowRatingGrid.Rows[ShowRatingGrid.Rows.Count - 1].Cells["ratename"].Value =
                    reader.GetValue(reader.GetOrdinal("lastname")) + " " + reader.GetValue(reader.GetOrdinal("name"));
                query = "SELECT * FROM rating WHERE id = " + reader.GetValue(reader.GetOrdinal("id")).ToString();
                command = new SQLiteCommand(query, connection);
                SQLiteDataReader markReader = command.ExecuteReader();
                while (markReader.Read())
                {
                    ShowRatingGrid.Rows[ShowRatingGrid.Rows.Count - 1].Cells[markReader.GetValue(markReader.GetOrdinal("subj_id")).ToString()].Value =
                    markReader.GetValue(markReader.GetOrdinal("mark")).ToString();
                }
            }
            ShowRatingGrid.Refresh();
            ShowRatingGrid.Update();
            connection.Close();

            // load exam marks

            connectionString = @"data source=database.sqlite3; Version=3;";
            connection = new SQLiteConnection(connectionString);
            connection = new SQLiteConnection(connectionString);
            connection.Open();
            query = "SELECT * FROM exams";
            command = new SQLiteCommand(query, connection);
            reader = command.ExecuteReader();
            List<Subject> exams = new List<Subject>();
            while (reader.Read())
            {
                int exam_id;
                int.TryParse(reader.GetValue(reader.GetOrdinal("exam_id")).ToString(), out exam_id);
                exams.Add(new Subject(exam_id, reader.GetValue(reader.GetOrdinal("exam_name")).ToString()));
                ShowExamMarksGrid.Columns.Add(exam_id.ToString(), exams.Last().subj_name);
            }
            query = "SELECT * FROM abiturients";
            command = new SQLiteCommand(query, connection);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                ShowExamMarksGrid.Rows.Add();
                ShowExamMarksGrid.Rows[ShowExamMarksGrid.Rows.Count - 1].Cells["exid"].Value =
                    reader.GetValue(reader.GetOrdinal("id"));
                ShowExamMarksGrid.Rows[ShowExamMarksGrid.Rows.Count - 1].Cells["exname"].Value =
                    reader.GetValue(reader.GetOrdinal("lastname")) + " " + reader.GetValue(reader.GetOrdinal("name"));
                query = "SELECT * FROM exam_marks WHERE id = " + reader.GetValue(reader.GetOrdinal("id")).ToString();
                command = new SQLiteCommand(query, connection);
                SQLiteDataReader markReader = command.ExecuteReader();
                while (markReader.Read())
                {
                    ShowExamMarksGrid.Rows[ShowExamMarksGrid.Rows.Count - 1].Cells[markReader.GetValue(markReader.GetOrdinal("subj_id")).ToString()].Value =
                    markReader.GetValue(markReader.GetOrdinal("mark")).ToString();
                }
            }
            ShowExamMarksGrid.Refresh();
            ShowExamMarksGrid.Update();
            connection.Close();

            // load additional work

            connectionString = @"data source=database.sqlite3; Version=3;";
            connection = new SQLiteConnection(connectionString);
            connection = new SQLiteConnection(connectionString);
            connection.Open();
            query = "SELECT * FROM abiturients";
            command = new SQLiteCommand(query, connection);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                query = "SELECT * FROM additional_work WHERE id = " + reader.GetValue(reader.GetOrdinal("id")).ToString();
                command = new SQLiteCommand(query, connection);
                SQLiteDataReader addReader = command.ExecuteReader();
                while (addReader.Read())
                {
                    //MessageBox.Show(addReader.GetValue(reader.GetOrdinal("mark")).ToString());
                    ShowAdditionalGrid.Rows.Add();
                    ShowAdditionalGrid.Rows[ShowAdditionalGrid.Rows.Count - 1].Cells["addid"].Value =
                        reader.GetValue(reader.GetOrdinal("id"));
                    ShowAdditionalGrid.Rows[ShowAdditionalGrid.Rows.Count - 1].Cells["addname"].Value =
                        reader.GetValue(reader.GetOrdinal("lastname")) + " " + reader.GetValue(reader.GetOrdinal("name"));
                    ShowAdditionalGrid.Rows[ShowAdditionalGrid.Rows.Count - 1].Cells["addworkname"].Value =
                                            addReader.GetValue(addReader.GetOrdinal("work_name"));
                    ShowAdditionalGrid.Rows[ShowAdditionalGrid.Rows.Count - 1].Cells["addmark"].Value =
                                            addReader.GetValue(addReader.GetOrdinal("mark"));
                }
            }
            ShowAdditionalGrid.Refresh();
            ShowAdditionalGrid.Update();
            connection.Close();
        }

        private void ShowRatingTabControl_Click(object sender, EventArgs e)
        {

        }

        private void ShowExamResultsTab_Click(object sender, EventArgs e)
        {
            
        }
    }
}
