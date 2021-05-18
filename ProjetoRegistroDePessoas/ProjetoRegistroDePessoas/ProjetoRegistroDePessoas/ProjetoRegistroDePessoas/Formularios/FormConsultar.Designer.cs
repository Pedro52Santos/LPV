namespace ProjetoRegistroDePessoas.Formularios
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
            this.edTel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.edRg = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.edCpf = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.edNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.combPesquisa = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btLimpar = new System.Windows.Forms.Button();
            this.btPesquisar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // edTel
            // 
            this.edTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edTel.Location = new System.Drawing.Point(505, 255);
            this.edTel.Name = "edTel";
            this.edTel.Size = new System.Drawing.Size(220, 26);
            this.edTel.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(501, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "TEL/CEL:";
            // 
            // edRg
            // 
            this.edRg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edRg.Location = new System.Drawing.Point(279, 255);
            this.edRg.Name = "edRg";
            this.edRg.Size = new System.Drawing.Size(220, 26);
            this.edRg.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(275, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "RG:";
            // 
            // edCpf
            // 
            this.edCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edCpf.Location = new System.Drawing.Point(53, 255);
            this.edCpf.Name = "edCpf";
            this.edCpf.Size = new System.Drawing.Size(220, 26);
            this.edCpf.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "CPF:";
            // 
            // edNome
            // 
            this.edNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edNome.Location = new System.Drawing.Point(53, 180);
            this.edNome.Name = "edNome";
            this.edNome.Size = new System.Drawing.Size(672, 26);
            this.edNome.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "NOME:";
            // 
            // combPesquisa
            // 
            this.combPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combPesquisa.FormattingEnabled = true;
            this.combPesquisa.Location = new System.Drawing.Point(93, 49);
            this.combPesquisa.Name = "combPesquisa";
            this.combPesquisa.Size = new System.Drawing.Size(513, 28);
            this.combPesquisa.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "CONSULTAR POR NOME";
            // 
            // btLimpar
            // 
            this.btLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLimpar.Image = global::ProjetoRegistroDePessoas.Properties.Resources.Clear_37294;
            this.btLimpar.Location = new System.Drawing.Point(350, 318);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(119, 104);
            this.btLimpar.TabIndex = 22;
            this.btLimpar.Text = "LIMPAR";
            this.btLimpar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btLimpar.UseVisualStyleBackColor = true;
            // 
            // btPesquisar
            // 
            this.btPesquisar.Image = global::ProjetoRegistroDePessoas.Properties.Resources.search_icon_icons_com_74448;
            this.btPesquisar.Location = new System.Drawing.Point(626, 34);
            this.btPesquisar.Name = "btPesquisar";
            this.btPesquisar.Size = new System.Drawing.Size(75, 59);
            this.btPesquisar.TabIndex = 20;
            this.btPesquisar.UseVisualStyleBackColor = true;
            // 
            // FormConsultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btPesquisar);
            this.Controls.Add(this.combPesquisa);
            this.Controls.Add(this.edTel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.edRg);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.edCpf);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.edNome);
            this.Controls.Add(this.label2);
            this.Name = "FormConsultar";
            this.Text = "CONSULTAR PESSOAS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox edTel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox edRg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox edCpf;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox edNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox combPesquisa;
        private System.Windows.Forms.Button btPesquisar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btLimpar;
    }
}