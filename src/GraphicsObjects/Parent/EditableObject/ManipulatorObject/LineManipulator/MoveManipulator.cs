using NNPG_2023_Uloha_4_Lukas_Bajer.src.GraphicsObjects.Parent.EditableObject.ManipulatorObject.LineManipulatorr.Parent;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NNPG_2023_Uloha_4_Lukas_Bajer.src.GraphicsObjects.Parent.EditableObject.ManipulatorObject.LineManipulatorr
{
    internal class MoveManipulator : LineManipulator
    {
        public MoveManipulator(int x, int y) : base(x, y) { }

        public override void HandleManipulation(ref Point point, int deltaX, int deltaY)
        {
            point.X += deltaX;
            point.Y += deltaY;
        }

        public override void UpdatePosition(Point point)
        {
            ManipulatorHandle.X = point.X;
            ManipulatorHandle.Y = point.Y;
        }
    }
}
