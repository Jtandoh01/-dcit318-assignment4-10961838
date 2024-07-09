using System;
using System.Drawing;
using System.Windows.Forms;

namespace DrawingApp
{
    public partial class Form1 : Form
    {
        private enum Shape { None, Line, Rectangle, Circle, Sketch }
        private Shape currentShape = Shape.None;

        private Point startPoint;
        private bool isDrawing = false;
        private Bitmap canvasBitmap;
        private Graphics canvasGraphics;

        public Form1()
        {
            InitializeComponent();

            // Initialize the bitmap and graphics for drawing
            canvasBitmap = new Bitmap(panelCanvas.Width, panelCanvas.Height);
            canvasGraphics = Graphics.FromImage(canvasBitmap);
            canvasGraphics.Clear(Color.White);
        }

        private void panelCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDrawing = true;
                startPoint = e.Location;
                if (currentShape == Shape.Sketch)
                {
                    // For sketching, start drawing immediately
                    previousPoint = startPoint;
                }
            }
        }

        private void panelCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                if (currentShape == Shape.Sketch)
                {
                    // Draw line segments for sketching
                    Point currentPoint = e.Location;
                    canvasGraphics.DrawLine(Pens.Black, previousPoint, currentPoint);
                    previousPoint = currentPoint;
                    panelCanvas.Invalidate(); // Refresh the panel to show the drawing
                }
                else
                {
                    panelCanvas.Invalidate(); // Refresh the panel to show the drawing preview
                }
            }
        }

        private void panelCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDrawing = false;
                if (currentShape != Shape.Sketch)
                {
                    DrawShape(e.Location);
                }
            }
        }

        private void panelCanvas_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImageUnscaled(canvasBitmap, Point.Empty);
            if (isDrawing && currentShape != Shape.Sketch)
            {
                DrawShapePreview(e.Graphics, panelCanvas.PointToClient(Cursor.Position));
            }
        }

        private void DrawShape(Point endPoint)
        {
            switch (currentShape)
            {
                case Shape.Line:
                    canvasGraphics.DrawLine(Pens.Black, startPoint, endPoint);
                    break;
                case Shape.Rectangle:
                    canvasGraphics.DrawRectangle(Pens.Black, GetRectangle(startPoint, endPoint));
                    break;
                case Shape.Circle:
                    canvasGraphics.DrawEllipse(Pens.Black, GetRectangle(startPoint, endPoint));
                    break;
            }
            panelCanvas.Invalidate();
        }

        private void DrawShapePreview(Graphics g, Point currentPoint)
        {
            switch (currentShape)
            {
                case Shape.Line:
                    g.DrawLine(Pens.Gray, startPoint, currentPoint);
                    break;
                case Shape.Rectangle:
                    g.DrawRectangle(Pens.Gray, GetRectangle(startPoint, currentPoint));
                    break;
                case Shape.Circle:
                    g.DrawEllipse(Pens.Gray, GetRectangle(startPoint, currentPoint));
                    break;
            }
        }

        private Rectangle GetRectangle(Point p1, Point p2)
        {
            return new Rectangle(
                Math.Min(p1.X, p2.X),
                Math.Min(p1.Y, p2.Y),
                Math.Abs(p1.X - p2.X),
                Math.Abs(p1.Y - p2.Y));
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            canvasGraphics.Clear(Color.White);
            panelCanvas.Invalidate();
        }

        private void radioButtonLine_CheckedChanged(object sender, EventArgs e)
        {
            currentShape = Shape.Line;
        }

        private void radioButtonRectangle_CheckedChanged(object sender, EventArgs e)
        {
            currentShape = Shape.Rectangle;
        }

        private void radioButtonCircle_CheckedChanged(object sender, EventArgs e)
        {
            currentShape = Shape.Circle;
        }

        private void radioButtonSketch_CheckedChanged(object sender, EventArgs e)
        {
            currentShape = Shape.Sketch;
        }

        private Point previousPoint; // To keep track of the last point for sketching
    }
}
