
namespace CheckBoxDemo
{
    partial class Form1
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
            this.checkBoxFruit = new System.Windows.Forms.CheckBox();
            this.checkBoxSamosa = new System.Windows.Forms.CheckBox();
            this.checkBoxKarahi = new System.Windows.Forms.CheckBox();
            this.checkBoxSelect = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // checkBoxFruit
            // 
            this.checkBoxFruit.AutoSize = true;
            this.checkBoxFruit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxFruit.Location = new System.Drawing.Point(142, 96);
            this.checkBoxFruit.Name = "checkBoxFruit";
            this.checkBoxFruit.Size = new System.Drawing.Size(68, 24);
            this.checkBoxFruit.TabIndex = 0;
            this.checkBoxFruit.Text = "Fruits";
            this.checkBoxFruit.UseVisualStyleBackColor = true;
            this.checkBoxFruit.Click += new System.EventHandler(this.select_all);
            // 
            // checkBoxSamosa
            // 
            this.checkBoxSamosa.AutoSize = true;
            this.checkBoxSamosa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxSamosa.ForeColor = System.Drawing.Color.Black;
            this.checkBoxSamosa.Location = new System.Drawing.Point(142, 159);
            this.checkBoxSamosa.Name = "checkBoxSamosa";
            this.checkBoxSamosa.Size = new System.Drawing.Size(87, 24);
            this.checkBoxSamosa.TabIndex = 1;
            this.checkBoxSamosa.Text = "Samosa";
            this.checkBoxSamosa.UseVisualStyleBackColor = true;
            this.checkBoxSamosa.Click += new System.EventHandler(this.select_all);
            // 
            // checkBoxKarahi
            // 
            this.checkBoxKarahi.AutoSize = true;
            this.checkBoxKarahi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxKarahi.Location = new System.Drawing.Point(142, 224);
            this.checkBoxKarahi.Name = "checkBoxKarahi";
            this.checkBoxKarahi.Size = new System.Drawing.Size(73, 24);
            this.checkBoxKarahi.TabIndex = 2;
            this.checkBoxKarahi.Text = "Karahi";
            this.checkBoxKarahi.UseVisualStyleBackColor = true;
            this.checkBoxKarahi.Click += new System.EventHandler(this.select_all);
            // 
            // checkBoxSelect
            // 
            this.checkBoxSelect.AutoSize = true;
            this.checkBoxSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxSelect.Location = new System.Drawing.Point(83, 46);
            this.checkBoxSelect.Name = "checkBoxSelect";
            this.checkBoxSelect.Size = new System.Drawing.Size(73, 24);
            this.checkBoxSelect.TabIndex = 3;
            this.checkBoxSelect.Text = "Select";
            this.checkBoxSelect.ThreeState = true;
            this.checkBoxSelect.UseVisualStyleBackColor = true;
            this.checkBoxSelect.Click += new System.EventHandler(this.checkBoxSelect_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBoxSelect);
            this.Controls.Add(this.checkBoxKarahi);
            this.Controls.Add(this.checkBoxSamosa);
            this.Controls.Add(this.checkBoxFruit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxFruit;
        private System.Windows.Forms.CheckBox checkBoxSamosa;
        private System.Windows.Forms.CheckBox checkBoxKarahi;
        private System.Windows.Forms.CheckBox checkBoxSelect;
    }
}

