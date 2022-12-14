
namespace Lab_08
{
    partial class FormTrexGame
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
            this.lblScore = new System.Windows.Forms.Label();
            this.pbObstacle2 = new System.Windows.Forms.PictureBox();
            this.pbObstacle1 = new System.Windows.Forms.PictureBox();
            this.pbTrex = new System.Windows.Forms.PictureBox();
            this.pbGround = new System.Windows.Forms.PictureBox();
            this.tmGame = new System.Windows.Forms.Timer(this.components);
            this.tmScore = new System.Windows.Forms.Timer(this.components);
            this.tmUpDown = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbObstacle2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbObstacle1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTrex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGround)).BeginInit();
            this.SuspendLayout();
            // 
            // lblScore
            // 
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(35, 29);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(100, 23);
            this.lblScore.TabIndex = 4;
            this.lblScore.Text = "Score : 0";
            // 
            // pbObstacle2
            // 
            this.pbObstacle2.Image = global::Lab_08.Properties.Resources.obstacle_2;
            this.pbObstacle2.Location = new System.Drawing.Point(669, 358);
            this.pbObstacle2.Name = "pbObstacle2";
            this.pbObstacle2.Size = new System.Drawing.Size(81, 83);
            this.pbObstacle2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbObstacle2.TabIndex = 3;
            this.pbObstacle2.TabStop = false;
            // 
            // pbObstacle1
            // 
            this.pbObstacle1.Image = global::Lab_08.Properties.Resources.obstacle_1;
            this.pbObstacle1.Location = new System.Drawing.Point(498, 344);
            this.pbObstacle1.Name = "pbObstacle1";
            this.pbObstacle1.Size = new System.Drawing.Size(51, 96);
            this.pbObstacle1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbObstacle1.TabIndex = 2;
            this.pbObstacle1.TabStop = false;
            // 
            // pbTrex
            // 
            this.pbTrex.Image = global::Lab_08.Properties.Resources.running;
            this.pbTrex.Location = new System.Drawing.Point(21, 341);
            this.pbTrex.Name = "pbTrex";
            this.pbTrex.Size = new System.Drawing.Size(89, 100);
            this.pbTrex.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTrex.TabIndex = 1;
            this.pbTrex.TabStop = false;
            // 
            // pbGround
            // 
            this.pbGround.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pbGround.Location = new System.Drawing.Point(-2, 441);
            this.pbGround.Name = "pbGround";
            this.pbGround.Size = new System.Drawing.Size(804, 13);
            this.pbGround.TabIndex = 0;
            this.pbGround.TabStop = false;
            // 
            // tmGame
            // 
            this.tmGame.Enabled = true;
            this.tmGame.Tick += new System.EventHandler(this.tmGame_Tick);
            // 
            // tmScore
            // 
            this.tmScore.Enabled = true;
            this.tmScore.Tick += new System.EventHandler(this.tmScore_Tick);
            // 
            // tmUpDown
            // 
            this.tmUpDown.Tick += new System.EventHandler(this.tmUpDown_Tick);
            // 
            // FormTrexGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.pbObstacle2);
            this.Controls.Add(this.pbObstacle1);
            this.Controls.Add(this.pbTrex);
            this.Controls.Add(this.pbGround);
            this.Name = "FormTrexGame";
            this.Text = "Trex Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormTrexGame_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormTrexGame_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbObstacle2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbObstacle1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTrex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGround)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbGround;
        private System.Windows.Forms.PictureBox pbTrex;
        private System.Windows.Forms.PictureBox pbObstacle1;
        private System.Windows.Forms.PictureBox pbObstacle2;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Timer tmGame;
        private System.Windows.Forms.Timer tmScore;
        private System.Windows.Forms.Timer tmUpDown;
    }
}

