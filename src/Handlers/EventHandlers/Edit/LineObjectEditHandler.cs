using NNPG_2023_Uloha_4_Lukas_Bajer.src.Classes;
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
    internal class LineObjectEditHandler : Handler
    {
        private LineObject LineObject;
        private ApplicationHandler AppHandler;
        private bool Drag;
        private bool Edit;
        private Point LastMousePosition;

        public LineObjectEditHandler(ApplicationHandler formHandler, LineObject lineObject)
        {
            AppHandler = formHandler;
            LineObject = lineObject;
        }

        public override void Canvas_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Drag = true;
                LastMousePosition = e.Location;
                if (LineObject.ManipulatorContains(e.X, e.Y))
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
                    int deltaX = e.X - LastMousePosition.X;
                    int deltaY = e.Y - LastMousePosition.Y;
                    LineObject.HandleManipulation(deltaX, deltaY);
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
                LineObject.ResetManipulation();
            }
        }

        public override void Cancel()
        {
            Console.WriteLine("LineObjectEditHandler: Cancel");
        }
    }
}
