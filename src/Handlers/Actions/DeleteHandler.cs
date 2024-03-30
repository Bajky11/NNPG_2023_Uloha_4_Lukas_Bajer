using NNPG_2023_Uloha_4_Lukas_Bajer.src.Handlers.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NNPG_2023_Uloha_4_Lukas_Bajer.src.Handlers.Actions
{
    internal class DeleteHandler : Handler
    {
        ApplicationHandler FormHandler;

        public DeleteHandler(ApplicationHandler formHandler)
        {
            FormHandler = formHandler;
        }

        public override void Canvas_MouseUp(object sender, MouseEventArgs e)
        {
            foreach (var graphicsObject in FormHandler.GetGraphicsObjects())
            {
                if (graphicsObject.Contains(e.X, e.Y))
                {
                    FormHandler.DeleteObject(graphicsObject);
                    return;
                }
            }
        }

        public override void Cancel()
        {
            Console.WriteLine("DeleteHandler: Cancel");
        }
    }
}
