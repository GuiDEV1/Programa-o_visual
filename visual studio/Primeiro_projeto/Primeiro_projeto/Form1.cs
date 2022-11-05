using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Primeiro_projeto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btBoasVindas_Click(object sender, EventArgs e)
        {
            lbResultado.Text = "Olá " + txtNome.Text + " " + txtSobrenome.Text + ", seja bem-vindo!";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lbNome_Click(object sender, EventArgs e)
        {

        }
    }
}
