namespace AppCadCandidato.Formularios
{
    partial class FormCadastro
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
            this.label3 = new System.Windows.Forms.Label();
            this.edNota = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.edNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.edInscricao = new System.Windows.Forms.TextBox();
            this.btSalvar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 237);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Nota:";
            // 
            // edNota
            // 
            this.edNota.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.edNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edNota.Location = new System.Drawing.Point(49, 263);
            this.edNota.Margin = new System.Windows.Forms.Padding(6);
            this.edNota.Name = "edNota";
            this.edNota.Size = new System.Drawing.Size(247, 29);
            this.edNota.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 162);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nome:";
            // 
            // edNome
            // 
            this.edNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.edNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edNome.Location = new System.Drawing.Point(49, 188);
            this.edNome.Margin = new System.Windows.Forms.Padding(6);
            this.edNome.Name = "edNome";
            this.edNome.Size = new System.Drawing.Size(678, 29);
            this.edNome.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Número de Inscrição:";
            // 
            // edInscricao
            // 
            this.edInscricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edInscricao.Location = new System.Drawing.Point(49, 115);
            this.edInscricao.Margin = new System.Windows.Forms.Padding(6);
            this.edInscricao.Name = "edInscricao";
            this.edInscricao.Size = new System.Drawing.Size(247, 29);
            this.edInscricao.TabIndex = 6;
            // 
            // btSalvar
            // 
            this.btSalvar.Image = global::AppCadCandidato.Properties.Resources.businessregistration_signpen_negocio_inscripcio_2358__2_;
            this.btSalvar.Location = new System.Drawing.Point(597, 333);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(85, 69);
            this.btSalvar.TabIndex = 14;
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Image = global::AppCadCandidato.Properties.Resources.cancel_stop_exit_1583;
            this.btCancelar.Location = new System.Drawing.Point(355, 333);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(85, 69);
            this.btCancelar.TabIndex = 13;
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btAdd
            // 
            this.btAdd.Image = global::AppCadCandidato.Properties.Resources._new_add_user_16734__4_1;
            this.btAdd.Location = new System.Drawing.Point(136, 333);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 69);
            this.btAdd.TabIndex = 12;
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // FormCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.edNota);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.edNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.edInscricao);
            this.Name = "FormCadastro";
            this.Text = "FormCadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox edNota;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox edNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox edInscricao;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btSalvar;
    }
}