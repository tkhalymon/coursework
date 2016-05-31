namespace cursova
{
    partial class AddAbiturientWindow
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
            this.StaticLastnameText = new System.Windows.Forms.TextBox();
            this.LastnameBox = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.SurnameBox = new System.Windows.Forms.TextBox();
            this.StaticNameText = new System.Windows.Forms.TextBox();
            this.StaticSurnameText = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StaticLastnameText
            // 
            this.StaticLastnameText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StaticLastnameText.Location = new System.Drawing.Point(12, 15);
            this.StaticLastnameText.Name = "StaticLastnameText";
            this.StaticLastnameText.ReadOnly = true;
            this.StaticLastnameText.Size = new System.Drawing.Size(71, 13);
            this.StaticLastnameText.TabIndex = 0;
            this.StaticLastnameText.TabStop = false;
            this.StaticLastnameText.Text = "Прізвище";
            // 
            // LastnameBox
            // 
            this.LastnameBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LastnameBox.Location = new System.Drawing.Point(89, 12);
            this.LastnameBox.Name = "LastnameBox";
            this.LastnameBox.Size = new System.Drawing.Size(187, 20);
            this.LastnameBox.TabIndex = 0;
            // 
            // NameBox
            // 
            this.NameBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameBox.Location = new System.Drawing.Point(89, 38);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(187, 20);
            this.NameBox.TabIndex = 1;
            // 
            // SurnameBox
            // 
            this.SurnameBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SurnameBox.Location = new System.Drawing.Point(89, 64);
            this.SurnameBox.Name = "SurnameBox";
            this.SurnameBox.Size = new System.Drawing.Size(187, 20);
            this.SurnameBox.TabIndex = 2;
            // 
            // StaticNameText
            // 
            this.StaticNameText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StaticNameText.Location = new System.Drawing.Point(12, 41);
            this.StaticNameText.Name = "StaticNameText";
            this.StaticNameText.ReadOnly = true;
            this.StaticNameText.Size = new System.Drawing.Size(71, 13);
            this.StaticNameText.TabIndex = 6;
            this.StaticNameText.TabStop = false;
            this.StaticNameText.Text = "Ім\'я";
            // 
            // StaticSurnameText
            // 
            this.StaticSurnameText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StaticSurnameText.Location = new System.Drawing.Point(12, 67);
            this.StaticSurnameText.Name = "StaticSurnameText";
            this.StaticSurnameText.ReadOnly = true;
            this.StaticSurnameText.Size = new System.Drawing.Size(71, 13);
            this.StaticSurnameText.TabIndex = 7;
            this.StaticSurnameText.TabStop = false;
            this.StaticSurnameText.Text = "По батькові";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(89, 90);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 3;
            this.AddButton.Text = "Додати";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // AddAbiturientWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 125);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.StaticSurnameText);
            this.Controls.Add(this.StaticNameText);
            this.Controls.Add(this.SurnameBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.LastnameBox);
            this.Controls.Add(this.StaticLastnameText);
            this.Name = "AddAbiturientWindow";
            this.Text = "AddAbiturientWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox StaticLastnameText;
        private System.Windows.Forms.TextBox LastnameBox;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox SurnameBox;
        private System.Windows.Forms.TextBox StaticNameText;
        private System.Windows.Forms.TextBox StaticSurnameText;
        private System.Windows.Forms.Button AddButton;
    }
}