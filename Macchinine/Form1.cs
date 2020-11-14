using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Macchinine
{
    public partial class Form1 : Form
    {
        BackgroundWorker bgw_Macchina1, bgw_Macchina2;
        public Random rnd = new Random();
        public bool boh;
        public Form1()
        {
            InitializeComponent();

            FotoStrada.Controls.Add(FotoMacchina1);
            FotoStrada.Controls.Add(FotoMacchina2);
        }

        private void Bgw_Macchina1_DoWork(object sender, DoWorkEventArgs e)
        {
            PictureBox pb = (PictureBox)e.Argument;
            BackgroundWorker bgw = sender as BackgroundWorker;
            while(!(FotoMacchina1.Right >= FotoStrada.Width - 50 || FotoMacchina2.Right >= FotoStrada.Width - 50))
            {
                if (bgw.CancellationPending)
                    return;
                bgw.ReportProgress(0, e.Argument);
                Thread.Sleep(25);
            }
            if (FotoMacchina1.Right >= FotoStrada.Width - 50 && FotoMacchina2.Right < FotoStrada.Width - 50)
                MessageBox.Show("Vince la macchina arancione!!");
            else if(FotoMacchina2.Right >= FotoStrada.Width - 50 && FotoMacchina1.Right < FotoStrada.Width - 50)
                MessageBox.Show("Vince la macchina blu!!");
            else
                MessageBox.Show("Pareggio!!");
        }

        private void Bgw_Macchina1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            PictureBox pb = (PictureBox)e.UserState;
            pb.Left += rnd.Next(1, 5);
        }
        //private void Gara(bool UnoDue, Point Posizione)
        //{
        //    int y;
        //    int x = 25;
        //    y = UnoDue ? 91 : 265;
        //    Posizione.X = x;
        //    Posizione.Y = y;
        //    do
        //    {
        //        x += rnd.Next(1, 4);
        //        Posizione.X = x;
        //    } while ( x >= 600);
        //    if (UnoDue) { MessageBox.Show("Ha vinto la macchina arancione!!"); }
        //    else { MessageBox.Show("Ha vinto la macchina blu!!"); }
        //}

        private void BtnAvvio_Click(object sender, EventArgs e)
        {
            if (!boh)
            {
                bgw_Macchina1 = new BackgroundWorker();
                bgw_Macchina1.WorkerReportsProgress = true;
                bgw_Macchina1.WorkerSupportsCancellation = true;
                bgw_Macchina1.DoWork += Bgw_Macchina1_DoWork;
                bgw_Macchina1.ProgressChanged += Bgw_Macchina1_ProgressChanged;
                bgw_Macchina2 = new BackgroundWorker();
                bgw_Macchina2.WorkerReportsProgress = true;
                bgw_Macchina2.WorkerSupportsCancellation = true;
                bgw_Macchina2.DoWork += Bgw_Macchina1_DoWork;
                bgw_Macchina2.ProgressChanged += Bgw_Macchina1_ProgressChanged;
                bgw_Macchina1.RunWorkerAsync(FotoMacchina1);
                bgw_Macchina2.RunWorkerAsync(FotoMacchina2);
                boh = true;
            }
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            bgw_Macchina1.CancelAsync();
            bgw_Macchina2.CancelAsync();
        }

        private void BtnRivincita_Click(object sender, EventArgs e)
        {
            if (bgw_Macchina1 == null)
                bgw_Macchina1.CancelAsync();
            if (bgw_Macchina2 == null)
                bgw_Macchina2.CancelAsync();
            FotoMacchina1.Left = 0;
            FotoMacchina2.Left = 0;
            Refresh();
        }
    }
}
