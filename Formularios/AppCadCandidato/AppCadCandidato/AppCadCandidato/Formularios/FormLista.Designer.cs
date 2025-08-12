namespace AppCadCandidato.Formularios
{
    partial class FormLista
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gdLista = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.inscricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.situacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gdLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // gdLista
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.gdLista.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gdLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.inscricao,
            this.nome,
            this.nota,
            this.situacao});
            this.gdLista.Location = new System.Drawing.Point(12, 91);
            this.gdLista.Name = "gdLista";
            this.gdLista.Size = new System.Drawing.Size(776, 496);
            this.gdLista.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(758, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "LISTA DE CANDIDATOS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // inscricao
            // 
            this.inscricao.DataPropertyName = "Insc";
            this.inscricao.HeaderText = "Nº INSCRIÇÃO";
            this.inscricao.Name = "inscricao";
            // 
            // nome
            // 
            this.nome.DataPropertyName = "Nome";
            this.nome.HeaderText = "NOME: ";
            this.nome.Name = "nome";
            // 
            // nota
            // 
            this.nota.DataPropertyName = "Nota";
            this.nota.HeaderText = "NOTA: ";
            this.nota.Name = "nota";
            // 
            // situacao
            // 
            this.situacao.DataPropertyName = "Situacao";
            this.situacao.HeaderText = "SITUAÇÃO";
            this.situacao.Name = "situacao";
            // 
            // FormLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 634);
            this.Controls.Add(this.gdLista);
            this.Controls.Add(this.label1);
            this.Name = "FormLista";
            this.Text = "FormLista";
            ((System.ComponentModel.ISupportInitialize)(this.gdLista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gdLista;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn inscricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn nota;
        private System.Windows.Forms.DataGridViewTextBoxColumn situacao;
    }
}