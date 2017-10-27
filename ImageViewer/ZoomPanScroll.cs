using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace ImageViewer
{
    public partial class MainForm : Form
    {

        private void ZoomScroll(object sender, MouseEventArgs e)
        {
            if (Wheel.Mode == "Zoom")
            {
                if (e.Delta > 0)
                {
                    Zoom.Value *= Zoom.Factor;
                    if (Zoom.Value > Zoom.Max)
                        Zoom.Value = Zoom.Max;
                }
                else
                {
                    Zoom.Value /= Zoom.Factor;
                    if (Zoom.Value < Zoom.Min)
                        Zoom.Value = Zoom.Min;
                }
                ZoomComboBox.ResetText();
                ZoomComboBox.SelectedText = (Zoom.Value * 100).ToString("0.00") + "%";
                ScaleImage();
            }
            else if (Wheel.Mode == "Scroll")
            {
                if (e.Delta > 0) // up
                {
                    if ((ImageBox.Top + Wheel.Step) < 0)
                        ImageBox.Top += Wheel.Step;
                    else
                        ImageBox.Top = 0;
                }
                else // down
                {
                    if ((ImageBox.Top - Wheel.Step) > -(ImageBox.Height - BottomPanel.Height))
                        ImageBox.Top -= Wheel.Step;
                    else
                        ImageBox.Top = -(ImageBox.Height - BottomPanel.Height);
                }
                TopLabel.Text = ImageBox.Top.ToString();
            }
        }

        private void ChangeCursor()
        {
            if (ImageBoxOverflows())
            {
                if (BottomPanel.Cursor != MyCursors.Pannable.Cursor)
                {
                    BottomPanel.Cursor = MyCursors.Pannable.Cursor;
                }
            }
            else if (BottomPanel.Cursor != Cursors.Default)
            {
                BottomPanel.Cursor = Cursors.Default;
            }
        }

        private void BottomPanel_MouseEnter(object sender, EventArgs e)
        {
            ImageBox.Focus();
            //ChangeCursor();
        }

        private void ImageBox_MouseEnter(object sender, EventArgs e)
        {
            ImageBox.Focus();
        }

        private void PanMouseDown(object sender, MouseEventArgs e)
        {
            if (BottomPanel.Cursor == MyCursors.Pannable.Cursor)
            {
                BottomPanel.Cursor = MyCursors.Panning.Cursor;
            }
        }

        private void PanMouseUp(object sender, MouseEventArgs e)
        {
            ChangeCursor();
        }
    }
}
