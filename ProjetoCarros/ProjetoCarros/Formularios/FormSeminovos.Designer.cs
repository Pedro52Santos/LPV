﻿
namespace ProjetoCarros.Formularios
{
    partial class FormSeminovos
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
            this.components = new System.ComponentModel.Container();
            this.gridVeiculos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Placa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Idade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alorAtual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Situacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridVeiculos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridVeiculos
            // 
            this.gridVeiculos.BackgroundColor = System.Drawing.Color.DimGray;
            this.gridVeiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridVeiculos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Modelo,
            this.Placa,
            this.Idade,
            this.alorAtual,
            this.Situacao});
            this.gridVeiculos.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gridVeiculos.Location = new System.Drawing.Point(67, 92);
            this.gridVeiculos.Margin = new System.Windows.Forms.Padding(0);
            this.gridVeiculos.Name = "gridVeiculos";
            this.gridVeiculos.Size = new System.Drawing.Size(916, 380);
            this.gridVeiculos.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(68)))), ((int)(((byte)(228)))));
            this.label1.Location = new System.Drawing.Point(196, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(472, 35);
            this.label1.TabIndex = 20;
            this.label1.Text = "Lista de veículos Seminovos";
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Id.DataPropertyName = "id";
            this.Id.HeaderText = "ID";
            this.Id.Name = "Id";
            // 
            // Modelo
            // 
            this.Modelo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Modelo.DataPropertyName = "modelo";
            this.Modelo.HeaderText = "Modelo";
            this.Modelo.Name = "Modelo";
            // 
            // Placa
            // 
            this.Placa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Placa.DataPropertyName = "placa";
            this.Placa.HeaderText = "Placa";
            this.Placa.Name = "Placa";
            // 
            // Idade
            // 
            this.Idade.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Idade.DataPropertyName = "idade";
            this.Idade.HeaderText = "Idade";
            this.Idade.Name = "Idade";
            // 
            // alorAtual
            // 
            this.alorAtual.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.alorAtual.DataPropertyName = "valoratual";
            this.alorAtual.HeaderText = "Valor pós Depreciação";
            this.alorAtual.Name = "alorAtual";
            // 
            // Situacao
            // 
            this.Situacao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Situacao.DataPropertyName = "situacao";
            this.Situacao.HeaderText = "Situação";
            this.Situacao.Name = "Situacao";
            // 
            // FormSeminovos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.gridVeiculos);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormSeminovos";
            this.Text = "FormSeminovos";
            ((System.ComponentModel.ISupportInitialize)(this.gridVeiculos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridVeiculos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Placa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Idade;
        private System.Windows.Forms.DataGridViewTextBoxColumn alorAtual;
        private System.Windows.Forms.DataGridViewTextBoxColumn Situacao;
    }
}