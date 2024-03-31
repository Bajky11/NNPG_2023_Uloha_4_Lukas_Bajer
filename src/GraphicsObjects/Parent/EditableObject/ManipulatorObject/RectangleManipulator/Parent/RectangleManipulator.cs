using NNPG_2023_Uloha_4_Lukas_Bajer.src.GraphicsObjects.Parent.EditableObject.Manipulatorr.Parent;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NNPG_2023_Uloha_4_Lukas_Bajer.src.GraphicsObjects.Parent.EditableObject.ManipulatorObject.RectangleManipulatorr.Parent
{
    internal abstract class RectangleManipulator : Manipulator
    {
        public RectangleManipulator(int x, int y) : base(x, y) { }
        public abstract void UpdatePosition(Rectangle rectangle);
        public abstract void HandleManipulation(ref Rectangle rectangle, int deltaX, int deltaY);
    }
}
