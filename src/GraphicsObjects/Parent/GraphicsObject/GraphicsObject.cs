using NNPG_2023_Uloha_4_Lukas_Bajer.src.GraphicalObjects;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NNPG_2023_Uloha_4_Lukas_Bajer.src.GraphicsObjects
{
    internal abstract class GraphicsObject : IGraphicsObject
    {
        // Form properties
        public bool PropertyEdge { get; set; } = true;
        public bool PropertyFill { get; set; } = false;
        public int ZIndex { get; set; } = 0;

        public Brush FillBrush = Brushes.DarkGray;
        public Pen EdgePen = Pens.Blue;

        // Component Properties
        public bool Selected = false;

        // Component Methods
        public abstract bool Contains(int x, int y);
        public abstract void Draw(Graphics g);
        public abstract void UpdatePosition(int deltaX, int deltaY);
        public void Reset() { Selected = false; }
    }
}
