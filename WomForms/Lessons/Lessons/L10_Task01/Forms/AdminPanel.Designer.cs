namespace L10_Task01.Forms
{
    partial class AdminPanel
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
            this.label1 = new System.Windows.Forms.Label();
            this.ArrivalTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DepartureTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AddBtn = new System.Windows.Forms.Button();
            this.ScheduleTable = new System.Windows.Forms.DataGridView();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArrivalTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepartureTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteRun = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ScheduleTable)).BeginInit();
            this.SuspendLayout();
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(196, 51);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(255, 31);
            this.NameTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // ArrivalTimePicker
            // 
            this.ArrivalTimePicker.Location = new System.Drawing.Point(196, 108);
            this.ArrivalTimePicker.Name = "ArrivalTimePicker";
            this.ArrivalTimePicker.Size = new System.Drawing.Size(255, 31);
            this.ArrivalTimePicker.TabIndex = 2;
            // 
            // DepartureTimePicker
            // 
            this.DepartureTimePicker.Location = new System.Drawing.Point(196, 164);
            this.DepartureTimePicker.Name = "DepartureTimePicker";
            this.DepartureTimePicker.Size = new System.Drawing.Size(255, 31);
            this.DepartureTimePicker.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 113);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Arrival time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 169);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Departure time";
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(196, 222);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(255, 46);
            this.AddBtn.TabIndex = 6;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // ScheduleTable
            // 
            this.ScheduleTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ScheduleTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.ArrivalTime,
            this.DepartureTime,
            this.DeleteRun});
            this.ScheduleTable.Location = new System.Drawing.Point(491, 51);
            this.ScheduleTable.Name = "ScheduleTable";
            this.ScheduleTable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ScheduleTable.Size = new System.Drawing.Size(645, 319);
            this.ScheduleTable.TabIndex = 7;
            this.ScheduleTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ScheduleTable_CellContentClick);
            // 
            // Name
            // 
            this.Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Name.HeaderText = "Name";
            this.Name.Name = "Name";
            this.Name.Width = 93;
            // 
            // ArrivalTime
            // 
            this.ArrivalTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ArrivalTime.HeaderText = "Arrival time";
            this.ArrivalTime.Name = "ArrivalTime";
            this.ArrivalTime.Width = 144;
            // 
            // DepartureTime
            // 
            this.DepartureTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DepartureTime.HeaderText = "Departure time";
            this.DepartureTime.Name = "DepartureTime";
            this.DepartureTime.Width = 162;
            // 
            // DeleteRun
            // 
            this.DeleteRun.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.DeleteRun.HeaderText = "Delete";
            this.DeleteRun.Name = "DeleteRun";
            this.DeleteRun.Width = 80;
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 397);
            this.Controls.Add(this.ScheduleTable);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DepartureTimePicker);
            this.Controls.Add(this.ArrivalTimePicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameTextBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Text = "AdminPanel";
            ((System.ComponentModel.ISupportInitialize)(this.ScheduleTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker ArrivalTimePicker;
        private System.Windows.Forms.DateTimePicker DepartureTimePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.DataGridView ScheduleTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArrivalTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepartureTime;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteRun;
    }
}