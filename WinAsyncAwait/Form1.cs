
namespace WinAsyncAwait
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void IniciarAsync(object sender, EventArgs e)
        {
            loadingGIF.Visible = true;
            await EsperarAsync();
            loadingGIF.Visible = false;
        }

        private async Task EsperarAsync()
        {
            await Task.Delay(5000);
        }
    }
}
