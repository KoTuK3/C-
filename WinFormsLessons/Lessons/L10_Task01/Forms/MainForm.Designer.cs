namespace L10_Task01
{
    partial class MainForm
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
            this.AdminBtn = new System.Windows.Forms.Button();
            this.TableBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AdminBtn
            // 
            this.AdminBtn.Location = new System.Drawing.Point(15, 23);
            this.AdminBtn.Margin = new System.Windows.Forms.Padding(6);
            this.AdminBtn.Name = "AdminBtn";
            this.AdminBtn.Size = new System.Drawing.Size(294, 140);
            this.AdminBtn.TabIndex = 0;
            this.AdminBtn.Text = "Admin";
            this.AdminBtn.UseVisualStyleBackColor = true;
            this.AdminBtn.Click += new System.EventHandler(this.AdminBtn_Click);
            // 
            // TableBtn
            // 
            this.TableBtn.Location = new System.Drawing.Point(333, 23);
            this.TableBtn.Margin = new System.Windows.Forms.Padding(6);
            this.TableBtn.Name = "TableBtn";
            this.TableBtn.Size = new System.Drawing.Size(294, 140);
            this.TableBtn.TabIndex = 1;
            this.TableBtn.Text = "Table";
            this.TableBtn.UseVisualStyleBackColor = true;
            this.TableBtn.Click += new System.EventHandler(this.TableBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 188);
            this.Controls.Add(this.TableBtn);
            this.Controls.Add(this.AdminBtn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MainForm";
            this.Text = "Schedule";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AdminBtn;
        private System.Windows.Forms.Button TableBtn;
    }
}

