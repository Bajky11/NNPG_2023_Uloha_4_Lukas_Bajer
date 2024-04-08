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
            PropertiesPanelHandler = new PropertiesPanelHandler(PropertyEdge, PictureBoxEdgeColor, PropertyEdgeStyle, PropertyEdgeWidth, PropertyNoFill, PropertySolidColorFill, PropertyHatchFill, PictureBoxFillColor, PropertyHatchStyle);
            ApplicationHandler = new ApplicationHandler(Canvas, PropertiesPanelHandler);

            PropertiesPanelHandler.ComboBoxHashStyleInit(PropertyHatchStyle);
            PropertiesPanelHandler.ComboBoxEdgeStyleInit(PropertyEdgeStyle);
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

        private void ActionEllipse_Click(object sender, EventArgs e)
        {
            ApplicationHandler.SetHandler(new EllipseHandler(ApplicationHandler));
        }

        private void ActionBrokenLine_Click(object sender, EventArgs e)
        {
            ApplicationHandler.SetHandler(new BrokenLineHandler(ApplicationHandler));
        }

        private void PropertyEdge_CheckedChanged(object sender, EventArgs e)
        {
            if (PropertiesPanelHandler.ShouldSuppressChangeEvent()) return;
            ApplicationHandler.HandlePropertyChange(PropertyEnum.PropertyEdge, PropertyEdge.Checked.ToString(), "bool");
        }

        private void PropertyNoFill_CheckedChanged(object sender, EventArgs e)
        {
            if (PropertiesPanelHandler.ShouldSuppressChangeEvent()) return;
            ApplicationHandler.HandlePropertyChange(PropertyEnum.PropertyNoFill, PropertyNoFill.Checked.ToString(), "bool");
            Console.WriteLine("NoFillChanged");
        }

        private void PropertySolidColorFill_CheckedChanged(object sender, EventArgs e)
        {
            if (PropertiesPanelHandler.ShouldSuppressChangeEvent()) return;
            ApplicationHandler.HandlePropertyChange(PropertyEnum.PropertyFill, PropertySolidColorFill.Checked.ToString(), "bool");
            Console.WriteLine("SolidFillChanged");

        }

        private void PropertyHatchFill_CheckedChanged(object sender, EventArgs e)
        {
            if (PropertiesPanelHandler.ShouldSuppressChangeEvent()) return;
            ApplicationHandler.HandlePropertyChange(PropertyEnum.PropertyHatchFill, PropertyHatchFill.Checked.ToString(), "bool");
            Console.WriteLine("HatchFillChanged");

        }

        private void PictureBoxFillColor_Click(object sender, EventArgs e)
        {
            Color newColor = ApplicationHandler.SetColorUsingColorDialog("FILL");
            if (newColor != Color.Empty) PictureBoxFillColor.BackColor = newColor;

        }

        private void PictureBoxEdgeColor_Click(object sender, EventArgs e)
        {
            Color newColor = ApplicationHandler.SetColorUsingColorDialog("EDGE");
            if (newColor != Color.Empty) PictureBoxEdgeColor.BackColor = newColor;
        }

        private void PropertyEdgeWidth_ValueChanged(object sender, EventArgs e)
        {
            ApplicationHandler.HandlePropertyChange(PropertyEnum.PropertyEdgeWidth, PropertyEdgeWidth.Value.ToString(), "int");
        }

        private void PropertyEdgeStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplicationHandler.HandlePropertyChange(PropertyEnum.PropertyEdgeStyle, PropertyEdgeStyle.Text, "dashstyle");
        }

        private void PropertyHatchStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplicationHandler.HandlePropertyChange(PropertyEnum.PropertyHatchStyle, PropertyHatchStyle.Text, "hatchstyle");
        }
    }
}
