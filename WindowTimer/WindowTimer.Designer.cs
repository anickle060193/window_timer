namespace WindowTimer
{
    partial class WindowTimer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.uxForegroundWindow = new System.Windows.Forms.TextBox();
            this.uxTimer = new System.Windows.Forms.Timer(this.components);
            this.uxActivityLog = new System.Windows.Forms.ListBox();
            this.uxActivityLogLabel = new System.Windows.Forms.Label();
            this.uxForegroundWindowLabel = new System.Windows.Forms.Label();
            this.uxControls = new System.Windows.Forms.GroupBox();
            this.uxActivityPanel = new System.Windows.Forms.Panel();
            this.uxPauseResumeMonitor = new System.Windows.Forms.Button();
            this.uxControls.SuspendLayout();
            this.uxActivityPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // uxForegroundWindow
            // 
            this.uxForegroundWindow.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uxForegroundWindow.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxForegroundWindow.Location = new System.Drawing.Point(3, 16);
            this.uxForegroundWindow.Name = "uxForegroundWindow";
            this.uxForegroundWindow.ReadOnly = true;
            this.uxForegroundWindow.Size = new System.Drawing.Size(357, 23);
            this.uxForegroundWindow.TabIndex = 0;
            // 
            // uxActivityLog
            // 
            this.uxActivityLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uxActivityLog.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxActivityLog.FormattingEnabled = true;
            this.uxActivityLog.IntegralHeight = false;
            this.uxActivityLog.Location = new System.Drawing.Point(3, 58);
            this.uxActivityLog.Name = "uxActivityLog";
            this.uxActivityLog.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.uxActivityLog.Size = new System.Drawing.Size(357, 347);
            this.uxActivityLog.TabIndex = 1;
            // 
            // uxActivityLogLabel
            // 
            this.uxActivityLogLabel.AutoSize = true;
            this.uxActivityLogLabel.Location = new System.Drawing.Point(3, 42);
            this.uxActivityLogLabel.Name = "uxActivityLogLabel";
            this.uxActivityLogLabel.Size = new System.Drawing.Size(65, 13);
            this.uxActivityLogLabel.TabIndex = 2;
            this.uxActivityLogLabel.Text = "Activity Log:";
            // 
            // uxForegroundWindowLabel
            // 
            this.uxForegroundWindowLabel.AutoSize = true;
            this.uxForegroundWindowLabel.Location = new System.Drawing.Point(3, 0);
            this.uxForegroundWindowLabel.Name = "uxForegroundWindowLabel";
            this.uxForegroundWindowLabel.Size = new System.Drawing.Size(106, 13);
            this.uxForegroundWindowLabel.TabIndex = 3;
            this.uxForegroundWindowLabel.Text = "Foreground Window:";
            // 
            // uxControls
            // 
            this.uxControls.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uxControls.Controls.Add(this.uxPauseResumeMonitor);
            this.uxControls.Location = new System.Drawing.Point(381, 12);
            this.uxControls.Name = "uxControls";
            this.uxControls.Size = new System.Drawing.Size(245, 408);
            this.uxControls.TabIndex = 0;
            this.uxControls.TabStop = false;
            this.uxControls.Text = "Controls";
            // 
            // uxActivityPanel
            // 
            this.uxActivityPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uxActivityPanel.Controls.Add(this.uxForegroundWindowLabel);
            this.uxActivityPanel.Controls.Add(this.uxForegroundWindow);
            this.uxActivityPanel.Controls.Add(this.uxActivityLog);
            this.uxActivityPanel.Controls.Add(this.uxActivityLogLabel);
            this.uxActivityPanel.Location = new System.Drawing.Point(12, 12);
            this.uxActivityPanel.Name = "uxActivityPanel";
            this.uxActivityPanel.Size = new System.Drawing.Size(363, 408);
            this.uxActivityPanel.TabIndex = 4;
            // 
            // uxPauseResumeMonitor
            // 
            this.uxPauseResumeMonitor.Location = new System.Drawing.Point(6, 19);
            this.uxPauseResumeMonitor.Name = "uxPauseResumeMonitor";
            this.uxPauseResumeMonitor.Size = new System.Drawing.Size(233, 23);
            this.uxPauseResumeMonitor.TabIndex = 0;
            this.uxPauseResumeMonitor.Text = "Pause Monitor";
            this.uxPauseResumeMonitor.UseVisualStyleBackColor = true;
            // 
            // WindowTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 432);
            this.Controls.Add(this.uxActivityPanel);
            this.Controls.Add(this.uxControls);
            this.Name = "WindowTimer";
            this.Text = "Window Timer";
            this.uxControls.ResumeLayout(false);
            this.uxActivityPanel.ResumeLayout(false);
            this.uxActivityPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox uxForegroundWindow;
        private System.Windows.Forms.Timer uxTimer;
        private System.Windows.Forms.ListBox uxActivityLog;
        private System.Windows.Forms.Label uxForegroundWindowLabel;
        private System.Windows.Forms.Label uxActivityLogLabel;
        private System.Windows.Forms.GroupBox uxControls;
        private System.Windows.Forms.Panel uxActivityPanel;
        private System.Windows.Forms.Button uxPauseResumeMonitor;
    }
}

