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

        public RectangleObject(Point startPoint, int width, int height)
        {
            Rectangle = new Rectangle(startPoint.X, startPoint.Y, width, height);
        }

        public override bool Contains(int x, int y)
        {
            return Rectangle.Contains(new Point(x, y));
        }

        public override void Draw(Graphics g)
        {
            if (DrawFill)
            {
                g.FillRectangle(FillBrush, Rectangle);
            }

            if (DrawEdge)
            {
                g.DrawRectangle(EdgePen, Rectangle);
            }

            if (Selected)
            {
                g.DrawRectangle(Pens.Red, Rectangle);
            }
        }

        public override void UpdatePosition(int x, int y)
        {
            Rectangle.X = x;
            Rectangle.Y = y;
        }
    }
}
