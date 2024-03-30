using NNPG_2023_Uloha_4_Lukas_Bajer.src.Handlers.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NNPG_2023_Uloha_4_Lukas_Bajer.src.Handlers
{
    internal interface IHandler
    {
        void Canvas_MouseUp(object sender, MouseEventArgs e);
        void Canvas_MouseDown(object sender, MouseEventArgs e);
        void Canvas_MouseMove(object sender, MouseEventArgs e);
        void Canvas_Click(object sender, EventArgs e);
    }
}
