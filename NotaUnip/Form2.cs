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

namespace NotaUnip
{
    public partial class MenuVertical : Form
    {
        public MenuVertical()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void BtnSlide_Click(object sender, EventArgs e)
        {
            if(Menu.Width == 250)
            {
                Menu.Width = 50;
            } else
            {
                Menu.Width = 250;
            }
        }

        private void Titulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle,0x112,0xf012,0);
        }

        private void AbrirFormInPainel(object Formhijo)
        {
            if (this.PainelPrincipal.Controls.Count > 0)
                this.PainelPrincipal.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PainelPrincipal.Controls.Clear();
            this.PainelPrincipal.Controls.Add(fh);
            this.PainelPrincipal.Tag = fh;
            fh.Show();
         }

        private void button1_Click(object sender, EventArgs e)
        {
            //AbrirFormInPainel(new Painel());
            var teste = new Form3();
            teste.TopLevel = false;
            teste.Dock = DockStyle.Fill;
            this.PainelPrincipal.Controls.Clear();
            this.PainelPrincipal.Controls.Add(teste);
            this.PainelPrincipal.Tag = teste;
            teste.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você deseja Sair?", "Fechar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
      
            AbrirFormInPainel(new Form6());
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AbrirFormInPainel(new Form5());
        }

        
    }
}
