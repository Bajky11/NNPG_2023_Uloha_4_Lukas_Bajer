using NNPG_2023_Uloha_4_Lukas_Bajer.src.GraphicsObjects.Parent.EditableObject.ManipulatorObject.RectangleManipulatorr.Parent;
using NNPG_2023_Uloha_4_Lukas_Bajer.src.GraphicsObjects.Parent.EditableObject.Manipulatorr.Parent;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NNPG_2023_Uloha_4_Lukas_Bajer.src.GraphicsObjects.Parent.EditableObject.ManipulatorObject.RectangleManipulatorr
{
    internal class HeightManipulator : RectangleManipulator
    {
        public HeightManipulator(int x, int y) : base(x, y) { }

        public override void HandleManipulation(ref Rectangle rectangle, int deltaX, int deltaY)
        {
            rectangle.Height += deltaY;

            // Ensure that the rectangle's width and height are non-negative
            rectangle.Height = Math.Max(0, rectangle.Height);
        }

        public override void UpdatePosition(Rectangle rectangle)
        {
            ManipulatorHandle.X = rectangle.X + rectangle.Width / 2;
            ManipulatorHandle.Y = rectangle.Y + rectangle.Height;
        }
    }
}
