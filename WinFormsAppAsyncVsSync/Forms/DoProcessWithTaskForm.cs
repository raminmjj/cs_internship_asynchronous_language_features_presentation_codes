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
    public partial class DoProcessWithTaskForm : BaseSampleForm
    {
        public DoProcessWithTaskForm()
        {
            InitializeComponent();
        }

        private async void startBtn_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
            this.textBox2.Text = string.Empty;
            await Task.Run(() => SimulateBackgroundTask());
        }

        private void SimulateBackgroundTask()
        {
            SetupControlsForTheStartProcess();
            for (var i = 0; i < 10; i++)
            {
                UpdateTextBox(this.textBox1, i.ToString());
                Task.Delay(500);
            }
            for (var j = 0; j < 10; j++)
            {
                UpdateTextBox(this.textBox1, j.ToString());
                Task.Delay(500);
            }
            SetupControlsForEndOfProcess();
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

        private void SetupControlsForEndOfProcess()
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(SetupControlsForEndOfProcess));
            }
            else
            {
                this.progressBar1.Visible = false;
                this.startBtn.Enabled = true;
            }
        }

        private void SetupControlsForTheStartProcess()
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(SetupControlsForTheStartProcess));
            }
            else
            {
                this.startBtn.Enabled = false;
                this.progressBar1.Visible = true;
            }
        }

    }
}
