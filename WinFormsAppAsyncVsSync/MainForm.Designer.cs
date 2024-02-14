namespace WinFormsAppAsyncVsSync
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            synchronousBtn = new Button();
            threadBtn = new Button();
            taskBtn = new Button();
            concurrentTaskBtn = new Button();
            concurrentThreadBtn = new Button();
            fixedConcurrentThreadBtn = new Button();
            exceptionHandelingBtn = new Button();
            SuspendLayout();
            // 
            // synchronousBtn
            // 
            synchronousBtn.Location = new Point(21, 24);
            synchronousBtn.Margin = new Padding(5, 6, 5, 6);
            synchronousBtn.Name = "synchronousBtn";
            synchronousBtn.Size = new Size(266, 46);
            synchronousBtn.TabIndex = 0;
            synchronousBtn.Text = "Synchronous";
            synchronousBtn.TextAlign = ContentAlignment.MiddleLeft;
            synchronousBtn.UseVisualStyleBackColor = true;
            synchronousBtn.Click += synchronousBtn_Click;
            // 
            // threadBtn
            // 
            threadBtn.Location = new Point(21, 82);
            threadBtn.Margin = new Padding(5, 6, 5, 6);
            threadBtn.Name = "threadBtn";
            threadBtn.Size = new Size(266, 46);
            threadBtn.TabIndex = 0;
            threadBtn.Text = "Thread";
            threadBtn.TextAlign = ContentAlignment.MiddleLeft;
            threadBtn.UseVisualStyleBackColor = true;
            threadBtn.Click += threadBtn_Click;
            // 
            // taskBtn
            // 
            taskBtn.Location = new Point(21, 140);
            taskBtn.Margin = new Padding(5, 6, 5, 6);
            taskBtn.Name = "taskBtn";
            taskBtn.Size = new Size(266, 46);
            taskBtn.TabIndex = 0;
            taskBtn.Text = "Task";
            taskBtn.TextAlign = ContentAlignment.MiddleLeft;
            taskBtn.UseVisualStyleBackColor = true;
            taskBtn.Click += taskBtn_Click;
            // 
            // concurrentTaskBtn
            // 
            concurrentTaskBtn.Location = new Point(21, 256);
            concurrentTaskBtn.Margin = new Padding(5, 6, 5, 6);
            concurrentTaskBtn.Name = "concurrentTaskBtn";
            concurrentTaskBtn.Size = new Size(266, 46);
            concurrentTaskBtn.TabIndex = 0;
            concurrentTaskBtn.Text = "Concurrent Task";
            concurrentTaskBtn.TextAlign = ContentAlignment.MiddleLeft;
            concurrentTaskBtn.UseVisualStyleBackColor = true;
            concurrentTaskBtn.Click += concurrentTaskBtn_Click;
            // 
            // concurrentThreadBtn
            // 
            concurrentThreadBtn.Location = new Point(21, 198);
            concurrentThreadBtn.Margin = new Padding(5, 6, 5, 6);
            concurrentThreadBtn.Name = "concurrentThreadBtn";
            concurrentThreadBtn.Size = new Size(266, 46);
            concurrentThreadBtn.TabIndex = 0;
            concurrentThreadBtn.Text = "Concurrent Thread";
            concurrentThreadBtn.TextAlign = ContentAlignment.MiddleLeft;
            concurrentThreadBtn.UseVisualStyleBackColor = true;
            concurrentThreadBtn.Click += concurrentThreadBtn_Click;
            // 
            // fixedConcurrentThreadBtn
            // 
            fixedConcurrentThreadBtn.Location = new Point(21, 314);
            fixedConcurrentThreadBtn.Margin = new Padding(5, 6, 5, 6);
            fixedConcurrentThreadBtn.Name = "fixedConcurrentThreadBtn";
            fixedConcurrentThreadBtn.Size = new Size(266, 46);
            fixedConcurrentThreadBtn.TabIndex = 0;
            fixedConcurrentThreadBtn.Text = "Fixed Concurrent Thread";
            fixedConcurrentThreadBtn.TextAlign = ContentAlignment.MiddleLeft;
            fixedConcurrentThreadBtn.UseVisualStyleBackColor = true;
            fixedConcurrentThreadBtn.Click += fixedConcurrentThreadBtn_Click;
            // 
            // exceptionHandelingBtn
            // 
            exceptionHandelingBtn.Location = new Point(21, 372);
            exceptionHandelingBtn.Margin = new Padding(5, 6, 5, 6);
            exceptionHandelingBtn.Name = "exceptionHandelingBtn";
            exceptionHandelingBtn.Size = new Size(266, 46);
            exceptionHandelingBtn.TabIndex = 0;
            exceptionHandelingBtn.Text = "Exception Handeling";
            exceptionHandelingBtn.TextAlign = ContentAlignment.MiddleLeft;
            exceptionHandelingBtn.UseVisualStyleBackColor = true;
            exceptionHandelingBtn.Click += exceptionHandelingBtn_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(866, 454);
            Controls.Add(exceptionHandelingBtn);
            Controls.Add(fixedConcurrentThreadBtn);
            Controls.Add(concurrentThreadBtn);
            Controls.Add(concurrentTaskBtn);
            Controls.Add(taskBtn);
            Controls.Add(threadBtn);
            Controls.Add(synchronousBtn);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main";
            ResumeLayout(false);
        }

        #endregion

        private Button synchronousBtn;
        private Button threadBtn;
        private Button taskBtn;
        private Button concurrentTaskBtn;
        private Button concurrentThreadBtn;
        private Button fixedConcurrentThreadBtn;
        private Button exceptionHandelingBtn;
    }
}
