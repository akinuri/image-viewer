namespace ImageViewer
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.TopPanel = new System.Windows.Forms.Panel();
            this.TopPanelSeperator = new System.Windows.Forms.Label();
            this.RotateCWButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.RotateCCWButton = new System.Windows.Forms.Button();
            this.ZoomComboBox = new System.Windows.Forms.ComboBox();
            this.PreviousButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.ActualPixelsButton = new System.Windows.Forms.Button();
            this.FitScreenButton = new System.Windows.Forms.Button();
            this.FullScreenButton = new System.Windows.Forms.Button();
            this.FillScreenButton = new System.Windows.Forms.Button();
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.WheelModeContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.WheelModeItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WheelModeSeperator = new System.Windows.Forms.ToolStripSeparator();
            this.ZoomModeItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ScrollModeItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ImageBox = new System.Windows.Forms.PictureBox();
            this.ControlToolTips = new System.Windows.Forms.ToolTip(this.components);
            this.TopPanel.SuspendLayout();
            this.BottomPanel.SuspendLayout();
            this.WheelModeContextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TopPanel.BackColor = System.Drawing.SystemColors.Control;
            this.TopPanel.Controls.Add(this.TopPanelSeperator);
            this.TopPanel.Controls.Add(this.RotateCWButton);
            this.TopPanel.Controls.Add(this.DeleteButton);
            this.TopPanel.Controls.Add(this.RotateCCWButton);
            this.TopPanel.Controls.Add(this.ZoomComboBox);
            this.TopPanel.Controls.Add(this.PreviousButton);
            this.TopPanel.Controls.Add(this.NextButton);
            this.TopPanel.Controls.Add(this.ActualPixelsButton);
            this.TopPanel.Controls.Add(this.FitScreenButton);
            this.TopPanel.Controls.Add(this.FullScreenButton);
            this.TopPanel.Controls.Add(this.FillScreenButton);
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Margin = new System.Windows.Forms.Padding(0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(624, 33);
            this.TopPanel.TabIndex = 0;
            // 
            // TopPanelSeperator
            // 
            this.TopPanelSeperator.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TopPanelSeperator.BackColor = System.Drawing.SystemColors.ControlDark;
            this.TopPanelSeperator.Location = new System.Drawing.Point(0, 32);
            this.TopPanelSeperator.Name = "TopPanelSeperator";
            this.TopPanelSeperator.Size = new System.Drawing.Size(624, 1);
            this.TopPanelSeperator.TabIndex = 2;
            // 
            // RotateCWButton
            // 
            this.RotateCWButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RotateCWButton.AutoSize = true;
            this.RotateCWButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.RotateCWButton.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RotateCWButton.Image = global::ImageViewer.Properties.Resources.cw;
            this.RotateCWButton.Location = new System.Drawing.Point(563, 3);
            this.RotateCWButton.Name = "RotateCWButton";
            this.RotateCWButton.Size = new System.Drawing.Size(26, 26);
            this.RotateCWButton.TabIndex = 6;
            this.ControlToolTips.SetToolTip(this.RotateCWButton, "Rotate CW");
            this.RotateCWButton.UseVisualStyleBackColor = true;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteButton.AutoSize = true;
            this.DeleteButton.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DeleteButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DeleteButton.Image = global::ImageViewer.Properties.Resources.delete;
            this.DeleteButton.Location = new System.Drawing.Point(595, 3);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(26, 26);
            this.DeleteButton.TabIndex = 6;
            this.ControlToolTips.SetToolTip(this.DeleteButton, "Delete");
            this.DeleteButton.UseVisualStyleBackColor = true;
            // 
            // RotateCCWButton
            // 
            this.RotateCCWButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RotateCCWButton.AutoSize = true;
            this.RotateCCWButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.RotateCCWButton.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RotateCCWButton.Image = global::ImageViewer.Properties.Resources.ccw;
            this.RotateCCWButton.Location = new System.Drawing.Point(531, 3);
            this.RotateCCWButton.Name = "RotateCCWButton";
            this.RotateCCWButton.Size = new System.Drawing.Size(26, 26);
            this.RotateCCWButton.TabIndex = 6;
            this.ControlToolTips.SetToolTip(this.RotateCCWButton, "Rotate CCW");
            this.RotateCCWButton.UseVisualStyleBackColor = true;
            // 
            // ZoomComboBox
            // 
            this.ZoomComboBox.FormattingEnabled = true;
            this.ZoomComboBox.Items.AddRange(new object[] {
            "10%",
            "25%",
            "33.33%",
            "50%",
            "66.67%",
            "75%",
            "100%",
            "150%",
            "200%",
            "250%",
            "300%",
            "400%",
            "500%"});
            this.ZoomComboBox.Location = new System.Drawing.Point(6, 6);
            this.ZoomComboBox.Name = "ZoomComboBox";
            this.ZoomComboBox.Size = new System.Drawing.Size(72, 21);
            this.ZoomComboBox.TabIndex = 3;
            this.ZoomComboBox.SelectedIndexChanged += new System.EventHandler(this.ZoomComboBox_SelectedIndexChanged);
            // 
            // PreviousButton
            // 
            this.PreviousButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PreviousButton.AutoSize = true;
            this.PreviousButton.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PreviousButton.Image = global::ImageViewer.Properties.Resources.to_left;
            this.PreviousButton.Location = new System.Drawing.Point(288, 3);
            this.PreviousButton.Name = "PreviousButton";
            this.PreviousButton.Size = new System.Drawing.Size(26, 26);
            this.PreviousButton.TabIndex = 6;
            this.ControlToolTips.SetToolTip(this.PreviousButton, "Previous");
            this.PreviousButton.UseVisualStyleBackColor = true;
            // 
            // NextButton
            // 
            this.NextButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NextButton.AutoSize = true;
            this.NextButton.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.NextButton.Image = global::ImageViewer.Properties.Resources.to_right;
            this.NextButton.Location = new System.Drawing.Point(316, 3);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(26, 26);
            this.NextButton.TabIndex = 6;
            this.ControlToolTips.SetToolTip(this.NextButton, "Next");
            this.NextButton.UseVisualStyleBackColor = true;
            // 
            // ActualPixelsButton
            // 
            this.ActualPixelsButton.AutoSize = true;
            this.ActualPixelsButton.Image = global::ImageViewer.Properties.Resources.actual_pixels;
            this.ActualPixelsButton.Location = new System.Drawing.Point(84, 3);
            this.ActualPixelsButton.Name = "ActualPixelsButton";
            this.ActualPixelsButton.Size = new System.Drawing.Size(26, 26);
            this.ActualPixelsButton.TabIndex = 0;
            this.ControlToolTips.SetToolTip(this.ActualPixelsButton, "Actual Pixels");
            this.ActualPixelsButton.UseVisualStyleBackColor = true;
            this.ActualPixelsButton.Click += new System.EventHandler(this.ActualPixelsButton_Click);
            // 
            // FitScreenButton
            // 
            this.FitScreenButton.AutoSize = true;
            this.FitScreenButton.Image = global::ImageViewer.Properties.Resources.fit_screen;
            this.FitScreenButton.Location = new System.Drawing.Point(116, 3);
            this.FitScreenButton.Name = "FitScreenButton";
            this.FitScreenButton.Size = new System.Drawing.Size(26, 26);
            this.FitScreenButton.TabIndex = 0;
            this.ControlToolTips.SetToolTip(this.FitScreenButton, "Fit Screen");
            this.FitScreenButton.UseVisualStyleBackColor = true;
            this.FitScreenButton.Click += new System.EventHandler(this.FitScreenButton_Click);
            // 
            // FullScreenButton
            // 
            this.FullScreenButton.AutoSize = true;
            this.FullScreenButton.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FullScreenButton.Image = global::ImageViewer.Properties.Resources.full_screen;
            this.FullScreenButton.Location = new System.Drawing.Point(180, 3);
            this.FullScreenButton.Name = "FullScreenButton";
            this.FullScreenButton.Size = new System.Drawing.Size(26, 26);
            this.FullScreenButton.TabIndex = 6;
            this.ControlToolTips.SetToolTip(this.FullScreenButton, "Full Screen");
            this.FullScreenButton.UseVisualStyleBackColor = true;
            this.FullScreenButton.Click += new System.EventHandler(this.FullScreenButton_Click);
            // 
            // FillScreenButton
            // 
            this.FillScreenButton.AutoSize = true;
            this.FillScreenButton.Image = global::ImageViewer.Properties.Resources.fill_screen;
            this.FillScreenButton.Location = new System.Drawing.Point(148, 3);
            this.FillScreenButton.Name = "FillScreenButton";
            this.FillScreenButton.Size = new System.Drawing.Size(26, 26);
            this.FillScreenButton.TabIndex = 0;
            this.ControlToolTips.SetToolTip(this.FillScreenButton, "Fill Screen");
            this.FillScreenButton.UseVisualStyleBackColor = true;
            this.FillScreenButton.Click += new System.EventHandler(this.FillScreenButton_Click);
            // 
            // BottomPanel
            // 
            this.BottomPanel.AllowDrop = true;
            this.BottomPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BottomPanel.AutoScroll = true;
            this.BottomPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.BottomPanel.ContextMenuStrip = this.WheelModeContextMenu;
            this.BottomPanel.Controls.Add(this.ImageBox);
            this.BottomPanel.Location = new System.Drawing.Point(0, 33);
            this.BottomPanel.Margin = new System.Windows.Forms.Padding(0);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(624, 328);
            this.BottomPanel.TabIndex = 3;
            this.BottomPanel.Click += new System.EventHandler(this.BottomPanel_Click);
            this.BottomPanel.DragDrop += new System.Windows.Forms.DragEventHandler(this.BottomPanel_DragDrop);
            this.BottomPanel.DragEnter += new System.Windows.Forms.DragEventHandler(this.BottomPanel_DragEnter);
            // 
            // WheelModeContextMenu
            // 
            this.WheelModeContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.WheelModeItem,
            this.WheelModeSeperator,
            this.ZoomModeItem,
            this.ScrollModeItem});
            this.WheelModeContextMenu.Name = "contextMenuStrip1";
            this.WheelModeContextMenu.Size = new System.Drawing.Size(181, 98);
            this.WheelModeContextMenu.Text = "Mouse Wheel Mode";
            // 
            // WheelModeItem
            // 
            this.WheelModeItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.WheelModeItem.Enabled = false;
            this.WheelModeItem.Name = "WheelModeItem";
            this.WheelModeItem.Size = new System.Drawing.Size(180, 22);
            this.WheelModeItem.Text = "Mouse Wheel Mode";
            // 
            // WheelModeSeperator
            // 
            this.WheelModeSeperator.Name = "WheelModeSeperator";
            this.WheelModeSeperator.Size = new System.Drawing.Size(177, 6);
            // 
            // ZoomModeItem
            // 
            this.ZoomModeItem.Checked = true;
            this.ZoomModeItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ZoomModeItem.Name = "ZoomModeItem";
            this.ZoomModeItem.Size = new System.Drawing.Size(180, 22);
            this.ZoomModeItem.Text = "Zoom";
            // 
            // ScrollModeItem
            // 
            this.ScrollModeItem.Name = "ScrollModeItem";
            this.ScrollModeItem.Size = new System.Drawing.Size(180, 22);
            this.ScrollModeItem.Text = "Scroll";
            // 
            // ImageBox
            // 
            this.ImageBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ImageBox.BackColor = System.Drawing.Color.Red;
            this.ImageBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ImageBox.Image = ((System.Drawing.Image)(resources.GetObject("ImageBox.Image")));
            this.ImageBox.Location = new System.Drawing.Point(162, 64);
            this.ImageBox.Margin = new System.Windows.Forms.Padding(0);
            this.ImageBox.Name = "ImageBox";
            this.ImageBox.Size = new System.Drawing.Size(300, 200);
            this.ImageBox.TabIndex = 1;
            this.ImageBox.TabStop = false;
            this.ImageBox.Paint += new System.Windows.Forms.PaintEventHandler(this.ImageBox_Paint);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 361);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.BottomPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MinimumSize = new System.Drawing.Size(640, 400);
            this.Name = "MainForm";
            this.Text = "Image Viewer";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.BottomPanel.ResumeLayout(false);
            this.WheelModeContextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ImageBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.PictureBox ImageBox;
        private System.Windows.Forms.Button ActualPixelsButton;
        private System.Windows.Forms.Button FillScreenButton;
        private System.Windows.Forms.Button FitScreenButton;
        private System.Windows.Forms.ComboBox ZoomComboBox;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button PreviousButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Panel BottomPanel;
        private System.Windows.Forms.Button RotateCWButton;
        private System.Windows.Forms.Button RotateCCWButton;
        private System.Windows.Forms.Button FullScreenButton;
        private System.Windows.Forms.ToolTip ControlToolTips;
        private System.Windows.Forms.Label TopPanelSeperator;
        private System.Windows.Forms.ContextMenuStrip WheelModeContextMenu;
        private System.Windows.Forms.ToolStripMenuItem ZoomModeItem;
        private System.Windows.Forms.ToolStripMenuItem ScrollModeItem;
        private System.Windows.Forms.ToolStripSeparator WheelModeSeperator;
        private System.Windows.Forms.ToolStripMenuItem WheelModeItem;
    }
}

