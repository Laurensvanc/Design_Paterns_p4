
namespace assignment1
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
            this.NextStation_btn = new System.Windows.Forms.Button();
            this.NewDisplay_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NextStation_btn
            // 
            this.NextStation_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.NextStation_btn.Location = new System.Drawing.Point(64, 55);
            this.NextStation_btn.Name = "NextStation_btn";
            this.NextStation_btn.Size = new System.Drawing.Size(194, 49);
            this.NextStation_btn.TabIndex = 0;
            this.NextStation_btn.Text = "Next Station";
            this.NextStation_btn.UseVisualStyleBackColor = true;
            // 
            // NewDisplay_btn
            // 
            this.NewDisplay_btn.Location = new System.Drawing.Point(12, 172);
            this.NewDisplay_btn.Name = "NewDisplay_btn";
            this.NewDisplay_btn.Size = new System.Drawing.Size(106, 23);
            this.NewDisplay_btn.TabIndex = 1;
            this.NewDisplay_btn.Text = "New display";
            this.NewDisplay_btn.UseVisualStyleBackColor = true;
            // 
            // ControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 217);
            this.Controls.Add(this.NewDisplay_btn);
            this.Controls.Add(this.NextStation_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ControlPanel";
            this.Text = "Control Panel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button NextStation_btn;
        private System.Windows.Forms.Button NewDisplay_btn;
    }
}

