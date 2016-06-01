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
            this.AbiturientsRatingView = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.additional = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.AbiturientsRatingView)).BeginInit();
            this.SuspendLayout();
            // 
            // AbiturientsRatingView
            // 
            this.AbiturientsRatingView.AllowUserToAddRows = false;
            this.AbiturientsRatingView.AllowUserToDeleteRows = false;
            this.AbiturientsRatingView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.AbiturientsRatingView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.AbiturientsRatingView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.rating,
            this.exam,
            this.additional,
            this.sum});
            this.AbiturientsRatingView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AbiturientsRatingView.Location = new System.Drawing.Point(0, 0);
            this.AbiturientsRatingView.MultiSelect = false;
            this.AbiturientsRatingView.Name = "AbiturientsRatingView";
            this.AbiturientsRatingView.ReadOnly = true;
            this.AbiturientsRatingView.RowHeadersVisible = false;
            this.AbiturientsRatingView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.AbiturientsRatingView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AbiturientsRatingView.Size = new System.Drawing.Size(653, 322);
            this.AbiturientsRatingView.TabIndex = 0;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.id.Visible = false;
            // 
            // name
            // 
            this.name.HeaderText = "Ім\'я";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.name.Width = 250;
            // 
            // rating
            // 
            this.rating.HeaderText = "Рейтинг";
            this.rating.Name = "rating";
            this.rating.ReadOnly = true;
            this.rating.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // exam
            // 
            this.exam.HeaderText = "Екзамен";
            this.exam.Name = "exam";
            this.exam.ReadOnly = true;
            this.exam.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // additional
            // 
            this.additional.HeaderText = "Додаткові бали";
            this.additional.Name = "additional";
            this.additional.ReadOnly = true;
            this.additional.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // sum
            // 
            this.sum.HeaderText = "Сума";
            this.sum.Name = "sum";
            this.sum.ReadOnly = true;
            this.sum.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ShowRatingWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 322);
            this.Controls.Add(this.AbiturientsRatingView);
            this.Name = "ShowRatingWindow";
            this.Text = "ShowRatingWindow";
            this.Load += new System.EventHandler(this.ShowRatingWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AbiturientsRatingView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView AbiturientsRatingView;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn rating;
        private System.Windows.Forms.DataGridViewTextBoxColumn exam;
        private System.Windows.Forms.DataGridViewTextBoxColumn additional;
        private System.Windows.Forms.DataGridViewTextBoxColumn sum;
    }
}