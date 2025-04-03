using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAsyncAwait
{
    public partial class FrmAsyncAwait : Form
    {
        public FrmAsyncAwait()
        {
            InitializeComponent();
        }

        private async void IniciarProcesoAsync(object sender, EventArgs e)
        {
            pbLoadingGIF.Visible = true;
            await EsperarAsync();
            pbLoadingGIF.Visible = false;
        }

        private async Task EsperarAsync()
        {
            await Task.Delay(5000);
        }
    }
}
