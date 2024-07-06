namespace ImageResizeForm
{
    partial class Main
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
            this.UploadButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PreviousButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // UploadButton
            // 
            this.UploadButton.Location = new System.Drawing.Point(692, 365);
            this.UploadButton.Name = "UploadButton";
            this.UploadButton.Size = new System.Drawing.Size(96, 73);
            this.UploadButton.TabIndex = 0;
            this.UploadButton.Text = "Upload foto";
            this.UploadButton.UseVisualStyleBackColor = true;
            this.UploadButton.Click += new System.EventHandler(this.UploadButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(510, 365);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(89, 73);
            this.NextButton.TabIndex = 1;
            this.NextButton.Text = "Volgende Foto";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(776, 347);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(278, 365);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 73);
            this.label1.TabIndex = 3;
            this.label1.Text = "(4 - 10)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PreviousButton
            // 
            this.PreviousButton.Location = new System.Drawing.Point(183, 365);
            this.PreviousButton.Name = "PreviousButton";
            this.PreviousButton.Size = new System.Drawing.Size(89, 73);
            this.PreviousButton.TabIndex = 4;
            this.PreviousButton.Text = "Vorige Foto";
            this.PreviousButton.UseVisualStyleBackColor = true;
            this.PreviousButton.Click += new System.EventHandler(this.PreviousButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PreviousButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.UploadButton);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button PreviousButton;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.PictureBox pictureBox1;

        private System.Windows.Forms.Button UploadButton;

        private System.Windows.Forms.Button NextButton;

        #endregion
    }
}