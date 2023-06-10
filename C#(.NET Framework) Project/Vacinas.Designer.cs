namespace ProntuarioMedico
{
    partial class Vacinas
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
            this.NomeVac = new System.Windows.Forms.Label();
            this.NomeVacina = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateVacina = new System.Windows.Forms.DateTimePicker();
            this.SaveVax = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.viewVacinas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.viewVacinas)).BeginInit();
            this.SuspendLayout();
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold);
            this.Titulo.Location = new System.Drawing.Point(12, 26);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(148, 32);
            this.Titulo.TabIndex = 0;
            this.Titulo.Text = "Vacinação";
            // 
            // NomeVac
            // 
            this.NomeVac.AutoSize = true;
            this.NomeVac.Location = new System.Drawing.Point(15, 74);
            this.NomeVac.Name = "NomeVac";
            this.NomeVac.Size = new System.Drawing.Size(117, 17);
            this.NomeVac.TabIndex = 1;
            this.NomeVac.Text = "Nome da vacina:";
            // 
            // NomeVacina
            // 
            this.NomeVacina.Location = new System.Drawing.Point(18, 94);
            this.NomeVacina.Name = "NomeVacina";
            this.NomeVacina.Size = new System.Drawing.Size(608, 25);
            this.NomeVacina.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome da vacina:";
            // 
            // dateVacina
            // 
            this.dateVacina.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateVacina.Location = new System.Drawing.Point(18, 146);
            this.dateVacina.Name = "dateVacina";
            this.dateVacina.Size = new System.Drawing.Size(608, 25);
            this.dateVacina.TabIndex = 4;
            this.dateVacina.Value = new System.DateTime(2023, 6, 10, 0, 0, 0, 0);
            // 
            // SaveVax
            // 
            this.SaveVax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(156)))), ((int)(((byte)(180)))));
            this.SaveVax.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SaveVax.FlatAppearance.BorderSize = 0;
            this.SaveVax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveVax.ForeColor = System.Drawing.Color.White;
            this.SaveVax.Location = new System.Drawing.Point(18, 177);
            this.SaveVax.Margin = new System.Windows.Forms.Padding(0);
            this.SaveVax.Name = "SaveVax";
            this.SaveVax.Size = new System.Drawing.Size(115, 29);
            this.SaveVax.TabIndex = 5;
            this.SaveVax.Text = "Salvar vacina";
            this.SaveVax.UseVisualStyleBackColor = false;
            this.SaveVax.Click += new System.EventHandler(this.SaveVax_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(12, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(291, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "Vacinas Registradas:";
            // 
            // viewVacinas
            // 
            this.viewVacinas.AllowUserToAddRows = false;
            this.viewVacinas.AllowUserToDeleteRows = false;
            this.viewVacinas.AllowUserToResizeColumns = false;
            this.viewVacinas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.viewVacinas.BackgroundColor = System.Drawing.Color.White;
            this.viewVacinas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.viewVacinas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.viewVacinas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewVacinas.ColumnHeadersVisible = false;
            this.viewVacinas.Enabled = false;
            this.viewVacinas.Location = new System.Drawing.Point(18, 264);
            this.viewVacinas.Name = "viewVacinas";
            this.viewVacinas.ReadOnly = true;
            this.viewVacinas.RowHeadersVisible = false;
            this.viewVacinas.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.viewVacinas.Size = new System.Drawing.Size(608, 222);
            this.viewVacinas.TabIndex = 7;
            // 
            // Vacinas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(651, 500);
            this.ControlBox = false;
            this.Controls.Add(this.viewVacinas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SaveVax);
            this.Controls.Add(this.dateVacina);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NomeVacina);
            this.Controls.Add(this.NomeVac);
            this.Controls.Add(this.Titulo);
            this.Font = new System.Drawing.Font("Arial", 11.25F);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Vacinas";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Vacinas";
            this.Load += new System.EventHandler(this.Vacinas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewVacinas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.Label NomeVac;
        private System.Windows.Forms.TextBox NomeVacina;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateVacina;
        private System.Windows.Forms.Button SaveVax;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView viewVacinas;
    }
}