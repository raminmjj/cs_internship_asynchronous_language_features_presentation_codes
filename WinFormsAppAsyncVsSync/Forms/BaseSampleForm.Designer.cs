namespace WinFormsAppAsyncVsSync.Forms
{
    partial class BaseSampleForm
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
            textBox1 = new TextBox();
            label1 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            startBtn = new Button();
            progressBar1 = new ProgressBar();
            formTitleLb = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(123, 34);
            textBox1.Margin = new Padding(5, 6, 5, 6);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(169, 35);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 37);
            label1.Name = "label1";
            label1.Size = new Size(98, 30);
            label1.TabIndex = 1;
            label1.Text = "Counter1";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(123, 81);
            textBox2.Margin = new Padding(5, 6, 5, 6);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(169, 35);
            textBox2.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 84);
            label2.Name = "label2";
            label2.Size = new Size(98, 30);
            label2.TabIndex = 1;
            label2.Text = "Counter2";
            // 
            // startBtn
            // 
            startBtn.Location = new Point(123, 151);
            startBtn.Name = "startBtn";
            startBtn.Size = new Size(169, 49);
            startBtn.TabIndex = 2;
            startBtn.Text = "Start";
            startBtn.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(123, 122);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(169, 23);
            progressBar1.Style = ProgressBarStyle.Marquee;
            progressBar1.TabIndex = 3;
            progressBar1.Visible = false;
            // 
            // formTitleLb
            // 
            formTitleLb.Location = new Point(86, 256);
            formTitleLb.Name = "formTitleLb";
            formTitleLb.Size = new Size(243, 30);
            formTitleLb.TabIndex = 5;
            formTitleLb.Text = "Form Title";
            formTitleLb.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BaseSampleForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(415, 295);
            Controls.Add(formTitleLb);
            Controls.Add(progressBar1);
            Controls.Add(startBtn);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "BaseSampleForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "BaseForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        public Button startBtn;
        public ProgressBar progressBar1;
        public TextBox textBox1;
        public TextBox textBox2;
        public Label formTitleLb;
    }
}