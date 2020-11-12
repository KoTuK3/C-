using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HT07_Task01
{
    
    
    public partial class Form1 : Form
    {
        enum Figure
        {
            Circle,
            Square,
            Triangle
        }
        struct Coord
        {
            public int x;
            public int y;
        }

        private Color _borderColor = Color.Black;
        private Color _fillColor = Color.Black;
        private int _size = 50;

        List<FigureClass> _circleCoords = new List<FigureClass>();
        List<FigureClass> _squaresCoords = new List<FigureClass>();
        List<FigureClass> _triangesCoords = new List<FigureClass>();

        Figure _figure;

        public Form1()
        {
            InitializeComponent();
        }

        private void CircleBtn_Click(object sender, EventArgs e)
        {
            _figure = Figure.Circle;
        }

        private void SquareBtn_Click(object sender, EventArgs e)
        {
            _figure = Figure.Square;
        }

        private void TriangleBtn_Click(object sender, EventArgs e)
        {
            _figure = Figure.Triangle;
        }

        private void DrawPanel_Paint(object sender, PaintEventArgs e)
        {
            

            foreach (var item in _circleCoords)
            {
                int size = item.size;
                SolidBrush fillBrush = new SolidBrush(item.fillColor);
                var borderPen = new Pen(item.borderColor);

                e.Graphics.DrawArc(borderPen, item.x - size / 2, item.y - size / 2, item.size, item.size, 0, 360);
                e.Graphics.FillEllipse(fillBrush, item.x - size / 2, item.y - size / 2, item.size, item.size);
            }

            foreach (var item in _squaresCoords)
            {
                int size = item.size;
                SolidBrush fillBrush = new SolidBrush(item.fillColor);
                var borderPen = new Pen(item.borderColor);

                e.Graphics.DrawRectangle(borderPen, item.x - size / 2, item.y - size / 2, size, size);
                e.Graphics.FillRectangle(fillBrush, item.x - size / 2, item.y - size / 2, size, size);
            }
        }

        private void DrawPanel_MouseClick(object sender, MouseEventArgs e)
        {
            var figure = new FigureClass 
            { 
                x = e.X,
                y = e.Y,
                borderColor = _borderColor,
                fillColor = _fillColor,
                size = _size 
            };

            switch (_figure)
            {
                case Figure.Circle:
                    _circleCoords.Add(figure);
                    break;
                case Figure.Square:
                    _squaresCoords.Add(figure);
                    break;
                case Figure.Triangle:
                    _triangesCoords.Add(figure);
                    break;
                default:
                    break;
            }

            DrawPanel.Update();
            DrawPanel.Refresh();
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            _circleCoords.Clear();
            _squaresCoords.Clear();
            _triangesCoords.Clear();

            DrawPanel.Update();
            DrawPanel.Refresh();
        }

        private void BorderBtn_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();

            if (cd.ShowDialog() == DialogResult.OK)
            {
                _borderColor = cd.Color;
            }
        }

        private void FillBtn_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();

            if (cd.ShowDialog() == DialogResult.OK)
            {
                _fillColor = cd.Color;
            }
        }
    }
    class FigureClass
    {
        public int size;
        public int x;
        public int y;
        public Color borderColor;
        public Color fillColor;
    }
}
