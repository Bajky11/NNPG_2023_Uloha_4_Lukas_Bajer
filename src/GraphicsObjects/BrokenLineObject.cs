using NNPG_2023_Uloha_4_Lukas_Bajer.src.Classes;
using NNPG_2023_Uloha_4_Lukas_Bajer.src.GraphicsObjects.Parent.EditableObject.ManipulatorObject.RectangleManipulatorr;
using NNPG_2023_Uloha_4_Lukas_Bajer.src.GraphicsObjects.Parent.EditableObject.SizeManipulator;
using NNPG_2023_Uloha_4_Lukas_Bajer.src.GraphicsObjects.Parent.EditableObject;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NNPG_2023_Uloha_4_Lukas_Bajer.src.GraphicsObjects
{
    internal class BrokenLineObject : GraphicsObject, IEditableObject
    {
        List<LineObject> Lines;

        public BrokenLineObject(List<LineObject> lines)
        {
            Lines = lines;
        }

        public override bool Contains(int x, int y)
        {
            foreach (var line in Lines)
            {
                if (line.Contains(x, y))
                {
                    SetSelectOnAllLineSegments(true);
                    return true;
                }
            }
            return false;
        }

        private void SetSelectOnAllLineSegments(bool selected)
        {
            foreach (var line in Lines)
            {
                line.Selected = selected;
            }
        }

        public bool ManipulatorContains(int x, int y)
        {
            bool contains = false;
            foreach (var line in Lines)
            {
                if (line.ManipulatorContains(x, y))
                {
                    SetSelectOnAllLineSegments(true);
                    contains = true;
                }
            }
            return contains;
        }

        public void HandleManipulation(int deltaX, int deltaY)
        {
            foreach (var line in Lines)
            {
                line.HandleManipulation(deltaX, deltaY);
            }
        }

        public override void Draw(Graphics g)
        {
            foreach (var line in Lines)
            {
                line.Draw(g);
            }
        }

        public override void UpdatePosition(int deltaX, int deltaY)
        {
            foreach (var line in Lines)
            {
                line.UpdatePosition(deltaX, deltaY);
            }
        }

        public override void Reset()
        {
            SetSelectOnAllLineSegments(false);
        }

        public void ResetManipulation()
        {
            foreach (var line in Lines)
            {
                line.ResetManipulation();
            }
        }
    }
}
