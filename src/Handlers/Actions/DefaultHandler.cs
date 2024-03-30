using NNPG_2023_Uloha_4_Lukas_Bajer.src.Handlers.Actions;
using NNPG_2023_Uloha_4_Lukas_Bajer.src.Handlers.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NNPG_2023_Uloha_4_Lukas_Bajer.src.Handlers
{
    internal class DefaultHandler : Handler, IHandler
    {
        private ApplicationHandler AppHandler;
        private bool Drag;

        public DefaultHandler(ApplicationHandler formHandler)
        {
            AppHandler = formHandler;
        }

        public override void Canvas_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                Drag = true;
                TrySelectObject(e.X, e.Y);
            }
        }

        public override void Canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle && Drag)
            {
                AppHandler.HandleMoveObject(e.X, e.Y);
            }
        }

        public override void Canvas_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                Drag = false;
                AppHandler.DeselectAllObjects();
            }
            else if (e.Button == MouseButtons.Left)
            {
                TrySelectObject(e.X, e.Y);
            }
            else if (e.Button == MouseButtons.Right)
            {
            }
        }

        private void TrySelectObject(int x, int y)
        {
            foreach (var graphicsObject in AppHandler.GetGraphicsObjects())
            {
                if (graphicsObject.Contains(x, y))
                {
                    AppHandler.SetSelectedObject(graphicsObject);
                    return;
                }
            }
            AppHandler.SetSelectedObject(null);
        }

        public override void Cancel()
        {
            Console.WriteLine("DefaultHandler: Cancel");
        }
    }
}
