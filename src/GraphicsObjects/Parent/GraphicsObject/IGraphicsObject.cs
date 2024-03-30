using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NNPG_2023_Uloha_4_Lukas_Bajer.src.GraphicalObjects
{
    internal interface IGraphicsObject
    {
        void Draw(Graphics g);
        void UpdatePosition(int x, int y);
        bool Contains(int x, int y);
    }
}
