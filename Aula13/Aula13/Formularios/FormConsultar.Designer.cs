namespace Aula13.Formularios
{
    partial class FormConsultar
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CbPesquisa = new System.Windows.Forms.ComboBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.EdNome = new System.Windows.Forms.TextBox();
            this.EdeNumIns = new System.Windows.Forms.TextBox();
            this.EdNota = new System.Windows.Forms.TextBox();
            this.EdSituacao = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(193, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consultar por nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(193, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(194, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Número de Inscrição:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(404, 318);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nota:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(615, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Situação:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // CbPesquisa
            // 
            this.CbPesquisa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.CbPesquisa.DataSource = this.bindingSource1;
            this.CbPesquisa.FormattingEnabled = true;
            this.CbPesquisa.Location = new System.Drawing.Point(197, 116);
            this.CbPesquisa.Name = "CbPesquisa";
            this.CbPesquisa.Size = new System.Drawing.Size(419, 21);
            this.CbPesquisa.TabIndex = 5;
            // 
            // EdNome
            // 
            this.EdNome.Location = new System.Drawing.Point(197, 246);
            this.EdNome.Name = "EdNome";
            this.EdNome.Size = new System.Drawing.Size(519, 19);
            this.EdNome.TabIndex = 6;
            // 
            // EdeNumIns
            // 
            this.EdeNumIns.Location = new System.Drawing.Point(197, 338);
            this.EdeNumIns.Name = "EdeNumIns";
            this.EdeNumIns.Size = new System.Drawing.Size(186, 19);
            this.EdeNumIns.TabIndex = 7;
            // 
            // EdNota
            // 
            this.EdNota.Location = new System.Drawing.Point(406, 338);
            this.EdNota.Name = "EdNota";
            this.EdNota.Size = new System.Drawing.Size(187, 19);
            this.EdNota.TabIndex = 8;
            // 
            // EdSituacao
            // 
            this.EdSituacao.Location = new System.Drawing.Point(618, 338);
            this.EdSituacao.Name = "EdSituacao";
            this.EdSituacao.Size = new System.Drawing.Size(98, 19);
            this.EdSituacao.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(623, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Pesquisar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(359, 407);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(187, 31);
            this.button2.TabIndex = 11;
            this.button2.Text = "Limpar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Impact", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(361, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 37);
            this.label6.TabIndex = 12;
            this.label6.Text = "Consultar";
            // 
            // FormConsultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.EdSituacao);
            this.Controls.Add(this.EdNota);
            this.Controls.Add(this.EdeNumIns);
            this.Controls.Add(this.EdNome);
            this.Controls.Add(this.CbPesquisa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormConsultar";
            this.Text = "FormConsultar";
            this.Load += new System.EventHandler(this.FormConsultar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CbPesquisa;
        private System.Windows.Forms.TextBox EdNome;
        private System.Windows.Forms.TextBox EdeNumIns;
        private System.Windows.Forms.TextBox EdNota;
        private System.Windows.Forms.TextBox EdSituacao;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}