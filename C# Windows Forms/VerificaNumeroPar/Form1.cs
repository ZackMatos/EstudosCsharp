using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VerificaNumeroPar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_verificar_Click(object sender, EventArgs e)
        {
            // Botão Verificar
            // Verificando se o campo está vazio ou não:
               if (string.IsNullOrEmpty(tb_numero.Text))
            {
                MessageBox.Show("Digite um número para saber se é par ou ímpar");
                return;
            }
            //Entrada 
            int numeroDigitado = int.Parse(tb_numero.Text);

            //Processo 
            int resultado = numeroDigitado % 2;
          
            
            /* Se o resto da divisão do numero digitado dividido por 2 
              for 0 então o número é par, caso isso não aconteça 
               o número é impar. */

            // if ternário
            //Saída
            lb_resultado.Text = resultado == 0 ? "O número é par" :
                 "O número é impar";
            
             
         
            
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            lb_resultado.Text = "";
            tb_numero.Text = "";
        }
    }
}
