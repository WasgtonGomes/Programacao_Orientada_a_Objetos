namespace AppCadCandidato.Formularios
{
    partial class FormEstatistica
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.edQtdAprovados = new System.Windows.Forms.TextBox();
            this.edQtdReprovados = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.edQtdAcima50 = new System.Windows.Forms.TextBox();
            this.edqtdAbaixo50 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUANTIDADE DE APROVADOS:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(289, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "QUANTIDADE DE REPROVADOS:";
            // 
            // edQtdAprovados
            // 
            this.edQtdAprovados.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edQtdAprovados.Location = new System.Drawing.Point(324, 23);
            this.edQtdAprovados.Name = "edQtdAprovados";
            this.edQtdAprovados.Size = new System.Drawing.Size(139, 29);
            this.edQtdAprovados.TabIndex = 2;
            // 
            // edQtdReprovados
            // 
            this.edQtdReprovados.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edQtdReprovados.Location = new System.Drawing.Point(324, 91);
            this.edQtdReprovados.Name = "edQtdReprovados";
            this.edQtdReprovados.Size = new System.Drawing.Size(139, 29);
            this.edQtdReprovados.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(473, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "QUANTIDADE DE PESSOAS COM NOTAS ACIMA DE 50:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(484, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "QUANTIDADE DE PESSOAS COM NOTAS ABAIXO DE 50:";
            // 
            // edQtdAcima50
            // 
            this.edQtdAcima50.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edQtdAcima50.Location = new System.Drawing.Point(491, 176);
            this.edQtdAcima50.Name = "edQtdAcima50";
            this.edQtdAcima50.Size = new System.Drawing.Size(139, 29);
            this.edQtdAcima50.TabIndex = 6;
            this.edQtdAcima50.TextChanged += new System.EventHandler(this.edQtdAcima50_TextChanged);
            // 
            // edqtdAbaixo50
            // 
            this.edqtdAbaixo50.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edqtdAbaixo50.Location = new System.Drawing.Point(491, 228);
            this.edqtdAbaixo50.Name = "edqtdAbaixo50";
            this.edqtdAbaixo50.Size = new System.Drawing.Size(139, 29);
            this.edqtdAbaixo50.TabIndex = 7;
            // 
            // FormEstatistica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.edqtdAbaixo50);
            this.Controls.Add(this.edQtdAcima50);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.edQtdReprovados);
            this.Controls.Add(this.edQtdAprovados);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormEstatistica";
            this.Text = "FormEstatistica";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox edQtdAprovados;
        private System.Windows.Forms.TextBox edQtdReprovados;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox edQtdAcima50;
        private System.Windows.Forms.TextBox edqtdAbaixo50;
    }
}