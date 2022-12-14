
namespace SendMessageForms
{
    partial class FormMatrix1
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
            this.txtOne = new System.Windows.Forms.TextBox();
            this.txtTwo = new System.Windows.Forms.TextBox();
            this.txtFour = new System.Windows.Forms.TextBox();
            this.txtThree = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // txtOne
            // 
            this.txtOne.Location = new System.Drawing.Point(93, 90);
            this.txtOne.Name = "txtOne";
            this.txtOne.Size = new System.Drawing.Size(100, 20);
            this.txtOne.TabIndex = 0;
            this.txtOne.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtOne.TextChanged += new System.EventHandler(this.txtOne_TextChanged);
            // 
            // txtTwo
            // 
            this.txtTwo.Location = new System.Drawing.Point(283, 90);
            this.txtTwo.Name = "txtTwo";
            this.txtTwo.Size = new System.Drawing.Size(100, 20);
            this.txtTwo.TabIndex = 1;
            this.txtTwo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTwo.TextChanged += new System.EventHandler(this.txtTwo_TextChanged);
            // 
            // txtFour
            // 
            this.txtFour.Location = new System.Drawing.Point(283, 168);
            this.txtFour.Name = "txtFour";
            this.txtFour.Size = new System.Drawing.Size(100, 20);
            this.txtFour.TabIndex = 3;
            this.txtFour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFour.TextChanged += new System.EventHandler(this.txtFour_TextChanged);
            // 
            // txtThree
            // 
            this.txtThree.Location = new System.Drawing.Point(93, 168);
            this.txtThree.Name = "txtThree";
            this.txtThree.Size = new System.Drawing.Size(100, 20);
            this.txtThree.TabIndex = 2;
            this.txtThree.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtThree.TextChanged += new System.EventHandler(this.txtThree_TextChanged);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(196, 256);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Image = global::SendMessageForms.Properties.Resources.index;
            this.pictureBox.Location = new System.Drawing.Point(435, 60);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(337, 294);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 5;
            this.pictureBox.TabStop = false;
            // 
            // FormMatrix1
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
            this.Name = "FormMatrix1";
            this.Text = "Matrix 1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOne;
        private System.Windows.Forms.TextBox txtTwo;
        private System.Windows.Forms.TextBox txtFour;
        private System.Windows.Forms.TextBox txtThree;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}

