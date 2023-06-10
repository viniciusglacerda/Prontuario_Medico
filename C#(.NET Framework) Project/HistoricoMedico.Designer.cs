namespace ProntuarioMedico
{
    partial class HistoricoMedico
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
            this.Titulo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxIdade = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxAltura = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPeso = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxHistorico = new System.Windows.Forms.TextBox();
            this.salvarHistorico = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.Location = new System.Drawing.Point(12, 26);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(235, 32);
            this.Titulo.TabIndex = 0;
            this.Titulo.Text = "Histórico Médico";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome:";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(15, 98);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(618, 25);
            this.textBoxNome.TabIndex = 2;
            // 
            // textBoxIdade
            // 
            this.textBoxIdade.Location = new System.Drawing.Point(16, 159);
            this.textBoxIdade.Name = "textBoxIdade";
            this.textBoxIdade.Size = new System.Drawing.Size(617, 25);
            this.textBoxIdade.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Idade:";
            // 
            // textBoxAltura
            // 
            this.textBoxAltura.Location = new System.Drawing.Point(16, 224);
            this.textBoxAltura.Name = "textBoxAltura";
            this.textBoxAltura.Size = new System.Drawing.Size(617, 25);
            this.textBoxAltura.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Altura:";
            // 
            // textBoxPeso
            // 
            this.textBoxPeso.Location = new System.Drawing.Point(16, 287);
            this.textBoxPeso.Name = "textBoxPeso";
            this.textBoxPeso.Size = new System.Drawing.Size(617, 25);
            this.textBoxPeso.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Peso";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 332);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Histórico:";
            // 
            // textBoxHistorico
            // 
            this.textBoxHistorico.Location = new System.Drawing.Point(16, 352);
            this.textBoxHistorico.Multiline = true;
            this.textBoxHistorico.Name = "textBoxHistorico";
            this.textBoxHistorico.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxHistorico.Size = new System.Drawing.Size(617, 77);
            this.textBoxHistorico.TabIndex = 10;
            // 
            // salvarHistorico
            // 
            this.salvarHistorico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(156)))), ((int)(((byte)(180)))));
            this.salvarHistorico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.salvarHistorico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.salvarHistorico.FlatAppearance.BorderSize = 0;
            this.salvarHistorico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salvarHistorico.ForeColor = System.Drawing.Color.White;
            this.salvarHistorico.Location = new System.Drawing.Point(15, 450);
            this.salvarHistorico.Margin = new System.Windows.Forms.Padding(0);
            this.salvarHistorico.Name = "salvarHistorico";
            this.salvarHistorico.Size = new System.Drawing.Size(115, 29);
            this.salvarHistorico.TabIndex = 11;
            this.salvarHistorico.Text = "Salvar";
            this.salvarHistorico.UseVisualStyleBackColor = false;
            this.salvarHistorico.Click += new System.EventHandler(this.salvarHistorico_Click);
            // 
            // HistoricoMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(651, 500);
            this.ControlBox = false;
            this.Controls.Add(this.salvarHistorico);
            this.Controls.Add(this.textBoxHistorico);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxPeso);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxAltura);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxIdade);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Titulo);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HistoricoMedico";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "HistoricoMedico";
            this.Load += new System.EventHandler(this.HistoricoMedico_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.TextBox textBoxIdade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxAltura;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxPeso;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxHistorico;
        private System.Windows.Forms.Button salvarHistorico;
    }
}