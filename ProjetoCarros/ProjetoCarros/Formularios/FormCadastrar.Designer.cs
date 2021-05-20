namespace ProjetoCarros.Formularios
{
    partial class FormCadastrar
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
            this.btCancelar = new System.Windows.Forms.Button();
            this.btSalvar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.edModelo = new System.Windows.Forms.TextBox();
            this.edPlaca = new System.Windows.Forms.TextBox();
            this.edValorN = new System.Windows.Forms.TextBox();
            this.dtDataFab = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btCancelar
            // 
            this.btCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(68)))), ((int)(((byte)(228)))));
            this.btCancelar.BackgroundImage = global::ProjetoCarros.Properties.Resources.cross;
            this.btCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCancelar.FlatAppearance.BorderSize = 0;
            this.btCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelar.Location = new System.Drawing.Point(504, 335);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(132, 60);
            this.btCancelar.TabIndex = 2;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btCancelar.UseVisualStyleBackColor = false;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btSalvar
            // 
            this.btSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(68)))), ((int)(((byte)(228)))));
            this.btSalvar.BackgroundImage = global::ProjetoCarros.Properties.Resources.diskette;
            this.btSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSalvar.FlatAppearance.BorderSize = 0;
            this.btSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalvar.Location = new System.Drawing.Point(166, 335);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(132, 60);
            this.btSalvar.TabIndex = 1;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btSalvar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(68)))), ((int)(((byte)(228)))));
            this.label1.Location = new System.Drawing.Point(261, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 35);
            this.label1.TabIndex = 6;
            this.label1.Text = "Cadastrar veículo\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(68)))), ((int)(((byte)(228)))));
            this.label2.Location = new System.Drawing.Point(113, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Modelo:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(68)))), ((int)(((byte)(228)))));
            this.label3.Location = new System.Drawing.Point(445, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Placa:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(68)))), ((int)(((byte)(228)))));
            this.label4.Location = new System.Drawing.Point(113, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Valor Novo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(68)))), ((int)(((byte)(228)))));
            this.label5.Location = new System.Drawing.Point(445, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Data de Fabricação:";
            // 
            // edModelo
            // 
            this.edModelo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.edModelo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edModelo.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.edModelo.Location = new System.Drawing.Point(116, 125);
            this.edModelo.Name = "edModelo";
            this.edModelo.Size = new System.Drawing.Size(246, 27);
            this.edModelo.TabIndex = 11;
            this.edModelo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // edPlaca
            // 
            this.edPlaca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.edPlaca.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edPlaca.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.edPlaca.Location = new System.Drawing.Point(448, 125);
            this.edPlaca.Name = "edPlaca";
            this.edPlaca.Size = new System.Drawing.Size(246, 27);
            this.edPlaca.TabIndex = 12;
            this.edPlaca.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // edValorN
            // 
            this.edValorN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.edValorN.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edValorN.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.edValorN.Location = new System.Drawing.Point(116, 243);
            this.edValorN.Name = "edValorN";
            this.edValorN.Size = new System.Drawing.Size(246, 27);
            this.edValorN.TabIndex = 13;
            // 
            // dtDataFab
            // 
            this.dtDataFab.CalendarFont = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDataFab.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(68)))), ((int)(((byte)(228)))));
            this.dtDataFab.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.dtDataFab.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDataFab.Location = new System.Drawing.Point(448, 244);
            this.dtDataFab.Name = "dtDataFab";
            this.dtDataFab.Size = new System.Drawing.Size(246, 20);
            this.dtDataFab.TabIndex = 14;
            // 
            // FormCadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtDataFab);
            this.Controls.Add(this.edValorN);
            this.Controls.Add(this.edPlaca);
            this.Controls.Add(this.edModelo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btSalvar);
            this.Name = "FormCadastrar";
            this.Text = "Registro de Veículos";
            this.Load += new System.EventHandler(this.FormCadastrar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox edModelo;
        private System.Windows.Forms.TextBox edPlaca;
        private System.Windows.Forms.TextBox edValorN;
        private System.Windows.Forms.DateTimePicker dtDataFab;
    }
}