namespace AppLoteria.Formularios
{
    partial class FormQuina
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
            this.btLimparQuina = new System.Windows.Forms.Button();
            this.btGerarQuina = new System.Windows.Forms.Button();
            this.gridNumerosQuina = new System.Windows.Forms.DataGridView();
            this.ORD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NUMERO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridNumerosQuina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbAnalise
            // 
            this.lbAnalise.AutoSize = true;
            this.lbAnalise.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAnalise.Location = new System.Drawing.Point(311, 99);
            this.lbAnalise.Name = "lbAnalise";
            this.lbAnalise.Size = new System.Drawing.Size(96, 24);
            this.lbAnalise.TabIndex = 11;
            this.lbAnalise.Text = "ANÁLISE";
            // 
            // lbImpar
            // 
            this.lbImpar.AutoSize = true;
            this.lbImpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbImpar.Location = new System.Drawing.Point(311, 51);
            this.lbImpar.Name = "lbImpar";
            this.lbImpar.Size = new System.Drawing.Size(112, 24);
            this.lbImpar.TabIndex = 10;
            this.lbImpar.Text = "ÍMPARES :";
            // 
            // lbPar
            // 
            this.lbPar.AutoSize = true;
            this.lbPar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPar.Location = new System.Drawing.Point(311, 1);
            this.lbPar.Name = "lbPar";
            this.lbPar.Size = new System.Drawing.Size(90, 24);
            this.lbPar.TabIndex = 9;
            this.lbPar.Text = "PARES :";
            // 
            // btLimparQuina
            // 
            this.btLimparQuina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLimparQuina.Location = new System.Drawing.Point(448, 365);
            this.btLimparQuina.Name = "btLimparQuina";
            this.btLimparQuina.Size = new System.Drawing.Size(188, 47);
            this.btLimparQuina.TabIndex = 8;
            this.btLimparQuina.Text = "LIMPAR";
            this.btLimparQuina.UseVisualStyleBackColor = true;
            this.btLimparQuina.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // btGerarQuina
            // 
            this.btGerarQuina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGerarQuina.Location = new System.Drawing.Point(448, 266);
            this.btGerarQuina.Name = "btGerarQuina";
            this.btGerarQuina.Size = new System.Drawing.Size(188, 47);
            this.btGerarQuina.TabIndex = 7;
            this.btGerarQuina.Text = "GERAR NÚMEROS";
            this.btGerarQuina.UseVisualStyleBackColor = true;
            this.btGerarQuina.Click += new System.EventHandler(this.btGerar_Click);
            // 
            // gridNumerosQuina
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Purple;
            this.gridNumerosQuina.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridNumerosQuina.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.gridNumerosQuina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridNumerosQuina.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ORD,
            this.NUMERO});
            this.gridNumerosQuina.GridColor = System.Drawing.SystemColors.Control;
            this.gridNumerosQuina.Location = new System.Drawing.Point(12, 1);
            this.gridNumerosQuina.Name = "gridNumerosQuina";
            this.gridNumerosQuina.Size = new System.Drawing.Size(245, 426);
            this.gridNumerosQuina.TabIndex = 6;
            this.gridNumerosQuina.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridNumerosQuina_CellContentClick);
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
            // FormQuina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbAnalise);
            this.Controls.Add(this.lbImpar);
            this.Controls.Add(this.lbPar);
            this.Controls.Add(this.btLimparQuina);
            this.Controls.Add(this.btGerarQuina);
            this.Controls.Add(this.gridNumerosQuina);
            this.Name = "FormQuina";
            this.Text = "Quina";
            this.Load += new System.EventHandler(this.Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridNumerosQuina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbAnalise;
        private System.Windows.Forms.Label lbImpar;
        private System.Windows.Forms.Label lbPar;
        private System.Windows.Forms.Button btLimparQuina;
        private System.Windows.Forms.Button btGerarQuina;
        private System.Windows.Forms.DataGridView gridNumerosQuina;
        private System.Windows.Forms.DataGridViewTextBoxColumn ORD;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUMERO;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}