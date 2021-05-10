
namespace Aula02
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btSoma = new System.Windows.Forms.Button();
            this.btSubtrair = new System.Windows.Forms.Button();
            this.btMultiplica = new System.Windows.Forms.Button();
            this.btDividir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btSoma
            // 
            this.btSoma.Location = new System.Drawing.Point(296, 232);
            this.btSoma.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btSoma.Name = "btSoma";
            this.btSoma.Size = new System.Drawing.Size(125, 31);
            this.btSoma.TabIndex = 0;
            this.btSoma.Text = "SOMA";
            this.btSoma.UseVisualStyleBackColor = true;
            this.btSoma.Click += new System.EventHandler(this.button1_Click);
            // 
            // btSubtrair
            // 
            this.btSubtrair.Location = new System.Drawing.Point(466, 232);
            this.btSubtrair.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btSubtrair.Name = "btSubtrair";
            this.btSubtrair.Size = new System.Drawing.Size(125, 31);
            this.btSubtrair.TabIndex = 1;
            this.btSubtrair.Text = "SUBTRAÇÃO";
            this.btSubtrair.UseVisualStyleBackColor = true;
            // 
            // btMultiplica
            // 
            this.btMultiplica.Location = new System.Drawing.Point(296, 321);
            this.btMultiplica.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btMultiplica.Name = "btMultiplica";
            this.btMultiplica.Size = new System.Drawing.Size(125, 31);
            this.btMultiplica.TabIndex = 2;
            this.btMultiplica.Text = "MULTIPLICAÇÃO";
            this.btMultiplica.UseVisualStyleBackColor = true;
            // 
            // btDividir
            // 
            this.btDividir.Location = new System.Drawing.Point(466, 321);
            this.btDividir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btDividir.Name = "btDividir";
            this.btDividir.Size = new System.Drawing.Size(125, 31);
            this.btDividir.TabIndex = 3;
            this.btDividir.Text = "DIVISÃO";
            this.btDividir.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.btDividir);
            this.Controls.Add(this.btMultiplica);
            this.Controls.Add(this.btSubtrair);
            this.Controls.Add(this.btSoma);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btSoma;
        private System.Windows.Forms.Button btSubtrair;
        private System.Windows.Forms.Button btMultiplica;
        private System.Windows.Forms.Button btDividir;
    }
}

