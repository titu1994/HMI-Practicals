namespace HMI_1
{
    partial class SelectForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectForm));
            this.ExitBtn = new System.Windows.Forms.Button();
            this.SubtractionBtn = new System.Windows.Forms.Button();
            this.AdditionBtn = new System.Windows.Forms.Button();
            this.CountingBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.DarkOrange;
            this.ExitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.ForeColor = System.Drawing.Color.White;
            this.ExitBtn.Location = new System.Drawing.Point(267, 359);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(205, 55);
            this.ExitBtn.TabIndex = 3;
            this.ExitBtn.Text = "EXIT";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // SubtractionBtn
            // 
            this.SubtractionBtn.BackColor = System.Drawing.Color.White;
            this.SubtractionBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SubtractionBtn.BackgroundImage")));
            this.SubtractionBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SubtractionBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubtractionBtn.ForeColor = System.Drawing.Color.White;
            this.SubtractionBtn.Location = new System.Drawing.Point(490, 99);
            this.SubtractionBtn.Name = "SubtractionBtn";
            this.SubtractionBtn.Size = new System.Drawing.Size(205, 163);
            this.SubtractionBtn.TabIndex = 2;
            this.SubtractionBtn.UseVisualStyleBackColor = false;
            this.SubtractionBtn.Click += new System.EventHandler(this.SubtractionBtn_Click);
            // 
            // AdditionBtn
            // 
            this.AdditionBtn.BackColor = System.Drawing.Color.White;
            this.AdditionBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AdditionBtn.BackgroundImage")));
            this.AdditionBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AdditionBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdditionBtn.ForeColor = System.Drawing.Color.White;
            this.AdditionBtn.Location = new System.Drawing.Point(267, 99);
            this.AdditionBtn.Name = "AdditionBtn";
            this.AdditionBtn.Size = new System.Drawing.Size(205, 163);
            this.AdditionBtn.TabIndex = 1;
            this.AdditionBtn.UseVisualStyleBackColor = false;
            this.AdditionBtn.Click += new System.EventHandler(this.AdditionBtn_Click);
            // 
            // CountingBtn
            // 
            this.CountingBtn.BackColor = System.Drawing.Color.Black;
            this.CountingBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CountingBtn.BackgroundImage")));
            this.CountingBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CountingBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountingBtn.ForeColor = System.Drawing.Color.White;
            this.CountingBtn.Location = new System.Drawing.Point(53, 99);
            this.CountingBtn.Name = "CountingBtn";
            this.CountingBtn.Size = new System.Drawing.Size(205, 163);
            this.CountingBtn.TabIndex = 0;
            this.CountingBtn.UseVisualStyleBackColor = false;
            this.CountingBtn.Click += new System.EventHandler(this.CountingBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(275, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Select a Program";
            // 
            // SelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SpringGreen;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.SubtractionBtn);
            this.Controls.Add(this.AdditionBtn);
            this.Controls.Add(this.CountingBtn);
            this.Name = "SelectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button SubtractionBtn;
        private System.Windows.Forms.Button AdditionBtn;
        private System.Windows.Forms.Button CountingBtn;
        private System.Windows.Forms.Label label1;
    }
}