namespace ProjetoCarros.Formularios
{
    partial class FormListarSimples
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
            this.label1 = new System.Windows.Forms.Label();
            this.gridVeiculos = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Placa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataFabr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorZero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindSListaVeiculo = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridVeiculos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindSListaVeiculo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(68)))), ((int)(((byte)(228)))));
            this.label1.Location = new System.Drawing.Point(259, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(418, 35);
            this.label1.TabIndex = 17;
            this.label1.Text = "Lista de veículos simples";
            // 
            // gridVeiculos
            // 
            this.gridVeiculos.BackgroundColor = System.Drawing.Color.DimGray;
            this.gridVeiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridVeiculos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Modelo,
            this.Placa,
            this.DataFabr,
            this.ValorZero});
            this.gridVeiculos.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gridVeiculos.Location = new System.Drawing.Point(73, 95);
            this.gridVeiculos.Margin = new System.Windows.Forms.Padding(0);
            this.gridVeiculos.Name = "gridVeiculos";
            this.gridVeiculos.Size = new System.Drawing.Size(916, 185);
            this.gridVeiculos.TabIndex = 18;
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
            // DataFabr
            // 
            this.DataFabr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DataFabr.DataPropertyName = "datafabr";
            this.DataFabr.HeaderText = "Data de fabricação";
            this.DataFabr.Name = "DataFabr";
            // 
            // ValorZero
            // 
            this.ValorZero.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ValorZero.DataPropertyName = "valorzero";
            this.ValorZero.HeaderText = "Valor novo";
            this.ValorZero.Name = "ValorZero";
            // 
            // FormListarSimples
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.gridVeiculos);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormListarSimples";
            this.Text = "FormListarSimples";
            ((System.ComponentModel.ISupportInitialize)(this.gridVeiculos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindSListaVeiculo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridVeiculos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Placa;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataFabr;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorZero;
        private System.Windows.Forms.BindingSource bindSListaVeiculo;
    }
}