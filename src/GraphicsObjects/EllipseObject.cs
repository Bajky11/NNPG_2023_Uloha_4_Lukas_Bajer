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
    internal class EllipseObject : RectangleObject
    {
        public EllipseObject(Point startPoint, int width, int height) : base(startPoint, width, height) { }

        public override void Draw(Graphics g)
        {
            if (PropertyFill)
            {
                g.FillEllipse(FillBrush, Rectangle);
            }

            if (PropertyEdge)
            {
                g.DrawEllipse(EdgePen, Rectangle);
            }

            if (Selected)
            {
                g.DrawEllipse(Pens.Red, Rectangle);
                SizeManipulator.Draw(g);
                WidthManipulator.Draw(g);
                HeightManipulator.Draw(g);
                MoveManipulator.Draw(g);
            }
        }
    }
}
