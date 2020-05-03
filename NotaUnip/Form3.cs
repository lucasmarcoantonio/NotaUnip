using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotaUnip
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }


       

        private void AlterarFoto_Click_1(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FotoPerfil.ImageLocation = openFileDialog1.FileName;
                FotoPerfil.Load();
            }
        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            textBox4.Clear();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void textBox5_Click(object sender, EventArgs e)
        {
            textBox5.Clear();
        }

        private void FotoPerfil_Click(object sender, EventArgs e)
        {

        }
    }
}
