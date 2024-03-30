using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NNPG_2023_Uloha_4_Lukas_Bajer.src.Handlers.Forms
{
    internal class PropertiesPanelHandler
    {
        private CheckBox PropertyEdge;
        private bool suppressChangeEvent = false;
        private RadioButton PropertyNoFill;
        private RadioButton PropertySolidColorFill;

        public PropertiesPanelHandler(CheckBox propertyEdge, RadioButton propertyNoFill, RadioButton propertySolidColorFill)
        {
            PropertyEdge = propertyEdge;
            PropertyNoFill = propertyNoFill;
            PropertySolidColorFill = propertySolidColorFill;
        }

        public void SetProperties(bool propertyEdge, bool propertyFill)
        {
            suppressChangeEvent = true; // Suppress the change event
            PropertyEdge.Checked = propertyEdge;
            PropertyNoFill.Checked = propertyFill == true ? false : true;
            PropertySolidColorFill.Checked = propertyFill == true ? true : false;
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
    }
}
