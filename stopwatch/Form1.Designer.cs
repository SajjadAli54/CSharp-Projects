
namespace Stopwatch
{
    partial class frmStopWatch
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
            this.btnStart = new System.Windows.Forms.Button();
            this.txtHour = new System.Windows.Forms.TextBox();
            this.txtSeconds = new System.Windows.Forms.TextBox();
            this.txtMinutes = new System.Windows.Forms.TextBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(98, 56);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(200, 70);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtHour
            // 
            this.txtHour.Location = new System.Drawing.Point(115, 152);
            this.txtHour.Name = "txtHour";
            this.txtHour.Size = new System.Drawing.Size(46, 20);
            this.txtHour.TabIndex = 2;
            this.txtHour.Text = "00 : ";
            this.txtHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSeconds
            // 
            this.txtSeconds.Location = new System.Drawing.Point(220, 152);
            this.txtSeconds.Name = "txtSeconds";
            this.txtSeconds.Size = new System.Drawing.Size(47, 20);
            this.txtSeconds.TabIndex = 3;
            this.txtSeconds.Text = "00";
            this.txtSeconds.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMinutes
            // 
            this.txtMinutes.Location = new System.Drawing.Point(167, 152);
            this.txtMinutes.Name = "txtMinutes";
            this.txtMinutes.Size = new System.Drawing.Size(47, 20);
            this.txtMinutes.TabIndex = 4;
            this.txtMinutes.Text = "00 : ";
            this.txtMinutes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // frmStopWatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 314);
            this.Controls.Add(this.txtMinutes);
            this.Controls.Add(this.txtSeconds);
            this.Controls.Add(this.txtHour);
            this.Controls.Add(this.btnStart);
            this.Name = "frmStopWatch";
            this.Text = "Stop Watch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtHour;
        private System.Windows.Forms.TextBox txtSeconds;
        private System.Windows.Forms.TextBox txtMinutes;
        private System.Windows.Forms.Timer timer;
    }
}

