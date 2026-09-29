using orcamentoDev_3ESPR.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OrcamentoDev.Views
{
    public partial class FrmSplash : Form
    {
        private System.Windows.Forms.Timer timerSplash;
        private ProgressBar prgCarregando;

        public FrmSplash()
        {
            InitializeComponent();

            // Ensure progress bar exists (designer may create it; fallback if not)
            if (prgCarregando == null)
            {
                prgCarregando = new ProgressBar
                {
                    Minimum = 0,
                    Maximum = 100,
                    Value = 0,
                    Dock = DockStyle.Bottom
                };
                Controls.Add(prgCarregando);
            }
            else
            {
                prgCarregando.Minimum = 0;
                prgCarregando.Maximum = 100;
                prgCarregando.Value = 0;
            }

            timerSplash = new System.Windows.Forms.Timer();
            timerSplash.Interval = 100;
            timerSplash.Tick += timer1_Tick;
            timerSplash.Start();
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (prgCarregando.Value < 100)
            {
                prgCarregando.Value += 2;
            }
            else
            {
                timerSplash.Stop();
                FrmLogin login = new FrmLogin();
                login.Show();
                this.Hide();
            }
        }
    }
}