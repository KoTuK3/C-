using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L01_Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            Form form = new Form();
            Label label = new Label();
            Button btn = new Button();

            form.Size = new Size(500, 500);
            form.MouseClick += Form_MouseClick;

            btn.Location = new Point((form.ClientSize.Width - btn.ClientSize.Width) / 2, (form.ClientSize.Height - btn.ClientSize.Height) / 2);
            btn.Click += Btn_Click;

            form.Controls.Add(label);
            form.Controls.Add(btn);

            form.ShowDialog();
        }

        private static void Btn_Click(object sender, EventArgs e)
        {
            Form temp = sender as Form;
            var btn = temp.Controls.OfType<Button>().FirstOrDefault();

        }

        private static void Form_MouseClick(object sender, MouseEventArgs e)
        {
            Form temp = sender as Form;
            var label = temp.Controls.OfType<Label>().FirstOrDefault();
            switch (e.Button)
            {
                case MouseButtons.Left:
                    label.Text = "Left btn clicked";
                    break;
                case MouseButtons.Right:
                    label.Text = "Right btn clicked";
                    break;
                case MouseButtons.Middle:
                    label.Text = "Middle btn clicked";
                    break;
            }
        }
    }
}
