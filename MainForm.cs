using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using ConverterLib;
using System.Threading;
using VideoToAviConverter.Properties;

namespace VideoToAviConverter
{
	public partial class MainForm : Form
	{
		private Converter _converter;
		private bool _isRun;
		private string _outputPath;
        private Point lastPoint = Point.Empty;

        private const string HOMEPAGE = "http://www.soft-for-free.com";
        private const string COMPANY_DIRECTORY = "Soft-For-Free.com";
        private const string YOUTUBE_URL = "http://www.youtube.com/user/cameratunersoft";
        private const string FACEBOOK_URL = "https://www.facebook.com/pages/Soft-For-Free/448710121915677";
        private static int[] RGB_TRANS_MASK = { 230, 240, 250 };
        private const string TWITTER_URL = "https://twitter.com/intent/tweet?url=http%3A%2F%2Fsoft-for-free.com&via=KennyRojersJr&text=Free%20software%20for%20downloading%20video%20and%20Mp3%20from%20YouTube%2C%20Facebook%2C%20e.t.c.&";


        public enum VideoFormats
        { 
            MP3,
            MP4,
            AVI,
            FLV
        }

		public MainForm()
		{
			InitializeComponent();
			//_doneLabel.Visible = false;
			_openVideoButton.Visible = false;

            _gPanel.SetGradientColors(Color.Green, Color.LightGreen);
            _gPanel.ForeColor = Color.Black;

            this.FormBorderStyle = FormBorderStyle.None;
            this.Width = this.BackgroundImage.Width;
            this.Height = this.BackgroundImage.Height;
            this.TransparencyKey = Color.FromArgb(RGB_TRANS_MASK[0], RGB_TRANS_MASK[1],
                RGB_TRANS_MASK[2]);

            loadQualities();
		}

        private void loadQualities()
        {
            try
            {
                _outFormat_Cb.Items.Add(VideoFormats.MP3);
                _outFormat_Cb.Items.Add(VideoFormats.MP4);
                _outFormat_Cb.Items.Add(VideoFormats.AVI);
                _outFormat_Cb.Items.Add(VideoFormats.FLV);
                _outFormat_Cb.SelectedIndex = 0;
                _outFormat_Cb.Update();
            }
            catch
            { }
        }

        private void initGradientPanel()
        {
            _gPanel = new GradientPanel.GradientPanel();
            _gPanel.BackColor = System.Drawing.Color.White;
            _gPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            _gPanel.GradientLabelColor = System.Drawing.Color.Empty;
            _gPanel.GradientLabelFont = null;
            _gPanel.Location = new System.Drawing.Point(15, 212);
            _gPanel.Name = "_gPanel";
            _gPanel.Size = new System.Drawing.Size(565, 27);
            _gPanel.SetGradientColors(Color.GreenYellow, Color.Lime);
            _gPanel.ForeColor = Color.Black;
        }

		private void _browseOutputButton_Click(object sender, EventArgs e)
		{
			try
			{
				SaveFileDialog saveFileDialog = new SaveFileDialog();
				saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                if ((_outFormat_Cb.SelectedItem.ToString()).Contains("MP3"))
                    saveFileDialog.Filter = "mp3 files (*.mp3)|*.mp3";
                else if ((_outFormat_Cb.SelectedItem.ToString()).Contains("MP4"))
                    saveFileDialog.Filter = "mp4 files (*.mp4)|*.mp4";
                else if ((_outFormat_Cb.SelectedItem.ToString()).Contains("AVI"))
                    saveFileDialog.Filter = "avi files (*.avi)|*.avi";
                else if ((_outFormat_Cb.SelectedItem.ToString()).Contains("FLV"))
                    saveFileDialog.Filter = "flv files (*.flv)|*.flv";
                else if ((_outFormat_Cb.SelectedItem.ToString()).Contains("3GP"))
                    saveFileDialog.Filter = "3gp files (*.3gp)|*.3gp";
				
                saveFileDialog.RestoreDirectory = true;

				if (saveFileDialog.ShowDialog() == DialogResult.OK && !string.IsNullOrEmpty(saveFileDialog.FileName))
				{
					_outputPathTextBox.Text = saveFileDialog.FileName;
				}
			}
			catch
			{
				MessageBox.Show("Can't set a output path",
				   "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void _browseInputButton_Click(object sender, EventArgs e)
		{
			Stream myStream = null;
			OpenFileDialog openFileDialog = new OpenFileDialog();

			openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
			openFileDialog.Filter = "all video files (*.*)|*.*";
			openFileDialog.RestoreDirectory = true;

			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
                try
                {
                    if ((myStream = openFileDialog.OpenFile()) != null)
                    {
                        _inputPathTextBox.Text = openFileDialog.FileName;
                        myStream.Close();

                        if (string.IsNullOrEmpty(_outputPathTextBox.Text) ||
                            _outputPathTextBox.Text.Equals("Converted File"))
                        {
                            if ((_outFormat_Cb.SelectedItem.ToString()).Contains("MP3"))
                            {
                                _outputPathTextBox.Text = string.Format(@"{0}\{1}\{2}.mp3",
                                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), COMPANY_DIRECTORY,
                                Path.GetFileNameWithoutExtension(_inputPathTextBox.Text));
                            }
                            else if ((_outFormat_Cb.SelectedItem.ToString()).Contains("MP4"))
                            {
                                _outputPathTextBox.Text = string.Format(@"{0}\{1}\{2}.mp4",
                                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), COMPANY_DIRECTORY,
                                Path.GetFileNameWithoutExtension(_inputPathTextBox.Text));
                            }
                            else if ((_outFormat_Cb.SelectedItem.ToString()).Contains("AVI"))
                            {
                                _outputPathTextBox.Text = string.Format(@"{0}\{1}\{2}.avi",
                                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), COMPANY_DIRECTORY,
                                Path.GetFileNameWithoutExtension(_inputPathTextBox.Text));
                            }
                            else if ((_outFormat_Cb.SelectedItem.ToString()).Contains("FLV"))
                            {
                                _outputPathTextBox.Text = string.Format(@"{0}\{1}\{2}.flv",
                                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), COMPANY_DIRECTORY,
                                Path.GetFileNameWithoutExtension(_inputPathTextBox.Text));
                            }
                            else if ((_outFormat_Cb.SelectedItem.ToString()).Contains("3GP"))
                            {
                                _outputPathTextBox.Text = string.Format(@"{0}\{1}\{2}.3gp",
                                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), COMPANY_DIRECTORY,
                                Path.GetFileNameWithoutExtension(_inputPathTextBox.Text));
                            }
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Can't set a input path",
                     "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
			}
		}

		private void _startButton_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(_inputPathTextBox.Text) || string.IsNullOrEmpty(_outputPathTextBox.Text))
			{
				MessageBox.Show("Specify the input and the output file path, please",
					 "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			try
			{
				if (!File.Exists(_inputPathTextBox.Text))
				{
					MessageBox.Show("Can't get the input file",
					 "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}
			}
			catch
			{
				MessageBox.Show("Can't get the input file",
					 "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			_isRun = true;
			_outputPath = _outputPathTextBox.Text;
			convert();
		}

		private void convert()
		{
			try
			{
				InputParameters iParam = new InputParameters();

                if ((_outFormat_Cb.SelectedItem.ToString()).Contains("MP3"))
                {
                    if (!_outputPathTextBox.Text.Substring(_outputPathTextBox.Text.Length - 4).Equals(".mp3"))
                        _outputPathTextBox.Text = _outputPathTextBox.Text + ".mp3";
                }
                else if ((_outFormat_Cb.SelectedItem.ToString()).Contains("MP4"))
                {
                    if (!_outputPathTextBox.Text.Substring(_outputPathTextBox.Text.Length - 4).Equals(".mp4"))
                        _outputPathTextBox.Text = _outputPathTextBox.Text + ".mp4";
                }
                else if ((_outFormat_Cb.SelectedItem.ToString()).Contains("AVI"))
                {
                    if (!_outputPathTextBox.Text.Substring(_outputPathTextBox.Text.Length - 4).Equals(".avi"))
                        _outputPathTextBox.Text = _outputPathTextBox.Text + ".avi";
                }
                else if ((_outFormat_Cb.SelectedItem.ToString()).Contains("FLV"))
                {
                    if (!_outputPathTextBox.Text.Substring(_outputPathTextBox.Text.Length - 4).Equals(".flv"))
                        _outputPathTextBox.Text = _outputPathTextBox.Text + ".flv";

                    iParam.OutputAudioCodec = "libfaac";
                    iParam.OutputVideoCodec = "libx264";
                }
                else if ((_outFormat_Cb.SelectedItem.ToString()).Contains("3GP"))
                {
                    if (!_outputPathTextBox.Text.Substring(_outputPathTextBox.Text.Length - 4).Equals(".3gp"))
                        _outputPathTextBox.Text = _outputPathTextBox.Text + ".3gp";

                    iParam.FrameHeight = 144;
                    iParam.FrameWidth = 176;
                    iParam.OutputVideoCodec = "h263";
                    iParam.OutputAudioCodec = "libfaac";
                }
                
                iParam.InputPath = _inputPathTextBox.Text;
				iParam.OutputPath = _outputPathTextBox.Text;
				iParam.Owerwrite = true;

				if (!Directory.Exists(Path.GetDirectoryName(_outputPath)))
					Directory.CreateDirectory(Path.GetDirectoryName(_outputPath));

				_converter = new Converter();
				_converter.convert(iParam);

				//_doneLabel.Visible = false;
				_openVideoButton.Visible = false;
				//_progressBar.Visible = true;
                _gPanel.Visible = true;

				_browseInputButton.Enabled = false;
                openToolStripMenuItem.Enabled = false;
				_browseOutputButton.Enabled = false;
                convertedAVIFileToolStripMenuItem.Enabled = false;
				_startButton.Enabled = false;
                convertToolStripMenuItem1.Enabled = false;

				_timer.Start();
			}
			catch
			{
				MessageBox.Show("Converting Error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				_browseInputButton.Enabled = true;
                openToolStripMenuItem.Enabled = true;
				_browseOutputButton.Enabled = true;
                convertedAVIFileToolStripMenuItem.Enabled = true;
				_startButton.Enabled = true;
                convertToolStripMenuItem1.Enabled = true;
				_isRun = false;
			}
		}

		private void _stopButton_Click(object sender, EventArgs e)
		{
			if (!_isRun)
				return;

			this.Text = "Stopped";
			_converter.KillFFmpegProcess();

			_timer.Stop();
			_isRun = false;
            //initGradientPanel();
            //_progressBar.Value = 0;
            _gPanel.SetProgress(100);
            _gPanel.Refresh();
			_converter = null;

			_browseInputButton.Enabled = true;
            openToolStripMenuItem.Enabled = true;
			_browseOutputButton.Enabled = true;
            convertedAVIFileToolStripMenuItem.Enabled = true;
			_startButton.Enabled = true;
            convertToolStripMenuItem1.Enabled = true;

			Thread.Sleep(1000);

			try
			{
				if (File.Exists(_outputPath))
					File.Delete(_outputPath);
			}
			catch
			{ }
		}

		private void _timer_Tick(object sender, EventArgs e)
		{
			try
			{
				if (_converter.Error)
				{
					_timer.Stop();
					//_progressBar.Value = 0;
                    _gPanel.SetProgress(0);
					_isRun = false;

					MessageBox.Show("Converting Error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					_browseInputButton.Enabled = true;
                    openToolStripMenuItem.Enabled = true;
					_browseOutputButton.Enabled = true;
                    convertedAVIFileToolStripMenuItem.Enabled = true;
					_startButton.Enabled = true;
                    convertToolStripMenuItem1.Enabled = true;
				}

				int progress = _converter.Progress;

				if (progress >= 0 && progress <= 100)
				{
					//_progressBar.Value = progress;
                    _gPanel.SetProgress(progress);
					this.Text = "Converting: " + progress + "%";
				}
				if (progress == -2)
				{
					_timer.Stop();
					this.Text = "Converting: 100%";
					_isRun = false;

					_browseInputButton.Enabled = true;
                    openToolStripMenuItem.Enabled = true;
					_browseOutputButton.Enabled = true;
                    convertedAVIFileToolStripMenuItem.Enabled = true;
					_startButton.Enabled = true;
                    convertToolStripMenuItem1.Enabled = true;

					//_progressBar.Value = 0;
                    _gPanel.SetProgress(100);
                    MessageBox.Show("Video successfully converted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //_progressBar.Visible = false;
                    //_gPanel.Visible = false;
					//_doneLabel.Visible = true;
					_openVideoButton.Visible = true;
				}
			}
			catch
			{
				if (_timer != null)
					_timer.Stop();

				_isRun = false;

				_browseInputButton.Enabled = true;
                openToolStripMenuItem.Enabled = true;
				_browseOutputButton.Enabled = true;
                convertedAVIFileToolStripMenuItem.Enabled = true;
				_startButton.Enabled = true;
                convertToolStripMenuItem1.Enabled = true;
				//_progressBar.Value = 0;
                _gPanel.SetProgress(0);

				MessageBox.Show("Converting Error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void _openVideoButton_Click(object sender, EventArgs e)
		{
			try
			{
				if (!File.Exists(_outputPath))
				{
					MessageBox.Show("Can't find the converted file",
				   "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

					return;
				}

				string argument = @"/select, " + _outputPath;
				System.Diagnostics.Process.Start("explorer.exe", argument);
			}
			catch
			{
				MessageBox.Show("Can't find the converted file",
				   "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}

		}

        private void youtube_Btn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(YOUTUBE_URL);
        }

        private void Facebook_Btn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(FACEBOOK_URL);
        }

        private void _browseInputButton_MouseEnter(object sender, EventArgs e)
        {
            _browseInputButton.Image = Resources.browse2_over_btn;
            _browseInputButton.Refresh();
        }

        private void _browseInputButton_MouseLeave(object sender, EventArgs e)
        {
            _browseInputButton.Image = Resources.browse2_btn;
            _browseInputButton.Refresh();
        }

        private void _browseInputButton_MouseUp(object sender, MouseEventArgs e)
        {
            _browseInputButton.Image = Resources.browse2_over_btn;
            _browseInputButton.Refresh();
        }

        private void _browseInputButton_MouseDown(object sender, MouseEventArgs e)
        {
            _browseInputButton.Image = Resources.browse2_click_btn;
            _browseInputButton.Refresh();
        }

        private void _stopButton_MouseDown(object sender, MouseEventArgs e)
        {
            _stopButton.Image = Resources.abort_click_btn;
            _startButton.Refresh();
        }

        private void _stopButton_MouseLeave(object sender, EventArgs e)
        {
            _stopButton.Image = Resources.abort_btn;
            _startButton.Refresh();
        }

        private void _stopButton_MouseUp(object sender, MouseEventArgs e)
        {
            _stopButton.Image = Resources.abort_over_btn;
            _startButton.Refresh();
        }

        private void _stopButton_MouseEnter(object sender, EventArgs e)
        {
            _stopButton.Image = Resources.abort_over_btn;
            _startButton.Refresh();
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _browseInputButton_Click(sender, e);
        }

        private void convertedAVIFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _browseOutputButton_Click(sender, e);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void convertToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            _startButton_Click(sender, e);
        }

        private void abortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _stopButton_Click(sender, e);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Visible = true;
        }

        private void homepageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(HOMEPAGE);
        }

        private void youtubeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(YOUTUBE_URL);
        }

        private void facebookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(FACEBOOK_URL);
        }

        private void _browseOutputButton_MouseDown(object sender, MouseEventArgs e)
        {
            _browseOutputButton.Image = Resources.browse2_click_btn;
            _browseOutputButton.Refresh();
        }

        private void _browseOutputButton_MouseEnter(object sender, EventArgs e)
        {
            _browseOutputButton.Image = Resources.browse2_over_btn;
            _browseOutputButton.Refresh();
        }

        private void _browseOutputButton_MouseLeave(object sender, EventArgs e)
        {
            _browseOutputButton.Image = Resources.browse2_btn;
            _browseOutputButton.Refresh();
        }

        private void _browseOutputButton_MouseUp(object sender, MouseEventArgs e)
        {
            _browseOutputButton.Image = Resources.browse2_over_btn;
            _browseOutputButton.Refresh();
        }

        private void _openVideoButton_MouseDown(object sender, MouseEventArgs e)
        {
            _openVideoButton.Image = Resources.open_click_btn;
            _openVideoButton.Refresh();
        }

        private void _openVideoButton_MouseEnter(object sender, EventArgs e)
        {
            _openVideoButton.Image = Resources.open_over_btn;
            _openVideoButton.Refresh();
        }

        private void _openVideoButton_MouseLeave(object sender, EventArgs e)
        {
            _openVideoButton.Image = Resources.open_btn;
            _openVideoButton.Refresh();
        }

        private void _openVideoButton_MouseUp(object sender, MouseEventArgs e)
        {
            _openVideoButton.Image = Resources.open_over_btn;
            _openVideoButton.Refresh();
        }

        private void _startButton_MouseDown(object sender, MouseEventArgs e)
        {
            _startButton.Image = Resources.convert_click_btn;
            _startButton.Refresh();
        }

        private void _startButton_MouseEnter(object sender, EventArgs e)
        {
            _startButton.Image = Resources.convert_over_btn;
            _startButton.Refresh();
        }

        private void _startButton_MouseLeave(object sender, EventArgs e)
        {
            _startButton.Image = Resources.convert_btn;
            _startButton.Refresh();
        }

        private void _startButton_MouseUp(object sender, MouseEventArgs e)
        {
            _startButton.Image = Resources.convert_over_btn;
            _startButton.Refresh();
        }

        private void _outFormat_Cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_outputPathTextBox.Text) || _outputPathTextBox.Text.Equals("Converted File"))
                return;

            if (_outFormat_Cb.SelectedItem.ToString().Contains("MP3"))
            {
                _outputPathTextBox.Text =
                    _outputPathTextBox.Text.Substring(0, 
                    _outputPathTextBox.Text.Length - 4) + ".mp3";
            }
            else if (_outFormat_Cb.SelectedItem.ToString().Contains("MP4"))
            {
                _outputPathTextBox.Text =
                   _outputPathTextBox.Text.Substring(0,
                   _outputPathTextBox.Text.Length - 4) + ".mp4";
            }
            else if (_outFormat_Cb.SelectedItem.ToString().Contains("AVI"))
            {
                _outputPathTextBox.Text =
                   _outputPathTextBox.Text.Substring(0,
                   _outputPathTextBox.Text.Length - 4) + ".avi";
            }
            else if (_outFormat_Cb.SelectedItem.ToString().Contains("FLV"))
            {
                _outputPathTextBox.Text =
                   _outputPathTextBox.Text.Substring(0,
                   _outputPathTextBox.Text.Length - 4) + ".flv";
            }
            else if (_outFormat_Cb.SelectedItem.ToString().Contains("3GP"))
            {
                _outputPathTextBox.Text =
                   _outputPathTextBox.Text.Substring(0,
                   _outputPathTextBox.Text.Length - 4) + ".3gp";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(TWITTER_URL);
        }

        private void twitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(TWITTER_URL);
        }



	}
}
