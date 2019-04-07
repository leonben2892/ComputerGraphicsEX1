namespace ComputerGraphicsEX1
{
    partial class ComputerGraphicsEX1
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
            this.canvas = new System.Windows.Forms.Panel();
            this.Navigation = new System.Windows.Forms.Panel();
            this.NumericBoxLines = new System.Windows.Forms.NumericUpDown();
            this.BlackBtn = new System.Windows.Forms.Button();
            this.YellowBtn = new System.Windows.Forms.Button();
            this.GreenBtn = new System.Windows.Forms.Button();
            this.RedBtn = new System.Windows.Forms.Button();
            this.BlueBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CircleBtn = new System.Windows.Forms.Button();
            this.BazierCurveBtn = new System.Windows.Forms.Button();
            this.LineBtn = new System.Windows.Forms.Button();
            this.canvas.SuspendLayout();
            this.Navigation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericBoxLines)).BeginInit();
            this.SuspendLayout();
            // 
            // canvas
            // 
            this.canvas.BackColor = System.Drawing.SystemColors.Window;
            this.canvas.Controls.Add(this.Navigation);
            this.canvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.canvas.Location = new System.Drawing.Point(0, 0);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(609, 450);
            this.canvas.TabIndex = 0;
            this.canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.canvas_Paint);
            this.canvas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseClick);
            // 
            // Navigation
            // 
            this.Navigation.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Navigation.Controls.Add(this.NumericBoxLines);
            this.Navigation.Controls.Add(this.BlackBtn);
            this.Navigation.Controls.Add(this.YellowBtn);
            this.Navigation.Controls.Add(this.GreenBtn);
            this.Navigation.Controls.Add(this.RedBtn);
            this.Navigation.Controls.Add(this.BlueBtn);
            this.Navigation.Controls.Add(this.label2);
            this.Navigation.Controls.Add(this.label1);
            this.Navigation.Controls.Add(this.CircleBtn);
            this.Navigation.Controls.Add(this.BazierCurveBtn);
            this.Navigation.Controls.Add(this.LineBtn);
            this.Navigation.Dock = System.Windows.Forms.DockStyle.Top;
            this.Navigation.Location = new System.Drawing.Point(0, 0);
            this.Navigation.Name = "Navigation";
            this.Navigation.Size = new System.Drawing.Size(609, 74);
            this.Navigation.TabIndex = 4;
            // 
            // NumericBoxLines
            // 
            this.NumericBoxLines.Location = new System.Drawing.Point(413, 5);
            this.NumericBoxLines.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericBoxLines.Name = "NumericBoxLines";
            this.NumericBoxLines.Size = new System.Drawing.Size(75, 20);
            this.NumericBoxLines.TabIndex = 11;
            this.NumericBoxLines.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericBoxLines.ValueChanged += new System.EventHandler(this.NumericBoxLines_ValueChanged);
            // 
            // BlackBtn
            // 
            this.BlackBtn.BackColor = System.Drawing.Color.Black;
            this.BlackBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BlackBtn.Location = new System.Drawing.Point(506, 37);
            this.BlackBtn.Name = "BlackBtn";
            this.BlackBtn.Size = new System.Drawing.Size(75, 23);
            this.BlackBtn.TabIndex = 10;
            this.BlackBtn.UseVisualStyleBackColor = false;
            this.BlackBtn.Click += new System.EventHandler(this.BlackBtn_Click);
            // 
            // YellowBtn
            // 
            this.YellowBtn.BackColor = System.Drawing.Color.Yellow;
            this.YellowBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.YellowBtn.Location = new System.Drawing.Point(413, 37);
            this.YellowBtn.Name = "YellowBtn";
            this.YellowBtn.Size = new System.Drawing.Size(75, 23);
            this.YellowBtn.TabIndex = 9;
            this.YellowBtn.UseVisualStyleBackColor = false;
            this.YellowBtn.Click += new System.EventHandler(this.YellowBtn_Click);
            // 
            // GreenBtn
            // 
            this.GreenBtn.BackColor = System.Drawing.Color.Lime;
            this.GreenBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.GreenBtn.Location = new System.Drawing.Point(321, 37);
            this.GreenBtn.Name = "GreenBtn";
            this.GreenBtn.Size = new System.Drawing.Size(75, 23);
            this.GreenBtn.TabIndex = 8;
            this.GreenBtn.UseVisualStyleBackColor = false;
            this.GreenBtn.Click += new System.EventHandler(this.GreenBtn_Click);
            // 
            // RedBtn
            // 
            this.RedBtn.BackColor = System.Drawing.Color.Red;
            this.RedBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.RedBtn.Location = new System.Drawing.Point(227, 37);
            this.RedBtn.Name = "RedBtn";
            this.RedBtn.Size = new System.Drawing.Size(75, 23);
            this.RedBtn.TabIndex = 7;
            this.RedBtn.UseVisualStyleBackColor = false;
            this.RedBtn.Click += new System.EventHandler(this.RedBtn_Click);
            // 
            // BlueBtn
            // 
            this.BlueBtn.BackColor = System.Drawing.Color.Blue;
            this.BlueBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BlueBtn.Location = new System.Drawing.Point(133, 37);
            this.BlueBtn.Name = "BlueBtn";
            this.BlueBtn.Size = new System.Drawing.Size(75, 23);
            this.BlueBtn.TabIndex = 6;
            this.BlueBtn.UseVisualStyleBackColor = false;
            this.BlueBtn.Click += new System.EventHandler(this.BlueBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(15, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "What color?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(15, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "What to draw?";
            // 
            // CircleBtn
            // 
            this.CircleBtn.Location = new System.Drawing.Point(227, 2);
            this.CircleBtn.Name = "CircleBtn";
            this.CircleBtn.Size = new System.Drawing.Size(75, 23);
            this.CircleBtn.TabIndex = 1;
            this.CircleBtn.Text = "Draw Circle";
            this.CircleBtn.UseVisualStyleBackColor = true;
            this.CircleBtn.Click += new System.EventHandler(this.CircleBtn_Click);
            // 
            // BazierCurveBtn
            // 
            this.BazierCurveBtn.Location = new System.Drawing.Point(321, 2);
            this.BazierCurveBtn.Name = "BazierCurveBtn";
            this.BazierCurveBtn.Size = new System.Drawing.Size(75, 23);
            this.BazierCurveBtn.TabIndex = 2;
            this.BazierCurveBtn.Text = "Bazier Curve";
            this.BazierCurveBtn.UseVisualStyleBackColor = true;
            this.BazierCurveBtn.Click += new System.EventHandler(this.BazierCurveBtn_Click);
            // 
            // LineBtn
            // 
            this.LineBtn.Location = new System.Drawing.Point(133, 2);
            this.LineBtn.Name = "LineBtn";
            this.LineBtn.Size = new System.Drawing.Size(75, 23);
            this.LineBtn.TabIndex = 3;
            this.LineBtn.Text = "Draw Line";
            this.LineBtn.UseVisualStyleBackColor = true;
            this.LineBtn.Click += new System.EventHandler(this.LineBtn_Click);
            // 
            // ComputerGraphicsEX1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 450);
            this.Controls.Add(this.canvas);
            this.Name = "ComputerGraphicsEX1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simple Paint";
            this.canvas.ResumeLayout(false);
            this.Navigation.ResumeLayout(false);
            this.Navigation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericBoxLines)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel canvas;
        private System.Windows.Forms.Button BazierCurveBtn;
        private System.Windows.Forms.Button CircleBtn;
        private System.Windows.Forms.Button LineBtn;
        private System.Windows.Forms.Panel Navigation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button YellowBtn;
        private System.Windows.Forms.Button GreenBtn;
        private System.Windows.Forms.Button RedBtn;
        private System.Windows.Forms.Button BlueBtn;
        private System.Windows.Forms.Button BlackBtn;
        private System.Windows.Forms.NumericUpDown NumericBoxLines;
    }
}

