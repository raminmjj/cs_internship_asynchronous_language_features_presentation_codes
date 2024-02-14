namespace WinFormsAppAsyncVsSync.Forms
{
    partial class ExceptionHandelingForm
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
            catchException1Btn = new Button();
            catchException2Btn = new Button();
            catchException3Btn = new Button();
            SuspendLayout();
            // 
            // catchException1Btn
            // 
            catchException1Btn.Location = new Point(12, 29);
            catchException1Btn.Name = "catchException1Btn";
            catchException1Btn.Size = new Size(200, 55);
            catchException1Btn.TabIndex = 0;
            catchException1Btn.Text = "Catch Exception 1";
            catchException1Btn.UseVisualStyleBackColor = true;
            catchException1Btn.Click += catchException1Btn_Click;
            // 
            // catchException2Btn
            // 
            catchException2Btn.Location = new Point(12, 90);
            catchException2Btn.Name = "catchException2Btn";
            catchException2Btn.Size = new Size(200, 55);
            catchException2Btn.TabIndex = 0;
            catchException2Btn.Text = "Catch Exception 2";
            catchException2Btn.UseVisualStyleBackColor = true;
            catchException2Btn.Click += catchException2Btn_Click;
            // 
            // catchException3Btn
            // 
            catchException3Btn.Location = new Point(12, 151);
            catchException3Btn.Name = "catchException3Btn";
            catchException3Btn.Size = new Size(200, 55);
            catchException3Btn.TabIndex = 0;
            catchException3Btn.Text = "Catch Exception 3";
            catchException3Btn.UseVisualStyleBackColor = true;
            catchException3Btn.Click += catchException3Btn_Click;
            // 
            // ExceptionHandelingForm
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(753, 472);
            Controls.Add(catchException3Btn);
            Controls.Add(catchException2Btn);
            Controls.Add(catchException1Btn);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 5, 5, 5);
            Name = "ExceptionHandelingForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ExceptionHandelingForm";
            ResumeLayout(false);
        }

        #endregion

        private Button catchException1Btn;
        private Button catchException2Btn;
        private Button catchException3Btn;
    }
}