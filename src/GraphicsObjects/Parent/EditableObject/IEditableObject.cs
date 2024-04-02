using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NNPG_2023_Uloha_4_Lukas_Bajer.src.GraphicsObjects.Parent.EditableObject
{
    internal interface IEditableObject
    {
        void HandleManipulation(int deltaX, int deltaY);
        bool ManipulatorContains(int x, int y);
        void ResetManipulation();
    }
}
