using NNPG_2023_Uloha_4_Lukas_Bajer.src.GraphicsObjects;
using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace NNPG_2023_Uloha_4_Lukas_Bajer.src.Handlers.Forms
{
    internal class PropertiesPanelHandler
    {
        private bool suppressChangeEvent = false;
        private CheckBox PropertyEdge;
        private RadioButton PropertyNoFill;
        private RadioButton PropertySolidColorFill;
        private PictureBox PropertyEdgeColor;
        private ComboBox PropertyEdgeStyle;
        private NumericUpDown PropertyEdgeWidth;
        private RadioButton PropertyHatchFill;
        private PictureBox PropertyFillColor;
        private ComboBox PropertyHatchStyle;

        public PropertiesPanelHandler(CheckBox propertyEdge, PictureBox pictureBoxEdgeColor, ComboBox propertyEdgeStyle, NumericUpDown propertyEdgeWidth, RadioButton propertyNoFill, RadioButton propertySolidColorFill, RadioButton propertyHatchFill, PictureBox pictureBoxFillColor, ComboBox propertyHatchStyle)
        {
            PropertyEdge = propertyEdge;
            PropertyEdgeColor = pictureBoxEdgeColor;
            PropertyEdgeStyle = propertyEdgeStyle;
            PropertyEdgeWidth = propertyEdgeWidth;
            PropertyNoFill = propertyNoFill;
            PropertySolidColorFill = propertySolidColorFill;
            PropertyHatchFill = propertyHatchFill;
            PropertyFillColor = pictureBoxFillColor;
            PropertyHatchStyle = propertyHatchStyle;
        }

        internal void SetProperties(GraphicsObject selectedObject)
        {
            suppressChangeEvent = true; // Suppress the change event
            PropertyEdge.Checked = selectedObject.PropertyEdge;
            PropertyEdgeColor.BackColor = selectedObject.PropertyEdgeColor;
            PropertyEdgeStyle.SelectedItem = selectedObject.PropertyEdgeStyle;
            PropertyEdgeWidth.Value = selectedObject.PropertyEdgeWidth;
            PropertyNoFill.Checked = selectedObject.PropertyNoFill;
            PropertySolidColorFill.Checked = selectedObject.PropertyFill;
            PropertyHatchFill.Checked = selectedObject.PropertyHatchFill;
            PropertyFillColor.BackColor = selectedObject.PropertyFillColor;
            PropertyHatchStyle.SelectedItem = selectedObject.PropertyHatchStyle;
            suppressChangeEvent = false; // Re-enable the change event
        }

        public void ResetProperties()
        {
            suppressChangeEvent = true; // Suppress the change event
            PropertyEdge.Checked = false;
            PropertyNoFill.Checked = false;
            PropertySolidColorFill.Checked = false;
            suppressChangeEvent = false; // Re-enable the change event
        }

        public bool ShouldSuppressChangeEvent() => suppressChangeEvent;
        public void ComboBoxHashStyleInit(ComboBox comboBox)
        {
            comboBox.Items.Clear();

            // Pro naplneni cmboboxu hodnotami z HatchStyle nelze pouzit foreach
            // nebot vycet HatchStyle obsahuje opakujici se polozky (Cross=4)
            // a vic je tam Min a Max, takze celkem je ve vyctu 56 polozek
            //
            // foreach(HatchStyle stylSrafovani in Enum.GetValues(typeof(HatchStyle))) {
            //    comboBox.Items.Add(stylSrafovani);
            // }

            // Nelze pouzit Min a Max, protoze Max je chybne nastaveno na 4
            for (int i = 0; i <= 52; i++)
            {
                comboBox.Items.Add((HatchStyle)i);
            }
            comboBox.SelectedIndex = 0;
        }

        public void ComboBoxEdgeStyleInit(ComboBox comboBox)
        {
            Type styleType = typeof(EdgeStyle);
            foreach (string styleName in Enum.GetNames(typeof(DashStyle)))
            {
                comboBox.Items.Add(styleName);
            }
            comboBox.SelectedIndex = 0;
        }
    }
}
