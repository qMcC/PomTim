namespace pomodorotimer
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.timerDisplay = new System.Windows.Forms.Label();
            this.playPauseButton = new System.Windows.Forms.PictureBox();
            this.musicChangeButton = new System.Windows.Forms.PictureBox();
            this.settingsButton = new System.Windows.Forms.PictureBox();
            this.alarmTimer = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playPauseButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicChangeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsButton)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Black;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.timerDisplay, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.playPauseButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.musicChangeButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.settingsButton, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(300, 227);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // timerDisplay
            // 
            this.timerDisplay.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.timerDisplay, 3);
            this.timerDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timerDisplay.Font = new System.Drawing.Font("Courier New", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerDisplay.ForeColor = System.Drawing.Color.Red;
            this.timerDisplay.Location = new System.Drawing.Point(3, 75);
            this.timerDisplay.Name = "timerDisplay";
            this.timerDisplay.Size = new System.Drawing.Size(294, 75);
            this.timerDisplay.TabIndex = 0;
            this.timerDisplay.Text = "24:24";
            this.timerDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.timerDisplay.Click += new System.EventHandler(this.timerDisplay_Click);
            // 
            // playPauseButton
            // 
            this.playPauseButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.playPauseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.playPauseButton.Image = ((System.Drawing.Image)(resources.GetObject("playPauseButton.Image")));
            this.playPauseButton.Location = new System.Drawing.Point(3, 3);
            this.playPauseButton.Name = "playPauseButton";
            this.playPauseButton.Size = new System.Drawing.Size(94, 69);
            this.playPauseButton.TabIndex = 1;
            this.playPauseButton.TabStop = false;
            this.playPauseButton.Click += new System.EventHandler(this.playPauseButton_Click);
            // 
            // musicChangeButton
            // 
            this.musicChangeButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.musicChangeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.musicChangeButton.Image = global::pomodorotimer.Properties.Resources.ButtonMusic;
            this.musicChangeButton.Location = new System.Drawing.Point(103, 3);
            this.musicChangeButton.Name = "musicChangeButton";
            this.musicChangeButton.Size = new System.Drawing.Size(94, 69);
            this.musicChangeButton.TabIndex = 2;
            this.musicChangeButton.TabStop = false;
            this.musicChangeButton.Click += new System.EventHandler(this.musicChangeButton_Click);
            // 
            // settingsButton
            // 
            this.settingsButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.settingsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settingsButton.Image = global::pomodorotimer.Properties.Resources.ButtonSettings;
            this.settingsButton.Location = new System.Drawing.Point(203, 3);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(94, 69);
            this.settingsButton.TabIndex = 3;
            this.settingsButton.TabStop = false;
            // 
            // alarmTimer
            // 
            this.alarmTimer.Interval = 1000;
            this.alarmTimer.Tick += new System.EventHandler(this.alarmTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 227);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PomTim";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playPauseButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicChangeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label timerDisplay;
        private System.Windows.Forms.PictureBox playPauseButton;
        private System.Windows.Forms.PictureBox musicChangeButton;
        private System.Windows.Forms.PictureBox settingsButton;
        private System.Windows.Forms.Timer alarmTimer;
    }
}

