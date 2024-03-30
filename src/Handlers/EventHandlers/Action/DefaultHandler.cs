using NNPG_2023_Uloha_4_Lukas_Bajer.src.GraphicsObjects;
using NNPG_2023_Uloha_4_Lukas_Bajer.src.Handlers.Actions;
using NNPG_2023_Uloha_4_Lukas_Bajer.src.Handlers.Forms;
using NNPG_2023_Uloha_4_Lukas_Bajer.src.Handlers.Forms.PropertiesPanel;
using System;
using System.Collections.Generic;
using System.Drawing;
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
        private Point LastMousePosition;

        public DefaultHandler(ApplicationHandler formHandler)
        {
            AppHandler = formHandler;
        }

        public override void Canvas_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                var selectedObject = TrySelectObject(e.X, e.Y);
                if(selectedObject != null)
                {
                    Drag = true;
                    LastMousePosition = e.Location;
                }
            }
        }

        public override void Canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle && Drag)
            {
                int deltaX = e.X - LastMousePosition.X;
                int deltaY = e.Y - LastMousePosition.Y;
                LastMousePosition = e.Location;
                AppHandler.HandleMoveObject(deltaX, deltaY);
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
                var selectedObject = TrySelectObject(e.X, e.Y);
                if (selectedObject != null)
                {
                    AppHandler.InitEditMode();
                }
            }
            else if (e.Button == MouseButtons.Right)
            {
                var selectedObject = TrySelectObject(e.X, e.Y);
                if (selectedObject != null)
                {
                    AppHandler.ShowZIndexMenu(new Point(e.X, e.Y));
                }
            }
        }

        private GraphicsObject TrySelectObject(int x, int y)
        {
            foreach (var graphicsObject in AppHandler.GetGraphicsObjects())
            {
                if (graphicsObject.Contains(x, y))
                {
                    return AppHandler.SetSelectedObject(graphicsObject);
                }
            }
            return AppHandler.SetSelectedObject(null);
        }

        public override void Cancel()
        {
            Console.WriteLine("DefaultHandler: Cancel");
        }
    }
}
