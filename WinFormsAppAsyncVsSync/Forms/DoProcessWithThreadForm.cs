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
    public partial class DoProcessWithThreadForm : BaseSampleForm
    {
        public DoProcessWithThreadForm()
        {
            InitializeComponent();
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
            this.textBox2.Text = string.Empty;
            Thread thread = new Thread(SimulateBackgroundTask);
            thread.Start();
        }

        private void SimulateBackgroundTask()
        {
            SetupControlsForTheStartProcess();
            for (var i = 0; i <= 10; i++)
            {
                UpdateTextBox1(i);
                Thread.Sleep(500);
            }
            for (var j = 0; j <= 10; j++)
            {
                UpdateTextbox2(j);
                Thread.Sleep(500);
            }
            SetupControlsForEndOfProcess();
        }

        private void UpdateTextbox2(int j)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action<int>(UpdateTextbox2), j);
            }
            else
            {
                this.textBox2.Text = j.ToString();
            }
        }

        private void UpdateTextBox1(int i)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action<int>(UpdateTextBox1), i);
            }
            else
            {
                this.textBox1.Text = i.ToString();
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
