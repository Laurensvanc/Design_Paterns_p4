
namespace assignment1
{
    partial class TrainDisplay
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
            this.currentStation_txt = new System.Windows.Forms.Label();
            this.currentTrack_txt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // currentStation_txt
            // 
            this.currentStation_txt.AutoSize = true;
            this.currentStation_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.currentStation_txt.Location = new System.Drawing.Point(12, 27);
            this.currentStation_txt.Name = "currentStation_txt";
            this.currentStation_txt.Size = new System.Drawing.Size(160, 26);
            this.currentStation_txt.TabIndex = 0;
            this.currentStation_txt.Text = "Current station:";
            // 
            // currentTrack_txt
            // 
            this.currentTrack_txt.AutoSize = true;
            this.currentTrack_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.currentTrack_txt.Location = new System.Drawing.Point(12, 53);
            this.currentTrack_txt.Name = "currentTrack_txt";
            this.currentTrack_txt.Size = new System.Drawing.Size(154, 26);
            this.currentTrack_txt.TabIndex = 1;
            this.currentTrack_txt.Text = "Railway Track:";
            // 
            // TrainDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 123);
            this.Controls.Add(this.currentTrack_txt);
            this.Controls.Add(this.currentStation_txt);
            this.Name = "TrainDisplay";
            this.Text = "TrainDisplay";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label currentStation_txt;
        private System.Windows.Forms.Label currentTrack_txt;
    }
}