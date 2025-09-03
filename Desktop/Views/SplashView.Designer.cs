namespace Desktop.Views
{
    partial class SplashView
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
            components = new System.ComponentModel.Container();
            ProgressBar = new ProgressBar();
            TimerSplash = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // ProgressBar
            // 
            ProgressBar.ForeColor = SystemColors.ButtonHighlight;
            ProgressBar.Location = new Point(31, 285);
            ProgressBar.Name = "ProgressBar";
            ProgressBar.Size = new Size(741, 14);
            ProgressBar.TabIndex = 0;
            // 
            // TimerSplash
            // 
            TimerSplash.Enabled = true;
            TimerSplash.Tick += TimerSplash_Tick;
            // 
            // SplashView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Navy;
            ClientSize = new Size(817, 326);
            Controls.Add(ProgressBar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SplashView";
            Text = "SplashView";
            ResumeLayout(false);
        }

        #endregion

        private ProgressBar ProgressBar;
        private System.Windows.Forms.Timer TimerSplash;
    }
}