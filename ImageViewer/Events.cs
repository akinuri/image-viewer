using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace ImageViewer
{
    public partial class MainForm : Form
    {

        private void BottomPanel_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void BottomPanel_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            LoadImage(files[0]);
        }

        private void ImageBox_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.InterpolationMode = InterpolationMode.NearestNeighbor;

            int addW = ImageBox.Width / (InputImage.Width * 2);
            int addH = ImageBox.Height / (InputImage.Height * 2);

            e.Graphics.DrawImage(InputImage, new Rectangle(0, 0, ImageBox.Width + addW, ImageBox.Height + addH), 0, 0, InputImage.Width, InputImage.Height, GraphicsUnit.Pixel);
        }

        private void ZoomComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string text = ZoomComboBox.SelectedItem.ToString();
            var match = Regex.Match(text, @"([-+]?[0-9]*\.?[0-9]+)");
            if (match.Success)
            {
                Zoom.Value = float.Parse(match.Groups[1].Value) / 100;
                ScaleImage();
            }
            //ImageBox.Focus();
        }

        private void ActualPixelsButton_Click(object sender, EventArgs e)
        {
            ActualPixels();
            //ImageBox.Focus();
        }

        private void FitScreenButton_Click(object sender, EventArgs e)
        {
            FitScreen();
            //ImageBox.Focus();
        }

        private void FillScreenButton_Click(object sender, EventArgs e)
        {
            FillScreen();
            //ImageBox.Focus();
        }

        private void FullScreenButton_Click(object sender, EventArgs e)
        {
            //this.TopMost = true;
            //this.FormBorderStyle = FormBorderStyle.None;
            //this.WindowState = FormWindowState.Maximized;
            //BottomPanel.BackColor = Color.Black;
            //FitScreen();
        }

        private void ZoomModeItem_Click(object sender, EventArgs e)
        {
            Wheel.Mode = "Zoom";
            ZoomModeItem.Checked = true;
            ScrollModeItem.Checked = false;
        }

        private void ScrollModeItem_Click(object sender, EventArgs e)
        {
            Wheel.Mode = "Scroll";
            ScrollModeItem.Checked = true;
            ZoomModeItem.Checked = false;
        }

    }
}
