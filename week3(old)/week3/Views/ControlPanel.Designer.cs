
namespace assignment1
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
            this.newDisplay_btn = new System.Windows.Forms.Button();
            this.nxtStation_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // newDisplay_btn
            // 
            this.newDisplay_btn.Location = new System.Drawing.Point(12, 176);
            this.newDisplay_btn.Name = "newDisplay_btn";
            this.newDisplay_btn.Size = new System.Drawing.Size(103, 35);
            this.newDisplay_btn.TabIndex = 3;
            this.newDisplay_btn.Text = "New display";
            this.newDisplay_btn.UseVisualStyleBackColor = true;
            this.newDisplay_btn.Click += new System.EventHandler(this.newDisplay_btn_Click);
            // 
            // nxtStation_btn
            // 
            this.nxtStation_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.nxtStation_btn.Location = new System.Drawing.Point(65, 40);
            this.nxtStation_btn.Name = "nxtStation_btn";
            this.nxtStation_btn.Size = new System.Drawing.Size(163, 49);
            this.nxtStation_btn.TabIndex = 2;
            this.nxtStation_btn.Text = "Next Station";
            this.nxtStation_btn.UseVisualStyleBackColor = true;
            this.nxtStation_btn.Click += new System.EventHandler(this.nxtStation_btn_Click);
            // 
            // ControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 223);
            this.Controls.Add(this.newDisplay_btn);
            this.Controls.Add(this.nxtStation_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ControlPanel";
            this.Text = "ControlPanel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button newDisplay_btn;
        private System.Windows.Forms.Button nxtStation_btn;
    }
}