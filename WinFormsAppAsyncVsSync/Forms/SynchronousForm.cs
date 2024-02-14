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
    public partial class SynchronousForm : BaseSampleForm
    {
        public SynchronousForm()
        {
            InitializeComponent();
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
            this.textBox2.Text = string.Empty;
            SetupControlsForTheStartProcess();
            for (var i = 0; i <= 10; i++)
            {
                UpdateTextBox1(i);
                Thread.Sleep(500);
            }
            Application.DoEvents();
            for (var j = 0; j <= 10; j++)
            {
                UpdateTextbox2(j);
                Thread.Sleep(500);
            }
            SetupControlsForEndOfProcess();
        }

        private void UpdateTextbox2(int j)
        {
            this.textBox2.Text = j.ToString();
        }

        private void UpdateTextBox1(int i)
        {
            this.textBox1.Text = i.ToString();
        }

        private void SetupControlsForEndOfProcess()
        {
            this.progressBar1.Visible = false;
            this.startBtn.Enabled = true;
        }

        private void SetupControlsForTheStartProcess()
        {
            this.startBtn.Enabled = false;
            this.progressBar1.Visible = true;
        }
    }
}
