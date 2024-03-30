using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NNPG_2023_Uloha_4_Lukas_Bajer.src.GraphicsObjects
{
    internal class RectangleObject : GraphicsObject
    {
        private Rectangle Rectangle;
        private Rectangle RightBottomManipulator;

        public RectangleObject(Point startPoint, int width, int height)
        {
            Rectangle = new Rectangle(startPoint.X, startPoint.Y, width, height);
            RightBottomManipulator = new Rectangle(startPoint.X + width, startPoint.Y + height, 10, 10);
        }

        public override bool Contains(int x, int y)
        {
            return Rectangle.Contains(new Point(x, y));
        }

        public bool ManipulatorContains(int x, int y)
        {
            return RightBottomManipulator.Contains(new Point(x, y));
        }

        public void UpdateSize(int deltaX, int deltaY)
        {
            Rectangle.Width += deltaX;
            Rectangle.Height += deltaY;

            // Ensure that the rectangle's width and height are non-negative
            Rectangle.Width = Math.Max(0, Rectangle.Width);
            Rectangle.Height = Math.Max(0, Rectangle.Height);

            // Update the position of the right-bottom manipulator
            RightBottomManipulator.X = Rectangle.X + Rectangle.Width;
            RightBottomManipulator.Y = Rectangle.Y + Rectangle.Height;
        }


        public override void Draw(Graphics g)
        {
            if (PropertyFill)
            {
                g.FillRectangle(FillBrush, Rectangle);
            }

            if (PropertyEdge)
            {
                g.DrawRectangle(EdgePen, Rectangle);
            }

            if (Selected)
            {
                g.DrawRectangle(Pens.Red, Rectangle);
                g.FillRectangle(Brushes.Red, RightBottomManipulator);
            }
        }

        public override void UpdatePosition(int deltaX, int deltaY)
        {
            Rectangle.X += deltaX;
            Rectangle.Y += deltaY;
            RightBottomManipulator.X += deltaX;
            RightBottomManipulator.Y += deltaY;
        }
    }
}
