using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwitchTeste
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_executar_Click(object sender, EventArgs e)
        {
            int valor = int.Parse (tb_valor.Text);

            switch (valor)
            {
                case 10:
                    lb_resultado.Text = "O valor é 10.";
                    break;
                case 20:
                    lb_resultado.Text = "O valor é 20.";
                    break;
                case 30:
                    lb_resultado.Text = "O valor é 30.";
                    break;
                case 40:
                    lb_resultado.Text = "O valor é 40.";
                    break;
                default:
                    lb_resultado.Text = "Não consigo identificar.";
                    break;

            }
        }
    }
}
