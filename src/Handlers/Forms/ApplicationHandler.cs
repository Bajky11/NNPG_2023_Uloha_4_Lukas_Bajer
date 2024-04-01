using NNPG_2023_Uloha_4_Lukas_Bajer.src.Classes;
using NNPG_2023_Uloha_4_Lukas_Bajer.src.GraphicsObjects;
using NNPG_2023_Uloha_4_Lukas_Bajer.src.Handlers.Actions;
using NNPG_2023_Uloha_4_Lukas_Bajer.src.Handlers.EventHandlers.Edit;
using NNPG_2023_Uloha_4_Lukas_Bajer.src.Handlers.Forms.PropertiesPanel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
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

            // Set DoubleBuffering true on panel1
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty
             | BindingFlags.Instance | BindingFlags.NonPublic, null,
             Canvas, new object[] { true });
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

        public void HandleCancelAction(Handler handler)
        {
            if (SelectedObject != null)
            {
                SelectedObject.Reset();
            }
            SelectedObject = null;
            SetHandler(handler);
            Invalidate();
        }

        public void AddGraphicsObject(GraphicsObject graphicsObject)
        {
            GraphicsObjects.Add(graphicsObject);
        }
        public void Paint(Graphics g)
        {
            GraphicsObjects = GraphicsObjects.OrderBy(obj => obj.ZIndex).ToList();

            foreach (var graphicsObject in GraphicsObjects)
            {
                graphicsObject.Draw(g);
            }
        }


        internal void Invalidate()
        {
            Canvas.Invalidate();
        }

        internal GraphicsObject SetSelectedObject(GraphicsObject graphicsObject)
        {
            if (SelectedObject == graphicsObject) return null;

            if (SelectedObject != null)
            {
                SelectedObject.Selected = false;
                PropertiesPanelHandler.ResetProperties();
            }

            SelectedObject = graphicsObject;

            if (SelectedObject != null)
            {
                SelectedObject.Selected = true;
                PropertiesPanelHandler.SetProperties(SelectedObject.PropertyEdge, SelectedObject.PropertyFill);
            }

            Invalidate();
            return SelectedObject;
        }

        internal void HandlePropertyChange(PropertyEnum propertyEnum, string propertyValue, string propertyValueType)
        {
            if (SelectedObject == null) return;

            // Get the enum name as property name
            string propertyName = propertyEnum.ToString();

            // Use reflection to set the property value
            // NOTE: Because of inheritance, if Selected is defined in a base class of obj and not directly in the class of obj, GetProperty might not find it.
            // You may need to specify BindingFlags to search for properties in base classes as well.
            var property = SelectedObject.GetType().GetProperty(propertyName, BindingFlags.Public | BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.FlattenHierarchy);
            Console.WriteLine("Found property: " + property.Name);
            if (property != null)
            {
                string selectedValue = property.GetValue(SelectedObject).ToString();
                Console.WriteLine($"Value: {selectedValue}");
                switch (propertyValueType)
                {
                    case "bool":
                        bool newBoolValue = Convert.ToBoolean(propertyValue);
                        property.SetValue(SelectedObject, newBoolValue);
                        Console.WriteLine($"NEW Value: {newBoolValue}");
                        break;

                    case "int":
                        int newIntValue;
                        bool success = int.TryParse(propertyValue, out newIntValue);
                        if (success)
                        {
                            property.SetValue(SelectedObject, newIntValue);
                            Console.WriteLine($"NEW Value: {newIntValue}");
                        }

                        break;
                }
            }
            else
            {
                Console.WriteLine($"Property {propertyName} not found.");

            }
            Console.WriteLine();
            Invalidate();
        }


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

        internal void HandleMoveObject(int deltaX, int deltaY)
        {
            if (SelectedObject == null) return;

            SelectedObject.UpdatePosition(deltaX, deltaY);
            Invalidate();
        }

        public void ShowZIndexMenu(Point mouseCoordinates)
        {
            ContextMenuStrip contextMenuStrip = new ContextMenuStrip();
            ToolStripMenuItem bringforwardItem = new ToolStripMenuItem("Bring Forward");
            ToolStripMenuItem bringBackwardItem = new ToolStripMenuItem("Bring Backward");
            contextMenuStrip.Items.Add(bringforwardItem);
            contextMenuStrip.Items.Add(bringBackwardItem);
            bringforwardItem.Click += BringforwardItem_Click;
            bringBackwardItem.Click += BringBackwardItem_Click;
            contextMenuStrip.Show(mouseCoordinates);
        }

        private void BringBackwardItem_Click(object sender, EventArgs e)
        {
            int newZIndex = SelectedObject.ZIndex - 1;
            HandlePropertyChange(PropertyEnum.ZIndex, newZIndex.ToString(), "int");
        }

        private void BringforwardItem_Click(object sender, EventArgs e)
        {
            int newZIndex = SelectedObject.ZIndex + 1;
            HandlePropertyChange(PropertyEnum.ZIndex, newZIndex.ToString(), "int");
        }

        internal void InitEditMode()
        {
            switch (SelectedObject)
            {
                case RectangleObject rectangleObject:
                    SetHandler(new RectangleObjectEditHandler(this, rectangleObject));
                    break;
                case LineObject lineObject:
                    SetHandler(new LineObjectEditHandler(this, lineObject));
                    break;
                case BrokenLineObject brokenLine:
                    SetHandler(new BrokenLineObjectEditHandler(this, brokenLine));
                    break;
            }
        }
    }
}
