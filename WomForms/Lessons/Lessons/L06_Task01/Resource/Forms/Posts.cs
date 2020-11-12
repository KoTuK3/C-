using L06_Task01.Models;
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

namespace L06_Task01.Resource.Forms
{
    public partial class PostsForm : Form
    {
        public PostsForm()
        {
            InitializeComponent();
        }

        private void PostsForm_Load(object sender, EventArgs e)
        {
            using (StreamReader reader = new StreamReader(@"D:\Step\CSharp\WinFormsLessons\Lessons\L06_Task01\Resource\Posts\posts.json"))
            {
                var posts = JsonConvert.DeserializeObject<List<Post>>(reader.ReadToEnd());

            }
        }
    }
}
