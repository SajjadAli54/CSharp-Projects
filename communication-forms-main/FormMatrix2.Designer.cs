
namespace SendMessageForms
{
    partial class FormMatrix2
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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtFour = new System.Windows.Forms.TextBox();
            this.txtThree = new System.Windows.Forms.TextBox();
            this.txtTwo = new System.Windows.Forms.TextBox();
            this.txtOne = new System.Windows.Forms.TextBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(204, 238);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 9;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtFour
            // 
            this.txtFour.Location = new System.Drawing.Point(291, 150);
            this.txtFour.Name = "txtFour";
            this.txtFour.Size = new System.Drawing.Size(100, 20);
            this.txtFour.TabIndex = 8;
            this.txtFour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtThree
            // 
            this.txtThree.Location = new System.Drawing.Point(101, 150);
            this.txtThree.Name = "txtThree";
            this.txtThree.Size = new System.Drawing.Size(100, 20);
            this.txtThree.TabIndex = 7;
            this.txtThree.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTwo
            // 
            this.txtTwo.Location = new System.Drawing.Point(291, 72);
            this.txtTwo.Name = "txtTwo";
            this.txtTwo.Size = new System.Drawing.Size(100, 20);
            this.txtTwo.TabIndex = 6;
            this.txtTwo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtOne
            // 
            this.txtOne.Location = new System.Drawing.Point(101, 72);
            this.txtOne.Name = "txtOne";
            this.txtOne.Size = new System.Drawing.Size(100, 20);
            this.txtOne.TabIndex = 5;
            this.txtOne.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox
            // 
            this.pictureBox.Image = global::SendMessageForms.Properties.Resources.index;
            this.pictureBox.Location = new System.Drawing.Point(437, 50);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(337, 294);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 10;
            this.pictureBox.TabStop = false;
            // 
            // FormMatrix2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtFour);
            this.Controls.Add(this.txtThree);
            this.Controls.Add(this.txtTwo);
            this.Controls.Add(this.txtOne);
            this.Name = "FormMatrix2";
            this.Text = "FormMatrix2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtFour;
        private System.Windows.Forms.TextBox txtThree;
        private System.Windows.Forms.TextBox txtTwo;
        private System.Windows.Forms.TextBox txtOne;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}