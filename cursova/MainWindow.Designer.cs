namespace cursova
{
    partial class MainWindow
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
            this.ShowAbitListButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.ShowRatingButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ShowAbitListButton
            // 
            this.ShowAbitListButton.Location = new System.Drawing.Point(12, 12);
            this.ShowAbitListButton.Name = "ShowAbitListButton";
            this.ShowAbitListButton.Size = new System.Drawing.Size(200, 40);
            this.ShowAbitListButton.TabIndex = 0;
            this.ShowAbitListButton.Text = "Показати список абітурієнтів";
            this.ShowAbitListButton.UseVisualStyleBackColor = true;
            this.ShowAbitListButton.Click += new System.EventHandler(this.ShowAbitListButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(12, 214);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(200, 40);
            this.ExitButton.TabIndex = 1;
            this.ExitButton.Text = "Вийти";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ShowRatingButton
            // 
            this.ShowRatingButton.Location = new System.Drawing.Point(12, 58);
            this.ShowRatingButton.Name = "ShowRatingButton";
            this.ShowRatingButton.Size = new System.Drawing.Size(200, 40);
            this.ShowRatingButton.TabIndex = 2;
            this.ShowRatingButton.Text = "Показати рейтинг абітурієнтів";
            this.ShowRatingButton.UseVisualStyleBackColor = true;
            this.ShowRatingButton.Click += new System.EventHandler(this.ShowRatingButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 266);
            this.Controls.Add(this.ShowRatingButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ShowAbitListButton);
            this.Name = "MainWindow";
            this.Text = "Головне меню";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ShowAbitListButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button ShowRatingButton;
    }
}

