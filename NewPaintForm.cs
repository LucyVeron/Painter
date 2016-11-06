using System;
using System.Drawing;
using System.Windows.Forms;

namespace EnhancedPainter
{
    public partial class NewPaintForm : Form
    {
        bool shouldPaint = false;

        /* Make generic variables for brush color and size */
        private Color brushColor;
        public int brushSize;

        public NewPaintForm()
        {
            InitializeComponent();
        }

        /* Change brush color with radio buttons */
        private void RedButton_CheckedChanged(object sender, EventArgs e)
        {
            brushColor = Color.Red;
        }

        private void BlueButton_CheckedChanged(object sender, EventArgs e)
        {
            brushColor = Color.Blue;
        }

        private void GreenButton_CheckedChanged(object sender, EventArgs e)
        {
            brushColor = Color.Green;
        }

        private void BlackButton_CheckedChanged(object sender, EventArgs e)
        {
            brushColor = Color.Black;
        }

        /* User can erase parts of drawing */
        private void EraserButton_CheckedChanged(object sender, EventArgs e)
        {
            brushColor = Color.White;
        }

        /* Change brush size with radio buttons */
        private void SmallButton_CheckedChanged(object sender, EventArgs e)
        {
            brushSize = 5;
        }

        private void MediumButton_CheckedChanged(object sender, EventArgs e)
        {
            brushSize = 10;
        }

        private void LargeButton_CheckedChanged(object sender, EventArgs e)
        {
            brushSize = 15;
        }

        /* Paint when the user holds the mouse down */
        private void DrawingPanel_MouseDown(object sender, MouseEventArgs e)
        {
            shouldPaint = true;
        }

        /* Creates art when user drags the mouse around */
        private void DrawingPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (shouldPaint)
            {
                /* User is only able to draw within the panel */
                using (Graphics graphics = DrawingPanel.CreateGraphics())
                {
                    graphics.FillEllipse(
                    new SolidBrush(brushColor), e.X, e.Y, brushSize, brushSize);
                } 
            } 
        }

        /* Stop painting when user is not clicking the mouse */
        private void DrawingPanel_MouseUp(object sender, MouseEventArgs e)
        {
            shouldPaint = false;
        }
    }
}
