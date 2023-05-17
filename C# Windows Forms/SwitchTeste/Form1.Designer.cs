namespace SwitchTeste
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
            this.tb_valor = new System.Windows.Forms.TextBox();
            this.btn_executar = new System.Windows.Forms.Button();
            this.lb_resultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_valor
            // 
            this.tb_valor.Location = new System.Drawing.Point(117, 91);
            this.tb_valor.Name = "tb_valor";
            this.tb_valor.Size = new System.Drawing.Size(142, 20);
            this.tb_valor.TabIndex = 0;
            // 
            // btn_executar
            // 
            this.btn_executar.Location = new System.Drawing.Point(117, 310);
            this.btn_executar.Name = "btn_executar";
            this.btn_executar.Size = new System.Drawing.Size(147, 46);
            this.btn_executar.TabIndex = 1;
            this.btn_executar.Text = "Executar";
            this.btn_executar.UseVisualStyleBackColor = true;
            this.btn_executar.Click += new System.EventHandler(this.btn_executar_Click);
            // 
            // lb_resultado
            // 
            this.lb_resultado.AutoSize = true;
            this.lb_resultado.Location = new System.Drawing.Point(148, 186);
            this.lb_resultado.Name = "lb_resultado";
            this.lb_resultado.Size = new System.Drawing.Size(0, 13);
            this.lb_resultado.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 491);
            this.Controls.Add(this.lb_resultado);
            this.Controls.Add(this.btn_executar);
            this.Controls.Add(this.tb_valor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_valor;
        private System.Windows.Forms.Button btn_executar;
        private System.Windows.Forms.Label lb_resultado;
    }
}

