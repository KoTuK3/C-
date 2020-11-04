using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L08_Task01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void DrawPanel_Paint(object sender, PaintEventArgs e)
        {
            //Sky
            Rectangle skyRect = new Rectangle(0, 0, DrawPanel.Width, DrawPanel.Height / 5 * 3);

            e.Graphics.FillRectangle(Brushes.SkyBlue, skyRect);

            //Ground
            Rectangle groundRect = new Rectangle(0, DrawPanel.Height / 5 * 3, DrawPanel.Width, DrawPanel.Height / 5 * 3 + 1);

            e.Graphics.FillRectangle(Brushes.DarkGreen, groundRect);

            // Wall
            var xCenter = DrawPanel.Width / 2;
            var yCenter = DrawPanel.Height / 2;
            var wallSize = 300;
            var wallRect = new Rectangle(xCenter - wallSize / 2, yCenter - wallSize / 2, wallSize, wallSize);

            e.Graphics.FillRectangle(Brushes.Brown, wallRect);

            // Roof
            int roofHeight = wallSize / 3;
            int roofWidth = wallSize + 40;

            Point[] points = {
                new Point(xCenter + roofWidth / 2 + 20, yCenter - wallSize / 2),
                new Point(xCenter, yCenter - wallSize / 2  - roofHeight),
                new Point(xCenter - roofWidth / 2 - 20, yCenter - wallSize / 2)
            };

            GraphicsPath path = new GraphicsPath();

            path.AddCurve(points, 0);

            e.Graphics.FillPath(Brushes.DarkRed, path);

            // Door
            int doorWidth = wallSize / 4;
            int doorHeight = wallSize / 2;

            Rectangle doorRect = new Rectangle(xCenter - (wallSize - doorWidth) / 2, yCenter + wallSize / 2 - doorHeight, doorWidth, doorHeight);

            e.Graphics.FillRectangle(Brushes.Gray, doorRect);

            //Window            
            Image img = Image.FromFile(@"D:\Step\CSharp\WinFormsLessons\Lessons\L08_Task01\Images\WindowImage.png");
            Rectangle windorRect = new Rectangle(xCenter, yCenter - wallSize / 4, wallSize / 2 - 20, wallSize / 4);

            e.Graphics.FillRectangle(Brushes.SkyBlue, windorRect);
            e.Graphics.DrawImage(img, windorRect);
        }
    }
}
