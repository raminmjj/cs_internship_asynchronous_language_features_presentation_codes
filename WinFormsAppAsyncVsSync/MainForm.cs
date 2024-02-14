using WinFormsAppAsyncVsSync.Forms;

namespace WinFormsAppAsyncVsSync
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void synchronousBtn_Click(object sender, EventArgs e)
        {
            using (var frm = new SynchronousForm())
            {
                frm.ShowDialog(this);
            }
        }

        private void threadBtn_Click(object sender, EventArgs e)
        {
            using (var frm = new DoProcessWithThreadForm())
            {
                frm.ShowDialog(this);
            }
        }

        private void taskBtn_Click(object sender, EventArgs e)
        {
            using (var frm = new DoProcessWithTaskForm())
            {
                frm.ShowDialog(this);
            }
        }
        private void concurrentThreadBtn_Click(object sender, EventArgs e)
        {
            using (var frm = new DoProcessWithConcurrentThreadForm())
            {
                frm.ShowDialog(this);
            }
        }

        private void concurrentTaskBtn_Click(object sender, EventArgs e)
        {
            using (var frm = new DoProcessWithConcurrentTaskForm())
            {
                frm.ShowDialog(this);
            }
        }

        private void fixedConcurrentThreadBtn_Click(object sender, EventArgs e)
        {
            using (var frm = new DoProcessWithFixedConcurrentTaskForm())
            {
                frm.ShowDialog(this);
            }
        }

        private void exceptionHandelingBtn_Click(object sender, EventArgs e)
        {
            using (var frm = new ExceptionHandelingForm())
            {
                frm.ShowDialog(this);
            }

        }
    }
}
