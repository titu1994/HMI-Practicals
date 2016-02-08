namespace toh
{
	partial class GameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.usernameTextbox = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.moveCounterLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.moveCounter = new System.Windows.Forms.ToolStripStatusLabel();
            this.possibleToSolve = new System.Windows.Forms.ToolStripStatusLabel();
            this.hints = new System.Windows.Forms.RichTextBox();
            this.startBtn3 = new System.Windows.Forms.Button();
            this.helpBtn = new System.Windows.Forms.Button();
            this.restartBtn = new System.Windows.Forms.Button();
            this.startBtn4 = new System.Windows.Forms.Button();
            this.startBtn5 = new System.Windows.Forms.Button();
            this.startBtn6 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1323, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // usernameTextbox
            // 
            this.usernameTextbox.Location = new System.Drawing.Point(16, 538);
            this.usernameTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.usernameTextbox.Name = "usernameTextbox";
            this.usernameTextbox.Size = new System.Drawing.Size(163, 22);
            this.usernameTextbox.TabIndex = 6;
            this.usernameTextbox.Text = "Enter your name here";
            this.usernameTextbox.Visible = false;
            this.usernameTextbox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseClick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.moveCounterLabel,
            this.moveCounter,
            this.possibleToSolve});
            this.statusStrip1.Location = new System.Drawing.Point(0, 564);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1323, 25);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // moveCounterLabel
            // 
            this.moveCounterLabel.Name = "moveCounterLabel";
            this.moveCounterLabel.Size = new System.Drawing.Size(55, 20);
            this.moveCounterLabel.Text = "Moves:";
            // 
            // moveCounter
            // 
            this.moveCounter.Name = "moveCounter";
            this.moveCounter.Size = new System.Drawing.Size(0, 20);
            // 
            // possibleToSolve
            // 
            this.possibleToSolve.Name = "possibleToSolve";
            this.possibleToSolve.Size = new System.Drawing.Size(0, 20);
            // 
            // hints
            // 
            this.hints.Dock = System.Windows.Forms.DockStyle.Right;
            this.hints.Location = new System.Drawing.Point(1119, 24);
            this.hints.Margin = new System.Windows.Forms.Padding(4);
            this.hints.Name = "hints";
            this.hints.Size = new System.Drawing.Size(204, 540);
            this.hints.TabIndex = 9;
            this.hints.Text = "";
            this.hints.Visible = false;
            // 
            // startBtn3
            // 
            this.startBtn3.BackColor = System.Drawing.Color.LawnGreen;
            this.startBtn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.startBtn3.Location = new System.Drawing.Point(334, 213);
            this.startBtn3.Name = "startBtn3";
            this.startBtn3.Size = new System.Drawing.Size(146, 108);
            this.startBtn3.TabIndex = 10;
            this.startBtn3.Text = "3";
            this.startBtn3.UseVisualStyleBackColor = false;
            this.startBtn3.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // helpBtn
            // 
            this.helpBtn.BackColor = System.Drawing.Color.PaleTurquoise;
            this.helpBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.helpBtn.Location = new System.Drawing.Point(334, 456);
            this.helpBtn.Name = "helpBtn";
            this.helpBtn.Size = new System.Drawing.Size(234, 108);
            this.helpBtn.TabIndex = 11;
            this.helpBtn.Text = "Help!";
            this.helpBtn.UseVisualStyleBackColor = false;
            this.helpBtn.Visible = false;
            this.helpBtn.Click += new System.EventHandler(this.helpBtn_Click);
            // 
            // restartBtn
            // 
            this.restartBtn.BackColor = System.Drawing.Color.OrangeRed;
            this.restartBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.restartBtn.Location = new System.Drawing.Point(729, 456);
            this.restartBtn.Name = "restartBtn";
            this.restartBtn.Size = new System.Drawing.Size(234, 108);
            this.restartBtn.TabIndex = 12;
            this.restartBtn.Text = "Restart!";
            this.restartBtn.UseVisualStyleBackColor = false;
            this.restartBtn.Visible = false;
            this.restartBtn.Click += new System.EventHandler(this.restartBtn_Click);
            // 
            // startBtn4
            // 
            this.startBtn4.BackColor = System.Drawing.Color.Yellow;
            this.startBtn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.startBtn4.Location = new System.Drawing.Point(495, 213);
            this.startBtn4.Name = "startBtn4";
            this.startBtn4.Size = new System.Drawing.Size(146, 108);
            this.startBtn4.TabIndex = 13;
            this.startBtn4.Text = "4";
            this.startBtn4.UseVisualStyleBackColor = false;
            this.startBtn4.Click += new System.EventHandler(this.startBtn4_Click);
            // 
            // startBtn5
            // 
            this.startBtn5.BackColor = System.Drawing.Color.DarkOrange;
            this.startBtn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.startBtn5.Location = new System.Drawing.Point(656, 213);
            this.startBtn5.Name = "startBtn5";
            this.startBtn5.Size = new System.Drawing.Size(146, 108);
            this.startBtn5.TabIndex = 14;
            this.startBtn5.Text = "5";
            this.startBtn5.UseVisualStyleBackColor = false;
            this.startBtn5.Click += new System.EventHandler(this.startBtn5_Click);
            // 
            // startBtn6
            // 
            this.startBtn6.BackColor = System.Drawing.Color.Red;
            this.startBtn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.startBtn6.Location = new System.Drawing.Point(817, 213);
            this.startBtn6.Name = "startBtn6";
            this.startBtn6.Size = new System.Drawing.Size(146, 108);
            this.startBtn6.TabIndex = 15;
            this.startBtn6.Text = "6";
            this.startBtn6.UseVisualStyleBackColor = false;
            this.startBtn6.Click += new System.EventHandler(this.startButton6_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(352, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(565, 39);
            this.label1.TabIndex = 16;
            this.label1.Text = "Number of Disks to Start Game with:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(955, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 121);
            this.button1.TabIndex = 17;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GameForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1323, 589);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.startBtn6);
            this.Controls.Add(this.startBtn5);
            this.Controls.Add(this.startBtn4);
            this.Controls.Add(this.restartBtn);
            this.Controls.Add(this.helpBtn);
            this.Controls.Add(this.startBtn3);
            this.Controls.Add(this.hints);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.usernameTextbox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GameForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tower of Hanoi";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.DragOver += new System.Windows.Forms.DragEventHandler(this.Form2_DragOver);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TextBox usernameTextbox;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel moveCounterLabel;
        private System.Windows.Forms.ToolStripStatusLabel moveCounter;
        private System.Windows.Forms.ToolStripStatusLabel possibleToSolve;
        private System.Windows.Forms.RichTextBox hints;
        private System.Windows.Forms.Button startBtn3;
        private System.Windows.Forms.Button helpBtn;
        private System.Windows.Forms.Button restartBtn;
        private System.Windows.Forms.Button startBtn4;
        private System.Windows.Forms.Button startBtn5;
        private System.Windows.Forms.Button startBtn6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}