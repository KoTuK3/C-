namespace L05_Task01
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Tabs = new System.Windows.Forms.TabControl();
            this.HomePage = new System.Windows.Forms.TabPage();
            this.AboutMeTextBox = new System.Windows.Forms.TextBox();
            this.Picture = new System.Windows.Forms.PictureBox();
            this.AbouteMePage = new System.Windows.Forms.TabPage();
            this.ContactPage = new System.Windows.Forms.TabPage();
            this.ContactPhoneBox = new System.Windows.Forms.TextBox();
            this.ContactEmailBox = new System.Windows.Forms.TextBox();
            this.ContactPhonelLabel = new System.Windows.Forms.Label();
            this.ContactEmailLabel = new System.Windows.Forms.Label();
            this.SettingPage = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.HeaderBGLabel = new System.Windows.Forms.Label();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.GreenLabel = new System.Windows.Forms.Label();
            this.BlueLabel = new System.Windows.Forms.Label();
            this.RedLabel = new System.Windows.Forms.Label();
            this.SliderBlue = new System.Windows.Forms.TrackBar();
            this.SliderGreen = new System.Windows.Forms.TrackBar();
            this.SliderRed = new System.Windows.Forms.TrackBar();
            this.PhoneBox = new System.Windows.Forms.TextBox();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.HelpPage = new System.Windows.Forms.TabPage();
            this.ColorPanel = new System.Windows.Forms.Panel();
            this.Tabs.SuspendLayout();
            this.HomePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).BeginInit();
            this.ContactPage.SuspendLayout();
            this.SettingPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SliderBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SliderGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SliderRed)).BeginInit();
            this.SuspendLayout();
            // 
            // Tabs
            // 
            this.Tabs.Controls.Add(this.HomePage);
            this.Tabs.Controls.Add(this.AbouteMePage);
            this.Tabs.Controls.Add(this.ContactPage);
            this.Tabs.Controls.Add(this.SettingPage);
            this.Tabs.Controls.Add(this.HelpPage);
            this.Tabs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Tabs.Location = new System.Drawing.Point(13, 13);
            this.Tabs.Name = "Tabs";
            this.Tabs.SelectedIndex = 0;
            this.Tabs.Size = new System.Drawing.Size(775, 425);
            this.Tabs.TabIndex = 0;
            // 
            // HomePage
            // 
            this.HomePage.Controls.Add(this.AboutMeTextBox);
            this.HomePage.Controls.Add(this.Picture);
            this.HomePage.Location = new System.Drawing.Point(4, 29);
            this.HomePage.Name = "HomePage";
            this.HomePage.Padding = new System.Windows.Forms.Padding(3);
            this.HomePage.Size = new System.Drawing.Size(767, 392);
            this.HomePage.TabIndex = 0;
            this.HomePage.Text = "Home";
            this.HomePage.UseVisualStyleBackColor = true;
            // 
            // AboutMeTextBox
            // 
            this.AboutMeTextBox.Location = new System.Drawing.Point(190, 15);
            this.AboutMeTextBox.Multiline = true;
            this.AboutMeTextBox.Name = "AboutMeTextBox";
            this.AboutMeTextBox.Size = new System.Drawing.Size(557, 364);
            this.AboutMeTextBox.TabIndex = 3;
            // 
            // Picture
            // 
            this.Picture.ErrorImage = ((System.Drawing.Image)(resources.GetObject("Picture.ErrorImage")));
            this.Picture.InitialImage = ((System.Drawing.Image)(resources.GetObject("Picture.InitialImage")));
            this.Picture.Location = new System.Drawing.Point(16, 15);
            this.Picture.Name = "Picture";
            this.Picture.Size = new System.Drawing.Size(154, 155);
            this.Picture.TabIndex = 2;
            this.Picture.TabStop = false;
            // 
            // AbouteMePage
            // 
            this.AbouteMePage.Location = new System.Drawing.Point(4, 29);
            this.AbouteMePage.Name = "AbouteMePage";
            this.AbouteMePage.Padding = new System.Windows.Forms.Padding(3);
            this.AbouteMePage.Size = new System.Drawing.Size(767, 392);
            this.AbouteMePage.TabIndex = 1;
            this.AbouteMePage.Text = "About me";
            this.AbouteMePage.UseVisualStyleBackColor = true;
            // 
            // ContactPage
            // 
            this.ContactPage.Controls.Add(this.ContactPhoneBox);
            this.ContactPage.Controls.Add(this.ContactEmailBox);
            this.ContactPage.Controls.Add(this.ContactPhonelLabel);
            this.ContactPage.Controls.Add(this.ContactEmailLabel);
            this.ContactPage.Location = new System.Drawing.Point(4, 29);
            this.ContactPage.Name = "ContactPage";
            this.ContactPage.Padding = new System.Windows.Forms.Padding(3);
            this.ContactPage.Size = new System.Drawing.Size(767, 392);
            this.ContactPage.TabIndex = 2;
            this.ContactPage.Text = "Contact";
            this.ContactPage.UseVisualStyleBackColor = true;
            // 
            // ContactPhoneBox
            // 
            this.ContactPhoneBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ContactPhoneBox.Location = new System.Drawing.Point(93, 49);
            this.ContactPhoneBox.Name = "ContactPhoneBox";
            this.ContactPhoneBox.ReadOnly = true;
            this.ContactPhoneBox.Size = new System.Drawing.Size(195, 26);
            this.ContactPhoneBox.TabIndex = 3;
            this.ContactPhoneBox.Text = "test@gmail.com";
            // 
            // ContactEmailBox
            // 
            this.ContactEmailBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ContactEmailBox.Location = new System.Drawing.Point(93, 17);
            this.ContactEmailBox.Name = "ContactEmailBox";
            this.ContactEmailBox.ReadOnly = true;
            this.ContactEmailBox.Size = new System.Drawing.Size(195, 26);
            this.ContactEmailBox.TabIndex = 2;
            this.ContactEmailBox.Text = "+380961234567";
            // 
            // ContactPhonelLabel
            // 
            this.ContactPhonelLabel.AutoSize = true;
            this.ContactPhonelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ContactPhonelLabel.Location = new System.Drawing.Point(18, 52);
            this.ContactPhonelLabel.Name = "ContactPhonelLabel";
            this.ContactPhonelLabel.Size = new System.Drawing.Size(55, 20);
            this.ContactPhonelLabel.TabIndex = 1;
            this.ContactPhonelLabel.Text = "Phone";
            // 
            // ContactEmailLabel
            // 
            this.ContactEmailLabel.AutoSize = true;
            this.ContactEmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ContactEmailLabel.Location = new System.Drawing.Point(18, 20);
            this.ContactEmailLabel.Name = "ContactEmailLabel";
            this.ContactEmailLabel.Size = new System.Drawing.Size(48, 20);
            this.ContactEmailLabel.TabIndex = 0;
            this.ContactEmailLabel.Text = "Email";
            // 
            // SettingPage
            // 
            this.SettingPage.Controls.Add(this.ColorPanel);
            this.SettingPage.Controls.Add(this.label1);
            this.SettingPage.Controls.Add(this.HeaderBGLabel);
            this.SettingPage.Controls.Add(this.SaveBtn);
            this.SettingPage.Controls.Add(this.GreenLabel);
            this.SettingPage.Controls.Add(this.BlueLabel);
            this.SettingPage.Controls.Add(this.RedLabel);
            this.SettingPage.Controls.Add(this.SliderBlue);
            this.SettingPage.Controls.Add(this.SliderGreen);
            this.SettingPage.Controls.Add(this.SliderRed);
            this.SettingPage.Controls.Add(this.PhoneBox);
            this.SettingPage.Controls.Add(this.EmailBox);
            this.SettingPage.Controls.Add(this.PhoneLabel);
            this.SettingPage.Controls.Add(this.EmailLabel);
            this.SettingPage.Location = new System.Drawing.Point(4, 29);
            this.SettingPage.Name = "SettingPage";
            this.SettingPage.Padding = new System.Windows.Forms.Padding(3);
            this.SettingPage.Size = new System.Drawing.Size(767, 392);
            this.SettingPage.TabIndex = 3;
            this.SettingPage.Text = "Setting";
            this.SettingPage.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(119, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Contact info";
            // 
            // HeaderBGLabel
            // 
            this.HeaderBGLabel.AutoEllipsis = true;
            this.HeaderBGLabel.AutoSize = true;
            this.HeaderBGLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HeaderBGLabel.Location = new System.Drawing.Point(92, 125);
            this.HeaderBGLabel.Name = "HeaderBGLabel";
            this.HeaderBGLabel.Size = new System.Drawing.Size(180, 25);
            this.HeaderBGLabel.TabIndex = 11;
            this.HeaderBGLabel.Text = "Background color";
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(74, 335);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(220, 44);
            this.SaveBtn.TabIndex = 10;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // GreenLabel
            // 
            this.GreenLabel.AutoSize = true;
            this.GreenLabel.Location = new System.Drawing.Point(16, 229);
            this.GreenLabel.Name = "GreenLabel";
            this.GreenLabel.Size = new System.Drawing.Size(54, 20);
            this.GreenLabel.TabIndex = 9;
            this.GreenLabel.Text = "Green";
            // 
            // BlueLabel
            // 
            this.BlueLabel.AutoSize = true;
            this.BlueLabel.Location = new System.Drawing.Point(16, 279);
            this.BlueLabel.Name = "BlueLabel";
            this.BlueLabel.Size = new System.Drawing.Size(41, 20);
            this.BlueLabel.TabIndex = 8;
            this.BlueLabel.Text = "Blue";
            // 
            // RedLabel
            // 
            this.RedLabel.AutoSize = true;
            this.RedLabel.Location = new System.Drawing.Point(16, 179);
            this.RedLabel.Name = "RedLabel";
            this.RedLabel.Size = new System.Drawing.Size(39, 20);
            this.RedLabel.TabIndex = 7;
            this.RedLabel.Text = "Red";
            // 
            // SliderBlue
            // 
            this.SliderBlue.Location = new System.Drawing.Point(74, 265);
            this.SliderBlue.Maximum = 255;
            this.SliderBlue.Name = "SliderBlue";
            this.SliderBlue.Size = new System.Drawing.Size(220, 45);
            this.SliderBlue.TabIndex = 6;
            // 
            // SliderGreen
            // 
            this.SliderGreen.Location = new System.Drawing.Point(74, 214);
            this.SliderGreen.Maximum = 255;
            this.SliderGreen.Name = "SliderGreen";
            this.SliderGreen.Size = new System.Drawing.Size(220, 45);
            this.SliderGreen.TabIndex = 5;
            // 
            // SliderRed
            // 
            this.SliderRed.Location = new System.Drawing.Point(74, 163);
            this.SliderRed.Maximum = 255;
            this.SliderRed.Name = "SliderRed";
            this.SliderRed.Size = new System.Drawing.Size(220, 45);
            this.SliderRed.TabIndex = 4;
            // 
            // PhoneBox
            // 
            this.PhoneBox.Location = new System.Drawing.Point(74, 93);
            this.PhoneBox.Name = "PhoneBox";
            this.PhoneBox.Size = new System.Drawing.Size(220, 26);
            this.PhoneBox.TabIndex = 3;
            // 
            // EmailBox
            // 
            this.EmailBox.Location = new System.Drawing.Point(74, 55);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(220, 26);
            this.EmailBox.TabIndex = 2;
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.Location = new System.Drawing.Point(16, 96);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(55, 20);
            this.PhoneLabel.TabIndex = 1;
            this.PhoneLabel.Text = "Phone";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(16, 58);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(48, 20);
            this.EmailLabel.TabIndex = 0;
            this.EmailLabel.Text = "Email";
            // 
            // HelpPage
            // 
            this.HelpPage.Location = new System.Drawing.Point(4, 29);
            this.HelpPage.Name = "HelpPage";
            this.HelpPage.Padding = new System.Windows.Forms.Padding(3);
            this.HelpPage.Size = new System.Drawing.Size(767, 392);
            this.HelpPage.TabIndex = 4;
            this.HelpPage.Text = "Help";
            this.HelpPage.UseVisualStyleBackColor = true;
            // 
            // ColorPanel
            // 
            this.ColorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ColorPanel.Location = new System.Drawing.Point(300, 163);
            this.ColorPanel.Name = "ColorPanel";
            this.ColorPanel.Size = new System.Drawing.Size(27, 147);
            this.ColorPanel.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Tabs);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Tabs.ResumeLayout(false);
            this.HomePage.ResumeLayout(false);
            this.HomePage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).EndInit();
            this.ContactPage.ResumeLayout(false);
            this.ContactPage.PerformLayout();
            this.SettingPage.ResumeLayout(false);
            this.SettingPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SliderBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SliderGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SliderRed)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Tabs;
        private System.Windows.Forms.TabPage HomePage;
        private System.Windows.Forms.TabPage AbouteMePage;
        private System.Windows.Forms.TabPage ContactPage;
        private System.Windows.Forms.TabPage SettingPage;
        private System.Windows.Forms.TabPage HelpPage;
        private System.Windows.Forms.PictureBox Picture;
        private System.Windows.Forms.TextBox AboutMeTextBox;
        private System.Windows.Forms.TextBox PhoneBox;
        private System.Windows.Forms.TextBox EmailBox;
        private System.Windows.Forms.Label PhoneLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label HeaderBGLabel;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Label GreenLabel;
        private System.Windows.Forms.Label BlueLabel;
        private System.Windows.Forms.Label RedLabel;
        private System.Windows.Forms.TrackBar SliderBlue;
        private System.Windows.Forms.TrackBar SliderGreen;
        private System.Windows.Forms.TrackBar SliderRed;
        private System.Windows.Forms.TextBox ContactEmailBox;
        private System.Windows.Forms.Label ContactPhonelLabel;
        private System.Windows.Forms.Label ContactEmailLabel;
        private System.Windows.Forms.TextBox ContactPhoneBox;
        private System.Windows.Forms.Panel ColorPanel;
    }
}

