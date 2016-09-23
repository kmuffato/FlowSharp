﻿using System.Drawing;
using System.Windows.Forms;

namespace FlowSharp
{
    public class Box : GraphicElement
    {
        public Box()
        {
            FillBrush = new SolidBrush(Color.White);
            BorderPen = new Pen(Color.LightGreen);
            BorderPen.Width = 5;
        }

        protected override void Draw(Graphics gr)
        {
            gr.FillRectangle(FillBrush, DisplayRectangle);
            gr.DrawRectangle(BorderPen, DisplayRectangle);
            base.Draw(gr);
        }
    }
}
