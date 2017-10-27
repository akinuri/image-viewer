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
using System.IO;
using System.Runtime.InteropServices;
using System.Reflection;
using System.Diagnostics;

namespace ImageViewer
{
    public partial class MainForm : Form
    {
        Image InputImage = null;

        public class Zoom
        {
            public static float Factor = 1.2f;
            public static float Value = 1;
            public static float Min = 0.05f;
            public static float Max = 32;
            public static string Mode = null;
        }

        public static class Wheel
        {
            public static int Step = 50;
            public static string Mode = "Zoom";
        }

        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        private static extern IntPtr LoadCursorFromFile(string path);

        public class MyCursors
        {
            public static string Dir = Environment.ExpandEnvironmentVariables(@"%AppData%\ImageViewer\");

            public static class Pannable
            {
                public static string FileName = "pannable.cur";
                public static string Path = Dir + FileName;
                public static Cursor Cursor = null;
            }

            public class Panning
            {
                public static string FileName = "panning.cur";
                public static string Path = Dir + FileName;
                public static Cursor Cursor = null;
            }
        }

        public MainForm(string[] args)
        {
            InitializeComponent();

            this.ImageBox.MouseWheel += ImageBox_MouseWheel;

            Directory.CreateDirectory(MyCursors.Dir);

            if (!File.Exists(MyCursors.Pannable.Path))
                File.WriteAllBytes(MyCursors.Pannable.Path, ImageViewer.Properties.Resources.pannable);
            MyCursors.Pannable.Cursor = new Cursor(LoadCursorFromFile(MyCursors.Pannable.Path));

            if (!File.Exists(MyCursors.Panning.Path))
                File.WriteAllBytes(MyCursors.Panning.Path, ImageViewer.Properties.Resources.panning);
            MyCursors.Panning.Cursor = new Cursor(LoadCursorFromFile(MyCursors.Panning.Path));

            if (args.Length > 0)
                LoadImage(args[0]);
            else
                LoadImage(ImageViewer.Properties.Resources.no_image);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ZoomComboBox.SelectedIndex = ZoomComboBox.FindStringExact("100%");
            this.ActiveControl = ImageBox;

            ImageBox.MouseDown += PanMouseDown;
            ImageBox.MouseUp += PanMouseUp;
            BottomPanel.MouseDown += PanMouseDown;
            BottomPanel.MouseUp += PanMouseUp;
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (File.Exists(MyCursors.Pannable.Path))
                File.Delete(MyCursors.Pannable.Path);
            if (File.Exists(MyCursors.Panning.Path))
                File.Delete(MyCursors.Panning.Path);
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            CenterImage();
        }

        private void ImageBox_MouseWheel(object sender, MouseEventArgs e)
        {
            ZoomScroll(sender, e);
        }
    }
}