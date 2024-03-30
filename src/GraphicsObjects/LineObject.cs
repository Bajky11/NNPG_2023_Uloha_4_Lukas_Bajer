using NNPG_2023_Uloha_4_Lukas_Bajer.src.GraphicalObjects;
using NNPG_2023_Uloha_4_Lukas_Bajer.src.GraphicsObjects;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NNPG_2023_Uloha_4_Lukas_Bajer.src.Classes
{
    internal class LineObject : GraphicsObject, IGraphicsObject
    {
        private Point StartPoint;
        private Point EndPoint;
        public LineObject(Point startPoint, Point endPoint)
        {
            StartPoint = startPoint;
            EndPoint = endPoint;
        }

        public override bool Contains(int x, int y)
        {
            return false;
        }

        public override void Draw(Graphics g)
        {
            g.DrawLine(EdgePen, StartPoint, EndPoint);
        }

        public override void UpdatePosition(int x, int y)
        {

        }
    }
}
