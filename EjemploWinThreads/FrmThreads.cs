using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploWinThreads
{
    public partial class FrmThreads : Form
    {
        private Thread hilo1, hilo2, hilo3;
        delegate void delegado(int valor);
        delegate void otroDelegado(ProgressBar progressBar, int valor);

        public FrmThreads()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            hilo1 = new Thread(new ParameterizedThreadStart(Proceso));
            hilo2 = new Thread(new ParameterizedThreadStart(Proceso));
            hilo3 = new Thread(new ParameterizedThreadStart(Proceso));

            hilo1.Start(new { ProgressBar = pb1, Delay = 70 });
            hilo2.Start(new { ProgressBar = pb2, Delay = 40 });
            hilo3.Start(new { ProgressBar = pb3, Delay = 100 });
        }

        private void Proceso(object? parametro)
        {
            if (parametro is not { } param) return;
            var pb = param.GetType().GetProperty("ProgressBar")?.GetValue(param) as ProgressBar;
            var delay = (int?)param.GetType().GetProperty("Delay")?.GetValue(param) ?? 0;

            if (pb == null || delay <= 0) return;

            for (int i = 0; i <= 100; i++)
            {
                otroDelegado MD = new otroDelegado(Actualizar);
                Invoke(MD, new object[] { pb, i });
                //Invoke(new Action(() => pb.Value = i));
                Thread.Sleep(delay);
            }
        }

        private void Actualizar(ProgressBar pb, int valor)
        {
            pb.Value = valor;
        }

        private void Proceso1()
        {
            for (int i = 0; i <= 100; i++)
            {
                delegado MD = new delegado(Actualizar1);
                Invoke(MD, new object[] { i });
                Thread.Sleep(70);
            }
        }

        private void Actualizar1(int valor)
        {
            pb1.Value = valor;
        }

        private void Proceso2()
        {
            for (int i = 0; i <= 100; i++)
            {
                delegado MD = new delegado(Actualizar2);
                Invoke(MD, new object[] { i });
                Thread.Sleep(40);
            }
        }

        private void Actualizar2(int valor)
        {
            pb2.Value = valor;
        }

        private void Proceso3()
        {
            for (int i = 0; i <= 100; i++)
            {
                delegado MD = new delegado(Actualizar3);
                Invoke(MD, new object[] { i });
                Thread.Sleep(100);
            }
        }

        private void Actualizar3(int valor)
        {
            pb3.Value = valor;
        }
    }
}
