
namespace Aula02.Formularios
{
    partial class FormMultiplicacao
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
            this.btLimpar = new System.Windows.Forms.Button();
            this.btCalcular = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.EdResultado = new System.Windows.Forms.TextBox();
            this.ValorB = new System.Windows.Forms.TextBox();
            this.ValorA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btLimpar
            // 
            this.btLimpar.Location = new System.Drawing.Point(345, 347);
            this.btLimpar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(109, 22);
            this.btLimpar.TabIndex = 35;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // btCalcular
            // 
            this.btCalcular.Location = new System.Drawing.Point(345, 305);
            this.btCalcular.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(109, 22);
            this.btCalcular.TabIndex = 34;
            this.btCalcular.Text = "Calcular";
            this.btCalcular.UseVisualStyleBackColor = true;
            this.btCalcular.Click += new System.EventHandler(this.btCalcular_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(345, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 15);
            this.label4.TabIndex = 33;
            this.label4.Text = "Resultado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(345, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 32;
            this.label3.Text = "Valor 2:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(345, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 31;
            this.label2.Text = "Valor 1:";
            // 
            // EdResultado
            // 
            this.EdResultado.Location = new System.Drawing.Point(345, 268);
            this.EdResultado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EdResultado.Name = "EdResultado";
            this.EdResultado.Size = new System.Drawing.Size(110, 23);
            this.EdResultado.TabIndex = 30;
            // 
            // ValorB
            // 
            this.ValorB.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ValorB.Location = new System.Drawing.Point(345, 200);
            this.ValorB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ValorB.Name = "ValorB";
            this.ValorB.Size = new System.Drawing.Size(110, 32);
            this.ValorB.TabIndex = 29;
            // 
            // ValorA
            // 
            this.ValorA.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ValorA.Location = new System.Drawing.Point(345, 149);
            this.ValorA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ValorA.Name = "ValorA";
            this.ValorA.Size = new System.Drawing.Size(110, 32);
            this.ValorA.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(298, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 30);
            this.label1.TabIndex = 27;
            this.label1.Text = "Realizar Subtração";
            // 
            // FormMultiplicacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.btCalcular);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EdResultado);
            this.Controls.Add(this.ValorB);
            this.Controls.Add(this.ValorA);
            this.Controls.Add(this.label1);
            this.Name = "FormMultiplicacao";
            this.Text = "FormMultiplicacao";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Button btCalcular;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox EdResultado;
        private System.Windows.Forms.TextBox ValorB;
        private System.Windows.Forms.TextBox ValorA;
        private System.Windows.Forms.Label label1;
    }
}