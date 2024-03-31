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

namespace NNPG_2023_Uloha_4_Lukas_Bajer.src.Handlers.EventHandlers.Action
{
    internal class BrokenLineHandler : Handler
    {
        ApplicationHandler FormHandler;
        private Point StartPoint;
        private Point EndPoint;
        private bool Added;
        List<LineObject> Lines;

        public BrokenLineHandler(ApplicationHandler formHandler)
        {
            FormHandler = formHandler;
            StartPoint = Point.Empty;
            EndPoint = Point.Empty;
            Lines = new List<LineObject>();
        }

        public override void Canvas_MouseUp(object sender, MouseEventArgs e)
        {
            if (!Added)
            {
                FormHandler.AddGraphicsObject(new BrokenLineObject(Lines));
                Added = true;
            }

            if (e.Button == MouseButtons.Left)
            {
                if (StartPoint == Point.Empty)
                {
                    StartPoint = new Point(e.X, e.Y);
                }
                else
                {
                    EndPoint = new Point(e.X, e.Y);
                    Lines.Add(new LineObject(StartPoint, EndPoint));
                    StartPoint = EndPoint;
                    EndPoint = Point.Empty;
                }
            }

            if (e.Button == MouseButtons.Right)
            {
                FormHandler.AddGraphicsObject(new BrokenLineObject(Lines));
                Cancel();
            }

            FormHandler.Invalidate();
        }

        public override void Cancel()
        {
            StartPoint = Point.Empty;
            EndPoint = Point.Empty;
        }
    }
}
