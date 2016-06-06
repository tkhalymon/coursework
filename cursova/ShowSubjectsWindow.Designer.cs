namespace cursova
{
    partial class ShowSubjectsWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SubjectsGrig = new System.Windows.Forms.DataGridView();
            this.subj_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subj_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.SubjectNameBox = new System.Windows.Forms.TextBox();
            this.SubjectNameStatic = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.SubjectsGrig)).BeginInit();
            this.SuspendLayout();
            // 
            // SubjectsGrig
            // 
            this.SubjectsGrig.AllowUserToAddRows = false;
            this.SubjectsGrig.AllowUserToDeleteRows = false;
            this.SubjectsGrig.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SubjectsGrig.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.SubjectsGrig.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SubjectsGrig.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.SubjectsGrig.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SubjectsGrig.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.subj_id,
            this.subj_name});
            this.SubjectsGrig.Location = new System.Drawing.Point(12, 12);
            this.SubjectsGrig.Name = "SubjectsGrig";
            this.SubjectsGrig.ReadOnly = true;
            this.SubjectsGrig.RowHeadersVisible = false;
            this.SubjectsGrig.Size = new System.Drawing.Size(315, 202);
            this.SubjectsGrig.TabIndex = 0;
            // 
            // subj_id
            // 
            this.subj_id.HeaderText = "subj_id";
            this.subj_id.Name = "subj_id";
            this.subj_id.ReadOnly = true;
            this.subj_id.Visible = false;
            // 
            // subj_name
            // 
            this.subj_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.subj_name.HeaderText = "Назва предмета";
            this.subj_name.Name = "subj_name";
            this.subj_name.ReadOnly = true;
            // 
            // AddButton
            // 
            this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddButton.Location = new System.Drawing.Point(12, 246);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(101, 23);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "Додати";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EditButton.Location = new System.Drawing.Point(119, 246);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(101, 23);
            this.EditButton.TabIndex = 2;
            this.EditButton.Text = "Змінити";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RemoveButton.Location = new System.Drawing.Point(226, 246);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(101, 23);
            this.RemoveButton.TabIndex = 3;
            this.RemoveButton.Text = "Видалити";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // SubjectNameBox
            // 
            this.SubjectNameBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SubjectNameBox.Location = new System.Drawing.Point(119, 220);
            this.SubjectNameBox.Name = "SubjectNameBox";
            this.SubjectNameBox.Size = new System.Drawing.Size(208, 20);
            this.SubjectNameBox.TabIndex = 4;
            // 
            // SubjectNameStatic
            // 
            this.SubjectNameStatic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SubjectNameStatic.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SubjectNameStatic.Location = new System.Drawing.Point(12, 223);
            this.SubjectNameStatic.Name = "SubjectNameStatic";
            this.SubjectNameStatic.ReadOnly = true;
            this.SubjectNameStatic.Size = new System.Drawing.Size(101, 13);
            this.SubjectNameStatic.TabIndex = 5;
            this.SubjectNameStatic.TabStop = false;
            this.SubjectNameStatic.Text = "Назва предмету";
            // 
            // ShowSubjectsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 281);
            this.Controls.Add(this.SubjectNameStatic);
            this.Controls.Add(this.SubjectNameBox);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.SubjectsGrig);
            this.MinimumSize = new System.Drawing.Size(351, 150);
            this.Name = "ShowSubjectsWindow";
            this.Text = "ShowSubjectsWindow";
            this.Load += new System.EventHandler(this.ShowSubjectsWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SubjectsGrig)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView SubjectsGrig;
        private System.Windows.Forms.DataGridViewTextBoxColumn subj_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn subj_name;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.TextBox SubjectNameBox;
        private System.Windows.Forms.TextBox SubjectNameStatic;
    }
}