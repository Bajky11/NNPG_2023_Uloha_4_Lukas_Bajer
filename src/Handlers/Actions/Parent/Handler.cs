using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NNPG_2023_Uloha_4_Lukas_Bajer.src.Handlers.Actions
{
    internal abstract class Handler : IHandler
    {
        public virtual void Canvas_Click(object sender, EventArgs e)
        {
        }

        public virtual void Canvas_MouseDown(object sender, MouseEventArgs e)
        {
        }

        public virtual void Canvas_MouseMove(object sender, MouseEventArgs e)
        {
        }

        public virtual void Canvas_MouseUp(object sender, MouseEventArgs e)
        {
        }

        public abstract void Cancel();
    }
}
