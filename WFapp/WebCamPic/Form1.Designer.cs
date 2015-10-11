namespace WebCamPic
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
            this.TakePicBtn = new System.Windows.Forms.Button();
            this.NewMakePicBox = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.BadImageLabel1 = new System.Windows.Forms.Label();
            this.BadImageLabel2 = new System.Windows.Forms.Label();
            this.BadImagePlsLabel = new System.Windows.Forms.Label();
            this.BadImageExampleLabel = new System.Windows.Forms.Label();
            this.ImageTrueExampleBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.NewMakePicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageTrueExampleBox)).BeginInit();
            this.SuspendLayout();
            // 
            // TakePicBtn
            // 
            this.TakePicBtn.Location = new System.Drawing.Point(498, 538);
            this.TakePicBtn.Name = "TakePicBtn";
            this.TakePicBtn.Size = new System.Drawing.Size(75, 64);
            this.TakePicBtn.TabIndex = 1;
            this.TakePicBtn.Text = "Take Pic";
            this.TakePicBtn.UseVisualStyleBackColor = true;
            this.TakePicBtn.Click += new System.EventHandler(this.TakePicBtn_Click);
            // 
            // NewMakePicBox
            // 
            this.NewMakePicBox.Location = new System.Drawing.Point(312, -12);
            this.NewMakePicBox.Name = "NewMakePicBox";
            this.NewMakePicBox.Size = new System.Drawing.Size(527, 469);
            this.NewMakePicBox.TabIndex = 3;
            this.NewMakePicBox.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(26, 488);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(1064, 24);
            this.comboBox1.TabIndex = 4;
            // 
            // BadImageLabel1
            // 
            this.BadImageLabel1.AutoSize = true;
            this.BadImageLabel1.ForeColor = System.Drawing.Color.Red;
            this.BadImageLabel1.Location = new System.Drawing.Point(15, 9);
            this.BadImageLabel1.Name = "BadImageLabel1";
            this.BadImageLabel1.Size = new System.Drawing.Size(151, 17);
            this.BadImageLabel1.TabIndex = 5;
            this.BadImageLabel1.Text = "Възникна грешка при";
            // 
            // BadImageLabel2
            // 
            this.BadImageLabel2.AutoSize = true;
            this.BadImageLabel2.ForeColor = System.Drawing.Color.Red;
            this.BadImageLabel2.Location = new System.Drawing.Point(15, 40);
            this.BadImageLabel2.Name = "BadImageLabel2";
            this.BadImageLabel2.Size = new System.Drawing.Size(179, 17);
            this.BadImageLabel2.TabIndex = 6;
            this.BadImageLabel2.Text = "сканирането на снимката";
            // 
            // BadImagePlsLabel
            // 
            this.BadImagePlsLabel.AutoSize = true;
            this.BadImagePlsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BadImagePlsLabel.Location = new System.Drawing.Point(42, 93);
            this.BadImagePlsLabel.Name = "BadImagePlsLabel";
            this.BadImagePlsLabel.Size = new System.Drawing.Size(188, 18);
            this.BadImagePlsLabel.TabIndex = 7;
            this.BadImagePlsLabel.Text = "Моля опитайте отново";
            // 
            // BadImageExampleLabel
            // 
            this.BadImageExampleLabel.AutoSize = true;
            this.BadImageExampleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BadImageExampleLabel.Location = new System.Drawing.Point(21, 135);
            this.BadImageExampleLabel.Name = "BadImageExampleLabel";
            this.BadImageExampleLabel.Size = new System.Drawing.Size(83, 18);
            this.BadImageExampleLabel.TabIndex = 8;
            this.BadImageExampleLabel.Text = "Пример : ";
            // 
            // ImageTrueExampleBox
            // 
            this.ImageTrueExampleBox.Image = global::WebCamPic.Properties.Resources.TrueImage1;
            this.ImageTrueExampleBox.Location = new System.Drawing.Point(24, 188);
            this.ImageTrueExampleBox.Name = "ImageTrueExampleBox";
            this.ImageTrueExampleBox.Size = new System.Drawing.Size(231, 172);
            this.ImageTrueExampleBox.TabIndex = 9;
            this.ImageTrueExampleBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 614);
            this.Controls.Add(this.ImageTrueExampleBox);
            this.Controls.Add(this.BadImageExampleLabel);
            this.Controls.Add(this.BadImagePlsLabel);
            this.Controls.Add(this.BadImageLabel2);
            this.Controls.Add(this.BadImageLabel1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.NewMakePicBox);
            this.Controls.Add(this.TakePicBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NewMakePicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageTrueExampleBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button TakePicBtn;
        private System.Windows.Forms.PictureBox NewMakePicBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label BadImageLabel1;
        private System.Windows.Forms.Label BadImageLabel2;
        private System.Windows.Forms.Label BadImagePlsLabel;
        private System.Windows.Forms.Label BadImageExampleLabel;
        private System.Windows.Forms.PictureBox ImageTrueExampleBox;
    }
}

