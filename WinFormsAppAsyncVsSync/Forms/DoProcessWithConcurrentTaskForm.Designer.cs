﻿namespace WinFormsAppAsyncVsSync.Forms
{
    partial class DoProcessWithConcurrentTaskForm
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
            SuspendLayout();
            // 
            // startBtn
            // 
            startBtn.Click += startBtn_Click;
            // 
            // formTitleLb
            // 
            formTitleLb.Text = "Concurrent Task Form";
            // 
            // DoProcessWithConcurrentTaskForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(377, 295);
            Name = "DoProcessWithConcurrentTaskForm";
            Text = "DoProcessWithConcurrentTaskForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}