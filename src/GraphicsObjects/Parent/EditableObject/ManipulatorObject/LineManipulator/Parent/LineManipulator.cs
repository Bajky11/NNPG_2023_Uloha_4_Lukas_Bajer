using NNPG_2023_Uloha_4_Lukas_Bajer.src.GraphicsObjects.Parent.EditableObject.Manipulatorr.Parent;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NNPG_2023_Uloha_4_Lukas_Bajer.src.GraphicsObjects.Parent.EditableObject.ManipulatorObject.LineManipulatorr.Parent
{
    internal abstract class LineManipulator : Manipulator
    {
        protected LineManipulator(int x, int y) : base(x, y) { }
        public abstract void UpdatePosition(Point point);
        public abstract void HandleManipulation(ref Point point, int deltaX, int deltaY);
    }
}
