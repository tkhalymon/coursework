namespace cursova
{
    partial class ShowRatingWindow
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
            this.StudentSummaryTab = new System.Windows.Forms.TabPage();
            this.ShowAdditionalTab = new System.Windows.Forms.TabPage();
            this.ShowAdditionalGrid = new System.Windows.Forms.DataGridView();
            this.addmark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addworkname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShowExamResultsTab = new System.Windows.Forms.TabPage();
            this.ShowExamMarksGrid = new System.Windows.Forms.DataGridView();
            this.exname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShowRatingTabControl = new System.Windows.Forms.TabPage();
            this.ShowRatingGrid = new System.Windows.Forms.DataGridView();
            this.ratename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rateid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShowSummaryTab = new System.Windows.Forms.TabPage();
            this.ShowRatingTab = new System.Windows.Forms.TabControl();
            this.ShowAdditionalTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShowAdditionalGrid)).BeginInit();
            this.ShowExamResultsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShowExamMarksGrid)).BeginInit();
            this.ShowRatingTabControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShowRatingGrid)).BeginInit();
            this.ShowRatingTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // StudentSummaryTab
            // 
            this.StudentSummaryTab.Location = new System.Drawing.Point(4, 22);
            this.StudentSummaryTab.Name = "StudentSummaryTab";
            this.StudentSummaryTab.Padding = new System.Windows.Forms.Padding(3);
            this.StudentSummaryTab.Size = new System.Drawing.Size(645, 296);
            this.StudentSummaryTab.TabIndex = 4;
            this.StudentSummaryTab.Text = "Інформація про студента";
            this.StudentSummaryTab.UseVisualStyleBackColor = true;
            // 
            // ShowAdditionalTab
            // 
            this.ShowAdditionalTab.Controls.Add(this.ShowAdditionalGrid);
            this.ShowAdditionalTab.Location = new System.Drawing.Point(4, 22);
            this.ShowAdditionalTab.Name = "ShowAdditionalTab";
            this.ShowAdditionalTab.Size = new System.Drawing.Size(645, 296);
            this.ShowAdditionalTab.TabIndex = 2;
            this.ShowAdditionalTab.Text = "Додаткова робота";
            this.ShowAdditionalTab.UseVisualStyleBackColor = true;
            // 
            // ShowAdditionalGrid
            // 
            this.ShowAdditionalGrid.AllowUserToAddRows = false;
            this.ShowAdditionalGrid.AllowUserToDeleteRows = false;
            this.ShowAdditionalGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ShowAdditionalGrid.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.ShowAdditionalGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ShowAdditionalGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ShowAdditionalGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.addid,
            this.addname,
            this.addworkname,
            this.addmark});
            this.ShowAdditionalGrid.Location = new System.Drawing.Point(0, 0);
            this.ShowAdditionalGrid.Name = "ShowAdditionalGrid";
            this.ShowAdditionalGrid.ReadOnly = true;
            this.ShowAdditionalGrid.RowHeadersVisible = false;
            this.ShowAdditionalGrid.Size = new System.Drawing.Size(645, 296);
            this.ShowAdditionalGrid.TabIndex = 4;
            // 
            // addmark
            // 
            this.addmark.HeaderText = "Оцінка";
            this.addmark.Name = "addmark";
            this.addmark.ReadOnly = true;
            // 
            // addworkname
            // 
            this.addworkname.HeaderText = "Робота";
            this.addworkname.Name = "addworkname";
            this.addworkname.ReadOnly = true;
            this.addworkname.Width = 342;
            // 
            // addname
            // 
            this.addname.HeaderText = "Ім\'я абітурієнта";
            this.addname.Name = "addname";
            this.addname.ReadOnly = true;
            this.addname.Width = 200;
            // 
            // addid
            // 
            this.addid.HeaderText = "id";
            this.addid.Name = "addid";
            this.addid.ReadOnly = true;
            this.addid.Visible = false;
            // 
            // ShowExamResultsTab
            // 
            this.ShowExamResultsTab.Controls.Add(this.ShowExamMarksGrid);
            this.ShowExamResultsTab.Location = new System.Drawing.Point(4, 22);
            this.ShowExamResultsTab.Name = "ShowExamResultsTab";
            this.ShowExamResultsTab.Padding = new System.Windows.Forms.Padding(3);
            this.ShowExamResultsTab.Size = new System.Drawing.Size(645, 296);
            this.ShowExamResultsTab.TabIndex = 1;
            this.ShowExamResultsTab.Text = "Результати іспитів";
            this.ShowExamResultsTab.UseVisualStyleBackColor = true;
            this.ShowExamResultsTab.Click += new System.EventHandler(this.ShowExamResultsTab_Click);
            // 
            // ShowExamMarksGrid
            // 
            this.ShowExamMarksGrid.AllowUserToAddRows = false;
            this.ShowExamMarksGrid.AllowUserToDeleteRows = false;
            this.ShowExamMarksGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ShowExamMarksGrid.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.ShowExamMarksGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ShowExamMarksGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ShowExamMarksGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.exid,
            this.exname});
            this.ShowExamMarksGrid.Location = new System.Drawing.Point(0, 0);
            this.ShowExamMarksGrid.Name = "ShowExamMarksGrid";
            this.ShowExamMarksGrid.ReadOnly = true;
            this.ShowExamMarksGrid.RowHeadersVisible = false;
            this.ShowExamMarksGrid.Size = new System.Drawing.Size(645, 296);
            this.ShowExamMarksGrid.TabIndex = 3;
            // 
            // exname
            // 
            this.exname.HeaderText = "Ім\'я абітурієнта";
            this.exname.Name = "exname";
            this.exname.ReadOnly = true;
            this.exname.Width = 200;
            // 
            // exid
            // 
            this.exid.HeaderText = "id";
            this.exid.Name = "exid";
            this.exid.ReadOnly = true;
            this.exid.Visible = false;
            // 
            // ShowRatingTabControl
            // 
            this.ShowRatingTabControl.Controls.Add(this.ShowRatingGrid);
            this.ShowRatingTabControl.Location = new System.Drawing.Point(4, 22);
            this.ShowRatingTabControl.Name = "ShowRatingTabControl";
            this.ShowRatingTabControl.Padding = new System.Windows.Forms.Padding(3);
            this.ShowRatingTabControl.Size = new System.Drawing.Size(645, 296);
            this.ShowRatingTabControl.TabIndex = 0;
            this.ShowRatingTabControl.Text = "Рейтинг абітурієнтів";
            this.ShowRatingTabControl.UseVisualStyleBackColor = true;
            this.ShowRatingTabControl.Click += new System.EventHandler(this.ShowRatingTabControl_Click);
            // 
            // ShowRatingGrid
            // 
            this.ShowRatingGrid.AllowUserToAddRows = false;
            this.ShowRatingGrid.AllowUserToDeleteRows = false;
            this.ShowRatingGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ShowRatingGrid.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.ShowRatingGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ShowRatingGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ShowRatingGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rateid,
            this.ratename});
            this.ShowRatingGrid.Location = new System.Drawing.Point(0, 0);
            this.ShowRatingGrid.Name = "ShowRatingGrid";
            this.ShowRatingGrid.ReadOnly = true;
            this.ShowRatingGrid.RowHeadersVisible = false;
            this.ShowRatingGrid.Size = new System.Drawing.Size(645, 296);
            this.ShowRatingGrid.TabIndex = 0;
            // 
            // ratename
            // 
            this.ratename.HeaderText = "Ім\'я абітурієнта";
            this.ratename.Name = "ratename";
            this.ratename.ReadOnly = true;
            this.ratename.Width = 200;
            // 
            // rateid
            // 
            this.rateid.HeaderText = "id";
            this.rateid.Name = "rateid";
            this.rateid.ReadOnly = true;
            this.rateid.Visible = false;
            // 
            // ShowSummaryTab
            // 
            this.ShowSummaryTab.Location = new System.Drawing.Point(4, 22);
            this.ShowSummaryTab.Name = "ShowSummaryTab";
            this.ShowSummaryTab.Size = new System.Drawing.Size(645, 296);
            this.ShowSummaryTab.TabIndex = 3;
            this.ShowSummaryTab.Text = "Підсумковий рейтинг";
            this.ShowSummaryTab.UseVisualStyleBackColor = true;
            // 
            // ShowRatingTab
            // 
            this.ShowRatingTab.Controls.Add(this.ShowSummaryTab);
            this.ShowRatingTab.Controls.Add(this.ShowRatingTabControl);
            this.ShowRatingTab.Controls.Add(this.ShowExamResultsTab);
            this.ShowRatingTab.Controls.Add(this.ShowAdditionalTab);
            this.ShowRatingTab.Controls.Add(this.StudentSummaryTab);
            this.ShowRatingTab.Location = new System.Drawing.Point(0, 0);
            this.ShowRatingTab.Name = "ShowRatingTab";
            this.ShowRatingTab.SelectedIndex = 0;
            this.ShowRatingTab.Size = new System.Drawing.Size(653, 322);
            this.ShowRatingTab.TabIndex = 0;
            // 
            // ShowRatingWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 322);
            this.Controls.Add(this.ShowRatingTab);
            this.Name = "ShowRatingWindow";
            this.Text = "ShowRatingWindow";
            this.Load += new System.EventHandler(this.ShowRatingWindow_Load);
            this.ShowAdditionalTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ShowAdditionalGrid)).EndInit();
            this.ShowExamResultsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ShowExamMarksGrid)).EndInit();
            this.ShowRatingTabControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ShowRatingGrid)).EndInit();
            this.ShowRatingTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage StudentSummaryTab;
        private System.Windows.Forms.TabPage ShowAdditionalTab;
        private System.Windows.Forms.DataGridView ShowAdditionalGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn addid;
        private System.Windows.Forms.DataGridViewTextBoxColumn addname;
        private System.Windows.Forms.DataGridViewTextBoxColumn addworkname;
        private System.Windows.Forms.DataGridViewTextBoxColumn addmark;
        private System.Windows.Forms.TabPage ShowExamResultsTab;
        private System.Windows.Forms.DataGridView ShowExamMarksGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn exid;
        private System.Windows.Forms.DataGridViewTextBoxColumn exname;
        private System.Windows.Forms.TabPage ShowRatingTabControl;
        private System.Windows.Forms.DataGridView ShowRatingGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn rateid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ratename;
        private System.Windows.Forms.TabPage ShowSummaryTab;
        private System.Windows.Forms.TabControl ShowRatingTab;


    }
}