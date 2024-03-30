using NNPG_2023_Uloha_4_Lukas_Bajer.src.Classes;
using NNPG_2023_Uloha_4_Lukas_Bajer.src.GraphicsObjects;
using NNPG_2023_Uloha_4_Lukas_Bajer.src.Handlers;
using NNPG_2023_Uloha_4_Lukas_Bajer.src.Handlers.Actions;
using NNPG_2023_Uloha_4_Lukas_Bajer.src.Handlers.Forms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NNPG_2023_Uloha_4_Lukas_Bajer.src
{
    internal class LineHandler : Handler, IHandler
    {
        ApplicationHandler FormHandler;
        private Point StartPoint;
        private Point EndPoint;

        public LineHandler(ApplicationHandler formHandler)
        {
            FormHandler = formHandler;
            StartPoint = Point.Empty;
            EndPoint = Point.Empty;
        }

        public override void Canvas_MouseUp(object sender, MouseEventArgs e)
        {
            Console.WriteLine("LineHandler: Mouse Up");

            if (StartPoint == Point.Empty)
            {
                StartPoint = new Point(e.X, e.Y);
            }
            else
            {
                EndPoint = new Point(e.X, e.Y);
                FormHandler.AddGraphicsObject(new LineObject(StartPoint, EndPoint));
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
