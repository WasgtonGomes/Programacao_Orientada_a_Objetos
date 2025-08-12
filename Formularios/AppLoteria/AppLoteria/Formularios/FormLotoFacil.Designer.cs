namespace AppLoteria.Formularios
{
    partial class FormLotoFacil
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gridNumeros = new System.Windows.Forms.DataGridView();
            this.btGerar = new System.Windows.Forms.Button();
            this.btLimpar = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lbPar = new System.Windows.Forms.Label();
            this.lbImpar = new System.Windows.Forms.Label();
            this.lbAnalise = new System.Windows.Forms.Label();
            this.NumOrdem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NUMERO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridNumeros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridNumeros
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Purple;
            this.gridNumeros.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridNumeros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridNumeros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridNumeros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumOrdem,
            this.NUMERO});
            this.gridNumeros.GridColor = System.Drawing.SystemColors.Control;
            this.gridNumeros.Location = new System.Drawing.Point(12, 12);
            this.gridNumeros.Name = "gridNumeros";
            this.gridNumeros.Size = new System.Drawing.Size(245, 426);
            this.gridNumeros.TabIndex = 0;
            this.gridNumeros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridNumeros_CellContentClick);
            // 
            // btGerar
            // 
            this.btGerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGerar.Location = new System.Drawing.Point(448, 277);
            this.btGerar.Name = "btGerar";
            this.btGerar.Size = new System.Drawing.Size(188, 47);
            this.btGerar.TabIndex = 1;
            this.btGerar.Text = "GERAR NÚMEROS";
            this.btGerar.UseVisualStyleBackColor = true;
            this.btGerar.Click += new System.EventHandler(this.btGerar_Click);
            // 
            // btLimpar
            // 
            this.btLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLimpar.Location = new System.Drawing.Point(448, 376);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(188, 47);
            this.btLimpar.TabIndex = 2;
            this.btLimpar.Text = "LIMPAR";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // lbPar
            // 
            this.lbPar.AutoSize = true;
            this.lbPar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPar.Location = new System.Drawing.Point(311, 12);
            this.lbPar.Name = "lbPar";
            this.lbPar.Size = new System.Drawing.Size(90, 24);
            this.lbPar.TabIndex = 3;
            this.lbPar.Text = "PARES :";
            // 
            // lbImpar
            // 
            this.lbImpar.AutoSize = true;
            this.lbImpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbImpar.Location = new System.Drawing.Point(311, 62);
            this.lbImpar.Name = "lbImpar";
            this.lbImpar.Size = new System.Drawing.Size(112, 24);
            this.lbImpar.TabIndex = 4;
            this.lbImpar.Text = "ÍMPARES :";
            // 
            // lbAnalise
            // 
            this.lbAnalise.AutoSize = true;
            this.lbAnalise.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAnalise.Location = new System.Drawing.Point(311, 110);
            this.lbAnalise.Name = "lbAnalise";
            this.lbAnalise.Size = new System.Drawing.Size(96, 24);
            this.lbAnalise.TabIndex = 5;
            this.lbAnalise.Text = "ANÁLISE";
            // 
            // NumOrdem
            // 
            this.NumOrdem.DataPropertyName = "NumOrdem";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.NumOrdem.DefaultCellStyle = dataGridViewCellStyle3;
            this.NumOrdem.HeaderText = "ORD";
            this.NumOrdem.Name = "NumOrdem";
            // 
            // NUMERO
            // 
            this.NUMERO.DataPropertyName = "Numero";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.NUMERO.DefaultCellStyle = dataGridViewCellStyle4;
            this.NUMERO.HeaderText = "NÚMEROS";
            this.NUMERO.Name = "NUMERO";
            // 
            // FormLotoFacil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbAnalise);
            this.Controls.Add(this.lbImpar);
            this.Controls.Add(this.lbPar);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.btGerar);
            this.Controls.Add(this.gridNumeros);
            this.Name = "FormLotoFacil";
            this.Text = "LotoFacil";
            this.Load += new System.EventHandler(this.FormLotoFacil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridNumeros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridNumeros;
        private System.Windows.Forms.Button btGerar;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label lbPar;
        private System.Windows.Forms.Label lbImpar;
        private System.Windows.Forms.Label lbAnalise;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumOrdem;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUMERO;
    }
}