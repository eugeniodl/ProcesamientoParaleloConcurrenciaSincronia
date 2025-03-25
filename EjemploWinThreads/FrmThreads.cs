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
            hilo1 = new Thread(new ThreadStart(Proceso1));
            hilo2 = new Thread(new ThreadStart(Proceso2));
            hilo3 = new Thread(new ThreadStart(Proceso3));

            hilo1.Start();
            hilo2.Start();
            hilo3.Start();
        }

        private void Proceso()
        {
            for (int i = 0; i <= 100; i++)
            {
                otroDelegado MD = new otroDelegado(Actualizar);
                Invoke(MD, new object[] { pb1, i });
                Thread.Sleep(70);
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
