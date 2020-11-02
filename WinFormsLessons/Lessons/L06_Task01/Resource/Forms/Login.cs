using L06_Task01.Resource.Forms;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Windows.Forms;

namespace L06_Task01
{
    public partial class LoginForm : Form
    {
        public LoginForm()
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
                PostsForm posts = new PostsForm();
                posts.Size = this.Size;
                posts.StartPosition = this.StartPosition;
                this.Visible = false;
                
                posts.ShowDialog();

                this.Visible = true;
            }
            else
            {
                MessageBox.Show("Incorrect login or password.");
            }
        }
    }

    public class User
    {
        public string Login { get; set; }
        public string Password { get; set; }

        public bool CheckUser()
        {
            using (StreamReader stream = new StreamReader("user.json"))
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
