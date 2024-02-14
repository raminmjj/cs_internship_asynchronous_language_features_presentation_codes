using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppAsyncVsSync.Forms
{
    public partial class DoProcessWithConcurrentThreadForm : BaseSampleForm
    {
        public DoProcessWithConcurrentThreadForm()
        {
            InitializeComponent();
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            this.startBtn.Enabled = false;
            this.progressBar1.Visible = true;

            Thread thread1 = new Thread(() => SimulateBackgroundTask(textBox1));
            Thread thread2 = new Thread(() => SimulateBackgroundTask(textBox2));

            thread1.Start();
            thread2.Start();

            this.startBtn.Enabled = true;
            this.progressBar1.Visible = false;
        }


        private void SimulateBackgroundTask(TextBox textBox)
        {
            for (int i = 0; i <= 10; i++)
            {
                Thread.Sleep(500);
                UpdateTextBox(textBox, i.ToString());
            }
        }

        private void UpdateTextBox(TextBox textBox, string newText)
        {
            if (textBox.InvokeRequired)
            {
                textBox.Invoke(new Action<string>(s => UpdateTextBox(textBox, s)), newText);
            }
            else
            {
                textBox.Text = newText;
            }
        }

    }
}
