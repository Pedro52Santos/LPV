﻿namespace ProjetoRegistroDePessoas
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
            this.btConsultar = new System.Windows.Forms.Button();
            this.btListar = new System.Windows.Forms.Button();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btConsultar
            // 
            this.btConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConsultar.Image = global::ProjetoRegistroDePessoas.Properties.Resources.search_find_user_16727;
            this.btConsultar.Location = new System.Drawing.Point(425, 210);
            this.btConsultar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btConsultar.Name = "btConsultar";
            this.btConsultar.Size = new System.Drawing.Size(247, 193);
            this.btConsultar.TabIndex = 3;
            this.btConsultar.Text = "CONSULTAR";
            this.btConsultar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btConsultar.UseVisualStyleBackColor = true;
            this.btConsultar.Click += new System.EventHandler(this.btConsultar_Click);
            // 
            // btListar
            // 
            this.btListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btListar.Image = global::ProjetoRegistroDePessoas.Properties.Resources.L4;
            this.btListar.Location = new System.Drawing.Point(760, 210);
            this.btListar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btListar.Name = "btListar";
            this.btListar.Size = new System.Drawing.Size(247, 193);
            this.btListar.TabIndex = 2;
            this.btListar.Text = "LISTAR";
            this.btListar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btListar.UseVisualStyleBackColor = true;
            // 
            // btCadastrar
            // 
            this.btCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastrar.Image = global::ProjetoRegistroDePessoas.Properties.Resources.businessregistration_signpen_negocio_inscripcio_2358;
            this.btCadastrar.Location = new System.Drawing.Point(89, 210);
            this.btCadastrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(247, 193);
            this.btCadastrar.TabIndex = 0;
            this.btCadastrar.Text = "CADASTRAR";
            this.btCadastrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btCadastrar.UseVisualStyleBackColor = true;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(335, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(389, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "REGISTRO DE PESSOAS";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btConsultar);
            this.Controls.Add(this.btListar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btCadastrar);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "MENU";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.Button btListar;
        private System.Windows.Forms.Button btConsultar;
        private System.Windows.Forms.Label label1;
    }
}

