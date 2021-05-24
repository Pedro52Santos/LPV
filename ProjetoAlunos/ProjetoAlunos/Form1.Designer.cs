namespace ProjetoAlunos
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btAcimaDe = new System.Windows.Forms.Button();
            this.btReprovados = new System.Windows.Forms.Button();
            this.btAprovados = new System.Windows.Forms.Button();
            this.btConsultar = new System.Windows.Forms.Button();
            this.btListarCompleto = new System.Windows.Forms.Button();
            this.btListarSimples = new System.Windows.Forms.Button();
            this.btCadastrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjetoAlunos.Properties.Resources.escola;
            this.pictureBox1.Location = new System.Drawing.Point(19, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(313, 312);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btAcimaDe
            // 
            this.btAcimaDe.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btAcimaDe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btAcimaDe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAcimaDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAcimaDe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.btAcimaDe.Image = global::ProjetoAlunos.Properties.Resources.medal;
            this.btAcimaDe.Location = new System.Drawing.Point(372, 339);
            this.btAcimaDe.Name = "btAcimaDe";
            this.btAcimaDe.Size = new System.Drawing.Size(385, 72);
            this.btAcimaDe.TabIndex = 6;
            this.btAcimaDe.Text = "Acima de 80 pontos";
            this.btAcimaDe.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btAcimaDe.UseVisualStyleBackColor = false;
            this.btAcimaDe.Click += new System.EventHandler(this.btAcimaDe_Click);
            // 
            // btReprovados
            // 
            this.btReprovados.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btReprovados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btReprovados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btReprovados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReprovados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.btReprovados.Image = global::ProjetoAlunos.Properties.Resources.error;
            this.btReprovados.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btReprovados.Location = new System.Drawing.Point(576, 229);
            this.btReprovados.Name = "btReprovados";
            this.btReprovados.Size = new System.Drawing.Size(181, 93);
            this.btReprovados.TabIndex = 5;
            this.btReprovados.Text = "Lista de Reprovados";
            this.btReprovados.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btReprovados.UseVisualStyleBackColor = false;
            this.btReprovados.Click += new System.EventHandler(this.btReprovados_Click);
            // 
            // btAprovados
            // 
            this.btAprovados.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btAprovados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btAprovados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAprovados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAprovados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.btAprovados.Image = global::ProjetoAlunos.Properties.Resources.note__2_;
            this.btAprovados.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btAprovados.Location = new System.Drawing.Point(372, 229);
            this.btAprovados.Name = "btAprovados";
            this.btAprovados.Size = new System.Drawing.Size(181, 93);
            this.btAprovados.TabIndex = 4;
            this.btAprovados.Text = "Lista de Aprovados";
            this.btAprovados.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btAprovados.UseVisualStyleBackColor = false;
            this.btAprovados.Click += new System.EventHandler(this.btAprovados_Click);
            // 
            // btConsultar
            // 
            this.btConsultar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btConsultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConsultar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.btConsultar.Image = global::ProjetoAlunos.Properties.Resources.loupe;
            this.btConsultar.Location = new System.Drawing.Point(576, 141);
            this.btConsultar.Name = "btConsultar";
            this.btConsultar.Size = new System.Drawing.Size(181, 72);
            this.btConsultar.TabIndex = 3;
            this.btConsultar.Text = "Consultar Alunos";
            this.btConsultar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btConsultar.UseVisualStyleBackColor = false;
            this.btConsultar.Click += new System.EventHandler(this.btConsultar_Click);
            // 
            // btListarCompleto
            // 
            this.btListarCompleto.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btListarCompleto.BackgroundImage = global::ProjetoAlunos.Properties.Resources.List_ALL;
            this.btListarCompleto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btListarCompleto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btListarCompleto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btListarCompleto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.btListarCompleto.Location = new System.Drawing.Point(372, 141);
            this.btListarCompleto.Name = "btListarCompleto";
            this.btListarCompleto.Size = new System.Drawing.Size(181, 72);
            this.btListarCompleto.TabIndex = 2;
            this.btListarCompleto.Text = "Listar Alunos Completo";
            this.btListarCompleto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btListarCompleto.UseVisualStyleBackColor = false;
            this.btListarCompleto.Click += new System.EventHandler(this.btListarCompleto_Click);
            // 
            // btListarSimples
            // 
            this.btListarSimples.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btListarSimples.BackgroundImage = global::ProjetoAlunos.Properties.Resources.list_simple;
            this.btListarSimples.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btListarSimples.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btListarSimples.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btListarSimples.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.btListarSimples.Location = new System.Drawing.Point(576, 42);
            this.btListarSimples.Name = "btListarSimples";
            this.btListarSimples.Size = new System.Drawing.Size(181, 72);
            this.btListarSimples.TabIndex = 1;
            this.btListarSimples.Text = "Listar Alunos Simples";
            this.btListarSimples.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btListarSimples.UseVisualStyleBackColor = false;
            this.btListarSimples.Click += new System.EventHandler(this.btListarSimples_Click);
            // 
            // btCadastrar
            // 
            this.btCadastrar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btCadastrar.BackgroundImage = global::ProjetoAlunos.Properties.Resources.add;
            this.btCadastrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.btCadastrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btCadastrar.Location = new System.Drawing.Point(372, 42);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(181, 72);
            this.btCadastrar.TabIndex = 0;
            this.btCadastrar.Text = "Cadastrar Aluno";
            this.btCadastrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btCadastrar.UseVisualStyleBackColor = false;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btAcimaDe);
            this.Controls.Add(this.btReprovados);
            this.Controls.Add(this.btAprovados);
            this.Controls.Add(this.btConsultar);
            this.Controls.Add(this.btListarCompleto);
            this.Controls.Add(this.btListarSimples);
            this.Controls.Add(this.btCadastrar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.Button btListarSimples;
        private System.Windows.Forms.Button btListarCompleto;
        private System.Windows.Forms.Button btConsultar;
        private System.Windows.Forms.Button btAprovados;
        private System.Windows.Forms.Button btReprovados;
        private System.Windows.Forms.Button btAcimaDe;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

