using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Operacoes_OO
{
    
public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        
    private void bt_somar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_num.Text) || string.IsNullOrEmpty(tb_num2.Text))
            {
                MessageBox.Show("Por favor preencha todos os campos");
                return;
            }
            Operações somar = new Operações();
             lb_resultado.Text = somar.Somar(
                 float.Parse(tb_num.Text),float.Parse(tb_num2.Text)).ToString();

        }

        private void bt_subtrair_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_num.Text) || string.IsNullOrEmpty(tb_num2.Text))
            {
                MessageBox.Show("Por favor preencha todos os campos");
                return;
            }
            Operações subtrair = new Operações();
            lb_resultado.Text = subtrair.Subtrair(
                 float.Parse(tb_num.Text), float.Parse(tb_num2.Text)).ToString();

        }

        private void bt_multiplicar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_num.Text) || string.IsNullOrEmpty(tb_num2.Text))
            {
                MessageBox.Show("Por favor preencha todos os campos");
                return;
            }
            Operações multiplicar = new Operações();
            lb_resultado.Text =  multiplicar.Multiplicar(
                 float.Parse(tb_num.Text), float.Parse(tb_num2.Text)).ToString();
        }

        private void bt_dividir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_num.Text) || string.IsNullOrEmpty(tb_num2.Text))
            {
                MessageBox.Show("Por favor preencha todos os campos");
                return;
            }
            Operações dividir = new Operações();
            lb_resultado.Text = dividir.Dividir(
                 float.Parse(tb_num.Text), float.Parse(tb_num2.Text)).ToString();
        }

        private void bt_limpar_Click(object sender, EventArgs e)
        {
            tb_num.Text = "";
            tb_num2.Text = "";
        }

        private void bt_resto_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_num.Text) || string.IsNullOrEmpty(tb_num2.Text))
            {
                MessageBox.Show("Por favor preencha todos os campos");
                return;
            }
            Operações resto = new Operações();
            lb_resultado.Text = resto.Resto(
                 float.Parse(tb_num.Text), float.Parse(tb_num2.Text)).ToString();
        }
    }
}
