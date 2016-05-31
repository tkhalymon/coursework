namespace cursova
{
    partial class ShowAbiturientsWindow
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
            this.ShowAbitListView = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.FindButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ShowAbitListView)).BeginInit();
            this.SuspendLayout();
            // 
            // ShowAbitListView
            // 
            this.ShowAbitListView.AllowUserToAddRows = false;
            this.ShowAbitListView.AllowUserToDeleteRows = false;
            this.ShowAbitListView.AllowUserToResizeRows = false;
            this.ShowAbitListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ShowAbitListView.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.ShowAbitListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ShowAbitListView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ShowAbitListView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.lastname,
            this.name,
            this.surname});
            this.ShowAbitListView.EnableHeadersVisualStyles = false;
            this.ShowAbitListView.Location = new System.Drawing.Point(12, 12);
            this.ShowAbitListView.MultiSelect = false;
            this.ShowAbitListView.Name = "ShowAbitListView";
            this.ShowAbitListView.ReadOnly = true;
            this.ShowAbitListView.RowHeadersVisible = false;
            this.ShowAbitListView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ShowAbitListView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ShowAbitListView.Size = new System.Drawing.Size(317, 158);
            this.ShowAbitListView.TabIndex = 0;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // lastname
            // 
            this.lastname.HeaderText = "Прізвище";
            this.lastname.Name = "lastname";
            this.lastname.ReadOnly = true;
            // 
            // name
            // 
            this.name.HeaderText = "Ім\'я";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // surname
            // 
            this.surname.HeaderText = "По батькові";
            this.surname.Name = "surname";
            this.surname.ReadOnly = true;
            // 
            // AddButton
            // 
            this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddButton.Location = new System.Drawing.Point(335, 12);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(85, 35);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "Додати";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EditButton.Location = new System.Drawing.Point(335, 53);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(85, 35);
            this.EditButton.TabIndex = 2;
            this.EditButton.Text = "Редагувати";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoveButton.Location = new System.Drawing.Point(335, 94);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(85, 35);
            this.RemoveButton.TabIndex = 3;
            this.RemoveButton.Text = "Видалити";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // FindButton
            // 
            this.FindButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FindButton.Location = new System.Drawing.Point(335, 135);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(85, 35);
            this.FindButton.TabIndex = 4;
            this.FindButton.Text = "Знайти";
            this.FindButton.UseVisualStyleBackColor = true;
            // 
            // ShowAbiturientsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 182);
            this.Controls.Add(this.FindButton);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.ShowAbitListView);
            this.MinimumSize = new System.Drawing.Size(445, 216);
            this.Name = "ShowAbiturientsWindow";
            this.Text = "ShowAbitList";
            this.Load += new System.EventHandler(this.ShowAbitList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ShowAbitListView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ShowAbitListView;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button FindButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn surname;
    }
}