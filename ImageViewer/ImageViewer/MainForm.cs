using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Text.RegularExpressions;

namespace ImageViewer
{
    public partial class MainForm : Form
    {
        float zoom = 1;
        float zoomMax = 32;
        float zoomMin = 0.1f;
        Image image = null;

        public MainForm(string[] args)
        {
            InitializeComponent();
            image = ImageBox.Image;
            this.ImageBox.MouseWheel += ImageBox_MouseWheel;
            if (args.Length > 0)
            {
                LoadImage(args[0]);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ZoomComboBox.SelectedIndex = ZoomComboBox.FindStringExact("100%");
            this.ActiveControl = ImageBox;
        }

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
            // disable interpolation (sharper pixels)
            e.Graphics.InterpolationMode = InterpolationMode.NearestNeighbor;
            // https://msdn.microsoft.com/en-us/library/ms142046(v=vs.110).aspx
            e.Graphics.DrawImage(image,
                new Rectangle(0, 0, ImageBox.Width, ImageBox.Height),
                0, 0, image.Width, image.Height, GraphicsUnit.Pixel);
        }

        #region IMAGE FUNCTIONS

        private void LoadImage(string path)
        {
            image = Image.FromFile(path);
            ImageBox.Width = (int)(image.Width * zoom);
            ImageBox.Height = (int)(image.Height * zoom);
            ImageBox.Image = image;
            CenterImage();
        }

        private void CenterImage()
        {
            ImageBox.Left = (BottomPanel.Width / 2) - (ImageBox.Width / 2);
            ImageBox.Top = (BottomPanel.Height / 2) - (ImageBox.Height / 2);
        }

        private void ScaleImage()
        {
            ImageBox.Image = null;
            ImageBox.Width = (int)(image.Width * zoom);
            ImageBox.Height = (int)(image.Height * zoom);
            ImageBox.Image = image;
            CenterImage();
        }

        private void ActualPixels()
        {
            zoom = 1;
            ZoomComboBox.SelectedIndex = ZoomComboBox.FindStringExact("100%");
            ScaleImage();
            ImageBox.Focus();
        }

        private void FitScreen()
        {
            float ratio = (float)BottomPanel.Width / (float)image.Width;
            float newHeight = image.Height * ratio;
            if (newHeight < BottomPanel.Height)
            {
                zoom = ratio;
            }
            else
            {
                zoom = (float)BottomPanel.Height / (float)image.Height;
            }
            ZoomComboBox.ResetText();
            ZoomComboBox.SelectedText = (zoom * 100).ToString("0.00") + "%";
            ScaleImage();
            ImageBox.Focus();
        }

        private void FillScreen()
        {
            float ratio = (float)BottomPanel.Width / (float)image.Width;
            float newHeight = image.Height * ratio;
            if (newHeight > BottomPanel.Height)
            {
                zoom = ratio;
            }
            else
            {
                zoom = (float)BottomPanel.Height / (float)image.Height;
            }
            ZoomComboBox.ResetText();
            ZoomComboBox.SelectedText = (zoom * 100).ToString("0.00") + "%";
            ScaleImage();
            ImageBox.Focus();
        }

        #endregion

        #region FOCUS EVENTS

        private void BottomPanel_MouseEnter(object sender, EventArgs e)
        {
            ImageBox.Focus();
        }

        private void ImageBox_MouseEnter(object sender, EventArgs e)
        {
            ImageBox.Focus();
        }

        #endregion

        #region ZOOM EVENTS

        private void ZoomComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string text = ZoomComboBox.SelectedItem.ToString();
            var match = Regex.Match(text, @"([-+]?[0-9]*\.?[0-9]+)");
            if (match.Success)
            {
                zoom = float.Parse(match.Groups[1].Value) / 100;
                ScaleImage();
            }
            ImageBox.Focus();
        }

        private void ActualPixelsButton_Click(object sender, EventArgs e)
        {
            ActualPixels();
        }

        private void FitScreenButton_Click(object sender, EventArgs e)
        {
            FitScreen();
        }

        private void FillScreenButton_Click(object sender, EventArgs e)
        {
            FillScreen();
        }

        private void FullScreenButton_Click(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            BottomPanel.BackColor = Color.Black;
            FitScreen();
        }

        private void ImageBox_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
            {
                zoom *= 1.1f;
                if (zoom > zoomMax) { zoom /= 1.1f; }
            }
            else
            {
                zoom /= 1.1f;
                if (zoom < zoomMin) { zoom *= 1.1f; }
            }
            ZoomComboBox.ResetText();
            ZoomComboBox.SelectedText = (zoom * 100).ToString("0.00") + "%";
            ScaleImage();
        }

        #endregion
    }
}
