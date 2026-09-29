using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace orcamentoDev_3ESPR.Views
{
    partial class FrmSplash
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblTituloSplash = new Label();
            lblCarregandoModulo = new Label();
            prgCarregando = new ProgressBar();
            timer1 = new System.Windows.Forms.Timer(components);
            // 
            // lblTituloSplash
            // 
            lblTituloSplash.AutoSize = true;
            lblTituloSplash.Location = new Point(345, 55);
            lblTituloSplash.Name = "lblTituloSplash";
            lblTituloSplash.Size = new Size(132, 15);
            lblTituloSplash.TabIndex = 0;
            lblTituloSplash.Text = "Sistema de Orçamentos";
            // 
            // lblCarregandoModulo
            // 
            lblCarregandoModulo.AutoSize = true;
            lblCarregandoModulo.Location = new Point(345, 144);
            lblCarregandoModulo.Name = "lblCarregandoModulo";
            lblCarregandoModulo.Size = new Size(128, 15);
            lblCarregandoModulo.TabIndex = 1;
            lblCarregandoModulo.Text = "Carregando módulos...";
            // 
            // prgCarregando
            // 
            prgCarregando.Location = new Point(55, 393);
            prgCarregando.Name = "prgCarregando";
            prgCarregando.Size = new Size(708, 32);
            prgCarregando.TabIndex = 2;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // FrmSplash
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(prgCarregando);
            Controls.Add(lblCarregandoModulo);
            Controls.Add(lblTituloSplash);
            Name = "FrmSplash";
            Text = "Form1";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label lblTituloSplash;
        private Label lblCarregandoModulo;
        private ProgressBar prgCarregando;
        private System.Windows.Forms.Timer timer1;

        public SizeF AutoScaleDimensions { get; private set; }
        public AutoScaleMode AutoScaleMode { get; private set; }
        public Size ClientSize { get; private set; }
        public object Controls { get; private set; }
        public string Name { get; private set; }
        public string Text { get; private set; }
    }
}