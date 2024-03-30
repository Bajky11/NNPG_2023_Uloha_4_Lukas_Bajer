using NNPG_2023_Uloha_4_Lukas_Bajer.src.GraphicsObjects;
using NNPG_2023_Uloha_4_Lukas_Bajer.src.Handlers.Actions;
using NNPG_2023_Uloha_4_Lukas_Bajer.src.Handlers.Forms.PropertiesPanel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NNPG_2023_Uloha_4_Lukas_Bajer.src.Handlers.Forms
{
    internal class ApplicationHandler
    {
        private Panel Canvas;
        private PropertiesPanelHandler PropertiesPanelHandler;
        private List<GraphicsObject> GraphicsObjects;
        private GraphicsObject SelectedObject;
        private Handler Handler;

        public ApplicationHandler(Panel canvas, PropertiesPanelHandler propertiesPanelHandler)
        {
            Canvas = canvas;
            PropertiesPanelHandler = propertiesPanelHandler;

            GraphicsObjects = new List<GraphicsObject>();
            SetHandler(new DefaultHandler(this));

            GraphicsObjects.Add(new RectangleObject(new Point(50, 50), 100, 100));
            GraphicsObjects.Add(new RectangleObject(new Point(150, 150), 100, 100));
            GraphicsObjects.Add(new RectangleObject(new Point(450, 150), 100, 100));
        }

        public void SetHandler(Handler handler)
        {
            if (Handler != null)
            {
                Canvas.MouseDown -= Handler.Canvas_MouseDown;
                Canvas.MouseUp -= Handler.Canvas_MouseUp;
                Canvas.MouseMove -= Handler.Canvas_MouseMove;
                Canvas.Click -= Handler.Canvas_Click;
            }

            Handler = handler;

            Canvas.MouseDown += handler.Canvas_MouseDown;
            Canvas.MouseUp += handler.Canvas_MouseUp;
            Canvas.MouseMove += handler.Canvas_MouseMove;
            Canvas.Click += handler.Canvas_Click;
        }

        public void AddGraphicsObject(GraphicsObject graphicsObject)
        {
            GraphicsObjects.Add(graphicsObject);
        }

        public void Paint(Graphics g)
        {
            foreach (var graphicsObject in GraphicsObjects)
            {
                graphicsObject.Draw(g);
            }
        }


        internal void Invalidate()
        {
            Canvas.Invalidate();
        }

        internal void SetSelectedObject(GraphicsObject graphicsObject)
        {
            if (SelectedObject == graphicsObject) return;

            if (SelectedObject != null)
            {
                SelectedObject.Selected = false;
                PropertiesPanelHandler.ResetProperties();
            }

            SelectedObject = graphicsObject;

            if (SelectedObject != null)
            {
                SelectedObject.Selected = true;
                PropertiesPanelHandler.SetProperties(SelectedObject.DrawEdge, !SelectedObject.DrawFill);
            }

            Invalidate();

        }

        internal void HandlePropertyChange(Tuple<PropertyEnum, string> tuple)
        {
            if (SelectedObject == null) return;

            switch (tuple.Item1)
            {
                case PropertyEnum.PropertyEdge:
                    SelectedObject.DrawEdge = bool.Parse(tuple.Item2);
                    break;
                case PropertyEnum.PropertyNoFill:
                    SelectedObject.DrawFill = bool.Parse(tuple.Item2);
                    break;
            }
        }

        public bool DrawEdge = false;
        public bool DrawFill = true;
        public Brush FillBrush = Brushes.DarkGray;
        public Pen EdgePen = Pens.Blue;

        internal List<GraphicsObject> GetGraphicsObjects()
        {
            return GraphicsObjects;
        }

        internal void DeleteObject(GraphicsObject graphicsObject)
        {
            GraphicsObjects.Remove(graphicsObject);
            Invalidate();
        }

        public void DeselectAllObjects()
        {
            if (SelectedObject == null) return;

            SelectedObject.Selected = false;
            SelectedObject = null;
            Invalidate();
        }

        internal void HandleMoveObject(int x, int y)
        {
            if (SelectedObject == null) return;

            SelectedObject.UpdatePosition(x, y);
            Invalidate();
        }
    }
}
