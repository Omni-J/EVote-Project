namespace WebCamPic
{
    partial class Blank
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
            this.CandidatesListBox = new System.Windows.Forms.ListBox();
            this.EGNLabel = new System.Windows.Forms.Label();
            this.Submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CandidatesListBox
            // 
            this.CandidatesListBox.FormattingEnabled = true;
            this.CandidatesListBox.ItemHeight = 16;
            this.CandidatesListBox.Location = new System.Drawing.Point(15, 49);
            this.CandidatesListBox.Name = "CandidatesListBox";
            this.CandidatesListBox.Size = new System.Drawing.Size(503, 324);
            this.CandidatesListBox.TabIndex = 0;
            // 
            // EGNLabel
            // 
            this.EGNLabel.AutoSize = true;
            this.EGNLabel.Location = new System.Drawing.Point(12, 9);
            this.EGNLabel.Name = "EGNLabel";
            this.EGNLabel.Size = new System.Drawing.Size(0, 17);
            this.EGNLabel.TabIndex = 1;
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(127, 393);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(284, 36);
            this.Submit.TabIndex = 2;
            this.Submit.Text = "Гласувайте";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // Blank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 441);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.EGNLabel);
            this.Controls.Add(this.CandidatesListBox);
            this.Name = "Blank";
            this.Text = "Blank";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Blank_FormClosing);
            this.Load += new System.EventHandler(this.Blank_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox CandidatesListBox;
        private System.Windows.Forms.Label EGNLabel;
        private System.Windows.Forms.Button Submit;
    }
}