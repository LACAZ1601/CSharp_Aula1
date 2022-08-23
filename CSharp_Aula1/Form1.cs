using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_Aula1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string nome;
        string sobrenome;
        float N1, N2;

        private void button1_Click(object sender, EventArgs e)
        {
            nome = txtNome.Text;
            sobrenome = txtSobrenome.Text;
            nome = nome + " " + sobrenome;
            txtNomecompleto.Text = nome;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            N1 = float.Parse(txtN1.Text);
            N2 = float.Parse(txtN2.Text);
            N1 = N1 + N2;
            txtResultado.Text = N1.ToString();
            N1 = float.Parse(txtN1.Text);
            if (N1 >= 10)
            {
                txtResultado.Text = "É um número maior que dez";
            }
            else
            {
                txtResultado.Text = "É um número menor que dez";
            }
        }
    }
}
