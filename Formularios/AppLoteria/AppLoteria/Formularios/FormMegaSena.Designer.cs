namespace AppLoteria.Formularios
{
    partial class FormMegaSena
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbAnalise = new System.Windows.Forms.Label();
            this.lbImpar = new System.Windows.Forms.Label();
            this.lbPar = new System.Windows.Forms.Label();
            this.btLimpar = new System.Windows.Forms.Button();
            this.btGerar = new System.Windows.Forms.Button();
            this.gridNumeros = new System.Windows.Forms.DataGridView();
            this.ORD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NUMERO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridNumeros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbAnalise
            // 
            this.lbAnalise.AutoSize = true;
            this.lbAnalise.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAnalise.Location = new System.Drawing.Point(311, 110);
            this.lbAnalise.Name = "lbAnalise";
            this.lbAnalise.Size = new System.Drawing.Size(96, 24);
            this.lbAnalise.TabIndex = 11;
            this.lbAnalise.Text = "ANÁLISE";
            // 
            // lbImpar
            // 
            this.lbImpar.AutoSize = true;
            this.lbImpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbImpar.Location = new System.Drawing.Point(311, 62);
            this.lbImpar.Name = "lbImpar";
            this.lbImpar.Size = new System.Drawing.Size(112, 24);
            this.lbImpar.TabIndex = 10;
            this.lbImpar.Text = "ÍMPARES :";
            // 
            // lbPar
            // 
            this.lbPar.AutoSize = true;
            this.lbPar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPar.Location = new System.Drawing.Point(311, 12);
            this.lbPar.Name = "lbPar";
            this.lbPar.Size = new System.Drawing.Size(90, 24);
            this.lbPar.TabIndex = 9;
            this.lbPar.Text = "PARES :";
            // 
            // btLimpar
            // 
            this.btLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLimpar.Location = new System.Drawing.Point(448, 376);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(188, 47);
            this.btLimpar.TabIndex = 8;
            this.btLimpar.Text = "LIMPAR";
            this.btLimpar.UseVisualStyleBackColor = true;
            // 
            // btGerar
            // 
            this.btGerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGerar.Location = new System.Drawing.Point(448, 277);
            this.btGerar.Name = "btGerar";
            this.btGerar.Size = new System.Drawing.Size(188, 47);
            this.btGerar.TabIndex = 7;
            this.btGerar.Text = "GERAR NÚMEROS";
            this.btGerar.UseVisualStyleBackColor = true;
            // 
            // gridNumeros
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Purple;
            this.gridNumeros.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridNumeros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.gridNumeros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridNumeros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ORD,
            this.NUMERO});
            this.gridNumeros.GridColor = System.Drawing.SystemColors.Control;
            this.gridNumeros.Location = new System.Drawing.Point(12, 12);
            this.gridNumeros.Name = "gridNumeros";
            this.gridNumeros.Size = new System.Drawing.Size(245, 426);
            this.gridNumeros.TabIndex = 6;
            // 
            // ORD
            // 
            this.ORD.DataPropertyName = "NumOrdem";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.ORD.DefaultCellStyle = dataGridViewCellStyle7;
            this.ORD.HeaderText = "ORD";
            this.ORD.Name = "ORD";
            // 
            // NUMERO
            // 
            this.NUMERO.DataPropertyName = "Numero";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.NUMERO.DefaultCellStyle = dataGridViewCellStyle8;
            this.NUMERO.HeaderText = "NÚMEROS";
            this.NUMERO.Name = "NUMERO";
            // 
            // FormMegaSena
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
            this.Name = "FormMegaSena";
            this.Text = "MegaSena";
            this.Load += new System.EventHandler(this.FormMegaSena_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridNumeros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbAnalise;
        private System.Windows.Forms.Label lbImpar;
        private System.Windows.Forms.Label lbPar;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Button btGerar;
        private System.Windows.Forms.DataGridView gridNumeros;
        private System.Windows.Forms.DataGridViewTextBoxColumn ORD;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUMERO;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}