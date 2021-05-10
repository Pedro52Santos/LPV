namespace Aula02.Formularios
{
    partial class FormSoma
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.ValorA = new System.Windows.Forms.TextBox();
            this.ValorB = new System.Windows.Forms.TextBox();
            this.Resultado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btCalcular = new System.Windows.Forms.Button();
            this.btLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(246, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Realizar Soma";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ValorA
            // 
            this.ValorA.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ValorA.Location = new System.Drawing.Point(273, 83);
            this.ValorA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ValorA.Name = "ValorA";
            this.ValorA.Size = new System.Drawing.Size(110, 32);
            this.ValorA.TabIndex = 1;
            // 
            // ValorB
            // 
            this.ValorB.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ValorB.Location = new System.Drawing.Point(273, 134);
            this.ValorB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ValorB.Name = "ValorB";
            this.ValorB.Size = new System.Drawing.Size(110, 32);
            this.ValorB.TabIndex = 2;
            // 
            // Resultado
            // 
            this.Resultado.Location = new System.Drawing.Point(273, 202);
            this.Resultado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Resultado.Name = "Resultado";
            this.Resultado.Size = new System.Drawing.Size(110, 23);
            this.Resultado.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(273, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Valor 1:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(273, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Valor 2:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(273, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Resultado:";
            // 
            // btCalcular
            // 
            this.btCalcular.Location = new System.Drawing.Point(273, 239);
            this.btCalcular.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(109, 22);
            this.btCalcular.TabIndex = 7;
            this.btCalcular.Text = "Calcular";
            this.btCalcular.UseVisualStyleBackColor = true;
            this.btCalcular.Click += new System.EventHandler(this.btCalcular_Click);
            // 
            // btLimpar
            // 
            this.btLimpar.Location = new System.Drawing.Point(273, 281);
            this.btLimpar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(109, 22);
            this.btLimpar.TabIndex = 8;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = true;
            // 
            // FormSoma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 338);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.btCalcular);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Resultado);
            this.Controls.Add(this.ValorB);
            this.Controls.Add(this.ValorA);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormSoma";
            this.Text = "Formulário para somar dois Valores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ValorA;
        private System.Windows.Forms.TextBox ValorB;
        private System.Windows.Forms.TextBox Resultado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btCalcular;
        private System.Windows.Forms.Button btLimpar;
    }
}