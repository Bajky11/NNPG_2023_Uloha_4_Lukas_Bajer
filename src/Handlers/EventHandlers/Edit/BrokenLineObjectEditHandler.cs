using NNPG_2023_Uloha_4_Lukas_Bajer.src.Classes;
using NNPG_2023_Uloha_4_Lukas_Bajer.src.GraphicsObjects;
using NNPG_2023_Uloha_4_Lukas_Bajer.src.GraphicsObjects.Parent.EditableObject;
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
    internal class BrokenLineObjectEditHandler : Handler
    {
        private BrokenLineObject BrokenLineObject;
        private ApplicationHandler AppHandler;
        private bool Drag;
        private bool Edit;
        private Point LastMousePosition;

        public BrokenLineObjectEditHandler(ApplicationHandler formHandler, BrokenLineObject brokenLineObject)
        {
            AppHandler = formHandler;
            BrokenLineObject = brokenLineObject;
        }

        public override void Canvas_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Drag = true;
                LastMousePosition = e.Location;
                if (BrokenLineObject.ManipulatorContains(e.X, e.Y))
                {
                    Edit = true;
                }
                else
                {
                    AppHandler.HandleCancelAction(new DefaultHandler(AppHandler));
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
                    BrokenLineObject.HandleManipulation(deltaX, deltaY);
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
                BrokenLineObject.ResetManipulation();
            }
        }

        public override void Cancel()
        {
            BrokenLineObject.ResetManipulation();
            Console.WriteLine("LineObjectEditHandler: Cancel");
        }
    }
}
