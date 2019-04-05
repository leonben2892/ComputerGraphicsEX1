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
            this.LineBtn = new System.Windows.Forms.Button();
            this.BazierCurveBtn = new System.Windows.Forms.Button();
            this.CircleBtn = new System.Windows.Forms.Button();
            this.canvas.SuspendLayout();
            this.SuspendLayout();
            // 
            // canvas
            // 
            this.canvas.BackColor = System.Drawing.SystemColors.Window;
            this.canvas.Controls.Add(this.LineBtn);
            this.canvas.Controls.Add(this.BazierCurveBtn);
            this.canvas.Controls.Add(this.CircleBtn);
            this.canvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.canvas.Location = new System.Drawing.Point(0, 0);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(609, 450);
            this.canvas.TabIndex = 0;
            this.canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.canvas_Paint);
            this.canvas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseClick);
            // 
            // LineBtn
            // 
            this.LineBtn.Location = new System.Drawing.Point(60, 12);
            this.LineBtn.Name = "LineBtn";
            this.LineBtn.Size = new System.Drawing.Size(75, 23);
            this.LineBtn.TabIndex = 3;
            this.LineBtn.Text = "Draw Line";
            this.LineBtn.UseVisualStyleBackColor = true;
            this.LineBtn.Click += new System.EventHandler(this.LineBtn_Click);
            // 
            // BazierCurveBtn
            // 
            this.BazierCurveBtn.Location = new System.Drawing.Point(427, 12);
            this.BazierCurveBtn.Name = "BazierCurveBtn";
            this.BazierCurveBtn.Size = new System.Drawing.Size(75, 23);
            this.BazierCurveBtn.TabIndex = 2;
            this.BazierCurveBtn.Text = "Bazier Curve";
            this.BazierCurveBtn.UseVisualStyleBackColor = true;
            this.BazierCurveBtn.Click += new System.EventHandler(this.BazierCurveBtn_Click);
            // 
            // CircleBtn
            // 
            this.CircleBtn.Location = new System.Drawing.Point(247, 12);
            this.CircleBtn.Name = "CircleBtn";
            this.CircleBtn.Size = new System.Drawing.Size(75, 23);
            this.CircleBtn.TabIndex = 1;
            this.CircleBtn.Text = "Draw Circle";
            this.CircleBtn.UseVisualStyleBackColor = true;
            this.CircleBtn.Click += new System.EventHandler(this.CircleBtn_Click);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel canvas;
        private System.Windows.Forms.Button BazierCurveBtn;
        private System.Windows.Forms.Button CircleBtn;
        private System.Windows.Forms.Button LineBtn;
    }
}

