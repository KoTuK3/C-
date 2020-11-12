using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L10_Task01.Forms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void SignInBtn_Click(object sender, EventArgs e)
        {
            var user = new User();
            user.Login = LoginTextBox.Text;
            user.Password = PasswordTextBox.Text;
            if (user.CheckUser())
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                this.DialogResult = DialogResult.Cancel;
            }
        }
    }

    public class User
    {
        public string Login { get; set; }
        public string Password { get; set; }

        public bool CheckUser()
        {
            using (StreamReader stream = new StreamReader(@"D:\Step\CSharp\WinFormsLessons\Lessons\L10_Task01\Resource\config.json"))
            {
                var user = JsonConvert.DeserializeObject<User>(stream.ReadToEnd());
                const int step = 3;
                var pass = Password.ToCharArray();

                for (int i = 0; i < pass.Length; i++)
                {
                    pass[i] += (char)step;
                }
                var encryptedPassword = new string(pass);
                return Login == user.Login && encryptedPassword == user.Password;
            }
        }
    }
}
