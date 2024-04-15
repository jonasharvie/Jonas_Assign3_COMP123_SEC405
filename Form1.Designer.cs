namespace Jonas_Assign3_COMP123_SEC405
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.PremierNameLabel = new System.Windows.Forms.Label();
            this.PremierLifeLabel = new System.Windows.Forms.Label();
            this.PremierStartEndLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 149);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(283, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 225);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // PremierNameLabel
            // 
            this.PremierNameLabel.AutoSize = true;
            this.PremierNameLabel.Location = new System.Drawing.Point(12, 12);
            this.PremierNameLabel.Name = "PremierNameLabel";
            this.PremierNameLabel.Size = new System.Drawing.Size(0, 13);
            this.PremierNameLabel.TabIndex = 2;
            // 
            // PremierLifeLabel
            // 
            this.PremierLifeLabel.AutoSize = true;
            this.PremierLifeLabel.Location = new System.Drawing.Point(12, 189);
            this.PremierLifeLabel.Name = "PremierLifeLabel";
            this.PremierLifeLabel.Size = new System.Drawing.Size(0, 13);
            this.PremierLifeLabel.TabIndex = 3;
            // 
            // PremierStartEndLabel
            // 
            this.PremierStartEndLabel.AutoSize = true;
            this.PremierStartEndLabel.Location = new System.Drawing.Point(12, 202);
            this.PremierStartEndLabel.Name = "PremierStartEndLabel";
            this.PremierStartEndLabel.Size = new System.Drawing.Size(0, 13);
            this.PremierStartEndLabel.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(411, 244);
            this.Controls.Add(this.PremierStartEndLabel);
            this.Controls.Add(this.PremierLifeLabel);
            this.Controls.Add(this.PremierNameLabel);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Ontario\'s Premiers";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label PremierNameLabel;
        private System.Windows.Forms.Label PremierLifeLabel;
        private System.Windows.Forms.Label PremierStartEndLabel;
    }
}

