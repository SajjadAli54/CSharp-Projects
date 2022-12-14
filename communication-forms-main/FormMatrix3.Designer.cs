
namespace SendMessageForms
{
    partial class FormMatrix3
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
            this.btnClose = new System.Windows.Forms.Button();
            this.txtFour = new System.Windows.Forms.TextBox();
            this.txtThree = new System.Windows.Forms.TextBox();
            this.txtTwo = new System.Windows.Forms.TextBox();
            this.txtOne = new System.Windows.Forms.TextBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(207, 228);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtFour
            // 
            this.txtFour.Enabled = false;
            this.txtFour.Location = new System.Drawing.Point(294, 140);
            this.txtFour.Name = "txtFour";
            this.txtFour.Size = new System.Drawing.Size(100, 20);
            this.txtFour.TabIndex = 8;
            this.txtFour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtThree
            // 
            this.txtThree.Enabled = false;
            this.txtThree.Location = new System.Drawing.Point(104, 140);
            this.txtThree.Name = "txtThree";
            this.txtThree.Size = new System.Drawing.Size(100, 20);
            this.txtThree.TabIndex = 7;
            this.txtThree.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTwo
            // 
            this.txtTwo.Enabled = false;
            this.txtTwo.Location = new System.Drawing.Point(294, 62);
            this.txtTwo.Name = "txtTwo";
            this.txtTwo.Size = new System.Drawing.Size(100, 20);
            this.txtTwo.TabIndex = 6;
            this.txtTwo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtOne
            // 
            this.txtOne.Enabled = false;
            this.txtOne.Location = new System.Drawing.Point(104, 62);
            this.txtOne.Name = "txtOne";
            this.txtOne.Size = new System.Drawing.Size(100, 20);
            this.txtOne.TabIndex = 5;
            this.txtOne.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox
            // 
            this.pictureBox.Image = global::SendMessageForms.Properties.Resources.index;
            this.pictureBox.Location = new System.Drawing.Point(439, 26);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(337, 294);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 10;
            this.pictureBox.TabStop = false;
            // 
            // FormMatrix3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtFour);
            this.Controls.Add(this.txtThree);
            this.Controls.Add(this.txtTwo);
            this.Controls.Add(this.txtOne);
            this.Name = "FormMatrix3";
            this.Text = "FormMatrix3";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtFour;
        private System.Windows.Forms.TextBox txtThree;
        private System.Windows.Forms.TextBox txtTwo;
        private System.Windows.Forms.TextBox txtOne;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}