using NNPG_2023_Uloha_4_Lukas_Bajer.src.GraphicsObjects;
using NNPG_2023_Uloha_4_Lukas_Bajer.src.Handlers.Actions;
using NNPG_2023_Uloha_4_Lukas_Bajer.src.Handlers.Forms;
using System.Drawing;
using System.Windows.Forms;
using System;

internal class RectangleHandler : Handler
{
    ApplicationHandler FormHandler;
    private Point StartPoint;

    public RectangleHandler(ApplicationHandler formHandler)
    {
        FormHandler = formHandler;
        StartPoint = Point.Empty;
    }

    public override void Canvas_MouseUp(object sender, MouseEventArgs e)
    {
        Console.WriteLine("RectangleHandler: Mouse Up");

        if (StartPoint == Point.Empty)
        {
            StartPoint = new Point(e.X, e.Y);
        }
        else
        {
            // Calculate the correct starting point and dimensions
            // to ensure the rectangle is always valid.
            int x1 = StartPoint.X;
            int y1 = StartPoint.Y;
            int x2 = e.X;
            int y2 = e.Y;

            // Determine the top-left corner of the rectangle
            int rectX = Math.Min(x1, x2);
            int rectY = Math.Min(y1, y2);

            // Calculate the width and height as positive values
            int width = Math.Abs(x2 - x1);
            int height = Math.Abs(y2 - y1);

            // Create and add the rectangle object with the corrected parameters
            FormHandler.AddGraphicsObject(new RectangleObject(new Point(rectX, rectY), width, height));
            Cancel();
        }
        FormHandler.Invalidate();
    }

    public override void Cancel()
    {
        StartPoint = Point.Empty;
    }
}
