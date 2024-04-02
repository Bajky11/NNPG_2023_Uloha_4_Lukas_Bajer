using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NNPG_2023_Uloha_4_Lukas_Bajer.src.GraphicsObjects
{
    internal abstract class GraphicsObject
    {
        // Form properties
        public Color PropertyEdgeColor { get; set ; } = Color.Blue;
        public Color PropertyFillColor { get; set; } = Color.Black;
        public HatchStyle PropertyHatchStyle { get; set; } = HatchStyle.BackwardDiagonal;
        public DashStyle PropertyEdgeStyle { get; set; } = DashStyle.Solid;
        public int PropertyEdgeWidth { get; set; } = 2;
        public bool PropertyEdge { get; set; } = true;
        public bool PropertyFill { get; set; } = false;
        public bool PropertyNoFill { get; set; } = true;
        public bool PropertyHatchFill { get; set; } = false;
        public int ZIndex { get; set; } = 0;

        // Component Properties
        public bool Selected = false;

        // Component Methods
        public abstract bool Contains(int x, int y);
        public abstract void Draw(Graphics g);
        public abstract void UpdatePosition(int deltaX, int deltaY);
        public virtual void Reset() { Selected = false; }
    }
}
