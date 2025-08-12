namespace AppCadCandidato.Formularios
{
    partial class FormConsulta
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
            this.cbNome = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.edSituacao = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 268);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Nota:";
            // 
            // edNota
            // 
            this.edNota.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.edNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edNota.Location = new System.Drawing.Point(52, 294);
            this.edNota.Margin = new System.Windows.Forms.Padding(6);
            this.edNota.Name = "edNota";
            this.edNota.Size = new System.Drawing.Size(247, 29);
            this.edNota.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 193);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nome:";
            // 
            // edNome
            // 
            this.edNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.edNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edNome.Location = new System.Drawing.Point(52, 219);
            this.edNome.Margin = new System.Windows.Forms.Padding(6);
            this.edNome.Name = "edNome";
            this.edNome.Size = new System.Drawing.Size(678, 29);
            this.edNome.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 120);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Número de Inscrição:";
            // 
            // edInscricao
            // 
            this.edInscricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edInscricao.Location = new System.Drawing.Point(52, 146);
            this.edInscricao.Margin = new System.Windows.Forms.Padding(6);
            this.edInscricao.Name = "edInscricao";
            this.edInscricao.Size = new System.Drawing.Size(247, 29);
            this.edInscricao.TabIndex = 12;
            // 
            // cbNome
            // 
            this.cbNome.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbNome.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNome.FormattingEnabled = true;
            this.cbNome.Location = new System.Drawing.Point(235, 56);
            this.cbNome.Name = "cbNome";
            this.cbNome.Size = new System.Drawing.Size(318, 32);
            this.cbNome.TabIndex = 18;
            this.cbNome.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(276, 22);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(214, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "CONSULTAR POR NOME";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(48, 350);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Situação:";
            // 
            // edSituacao
            // 
            this.edSituacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.edSituacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edSituacao.Location = new System.Drawing.Point(52, 376);
            this.edSituacao.Margin = new System.Windows.Forms.Padding(6);
            this.edSituacao.Name = "edSituacao";
            this.edSituacao.Size = new System.Drawing.Size(247, 29);
            this.edSituacao.TabIndex = 20;
            // 
            // FormConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.edSituacao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbNome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.edNota);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.edNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.edInscricao);
            this.Name = "FormConsulta";
            this.Text = "FormConsulta";
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
        private System.Windows.Forms.ComboBox cbNome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox edSituacao;
    }
}