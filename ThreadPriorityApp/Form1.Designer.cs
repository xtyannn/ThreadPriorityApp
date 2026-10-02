namespace ThreadPriorityApp
{
    partial class frmTrackThread
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
            this.lblThreadStatus = new System.Windows.Forms.Label();
            this.btnRun = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblThreadStatus
            // 
            this.lblThreadStatus.AutoSize = true;
            this.lblThreadStatus.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThreadStatus.Location = new System.Drawing.Point(55, 45);
            this.lblThreadStatus.Name = "lblThreadStatus";
            this.lblThreadStatus.Size = new System.Drawing.Size(175, 32);
            this.lblThreadStatus.TabIndex = 0;
            this.lblThreadStatus.Text = "-Thread Starts-";
            this.lblThreadStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRun
            // 
            this.btnRun.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRun.Location = new System.Drawing.Point(95, 110);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(95, 35);
            this.btnRun.TabIndex = 1;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // frmTrackThread
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 191);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.lblThreadStatus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmTrackThread";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTrackThread";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblThreadStatus;
        private System.Windows.Forms.Button btnRun;
    }
}