using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace ImageViewer
{
    public partial class MainForm : Form
    {

        private void LoadImage(dynamic input)
        {
            if (input is string)
                InputImage = Image.FromFile(input);
            else if (input is Bitmap)
                InputImage = input;

            if (InputImageOverflows())
            {
                FitScreen();
            }
            else {
                ActualPixels();
            }
        }

        private bool InputImageOverflows()
        {
            return InputImage.Width > BottomPanel.Width || InputImage.Height > BottomPanel.Height;
        }

        private bool ImageBoxOverflows()
        {
            return ImageBox.Width > BottomPanel.Width || ImageBox.Height > BottomPanel.Height;
        }

        private void ScaleImage()
        {
            ImageBox.Image = null;
            ImageBox.Width = (int)Math.Round(InputImage.Width * Zoom.Value);
            ImageBox.Height = (int)Math.Round(InputImage.Height * Zoom.Value);
            ImageBox.Image = InputImage;
            CenterImage();
            ChangeCursor();
        }

        private void CenterImage()
        {
            if (Zoom.Mode == "FitScreen")
            {
                if (ImageBox.Width == BottomPanel.Width)
                    ImageBox.Left = 0;
                else
                    ImageBox.Left = (BottomPanel.Width / 2) - (ImageBox.Width / 2);

                if (ImageBox.Height == BottomPanel.Height)
                    ImageBox.Top = 0;
                else
                    ImageBox.Top = (BottomPanel.Height / 2) - (ImageBox.Height / 2);
            }
            else
            {
                ImageBox.Left = (BottomPanel.Width / 2) - (ImageBox.Width / 2);
                ImageBox.Top = (BottomPanel.Height / 2) - (ImageBox.Height / 2);
            }
            LeftLabel.Text = ImageBox.Left.ToString();
            TopLabel.Text = ImageBox.Top.ToString();
        }

        private void ActualPixels()
        {
            Zoom.Mode = "ActualPixels";
            Zoom.Value = 1;
            ScaleImage();
            ZoomComboBox.SelectedIndex = ZoomComboBox.FindStringExact("100%");
        }

        private void FitScreen()
        {
            Zoom.Mode = "FitScreen";
            float ratio = (float)BottomPanel.Width / InputImage.Width;
            if (InputImage.Height * ratio < BottomPanel.Height)
                Zoom.Value = ratio;
            else
                Zoom.Value = (float)BottomPanel.Height / InputImage.Height;
            ScaleImage();
            ZoomComboBox.ResetText();
            ZoomComboBox.SelectedText = (Zoom.Value * 100).ToString("0.00") + "%";
        }

        private void FillScreen()
        {
            Zoom.Mode = "FillScreen";
            float ratio = (float)BottomPanel.Width / InputImage.Width;
            if (InputImage.Height * ratio > BottomPanel.Height)
                Zoom.Value = ratio;
            else
                Zoom.Value = (float)BottomPanel.Height / InputImage.Height;
            ScaleImage();
            ZoomComboBox.ResetText();
            ZoomComboBox.SelectedText = (Zoom.Value * 100).ToString("0.00") + "%";
        }

    }
}
