namespace SimpleTaskManager
{
    partial class RunNewTaskForm
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
            this.openLabel = new System.Windows.Forms.Label();
            this.openInput = new System.Windows.Forms.TextBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // "Open" Label
            // 
            this.openLabel.AutoSize = true;
            this.openLabel.Location = new System.Drawing.Point(12, 19);
            this.openLabel.Name = "openLabel";
            this.openLabel.Size = new System.Drawing.Size(36, 13);
            this.openLabel.TabIndex = 0;
            this.openLabel.Text = "Open:";
            // 
            // Input to run new task
            // 
            this.openInput.Location = new System.Drawing.Point(54, 16);
            this.openInput.Name = "openInput";
            this.openInput.Size = new System.Drawing.Size(364, 20);
            this.openInput.TabIndex = 1;
            // 
            // btnRun
            // 
            this.btnRun.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnRun.Location = new System.Drawing.Point(313, 47);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(89, 22);
            this.btnRun.TabIndex = 2;
            this.btnRun.Text = "&Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // RunNewTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 103);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.openInput);
            this.Controls.Add(this.openLabel);
            this.MaximizeBox = false;
            this.Name = "RunNewTask";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Run new task";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label openLabel;
        private System.Windows.Forms.TextBox openInput;
        private System.Windows.Forms.Button btnRun;
    }
}