namespace AppLoteria
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
            this.btMegaSena = new System.Windows.Forms.Button();
            this.btQuina = new System.Windows.Forms.Button();
            this.btLotoFacil = new System.Windows.Forms.Button();
            this.btLotoMania = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btMegaSena
            // 
            this.btMegaSena.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMegaSena.Location = new System.Drawing.Point(105, 154);
            this.btMegaSena.Name = "btMegaSena";
            this.btMegaSena.Size = new System.Drawing.Size(200, 37);
            this.btMegaSena.TabIndex = 0;
            this.btMegaSena.Text = "MEGA SENA";
            this.btMegaSena.UseVisualStyleBackColor = true;
            this.btMegaSena.Click += new System.EventHandler(this.button1_Click);
            // 
            // btQuina
            // 
            this.btQuina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btQuina.Location = new System.Drawing.Point(363, 154);
            this.btQuina.Name = "btQuina";
            this.btQuina.Size = new System.Drawing.Size(200, 37);
            this.btQuina.TabIndex = 1;
            this.btQuina.Text = "QUINA";
            this.btQuina.UseVisualStyleBackColor = true;
            this.btQuina.Click += new System.EventHandler(this.btQuina_Click);
            // 
            // btLotoFacil
            // 
            this.btLotoFacil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLotoFacil.Location = new System.Drawing.Point(105, 289);
            this.btLotoFacil.Name = "btLotoFacil";
            this.btLotoFacil.Size = new System.Drawing.Size(200, 37);
            this.btLotoFacil.TabIndex = 2;
            this.btLotoFacil.Text = "LOTOFACÍL";
            this.btLotoFacil.UseVisualStyleBackColor = true;
            this.btLotoFacil.Click += new System.EventHandler(this.btLotoFacil_Click);
            // 
            // btLotoMania
            // 
            this.btLotoMania.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLotoMania.Location = new System.Drawing.Point(363, 289);
            this.btLotoMania.Name = "btLotoMania";
            this.btLotoMania.Size = new System.Drawing.Size(200, 37);
            this.btLotoMania.TabIndex = 3;
            this.btLotoMania.Text = "LOTOMANIA";
            this.btLotoMania.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btLotoMania);
            this.Controls.Add(this.btLotoFacil);
            this.Controls.Add(this.btQuina);
            this.Controls.Add(this.btMegaSena);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btMegaSena;
        private System.Windows.Forms.Button btQuina;
        private System.Windows.Forms.Button btLotoFacil;
        private System.Windows.Forms.Button btLotoMania;
    }
}

