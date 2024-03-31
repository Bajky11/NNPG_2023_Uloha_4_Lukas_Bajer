using NNPG_2023_Uloha_4_Lukas_Bajer.src;
using NNPG_2023_Uloha_4_Lukas_Bajer.src.GraphicsObjects;
using NNPG_2023_Uloha_4_Lukas_Bajer.src.Handlers;
using NNPG_2023_Uloha_4_Lukas_Bajer.src.Handlers.Actions;
using NNPG_2023_Uloha_4_Lukas_Bajer.src.Handlers.EventHandlers.Action;
using NNPG_2023_Uloha_4_Lukas_Bajer.src.Handlers.Forms;
using NNPG_2023_Uloha_4_Lukas_Bajer.src.Handlers.Forms.PropertiesPanel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NNPG_2023_Uloha_4_Lukas_Bajer
{
    public partial class Form1 : Form
    {
        ApplicationHandler ApplicationHandler;
        PropertiesPanelHandler PropertiesPanelHandler;

        public Form1()
        {
            InitializeComponent();
            Canvas.Paint += Canvas_Paint;
            PropertiesPanelHandler = new PropertiesPanelHandler(PropertyEdge, PropertyNoFill, PropertySolidColorFill);
            ApplicationHandler = new ApplicationHandler(Canvas, PropertiesPanelHandler);
        }

        private void Canvas_Paint(object sender, PaintEventArgs e)
        {
            ApplicationHandler.Paint(e.Graphics);
        }

        private void ActionLine_Click(object sender, EventArgs e)
        {
            ApplicationHandler.SetHandler(new LineHandler(ApplicationHandler));
        }

        private void ActionCancel_Click(object sender, EventArgs e)
        {
            ApplicationHandler.HandleCancelAction(new DefaultHandler(ApplicationHandler));
        }

        private void ActionRectangle_Click(object sender, EventArgs e)
        {
            ApplicationHandler.SetHandler(new RectangleHandler(ApplicationHandler));
        }
        private void ActionDelete_Click(object sender, EventArgs e)
        {
            ApplicationHandler.SetHandler(new DeleteHandler(ApplicationHandler));
        }

        private void PropertyEdge_CheckedChanged(object sender, EventArgs e)
        {
            if (PropertiesPanelHandler.ShouldSuppressChangeEvent()) return;

            ApplicationHandler.HandlePropertyChange(PropertyEnum.PropertyEdge, PropertyEdge.Checked.ToString(), "bool");
        }

        private void PropertyNoFill_Click(object sender, EventArgs e)
        {
            ApplicationHandler.HandlePropertyChange(PropertyEnum.PropertyFill, false.ToString(), "bool");
        }

        private void PropertySolidColorFill_Click(object sender, EventArgs e)
        {
            ApplicationHandler.HandlePropertyChange(PropertyEnum.PropertyFill, true.ToString(), "bool");
        }

        private void ActionEllipse_Click(object sender, EventArgs e)
        {
            ApplicationHandler.SetHandler(new EllipseHandler(ApplicationHandler));
        }

        private void ActionBrokenLine_Click(object sender, EventArgs e)
        {
            ApplicationHandler.SetHandler(new BrokenLineHandler(ApplicationHandler));
        }
    }
}
