namespace U1_Tarea_1___AochengYe
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using System.Runtime.InteropServices;
    using U1_Tarea_1___AochengYe.dao;
    using U1_Tarea_1___AochengYe.dto;


    public partial class FormularioPrincipal : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
          private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int
        wParam, int lParam);

        public FormularioPrincipal()
        {
            InitializeComponent();
            this.ClientSize = new System.Drawing.Size(1499, 905);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmPrincipal());
        }

        private void btnMaxi_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaxi.Visible = false;
            btnRes.Visible = true;
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRes_Click(object sender, EventArgs e)
        {
            this.WindowState= FormWindowState.Normal;
            btnRes.Visible = false;
            btnMaxi.Visible= true;
        }

        private void AbrirFormEnPanel(object formhija)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btnPrincipal_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmPrincipal());
        }

        private void panelBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnAnnadir_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmAnnadir());
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmListar());

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmConsultar());
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmEliminar());
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmModificar());
        }
    }
}
