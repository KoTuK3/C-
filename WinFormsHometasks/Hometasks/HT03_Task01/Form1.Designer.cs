namespace L04_Task01
{
    partial class Form1
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
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.WorkersList = new System.Windows.Forms.ListBox();
            this.CityCB = new System.Windows.Forms.ComboBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.CityLabel = new System.Windows.Forms.Label();
            this.SalaryLabel = new System.Windows.Forms.Label();
            this.SalaryTextBox = new System.Windows.Forms.TextBox();
            this.PositionLabel = new System.Windows.Forms.Label();
            this.StreetLabel = new System.Windows.Forms.Label();
            this.PositionCB = new System.Windows.Forms.ComboBox();
            this.StreetCB = new System.Windows.Forms.ComboBox();
            this.AddBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(95, 53);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(121, 20);
            this.NameTextBox.TabIndex = 0;
            // 
            // WorkersList
            // 
            this.WorkersList.FormattingEnabled = true;
            this.WorkersList.Location = new System.Drawing.Point(247, 53);
            this.WorkersList.Name = "WorkersList";
            this.WorkersList.Size = new System.Drawing.Size(259, 186);
            this.WorkersList.TabIndex = 1;
            // 
            // CityCB
            // 
            this.CityCB.FormattingEnabled = true;
            this.CityCB.Location = new System.Drawing.Point(95, 140);
            this.CityCB.Name = "CityCB";
            this.CityCB.Size = new System.Drawing.Size(121, 21);
            this.CityCB.TabIndex = 2;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(25, 56);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(35, 13);
            this.NameLabel.TabIndex = 3;
            this.NameLabel.Text = "Name";
            // 
            // CityLabel
            // 
            this.CityLabel.AutoSize = true;
            this.CityLabel.Location = new System.Drawing.Point(25, 143);
            this.CityLabel.Name = "CityLabel";
            this.CityLabel.Size = new System.Drawing.Size(24, 13);
            this.CityLabel.TabIndex = 4;
            this.CityLabel.Text = "City";
            // 
            // SalaryLabel
            // 
            this.SalaryLabel.AutoSize = true;
            this.SalaryLabel.Location = new System.Drawing.Point(25, 84);
            this.SalaryLabel.Name = "SalaryLabel";
            this.SalaryLabel.Size = new System.Drawing.Size(36, 13);
            this.SalaryLabel.TabIndex = 5;
            this.SalaryLabel.Text = "Salary";
            // 
            // SalaryTextBox
            // 
            this.SalaryTextBox.Location = new System.Drawing.Point(95, 81);
            this.SalaryTextBox.Name = "SalaryTextBox";
            this.SalaryTextBox.Size = new System.Drawing.Size(121, 20);
            this.SalaryTextBox.TabIndex = 6;
            // 
            // PositionLabel
            // 
            this.PositionLabel.AutoSize = true;
            this.PositionLabel.Location = new System.Drawing.Point(25, 113);
            this.PositionLabel.Name = "PositionLabel";
            this.PositionLabel.Size = new System.Drawing.Size(44, 13);
            this.PositionLabel.TabIndex = 7;
            this.PositionLabel.Text = "Position";
            // 
            // StreetLabel
            // 
            this.StreetLabel.AutoSize = true;
            this.StreetLabel.Location = new System.Drawing.Point(25, 174);
            this.StreetLabel.Name = "StreetLabel";
            this.StreetLabel.Size = new System.Drawing.Size(35, 13);
            this.StreetLabel.TabIndex = 8;
            this.StreetLabel.Text = "Street";
            // 
            // PositionCB
            // 
            this.PositionCB.FormattingEnabled = true;
            this.PositionCB.Location = new System.Drawing.Point(95, 110);
            this.PositionCB.Name = "PositionCB";
            this.PositionCB.Size = new System.Drawing.Size(121, 21);
            this.PositionCB.TabIndex = 9;
            // 
            // StreetCB
            // 
            this.StreetCB.FormattingEnabled = true;
            this.StreetCB.Location = new System.Drawing.Point(95, 171);
            this.StreetCB.Name = "StreetCB";
            this.StreetCB.Size = new System.Drawing.Size(121, 21);
            this.StreetCB.TabIndex = 10;
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(28, 209);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(188, 35);
            this.AddBtn.TabIndex = 11;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(28, 250);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(188, 35);
            this.SaveBtn.TabIndex = 12;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 306);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.StreetCB);
            this.Controls.Add(this.PositionCB);
            this.Controls.Add(this.StreetLabel);
            this.Controls.Add(this.PositionLabel);
            this.Controls.Add(this.SalaryTextBox);
            this.Controls.Add(this.SalaryLabel);
            this.Controls.Add(this.CityLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.CityCB);
            this.Controls.Add(this.WorkersList);
            this.Controls.Add(this.NameTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.ListBox WorkersList;
        private System.Windows.Forms.ComboBox CityCB;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label CityLabel;
        private System.Windows.Forms.Label SalaryLabel;
        private System.Windows.Forms.TextBox SalaryTextBox;
        private System.Windows.Forms.Label PositionLabel;
        private System.Windows.Forms.Label StreetLabel;
        private System.Windows.Forms.ComboBox PositionCB;
        private System.Windows.Forms.ComboBox StreetCB;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button SaveBtn;
    }
}

