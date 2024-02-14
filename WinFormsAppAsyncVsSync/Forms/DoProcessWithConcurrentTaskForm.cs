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
    public partial class DoProcessWithConcurrentTaskForm : BaseSampleForm
    {
        public DoProcessWithConcurrentTaskForm()
        {
            InitializeComponent();
        }

        private async void startBtn_Click(object sender, EventArgs e)
        {
            this.startBtn.Enabled = false;
            this.progressBar1.Visible = true;
            await Task.WhenAll(
                Task.Run(() => SimulateBackgroundTask(textBox1)),
                Task.Run(() => SimulateBackgroundTask(textBox2))
            );
            this.startBtn.Enabled = true;
            this.progressBar1.Visible = false;
        }

        private void SimulateBackgroundTask(TextBox textBox)
        {
            for (int i = 0; i <= 10; i++)
            {
                UpdateTextBox(textBox, i.ToString());
                Task.Delay(500).Wait();
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
