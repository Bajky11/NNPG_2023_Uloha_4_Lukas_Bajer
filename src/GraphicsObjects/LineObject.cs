using NNPG_2023_Uloha_4_Lukas_Bajer.src.GraphicsObjects;
using NNPG_2023_Uloha_4_Lukas_Bajer.src.GraphicsObjects.Parent.EditableObject;
using NNPG_2023_Uloha_4_Lukas_Bajer.src.GraphicsObjects.Parent.EditableObject.ManipulatorObject.LineManipulatorr;
using NNPG_2023_Uloha_4_Lukas_Bajer.src.GraphicsObjects.Parent.EditableObject.SizeManipulator;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NNPG_2023_Uloha_4_Lukas_Bajer.src.Classes
{
    internal class LineObject : GraphicsObject, IEditableObject
    {
        private Point StartPoint;
        private Point EndPoint;
        private EditEnum EditType = EditEnum.None;
        private MoveManipulator StartPointMoveManipulator;
        private MoveManipulator EndPointMoveManipulator;

        public LineObject(Point startPoint, Point endPoint)
        {
            StartPoint = startPoint;
            EndPoint = endPoint;
            StartPointMoveManipulator = new MoveManipulator(StartPoint.X, StartPoint.Y);
            EndPointMoveManipulator = new MoveManipulator(EndPoint.X, EndPoint.Y);
        }

        public override bool Contains(int x, int y)
        {
            double tolerance = 5.0; // You can adjust this tolerance as needed
            return IsPointCloseToLine(StartPoint.X, StartPoint.Y, EndPoint.X, EndPoint.Y, x, y, tolerance);
        }

        private bool IsPointCloseToLine(int x1, int y1, int x2, int y2, int px, int py, double tolerance)
        {
            double lineLength = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            if (lineLength == 0) return false; // The line is a point

            // Project point onto line, normalized
            double dx = (x2 - x1) / lineLength;
            double dy = (y2 - y1) / lineLength;
            double t = dx * (px - x1) + dy * (py - y1);

            // Nearest point on the line
            double nearestX, nearestY;
            if (t < 0)
            {
                nearestX = x1;
                nearestY = y1;
            }
            else if (t > lineLength)
            {
                nearestX = x2;
                nearestY = y2;
            }
            else
            {
                nearestX = x1 + t * dx;
                nearestY = y1 + t * dy;
            }

            double dist = Math.Sqrt((nearestX - px) * (nearestX - px) + (nearestY - py) * (nearestY - py));
            return dist <= tolerance;
        }

        public bool ManipulatorContains(int x, int y)
        {
            if (StartPointMoveManipulator.Contains(x, y))
            {
                EditType = EditEnum.MoveStartPoint;
                return true;
            }
            if (EndPointMoveManipulator.Contains(x, y))
            {
                EditType = EditEnum.MoveEndPoint;
                return true;
            }
            EditType = EditEnum.None;
            return false;
        }

        public void UpdateManipulatorsPositions()
        {
            StartPointMoveManipulator.UpdatePosition(StartPoint);
            EndPointMoveManipulator.UpdatePosition(EndPoint);
        }

        public override void Draw(Graphics g)
        {
            g.DrawLine(EdgePen, StartPoint, EndPoint);
            if (Selected)
            {
                StartPointMoveManipulator.Draw(g);
                EndPointMoveManipulator.Draw(g);
            }
        }

        public override void UpdatePosition(int deltaX, int deltaY)
        {
            StartPoint.X += deltaX;
            StartPoint.Y += deltaY;
            EndPoint.X += deltaX;
            EndPoint.Y += deltaY;
            UpdateManipulatorsPositions();
        }

        public void HandleManipulation(int deltaX, int deltaY)
        {
            Console.WriteLine(EditType);
            switch (EditType)
            {
                case EditEnum.MoveStartPoint:
                    StartPointMoveManipulator.HandleManipulation(ref StartPoint, deltaX, deltaY);
                    break;
                case EditEnum.MoveEndPoint:
                    EndPointMoveManipulator.HandleManipulation(ref EndPoint, deltaX, deltaY);
                    break;
            }
            UpdateManipulatorsPositions();
        }

        public void ResetManipulation()
        {
            EditType = EditEnum.None;
        }
    }
}
