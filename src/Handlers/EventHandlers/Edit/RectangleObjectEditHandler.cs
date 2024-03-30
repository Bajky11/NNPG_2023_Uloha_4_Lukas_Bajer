using NNPG_2023_Uloha_4_Lukas_Bajer.src.GraphicsObjects;
using NNPG_2023_Uloha_4_Lukas_Bajer.src.Handlers.Actions;
using NNPG_2023_Uloha_4_Lukas_Bajer.src.Handlers.Forms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NNPG_2023_Uloha_4_Lukas_Bajer.src.Handlers.EventHandlers.Edit
{
    internal class RectangleObjectEditHandler : Handler
    {
        private ApplicationHandler AppHandler;
        private RectangleObject RectangleObject;
        private bool Drag;
        private bool Edit;
        private Point LastMousePosition;

        public RectangleObjectEditHandler(ApplicationHandler formHandler, RectangleObject rectangleObject)
        {
            AppHandler = formHandler;
            RectangleObject = rectangleObject;
        }

        public override void Canvas_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Drag = true;
                LastMousePosition = e.Location;
                if (RectangleObject.ManipulatorContains(e.X, e.Y))
                {
                    Edit = true;
                }
            }
        }

        public override void Canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && Drag)
            {
                if (Edit)
                {
                    Console.WriteLine("CONTAINS");
                    int deltaX = e.X - LastMousePosition.X;
                    int deltaY = e.Y - LastMousePosition.Y;
                    RectangleObject.UpdateSize(deltaX, deltaY);
                    AppHandler.Invalidate();
                }
                LastMousePosition = e.Location;
            }
        }

        public override void Canvas_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && Drag)
            {
                Drag = false;
                Edit = false;
            }
        }

        public override void Cancel()
        {
            Console.WriteLine("DefaultHandler: Cancel");
        }
    }
}
