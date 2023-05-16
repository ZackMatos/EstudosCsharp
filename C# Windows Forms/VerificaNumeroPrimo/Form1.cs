using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VerificaNumeroPrimo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_verificar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_primo.Text))
            {
                MessageBox.Show("Digite um número para descobrir se é primo ou não");
                return;
            }
            int numeroDigitado = int.Parse (tb_primo.Text);
            int div = 0;
            int numeroAleatorio = numeroDigitado;
          
            while (numeroAleatorio != 0)
            {
                if (numeroDigitado % numeroAleatorio == 0)
                {
                    div++;
                    numeroAleatorio--;
                }
                else
                {
                    numeroAleatorio--;
                }
                if (div == 2 && numeroAleatorio == 0)
                {
                    lb_resultado.Text = ($"O número {numeroDigitado} é primo");
                }
                if (div > 2 && numeroAleatorio == 0)
                {
                    lb_resultado.Text = ($"O número {numeroDigitado} não é primo");
                }
              
            }
           
            
        }
    }
}
