namespace Operacoes_OO
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_num = new System.Windows.Forms.TextBox();
            this.tb_num2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_somar = new System.Windows.Forms.Button();
            this.bt_subtrair = new System.Windows.Forms.Button();
            this.bt_multiplicar = new System.Windows.Forms.Button();
            this.bt_dividir = new System.Windows.Forms.Button();
            this.bt_limpar = new System.Windows.Forms.Button();
            this.lb_resultado = new System.Windows.Forms.Label();
            this.bt_resto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_num
            // 
            this.tb_num.Location = new System.Drawing.Point(172, 15);
            this.tb_num.Name = "tb_num";
            this.tb_num.Size = new System.Drawing.Size(144, 20);
            this.tb_num.TabIndex = 0;
            // 
            // tb_num2
            // 
            this.tb_num2.Location = new System.Drawing.Point(172, 43);
            this.tb_num2.Name = "tb_num2";
            this.tb_num2.Size = new System.Drawing.Size(144, 20);
            this.tb_num2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Digite um número:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Digite outro número:";
            // 
            // bt_somar
            // 
            this.bt_somar.Location = new System.Drawing.Point(12, 168);
            this.bt_somar.Name = "bt_somar";
            this.bt_somar.Size = new System.Drawing.Size(137, 38);
            this.bt_somar.TabIndex = 4;
            this.bt_somar.Text = "SOMAR";
            this.bt_somar.UseVisualStyleBackColor = true;
            this.bt_somar.Click += new System.EventHandler(this.bt_somar_Click);
            // 
            // bt_subtrair
            // 
            this.bt_subtrair.Location = new System.Drawing.Point(155, 168);
            this.bt_subtrair.Name = "bt_subtrair";
            this.bt_subtrair.Size = new System.Drawing.Size(137, 38);
            this.bt_subtrair.TabIndex = 5;
            this.bt_subtrair.Text = "SUBTRAIR";
            this.bt_subtrair.UseVisualStyleBackColor = true;
            this.bt_subtrair.Click += new System.EventHandler(this.bt_subtrair_Click);
            // 
            // bt_multiplicar
            // 
            this.bt_multiplicar.Location = new System.Drawing.Point(298, 168);
            this.bt_multiplicar.Name = "bt_multiplicar";
            this.bt_multiplicar.Size = new System.Drawing.Size(137, 38);
            this.bt_multiplicar.TabIndex = 6;
            this.bt_multiplicar.Text = "MULTIPLICAR";
            this.bt_multiplicar.UseVisualStyleBackColor = true;
            this.bt_multiplicar.Click += new System.EventHandler(this.bt_multiplicar_Click);
            // 
            // bt_dividir
            // 
            this.bt_dividir.Location = new System.Drawing.Point(441, 168);
            this.bt_dividir.Name = "bt_dividir";
            this.bt_dividir.Size = new System.Drawing.Size(137, 38);
            this.bt_dividir.TabIndex = 7;
            this.bt_dividir.Text = "DIVIDIR";
            this.bt_dividir.UseVisualStyleBackColor = true;
            this.bt_dividir.Click += new System.EventHandler(this.bt_dividir_Click);
            // 
            // bt_limpar
            // 
            this.bt_limpar.Location = new System.Drawing.Point(181, 277);
            this.bt_limpar.Name = "bt_limpar";
            this.bt_limpar.Size = new System.Drawing.Size(173, 44);
            this.bt_limpar.TabIndex = 8;
            this.bt_limpar.Text = "LIMPAR";
            this.bt_limpar.UseVisualStyleBackColor = true;
            this.bt_limpar.Click += new System.EventHandler(this.bt_limpar_Click);
            // 
            // lb_resultado
            // 
            this.lb_resultado.AutoSize = true;
            this.lb_resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_resultado.Location = new System.Drawing.Point(121, 92);
            this.lb_resultado.Name = "lb_resultado";
            this.lb_resultado.Size = new System.Drawing.Size(0, 20);
            this.lb_resultado.TabIndex = 9;
            // 
            // bt_resto
            // 
            this.bt_resto.Location = new System.Drawing.Point(12, 212);
            this.bt_resto.Name = "bt_resto";
            this.bt_resto.Size = new System.Drawing.Size(137, 38);
            this.bt_resto.TabIndex = 10;
            this.bt_resto.Text = "RESTO DA DIVISÃO";
            this.bt_resto.UseVisualStyleBackColor = true;
            this.bt_resto.Click += new System.EventHandler(this.bt_resto_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 333);
            this.Controls.Add(this.bt_resto);
            this.Controls.Add(this.lb_resultado);
            this.Controls.Add(this.bt_limpar);
            this.Controls.Add(this.bt_dividir);
            this.Controls.Add(this.bt_multiplicar);
            this.Controls.Add(this.bt_subtrair);
            this.Controls.Add(this.bt_somar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_num2);
            this.Controls.Add(this.tb_num);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_num;
        private System.Windows.Forms.TextBox tb_num2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_somar;
        private System.Windows.Forms.Button bt_subtrair;
        private System.Windows.Forms.Button bt_multiplicar;
        private System.Windows.Forms.Button bt_dividir;
        private System.Windows.Forms.Button bt_limpar;
        private System.Windows.Forms.Label lb_resultado;
        private System.Windows.Forms.Button bt_resto;
    }
}

