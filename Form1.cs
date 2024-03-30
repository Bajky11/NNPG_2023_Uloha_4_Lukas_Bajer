﻿using NNPG_2023_Uloha_4_Lukas_Bajer.src;
using NNPG_2023_Uloha_4_Lukas_Bajer.src.GraphicsObjects;
using NNPG_2023_Uloha_4_Lukas_Bajer.src.Handlers;
using NNPG_2023_Uloha_4_Lukas_Bajer.src.Handlers.Actions;
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
            PropertiesPanelHandler = new PropertiesPanelHandler(PropertyEdge, propertyNoFill);
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
            ApplicationHandler.SetHandler(new DefaultHandler(ApplicationHandler));
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
            if (PropertiesPanelHandler.ShouldSuppressChangeEvent()) return; // Check the flag

            ApplicationHandler.HandlePropertyChange(new Tuple<PropertyEnum, string>(PropertyEnum.PropertyEdge, PropertyEdge.Checked.ToString()));
        }

        private void propertyNoFill_CheckedChanged(object sender, EventArgs e)
        {
            if (PropertiesPanelHandler.ShouldSuppressChangeEvent()) return; // Check the flag

            ApplicationHandler.HandlePropertyChange(new Tuple<PropertyEnum, string>(PropertyEnum.PropertyEdge, PropertyEdge.Checked.ToString()));
        }
    }
}