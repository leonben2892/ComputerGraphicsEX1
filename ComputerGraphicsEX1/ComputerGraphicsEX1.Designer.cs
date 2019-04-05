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
            this.DrawLine = new System.Windows.Forms.Button();
            this.BazierCurve = new System.Windows.Forms.Button();
            this.DrawCircle = new System.Windows.Forms.Button();
            this.canvas.SuspendLayout();
            this.SuspendLayout();
            // 
            // canvas
            // 
            this.canvas.BackColor = System.Drawing.SystemColors.Window;
            this.canvas.Controls.Add(this.DrawLine);
            this.canvas.Controls.Add(this.BazierCurve);
            this.canvas.Controls.Add(this.DrawCircle);
            this.canvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.canvas.Location = new System.Drawing.Point(0, 0);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(609, 450);
            this.canvas.TabIndex = 0;
            this.canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.canvas_Paint);
            this.canvas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseClick);
            // 
            // DrawLine
            // 
            this.DrawLine.Location = new System.Drawing.Point(60, 12);
            this.DrawLine.Name = "DrawLine";
            this.DrawLine.Size = new System.Drawing.Size(75, 23);
            this.DrawLine.TabIndex = 3;
            this.DrawLine.Text = "Draw Line";
            this.DrawLine.UseVisualStyleBackColor = true;
            this.DrawLine.Click += new System.EventHandler(this.DrawLine_Click);
            // 
            // BazierCurve
            // 
            this.BazierCurve.Location = new System.Drawing.Point(427, 12);
            this.BazierCurve.Name = "BazierCurve";
            this.BazierCurve.Size = new System.Drawing.Size(75, 23);
            this.BazierCurve.TabIndex = 2;
            this.BazierCurve.Text = "Bazier Curve";
            this.BazierCurve.UseVisualStyleBackColor = true;
            this.BazierCurve.Click += new System.EventHandler(this.BazierCurve_Click);
            // 
            // DrawCircle
            // 
            this.DrawCircle.Location = new System.Drawing.Point(247, 12);
            this.DrawCircle.Name = "DrawCircle";
            this.DrawCircle.Size = new System.Drawing.Size(75, 23);
            this.DrawCircle.TabIndex = 1;
            this.DrawCircle.Text = "Draw Circle";
            this.DrawCircle.UseVisualStyleBackColor = true;
            this.DrawCircle.Click += new System.EventHandler(this.DrawCircle_Click);
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
        private System.Windows.Forms.Button BazierCurve;
        private System.Windows.Forms.Button DrawCircle;
        private System.Windows.Forms.Button DrawLine;
    }
}

