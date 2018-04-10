using System.Drawing;
using System.Windows.Forms;
using VideoToAviConverter.Properties;
namespace VideoToAviConverter
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
            this._browseInputButton = new System.Windows.Forms.Button();
            this._browseOutputButton = new System.Windows.Forms.Button();
            this._outputPathTextBox = new System.Windows.Forms.TextBox();
            this._inputPathTextBox = new System.Windows.Forms.TextBox();
            this._startButton = new System.Windows.Forms.Button();
            this._stopButton = new System.Windows.Forms.Button();
            this._timer = new System.Windows.Forms.Timer(this.components);
            this._openVideoButton = new System.Windows.Forms.Button();
            this.Facebook_Btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.convertedAVIFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.convertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.convertToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.abortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homepageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facebookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._outFormat_Cb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._gPanel = new GradientPanel.GradientPanel();
            this.button4 = new System.Windows.Forms.Button();
            this.twitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _browseInputButton
            // 
            this._browseInputButton.BackgroundImage = global::VideoToAviConverter.Properties.Resources.browse2_btn;
            this._browseInputButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this._browseInputButton.FlatAppearance.BorderSize = 0;
            this._browseInputButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._browseInputButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._browseInputButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this._browseInputButton.Location = new System.Drawing.Point(480, 84);
            this._browseInputButton.Name = "_browseInputButton";
            this._browseInputButton.Size = new System.Drawing.Size(100, 32);
            this._browseInputButton.TabIndex = 0;
            this._browseInputButton.UseVisualStyleBackColor = false;
            this._browseInputButton.MouseLeave += new System.EventHandler(this._browseInputButton_MouseLeave);
            this._browseInputButton.Click += new System.EventHandler(this._browseInputButton_Click);
            this._browseInputButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this._browseInputButton_MouseDown);
            this._browseInputButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this._browseInputButton_MouseUp);
            this._browseInputButton.MouseEnter += new System.EventHandler(this._browseInputButton_MouseEnter);
            // 
            // _browseOutputButton
            // 
            this._browseOutputButton.BackgroundImage = global::VideoToAviConverter.Properties.Resources.browse2_btn;
            this._browseOutputButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this._browseOutputButton.FlatAppearance.BorderSize = 0;
            this._browseOutputButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._browseOutputButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._browseOutputButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this._browseOutputButton.Location = new System.Drawing.Point(480, 130);
            this._browseOutputButton.Name = "_browseOutputButton";
            this._browseOutputButton.Size = new System.Drawing.Size(100, 32);
            this._browseOutputButton.TabIndex = 1;
            this._browseOutputButton.UseVisualStyleBackColor = false;
            this._browseOutputButton.MouseLeave += new System.EventHandler(this._browseOutputButton_MouseLeave);
            this._browseOutputButton.Click += new System.EventHandler(this._browseOutputButton_Click);
            this._browseOutputButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this._browseOutputButton_MouseDown);
            this._browseOutputButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this._browseOutputButton_MouseUp);
            this._browseOutputButton.MouseEnter += new System.EventHandler(this._browseOutputButton_MouseEnter);
            // 
            // _outputPathTextBox
            // 
            this._outputPathTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this._outputPathTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._outputPathTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._outputPathTextBox.ForeColor = System.Drawing.Color.Green;
            this._outputPathTextBox.Location = new System.Drawing.Point(54, 139);
            this._outputPathTextBox.Name = "_outputPathTextBox";
            this._outputPathTextBox.Size = new System.Drawing.Size(407, 15);
            this._outputPathTextBox.TabIndex = 2;
            this._outputPathTextBox.Text = "Converted File";
            // 
            // _inputPathTextBox
            // 
            this._inputPathTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this._inputPathTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._inputPathTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._inputPathTextBox.ForeColor = System.Drawing.Color.Green;
            this._inputPathTextBox.Location = new System.Drawing.Point(54, 93);
            this._inputPathTextBox.Name = "_inputPathTextBox";
            this._inputPathTextBox.Size = new System.Drawing.Size(407, 15);
            this._inputPathTextBox.TabIndex = 3;
            this._inputPathTextBox.Text = "Input Video File";
            // 
            // _startButton
            // 
            this._startButton.BackgroundImage = global::VideoToAviConverter.Properties.Resources.convert_btn;
            this._startButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this._startButton.FlatAppearance.BorderSize = 0;
            this._startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._startButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this._startButton.Location = new System.Drawing.Point(480, 249);
            this._startButton.Name = "_startButton";
            this._startButton.Size = new System.Drawing.Size(100, 32);
            this._startButton.TabIndex = 4;
            this._startButton.UseVisualStyleBackColor = false;
            this._startButton.MouseLeave += new System.EventHandler(this._startButton_MouseLeave);
            this._startButton.Click += new System.EventHandler(this._startButton_Click);
            this._startButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this._startButton_MouseDown);
            this._startButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this._startButton_MouseUp);
            this._startButton.MouseEnter += new System.EventHandler(this._startButton_MouseEnter);
            // 
            // _stopButton
            // 
            this._stopButton.BackgroundImage = global::VideoToAviConverter.Properties.Resources.abort_btn;
            this._stopButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this._stopButton.FlatAppearance.BorderSize = 0;
            this._stopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._stopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._stopButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this._stopButton.Location = new System.Drawing.Point(374, 249);
            this._stopButton.Name = "_stopButton";
            this._stopButton.Size = new System.Drawing.Size(100, 32);
            this._stopButton.TabIndex = 5;
            this._stopButton.UseVisualStyleBackColor = false;
            this._stopButton.MouseLeave += new System.EventHandler(this._stopButton_MouseLeave);
            this._stopButton.Click += new System.EventHandler(this._stopButton_Click);
            this._stopButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this._stopButton_MouseDown);
            this._stopButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this._stopButton_MouseUp);
            this._stopButton.MouseEnter += new System.EventHandler(this._stopButton_MouseEnter);
            // 
            // _timer
            // 
            this._timer.Tick += new System.EventHandler(this._timer_Tick);
            // 
            // _openVideoButton
            // 
            this._openVideoButton.BackgroundImage = global::VideoToAviConverter.Properties.Resources.open_btn;
            this._openVideoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this._openVideoButton.FlatAppearance.BorderSize = 0;
            this._openVideoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._openVideoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._openVideoButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this._openVideoButton.Location = new System.Drawing.Point(248, 249);
            this._openVideoButton.Name = "_openVideoButton";
            this._openVideoButton.Size = new System.Drawing.Size(120, 32);
            this._openVideoButton.TabIndex = 7;
            this._openVideoButton.UseVisualStyleBackColor = false;
            this._openVideoButton.MouseLeave += new System.EventHandler(this._openVideoButton_MouseLeave);
            this._openVideoButton.Click += new System.EventHandler(this._openVideoButton_Click);
            this._openVideoButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this._openVideoButton_MouseDown);
            this._openVideoButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this._openVideoButton_MouseUp);
            this._openVideoButton.MouseEnter += new System.EventHandler(this._openVideoButton_MouseEnter);
            // 
            // Facebook_Btn
            // 
            this.Facebook_Btn.BackColor = System.Drawing.SystemColors.Menu;
            this.Facebook_Btn.Image = ((System.Drawing.Image)(resources.GetObject("Facebook_Btn.Image")));
            this.Facebook_Btn.Location = new System.Drawing.Point(15, 245);
            this.Facebook_Btn.Name = "Facebook_Btn";
            this.Facebook_Btn.Size = new System.Drawing.Size(40, 40);
            this.Facebook_Btn.TabIndex = 15;
            this.Facebook_Btn.UseVisualStyleBackColor = false;
            this.Facebook_Btn.Click += new System.EventHandler(this.Facebook_Btn_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::VideoToAviConverter.Properties.Resources._001_07;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Enabled = false;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(534, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 24);
            this.button1.TabIndex = 18;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::VideoToAviConverter.Properties.Resources._001_51;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(504, 11);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(24, 24);
            this.button2.TabIndex = 19;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::VideoToAviConverter.Properties.Resources._001_05;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(564, 11);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(24, 24);
            this.button3.TabIndex = 20;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.convertToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(7, 42);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(271, 30);
            this.menuStrip1.Stretch = false;
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.convertedAVIFileToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.LightGreen;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 25);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.openToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.openToolStripMenuItem.Text = "Open Input File...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // convertedAVIFileToolStripMenuItem
            // 
            this.convertedAVIFileToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.convertedAVIFileToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.convertedAVIFileToolStripMenuItem.Name = "convertedAVIFileToolStripMenuItem";
            this.convertedAVIFileToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.convertedAVIFileToolStripMenuItem.Text = "Converted File...";
            this.convertedAVIFileToolStripMenuItem.Click += new System.EventHandler(this.convertedAVIFileToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.exitToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // convertToolStripMenuItem
            // 
            this.convertToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.convertToolStripMenuItem1,
            this.abortToolStripMenuItem});
            this.convertToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.convertToolStripMenuItem.ForeColor = System.Drawing.Color.LightGreen;
            this.convertToolStripMenuItem.Name = "convertToolStripMenuItem";
            this.convertToolStripMenuItem.Size = new System.Drawing.Size(77, 25);
            this.convertToolStripMenuItem.Text = "Convert";
            // 
            // convertToolStripMenuItem1
            // 
            this.convertToolStripMenuItem1.BackColor = System.Drawing.Color.White;
            this.convertToolStripMenuItem1.Name = "convertToolStripMenuItem1";
            this.convertToolStripMenuItem1.Size = new System.Drawing.Size(135, 26);
            this.convertToolStripMenuItem1.Text = "Convert";
            this.convertToolStripMenuItem1.Click += new System.EventHandler(this.convertToolStripMenuItem1_Click);
            // 
            // abortToolStripMenuItem
            // 
            this.abortToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.abortToolStripMenuItem.Name = "abortToolStripMenuItem";
            this.abortToolStripMenuItem.Size = new System.Drawing.Size(135, 26);
            this.abortToolStripMenuItem.Text = "Abort";
            this.abortToolStripMenuItem.Click += new System.EventHandler(this.abortToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.homepageToolStripMenuItem,
            this.facebookToolStripMenuItem,
            this.twitterToolStripMenuItem});
            this.helpToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.helpToolStripMenuItem.ForeColor = System.Drawing.Color.LightGreen;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(54, 25);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(156, 26);
            this.aboutToolStripMenuItem.Text = "About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // homepageToolStripMenuItem
            // 
            this.homepageToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.homepageToolStripMenuItem.Name = "homepageToolStripMenuItem";
            this.homepageToolStripMenuItem.Size = new System.Drawing.Size(156, 26);
            this.homepageToolStripMenuItem.Text = "Homepage";
            this.homepageToolStripMenuItem.Click += new System.EventHandler(this.homepageToolStripMenuItem_Click);
            // 
            // facebookToolStripMenuItem
            // 
            this.facebookToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.facebookToolStripMenuItem.Name = "facebookToolStripMenuItem";
            this.facebookToolStripMenuItem.Size = new System.Drawing.Size(156, 26);
            this.facebookToolStripMenuItem.Text = "Facebook";
            this.facebookToolStripMenuItem.Click += new System.EventHandler(this.facebookToolStripMenuItem_Click);
            // 
            // _outFormat_Cb
            // 
            this._outFormat_Cb.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._outFormat_Cb.ForeColor = System.Drawing.Color.Green;
            this._outFormat_Cb.FormattingEnabled = true;
            this._outFormat_Cb.Location = new System.Drawing.Point(207, 175);
            this._outFormat_Cb.Name = "_outFormat_Cb";
            this._outFormat_Cb.Size = new System.Drawing.Size(258, 27);
            this._outFormat_Cb.TabIndex = 22;
            this._outFormat_Cb.SelectedIndexChanged += new System.EventHandler(this._outFormat_Cb_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(15, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 23);
            this.label1.TabIndex = 23;
            this.label1.Text = "Select Output Format:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(180, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 26);
            this.label2.TabIndex = 24;
            this.label2.Text = "Free Video Converter";
            // 
            // _gPanel
            // 
            this._gPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._gPanel.GradientLabelColor = System.Drawing.Color.Empty;
            this._gPanel.GradientLabelFont = null;
            this._gPanel.Location = new System.Drawing.Point(15, 212);
            this._gPanel.Name = "_gPanel";
            this._gPanel.Size = new System.Drawing.Size(565, 27);
            this._gPanel.TabIndex = 25;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.Menu;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(61, 245);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(40, 40);
            this.button4.TabIndex = 26;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // twitterToolStripMenuItem
            // 
            this.twitterToolStripMenuItem.Name = "twitterToolStripMenuItem";
            this.twitterToolStripMenuItem.Size = new System.Drawing.Size(156, 26);
            this.twitterToolStripMenuItem.Text = "Twitter";
            this.twitterToolStripMenuItem.Click += new System.EventHandler(this.twitterToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(599, 300);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._outFormat_Cb);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this._gPanel);
            this.Controls.Add(this.Facebook_Btn);
            this.Controls.Add(this._openVideoButton);
            this.Controls.Add(this._stopButton);
            this.Controls.Add(this._startButton);
            this.Controls.Add(this._inputPathTextBox);
            this.Controls.Add(this._outputPathTextBox);
            this.Controls.Add(this._browseOutputButton);
            this.Controls.Add(this._browseInputButton);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Free Video Converter";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button _browseInputButton;
		private System.Windows.Forms.Button _browseOutputButton;
		private System.Windows.Forms.TextBox _outputPathTextBox;
		private System.Windows.Forms.TextBox _inputPathTextBox;
		private System.Windows.Forms.Button _startButton;
        private System.Windows.Forms.Button _stopButton;
		private System.Windows.Forms.Timer _timer;
        private System.Windows.Forms.Button _openVideoButton;
        private System.Windows.Forms.Button Facebook_Btn;
        private GradientPanel.GradientPanel _gPanel;
        private Button button1;
        private Button button2;
        private Button button3;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem convertedAVIFileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem convertToolStripMenuItem;
        private ToolStripMenuItem convertToolStripMenuItem1;
        private ToolStripMenuItem abortToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem homepageToolStripMenuItem;
        private ToolStripMenuItem facebookToolStripMenuItem;
        private ComboBox _outFormat_Cb;
        private Label label1;
        private Label label2;
        private Button button4;
        private ToolStripMenuItem twitterToolStripMenuItem;
	}
}

