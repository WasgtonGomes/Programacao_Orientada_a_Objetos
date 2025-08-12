namespace AppCadCandidato
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
            this.btCadastrar = new System.Windows.Forms.Button();
            this.btListar = new System.Windows.Forms.Button();
            this.btConsultar = new System.Windows.Forms.Button();
            this.btStatistica = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btCadastrar
            // 
            this.btCadastrar.Location = new System.Drawing.Point(106, 136);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(216, 53);
            this.btCadastrar.TabIndex = 0;
            this.btCadastrar.Text = "CADASTRAR";
            this.btCadastrar.UseVisualStyleBackColor = true;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // btListar
            // 
            this.btListar.Location = new System.Drawing.Point(439, 132);
            this.btListar.Name = "btListar";
            this.btListar.Size = new System.Drawing.Size(216, 57);
            this.btListar.TabIndex = 1;
            this.btListar.Text = "LISTAR CANDIDATOS";
            this.btListar.UseVisualStyleBackColor = true;
            this.btListar.Click += new System.EventHandler(this.btListar_Click);
            // 
            // btConsultar
            // 
            this.btConsultar.Location = new System.Drawing.Point(112, 298);
            this.btConsultar.Name = "btConsultar";
            this.btConsultar.Size = new System.Drawing.Size(209, 53);
            this.btConsultar.TabIndex = 2;
            this.btConsultar.Text = "Consultar";
            this.btConsultar.UseVisualStyleBackColor = true;
            this.btConsultar.Click += new System.EventHandler(this.btConsultar_Click);
            // 
            // btStatistica
            // 
            this.btStatistica.Location = new System.Drawing.Point(439, 298);
            this.btStatistica.Name = "btStatistica";
            this.btStatistica.Size = new System.Drawing.Size(216, 53);
            this.btStatistica.TabIndex = 3;
            this.btStatistica.Text = "ESTATÍSTICA";
            this.btStatistica.UseVisualStyleBackColor = true;
            this.btStatistica.Click += new System.EventHandler(this.btStatistica_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btStatistica);
            this.Controls.Add(this.btConsultar);
            this.Controls.Add(this.btListar);
            this.Controls.Add(this.btCadastrar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.Button btListar;
        private System.Windows.Forms.Button btConsultar;
        private System.Windows.Forms.Button btStatistica;
    }
}

