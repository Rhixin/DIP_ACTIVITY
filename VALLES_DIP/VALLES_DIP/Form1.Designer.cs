namespace VALLES_DIP
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            dIPToolStripMenuItem = new ToolStripMenuItem();
            pixelCopyToolStripMenuItem = new ToolStripMenuItem();
            grayscaleToolStripMenuItem = new ToolStripMenuItem();
            inversionToolStripMenuItem = new ToolStripMenuItem();
            histogramToolStripMenuItem = new ToolStripMenuItem();
            sepiaToolStripMenuItem = new ToolStripMenuItem();
            smoothingToolStripMenuItem = new ToolStripMenuItem();
            gaussianBlurToolStripMenuItem = new ToolStripMenuItem();
            sharpenToolStripMenuItem = new ToolStripMenuItem();
            meanRemovalToolStripMenuItem = new ToolStripMenuItem();
            embossingToolStripMenuItem = new ToolStripMenuItem();
            edgeDetectQuickToolStripMenuItem = new ToolStripMenuItem();
            edgeDetectHorizontalToolStripMenuItem = new ToolStripMenuItem();
            edgeDetectVerticalToolStripMenuItem = new ToolStripMenuItem();
            onToolStripMenuItem = new ToolStripMenuItem();
            offToolStripMenuItem = new ToolStripMenuItem();
            vIDEOToolStripMenuItem = new ToolStripMenuItem();
            grayscaleToolStripMenuItem1 = new ToolStripMenuItem();
            openFileDialog1 = new OpenFileDialog();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            saveFileDialog1 = new SaveFileDialog();
            trackBar1 = new TrackBar();
            label1 = new Label();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            openFileDialog2 = new OpenFileDialog();
            openFileDialog3 = new OpenFileDialog();
            button5 = new Button();
            saveFileDialog2 = new SaveFileDialog();
            timer1 = new System.Windows.Forms.Timer(components);
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, dIPToolStripMenuItem, onToolStripMenuItem, offToolStripMenuItem, vIDEOToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1449, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, saveToolStripMenuItem });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(37, 20);
            toolStripMenuItem1.Text = "File";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(103, 22);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click_1;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(103, 22);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // dIPToolStripMenuItem
            // 
            dIPToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { pixelCopyToolStripMenuItem, grayscaleToolStripMenuItem, inversionToolStripMenuItem, histogramToolStripMenuItem, sepiaToolStripMenuItem, smoothingToolStripMenuItem, gaussianBlurToolStripMenuItem, sharpenToolStripMenuItem, meanRemovalToolStripMenuItem, embossingToolStripMenuItem, edgeDetectQuickToolStripMenuItem, edgeDetectHorizontalToolStripMenuItem, edgeDetectVerticalToolStripMenuItem });
            dIPToolStripMenuItem.Name = "dIPToolStripMenuItem";
            dIPToolStripMenuItem.Size = new Size(37, 20);
            dIPToolStripMenuItem.Text = "DIP";
            // 
            // pixelCopyToolStripMenuItem
            // 
            pixelCopyToolStripMenuItem.Name = "pixelCopyToolStripMenuItem";
            pixelCopyToolStripMenuItem.Size = new Size(192, 22);
            pixelCopyToolStripMenuItem.Text = "pixel copy";
            pixelCopyToolStripMenuItem.Click += pixelCopyToolStripMenuItem_Click;
            // 
            // grayscaleToolStripMenuItem
            // 
            grayscaleToolStripMenuItem.Name = "grayscaleToolStripMenuItem";
            grayscaleToolStripMenuItem.Size = new Size(192, 22);
            grayscaleToolStripMenuItem.Text = "grayscale";
            grayscaleToolStripMenuItem.Click += grayscaleToolStripMenuItem_Click;
            // 
            // inversionToolStripMenuItem
            // 
            inversionToolStripMenuItem.Name = "inversionToolStripMenuItem";
            inversionToolStripMenuItem.Size = new Size(192, 22);
            inversionToolStripMenuItem.Text = "inversion";
            inversionToolStripMenuItem.Click += inversionToolStripMenuItem_Click;
            // 
            // histogramToolStripMenuItem
            // 
            histogramToolStripMenuItem.Name = "histogramToolStripMenuItem";
            histogramToolStripMenuItem.Size = new Size(192, 22);
            histogramToolStripMenuItem.Text = "histogram";
            histogramToolStripMenuItem.Click += histogramToolStripMenuItem_Click;
            // 
            // sepiaToolStripMenuItem
            // 
            sepiaToolStripMenuItem.Name = "sepiaToolStripMenuItem";
            sepiaToolStripMenuItem.Size = new Size(192, 22);
            sepiaToolStripMenuItem.Text = "sepia";
            sepiaToolStripMenuItem.Click += sepiaToolStripMenuItem_Click;
            // 
            // smoothingToolStripMenuItem
            // 
            smoothingToolStripMenuItem.Name = "smoothingToolStripMenuItem";
            smoothingToolStripMenuItem.Size = new Size(192, 22);
            smoothingToolStripMenuItem.Text = "smoothing";
            smoothingToolStripMenuItem.Click += smoothingToolStripMenuItem_Click;
            // 
            // gaussianBlurToolStripMenuItem
            // 
            gaussianBlurToolStripMenuItem.Name = "gaussianBlurToolStripMenuItem";
            gaussianBlurToolStripMenuItem.Size = new Size(192, 22);
            gaussianBlurToolStripMenuItem.Text = "gaussian blur";
            gaussianBlurToolStripMenuItem.Click += gaussianBlurToolStripMenuItem_Click;
            // 
            // sharpenToolStripMenuItem
            // 
            sharpenToolStripMenuItem.Name = "sharpenToolStripMenuItem";
            sharpenToolStripMenuItem.Size = new Size(192, 22);
            sharpenToolStripMenuItem.Text = "sharpen";
            sharpenToolStripMenuItem.Click += sharpenToolStripMenuItem_Click;
            // 
            // meanRemovalToolStripMenuItem
            // 
            meanRemovalToolStripMenuItem.Name = "meanRemovalToolStripMenuItem";
            meanRemovalToolStripMenuItem.Size = new Size(192, 22);
            meanRemovalToolStripMenuItem.Text = "mean removal";
            meanRemovalToolStripMenuItem.Click += meanRemovalToolStripMenuItem_Click;
            // 
            // embossingToolStripMenuItem
            // 
            embossingToolStripMenuItem.Name = "embossingToolStripMenuItem";
            embossingToolStripMenuItem.Size = new Size(192, 22);
            embossingToolStripMenuItem.Text = "embossing";
            embossingToolStripMenuItem.Click += embossingToolStripMenuItem_Click;
            // 
            // edgeDetectQuickToolStripMenuItem
            // 
            edgeDetectQuickToolStripMenuItem.Name = "edgeDetectQuickToolStripMenuItem";
            edgeDetectQuickToolStripMenuItem.Size = new Size(192, 22);
            edgeDetectQuickToolStripMenuItem.Text = "edge detect quick";
            edgeDetectQuickToolStripMenuItem.Click += edgeDetectQuickToolStripMenuItem_Click;
            // 
            // edgeDetectHorizontalToolStripMenuItem
            // 
            edgeDetectHorizontalToolStripMenuItem.Name = "edgeDetectHorizontalToolStripMenuItem";
            edgeDetectHorizontalToolStripMenuItem.Size = new Size(192, 22);
            edgeDetectHorizontalToolStripMenuItem.Text = "edge detect horizontal";
            edgeDetectHorizontalToolStripMenuItem.Click += edgeDetectHorizontalToolStripMenuItem_Click;
            // 
            // edgeDetectVerticalToolStripMenuItem
            // 
            edgeDetectVerticalToolStripMenuItem.Name = "edgeDetectVerticalToolStripMenuItem";
            edgeDetectVerticalToolStripMenuItem.Size = new Size(192, 22);
            edgeDetectVerticalToolStripMenuItem.Text = "edge detect vertical";
            edgeDetectVerticalToolStripMenuItem.Click += edgeDetectVerticalToolStripMenuItem_Click;
            // 
            // onToolStripMenuItem
            // 
            onToolStripMenuItem.Name = "onToolStripMenuItem";
            onToolStripMenuItem.Size = new Size(33, 20);
            onToolStripMenuItem.Text = "on";
            onToolStripMenuItem.Click += onToolStripMenuItem_Click;
            // 
            // offToolStripMenuItem
            // 
            offToolStripMenuItem.Name = "offToolStripMenuItem";
            offToolStripMenuItem.Size = new Size(34, 20);
            offToolStripMenuItem.Text = "off";
            offToolStripMenuItem.Click += offToolStripMenuItem_Click;
            // 
            // vIDEOToolStripMenuItem
            // 
            vIDEOToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { grayscaleToolStripMenuItem1 });
            vIDEOToolStripMenuItem.Name = "vIDEOToolStripMenuItem";
            vIDEOToolStripMenuItem.Size = new Size(52, 20);
            vIDEOToolStripMenuItem.Text = "VIDEO";
            // 
            // grayscaleToolStripMenuItem1
            // 
            grayscaleToolStripMenuItem1.Name = "grayscaleToolStripMenuItem1";
            grayscaleToolStripMenuItem1.Size = new Size(123, 22);
            grayscaleToolStripMenuItem1.Text = "grayscale";
            grayscaleToolStripMenuItem1.Click += grayscaleToolStripMenuItem1_Click_1;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.FileOk += openFileDialog1_FileOk_1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveCaption;
            pictureBox1.Location = new Point(305, 107);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(344, 313);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.ActiveCaption;
            pictureBox2.Location = new Point(827, 107);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(344, 313);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.FileOk += saveFileDialog1_FileOk;
            // 
            // trackBar1
            // 
            trackBar1.LargeChange = 3;
            trackBar1.Location = new Point(472, 56);
            trackBar1.Maximum = 150;
            trackBar1.Minimum = -150;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(509, 45);
            trackBar1.TabIndex = 3;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Window;
            label1.Location = new Point(472, 38);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 4;
            label1.Text = "Brightness";
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = SystemColors.ActiveCaption;
            pictureBox3.Location = new Point(70, 446);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(381, 333);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = SystemColors.ActiveCaption;
            pictureBox4.Location = new Point(543, 446);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(381, 333);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 6;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = SystemColors.ActiveCaption;
            pictureBox5.Location = new Point(1014, 446);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(381, 333);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 7;
            pictureBox5.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(180, 806);
            button1.Name = "button1";
            button1.Size = new Size(124, 36);
            button1.TabIndex = 8;
            button1.Text = "Load Image";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(675, 806);
            button2.Name = "button2";
            button2.Size = new Size(124, 36);
            button2.TabIndex = 9;
            button2.Text = "Load Background";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(1165, 806);
            button3.Name = "button3";
            button3.Size = new Size(124, 36);
            button3.TabIndex = 10;
            button3.Text = "Subtract";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // openFileDialog2
            // 
            openFileDialog2.FileName = "openFileDialog2";
            openFileDialog2.FileOk += openFileDialog2_FileOk;
            // 
            // openFileDialog3
            // 
            openFileDialog3.FileName = "openFileDialog3";
            openFileDialog3.FileOk += openFileDialog3_FileOk;
            // 
            // button5
            // 
            button5.BackColor = Color.Lime;
            button5.Location = new Point(1353, 806);
            button5.Name = "button5";
            button5.Size = new Size(42, 36);
            button5.TabIndex = 12;
            button5.Text = "Save";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // saveFileDialog2
            // 
            saveFileDialog2.FileOk += saveFileDialog2_FileOk;
            // 
            // timer1
            // 
            timer1.Interval = 1;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1449, 874);
            Controls.Add(button5);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(label1);
            Controls.Add(trackBar1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem dIPToolStripMenuItem;
        private ToolStripMenuItem pixelCopyToolStripMenuItem;
        private ToolStripMenuItem grayscaleToolStripMenuItem;
        private OpenFileDialog openFileDialog1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private SaveFileDialog saveFileDialog1;
        private ToolStripMenuItem inversionToolStripMenuItem;
        private ToolStripMenuItem histogramToolStripMenuItem;
        private TrackBar trackBar1;
        private Label label1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private Button button1;
        private Button button2;
        private Button button3;
        private OpenFileDialog openFileDialog2;
        private OpenFileDialog openFileDialog3;
        private ToolStripMenuItem sepiaToolStripMenuItem;
        private Button button5;
        private SaveFileDialog saveFileDialog2;
        private ToolStripMenuItem onToolStripMenuItem;
        private ToolStripMenuItem offToolStripMenuItem;
        private ToolStripMenuItem vIDEOToolStripMenuItem;
        private ToolStripMenuItem grayscaleToolStripMenuItem1;
        private System.Windows.Forms.Timer timer1;
        private ToolStripMenuItem smoothingToolStripMenuItem;
        private ToolStripMenuItem gaussianBlurToolStripMenuItem;
        private ToolStripMenuItem sharpenToolStripMenuItem;
        private ToolStripMenuItem meanRemovalToolStripMenuItem;
        private ToolStripMenuItem embossingToolStripMenuItem;
        private ToolStripMenuItem edgeDetectQuickToolStripMenuItem;
        private ToolStripMenuItem edgeDetectHorizontalToolStripMenuItem;
        private ToolStripMenuItem edgeDetectVerticalToolStripMenuItem;
    }
}
