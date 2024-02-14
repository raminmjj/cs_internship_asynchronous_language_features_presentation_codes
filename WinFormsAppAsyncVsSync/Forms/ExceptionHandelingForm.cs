namespace WinFormsAppAsyncVsSync.Forms
{
    public partial class ExceptionHandelingForm : Form
    {
        public ExceptionHandelingForm()
        {
            InitializeComponent();
        }

        private async void catchException1Btn_Click(object sender, EventArgs e)
        {
            try
            {
                DoSomthing1();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void catchException2Btn_Click(object sender, EventArgs e)
        {
            try
            {
                await DoSomthing2();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void catchException3Btn_Click(object sender, EventArgs e)
        {
            Task tasks = null;
            try
            {
                var task1 = Task.Run(() => { throw new NotImplementedException(); });
                var task2 = Task.Run(() => { throw new InvalidDataException(); });

                tasks = Task.WhenAll(task1, task2);
                await tasks;
            }
            catch (Exception ex)
            {
                var exceptions = tasks?.Exception;
                MessageBox.Show(ex.Message);
            }
        }

        private async void DoSomthing1()
        {
            throw new NotImplementedException();
        }

        private async Task DoSomthing2()
        {
            throw new NotImplementedException();
        }

    }
}
