using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppAsyncVsSync.Forms
{
    public partial class DoProcessWithFixedConcurrentTaskForm : BaseSampleForm
    {
        private bool thread1Finished = false;
        private bool thread2Finished = false;

        public DoProcessWithFixedConcurrentTaskForm()
        {
            InitializeComponent();
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            startBtn.Enabled = false;
            progressBar1.Visible = true;

            thread1Finished = false;
            thread2Finished = false;

            Thread thread1 = new Thread(() =>
            {
                SimulateBackgroundTask(textBox1);
                thread1Finished = true;
                CheckEndOfTasks();
            });

            Thread thread2 = new Thread(() =>
            {
                SimulateBackgroundTask(textBox2);
                thread2Finished = true;
                CheckEndOfTasks();
            });

            thread1.Start();
            thread2.Start();

        }

        private void CheckEndOfTasks()
        {
            if(thread1Finished && thread2Finished)
            {
                SetupControlsForEndOfProcess();
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
