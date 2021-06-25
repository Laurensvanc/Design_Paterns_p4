
namespace assignment1.Views
{
    partial class ControlPanel
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
            this.btn_NewDisplay = new System.Windows.Forms.Button();
            this.btn_NextStation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_NewDisplay
            // 
            this.btn_NewDisplay.Location = new System.Drawing.Point(16, 224);
            this.btn_NewDisplay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_NewDisplay.Name = "btn_NewDisplay";
            this.btn_NewDisplay.Size = new System.Drawing.Size(141, 28);
            this.btn_NewDisplay.TabIndex = 3;
            this.btn_NewDisplay.Text = "New display";
            this.btn_NewDisplay.UseVisualStyleBackColor = true;
            this.btn_NewDisplay.Click += new System.EventHandler(this.btn_NewDisplay_Click);
            // 
            // btn_NextStation
            // 
            this.btn_NextStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btn_NextStation.Location = new System.Drawing.Point(85, 80);
            this.btn_NextStation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_NextStation.Name = "btn_NextStation";
            this.btn_NextStation.Size = new System.Drawing.Size(259, 60);
            this.btn_NextStation.TabIndex = 2;
            this.btn_NextStation.Text = "Next Station";
            this.btn_NextStation.UseVisualStyleBackColor = true;
            this.btn_NextStation.Click += new System.EventHandler(this.btn_NextStation_Click);
            // 
            // ControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 267);
            this.Controls.Add(this.btn_NewDisplay);
            this.Controls.Add(this.btn_NextStation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ControlPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control Panel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_NewDisplay;
        private System.Windows.Forms.Button btn_NextStation;
    }
}