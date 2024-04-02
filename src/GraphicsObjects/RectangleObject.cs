using NNPG_2023_Uloha_4_Lukas_Bajer.src.GraphicsObjects.Parent.EditableObject;
using NNPG_2023_Uloha_4_Lukas_Bajer.src.GraphicsObjects.Parent.EditableObject.ManipulatorObject.RectangleManipulatorr;
using NNPG_2023_Uloha_4_Lukas_Bajer.src.GraphicsObjects.Parent.EditableObject.SizeManipulator;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NNPG_2023_Uloha_4_Lukas_Bajer.src.GraphicsObjects
{
    internal class RectangleObject : GraphicsObject, IEditableObject
    {
        protected Rectangle Rectangle;
        private EditEnum EditType = EditEnum.None;

        protected SizeManipulator SizeManipulator;
        protected WidthManipulator WidthManipulator;
        protected HeightManipulator HeightManipulator;
        protected MoveManipulator MoveManipulator;

        public RectangleObject(Point startPoint, int width, int height)
        {
            Rectangle = new Rectangle(startPoint.X, startPoint.Y, width, height);

            SizeManipulator = new SizeManipulator(Rectangle.X + Rectangle.Width, Rectangle.Y + Rectangle.Height);
            HeightManipulator = new HeightManipulator(Rectangle.X + Rectangle.Width, Rectangle.Y + Rectangle.Height / 2);
            WidthManipulator = new WidthManipulator(Rectangle.X + Rectangle.Width / 2, Rectangle.Y + Rectangle.Height);
            MoveManipulator = new MoveManipulator(Rectangle.X + Rectangle.Width / 2, Rectangle.Y + Rectangle.Height / 2);
        }

        public override bool Contains(int x, int y)
        {
            return Rectangle.Contains(new Point(x, y));
        }

        public void ResetManipulation()
        {
            EditType = EditEnum.None;
        }

        public bool ManipulatorContains(int x, int y)
        {
            if (SizeManipulator.Contains(x, y))
            {
                EditType = EditEnum.Size;
                return true;
            }
            if (WidthManipulator.Contains(x, y))
            {
                EditType = EditEnum.Width;
                return true;
            }
            if (HeightManipulator.Contains(x, y))
            {
                EditType = EditEnum.Height;
                return true;
            }
            if (MoveManipulator.Contains(x, y))
            {
                EditType = EditEnum.Move;
                return true;
            }
            EditType = EditEnum.None;
            return false;
        }

        public void HandleManipulation(int deltaX, int deltaY)
        {
            switch (EditType)
            {
                case EditEnum.Size:
                    SizeManipulator.HandleManipulation(ref Rectangle, deltaX, deltaY);
                    break;
                case EditEnum.Width:
                    WidthManipulator.HandleManipulation(ref Rectangle, deltaX, deltaY);
                    break;
                case EditEnum.Height:
                    HeightManipulator.HandleManipulation(ref Rectangle, deltaX, deltaY);
                    break;
                case EditEnum.Move:
                    MoveManipulator.HandleManipulation(ref Rectangle, deltaX, deltaY);
                    break;
            }

            UpdateManipulatorsPositions();
        }

        public void UpdateManipulatorsPositions()
        {
            SizeManipulator.UpdatePosition(Rectangle);
            WidthManipulator.UpdatePosition(Rectangle);
            HeightManipulator.UpdatePosition(Rectangle);
            MoveManipulator.UpdatePosition(Rectangle);
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
                SizeManipulator.Draw(g);
                WidthManipulator.Draw(g);
                HeightManipulator.Draw(g);
                MoveManipulator.Draw(g);
            }
        }

        public override void UpdatePosition(int deltaX, int deltaY)
        {
            Rectangle.X += deltaX;
            Rectangle.Y += deltaY;
            UpdateManipulatorsPositions();
        }
    }
}
