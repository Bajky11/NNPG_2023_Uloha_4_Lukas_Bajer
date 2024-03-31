using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NNPG_2023_Uloha_4_Lukas_Bajer.src.GraphicsObjects.Parent.EditableObject.Manipulatorr.Parent
{
    internal abstract class Manipulator
    {
        public Rectangle ManipulatorHandle;
        public Manipulator(int x, int y)
        {
            ManipulatorHandle = new Rectangle(x, y, 10, 10);
        }
        public bool Contains(int x, int y)
        {
            return ManipulatorHandle.Contains(new Point(x, y));
        }
        public void Draw(Graphics g)
        {
            g.FillRectangle(Brushes.Red, ManipulatorHandle);
        }
    }
}
