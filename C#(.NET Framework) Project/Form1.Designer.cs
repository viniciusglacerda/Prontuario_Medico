namespace ProntuarioMedico
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.LabelHistorico = new System.Windows.Forms.Label();
            this.LabelExames = new System.Windows.Forms.Label();
            this.LabelVacinas = new System.Windows.Forms.Label();
            this.LabelAlergia = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.closeFormPrincipal = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BodyIntroducao = new System.Windows.Forms.RichTextBox();
            this.Titulo = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabelHistorico
            // 
            this.LabelHistorico.AutoSize = true;
            this.LabelHistorico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelHistorico.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHistorico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LabelHistorico.Location = new System.Drawing.Point(22, 47);
            this.LabelHistorico.Name = "LabelHistorico";
            this.LabelHistorico.Size = new System.Drawing.Size(126, 18);
            this.LabelHistorico.TabIndex = 0;
            this.LabelHistorico.Text = "Histórico Médico";
            this.LabelHistorico.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelHistorico.Click += new System.EventHandler(this.LabelHistorico_Click);
            // 
            // LabelExames
            // 
            this.LabelExames.AutoSize = true;
            this.LabelExames.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelExames.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelExames.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LabelExames.Location = new System.Drawing.Point(22, 82);
            this.LabelExames.Name = "LabelExames";
            this.LabelExames.Size = new System.Drawing.Size(160, 18);
            this.LabelExames.TabIndex = 1;
            this.LabelExames.Text = "Exames e Resultados";
            this.LabelExames.Click += new System.EventHandler(this.LabelExames_Click);
            // 
            // LabelVacinas
            // 
            this.LabelVacinas.AutoSize = true;
            this.LabelVacinas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelVacinas.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelVacinas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LabelVacinas.Location = new System.Drawing.Point(22, 117);
            this.LabelVacinas.Name = "LabelVacinas";
            this.LabelVacinas.Size = new System.Drawing.Size(82, 18);
            this.LabelVacinas.TabIndex = 3;
            this.LabelVacinas.Text = "Vacinação";
            this.LabelVacinas.Click += new System.EventHandler(this.LabelVacinas_Click);
            // 
            // LabelAlergia
            // 
            this.LabelAlergia.AutoSize = true;
            this.LabelAlergia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelAlergia.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAlergia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LabelAlergia.Location = new System.Drawing.Point(22, 155);
            this.LabelAlergia.Name = "LabelAlergia";
            this.LabelAlergia.Size = new System.Drawing.Size(66, 18);
            this.LabelAlergia.TabIndex = 7;
            this.LabelAlergia.Text = "Alergias";
            this.LabelAlergia.Click += new System.EventHandler(this.LabelAlergia_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(4, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 15);
            this.label8.TabIndex = 8;
            this.label8.Text = "Prontuário Médico";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(183)))), ((int)(((byte)(200)))));
            this.panel1.Controls.Add(this.closeFormPrincipal);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(887, 24);
            this.panel1.TabIndex = 9;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // closeFormPrincipal
            // 
            this.closeFormPrincipal.BackColor = System.Drawing.Color.IndianRed;
            this.closeFormPrincipal.FlatAppearance.BorderSize = 0;
            this.closeFormPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeFormPrincipal.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeFormPrincipal.Location = new System.Drawing.Point(859, 2);
            this.closeFormPrincipal.Name = "closeFormPrincipal";
            this.closeFormPrincipal.Size = new System.Drawing.Size(19, 19);
            this.closeFormPrincipal.TabIndex = 10;
            this.closeFormPrincipal.Text = "X";
            this.closeFormPrincipal.UseVisualStyleBackColor = false;
            this.closeFormPrincipal.Click += new System.EventHandler(this.closeFormPrincipal_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.BodyIntroducao);
            this.panel2.Controls.Add(this.Titulo);
            this.panel2.Location = new System.Drawing.Point(204, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(680, 538);
            this.panel2.TabIndex = 10;
            // 
            // BodyIntroducao
            // 
            this.BodyIntroducao.BackColor = System.Drawing.Color.White;
            this.BodyIntroducao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BodyIntroducao.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.BodyIntroducao.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BodyIntroducao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.BodyIntroducao.Location = new System.Drawing.Point(35, 90);
            this.BodyIntroducao.Name = "BodyIntroducao";
            this.BodyIntroducao.Size = new System.Drawing.Size(594, 270);
            this.BodyIntroducao.TabIndex = 1;
            this.BodyIntroducao.Text = resources.GetString("BodyIntroducao.Text");
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold);
            this.Titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.Titulo.Location = new System.Drawing.Point(29, 43);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(455, 32);
            this.Titulo.TabIndex = 0;
            this.Titulo.Text = "Bem-vindo ao Prontuário Médico!";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.LabelAlergia);
            this.Controls.Add(this.LabelVacinas);
            this.Controls.Add(this.LabelExames);
            this.Controls.Add(this.LabelHistorico);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormPrincipal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prontuário Médico";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelHistorico;
        private System.Windows.Forms.Label LabelExames;
        private System.Windows.Forms.Label LabelVacinas;
        private System.Windows.Forms.Label LabelAlergia;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button closeFormPrincipal;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox BodyIntroducao;
        private System.Windows.Forms.Label Titulo;
    }
}

