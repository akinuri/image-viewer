﻿using System;
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
        string zoomMode = null;
        Image image = null;

        public MainForm(string[] args)
        {
            InitializeComponent();
            this.ImageBox.MouseWheel += ImageBox_MouseWheel;
            if (args.Length > 0)
            {
                LoadImage(args[0]);
            }
            else
            {
                LoadImage(ImageViewer.Properties.Resources.no_image);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ZoomComboBox.SelectedIndex = ZoomComboBox.FindStringExact("100%");
            this.ActiveControl = ImageBox;
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            CenterImage();
        }


        /* ==================== IMAGE INPUT ==================== */

        private void BottomPanel_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void BottomPanel_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            LoadImage(files[0]);
        }


        /* ==================== IMAGE DRAW ==================== */

        private void ImageBox_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.InterpolationMode = InterpolationMode.NearestNeighbor;

            int addW = ImageBox.Width / (image.Width * 2);
            int addH = ImageBox.Height / (image.Height * 2);

            //int addW = ImageBox.Width / 200;
            //int addH = ImageBox.Height / 232;

            e.Graphics.DrawImage(image, new Rectangle(0, 0, ImageBox.Width + addW, ImageBox.Height + addH), 0, 0, image.Width, image.Height, GraphicsUnit.Pixel);
            //e.Graphics.DrawImage(image, new Rectangle(0, 0, ImageBox.Width, ImageBox.Height), 0, 0, image.Width, image.Height, GraphicsUnit.Pixel);
        }


        /* ==================== IMAGE FUNCTIONS ==================== */

        private void LoadImage(dynamic input)
        {
            if (input is string)
            {
                image = Image.FromFile(input);
            }
            else if (input is Bitmap)
            {
                image = input;
            }
            if (image.Width > BottomPanel.Width || image.Height > BottomPanel.Height)
            {
                FitScreen();
            }
            else
            {
                ActualPixels();
            }
        }

        private void ScaleImage()
        {
            ImageBox.Image = null;
            ImageBox.Width = (int)Math.Round((float)image.Width * zoom);
            ImageBox.Height = (int)Math.Round((float)image.Height * zoom);
            ImageBox.Image = image;
            CenterImage();
        }

        private void CenterImage()
        {
            if (zoomMode == "FitScreen")
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
        }

        private void ActualPixels()
        {
            zoomMode = "ActualPixels";
            zoom = 1;
            ScaleImage();
            ZoomComboBox.SelectedIndex = ZoomComboBox.FindStringExact("100%");
            ImageBox.Focus();
        }

        private void FitScreen()
        {
            zoomMode = "FitScreen";
            float ratio = (float)BottomPanel.Width / (float)image.Width;
            float newHeight = (float)image.Height * ratio;
            if (newHeight < (float)BottomPanel.Height)
            {
                zoom = ratio;
            }
            else
            {
                zoom = (float)BottomPanel.Height / (float)image.Height;
            }
            ScaleImage();
            ZoomComboBox.ResetText();
            ZoomComboBox.SelectedText = (zoom * 100).ToString("0.00") + "%";
            ImageBox.Focus();
        }

        private void FillScreen()
        {
            zoomMode = "FillScreen";
            float ratio = (float)BottomPanel.Width / (float)image.Width;
            float newHeight = (float)image.Height * ratio;
            if (newHeight > (float)BottomPanel.Height)
            {
                zoom = ratio;
            }
            else
            {
                zoom = (float)BottomPanel.Height / (float)image.Height;
            }
            ScaleImage();
            ZoomComboBox.ResetText();
            ZoomComboBox.SelectedText = (zoom * 100).ToString("0.00") + "%";
            ImageBox.Focus();
        }


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
                zoom = float.Parse(match.Groups[1].Value) / (float)100;
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
            zoomMode = null;
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
            ScaleImage();
            ZoomComboBox.ResetText();
            ZoomComboBox.SelectedText = (zoom * 100).ToString("0.00") + "%";
        }

        #endregion
    }
}