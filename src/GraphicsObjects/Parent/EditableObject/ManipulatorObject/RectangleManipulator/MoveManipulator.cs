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
    internal class MoveManipulator : RectangleManipulator
    {
        public MoveManipulator(int x, int y) : base(x, y) { }

        public override void HandleManipulation(ref Rectangle rectangle, int deltaX, int deltaY)
        {
            rectangle.X += deltaX;
            rectangle.Y += deltaY;
        }

        public override void UpdatePosition(Rectangle rectangle)
        {
            ManipulatorHandle.X = rectangle.X + rectangle.Width / 2;
            ManipulatorHandle.Y = rectangle.Y + rectangle.Height / 2;
        }
    }
}
