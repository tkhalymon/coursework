﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cursova
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ShowAbitListButton_Click(object sender, EventArgs e)
        {
            ShowAbiturientsWindow showAbitList = new ShowAbiturientsWindow();
            showAbitList.ShowDialog();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            //if (MessageBox.Show("Ви дійсно хочете вийти з програми?", "Вихід", MessageBoxButtons.OKCancel) == DialogResult.OK)
            //{
                Close();
            //}
        }

        private void ShowRatingButton_Click(object sender, EventArgs e)
        {
            ShowRatingWindow showRatingWindow = new ShowRatingWindow();
            showRatingWindow.ShowDialog();
        }
    }
}
