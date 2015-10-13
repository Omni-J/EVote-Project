namespace WebCamPic
{
    partial class Successfully
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
            this.OutputInfoLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // OutputInfoLabel
            // 
            this.OutputInfoLabel.AutoSize = true;
            this.OutputInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OutputInfoLabel.Location = new System.Drawing.Point(67, 162);
            this.OutputInfoLabel.Name = "OutputInfoLabel";
            this.OutputInfoLabel.Size = new System.Drawing.Size(0, 29);
            this.OutputInfoLabel.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Successfully
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 348);
            this.Controls.Add(this.OutputInfoLabel);
            this.Name = "Successfully";
            this.Text = "Successfully";
            this.Load += new System.EventHandler(this.Successfully_Load);
            this.Shown += new System.EventHandler(this.Successfully_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label OutputInfoLabel;
        private System.Windows.Forms.Timer timer1;
    }
}