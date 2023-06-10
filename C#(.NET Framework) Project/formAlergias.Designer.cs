namespace ProntuarioMedico
{
    partial class formAlergias
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
            this.label1 = new System.Windows.Forms.Label();
            this.textAlergia = new System.Windows.Forms.TextBox();
            this.AddAlergia = new System.Windows.Forms.Button();
            this.viewAlergias = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.viewAlergias)).BeginInit();
            this.SuspendLayout();
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold);
            this.Titulo.Location = new System.Drawing.Point(14, 28);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(122, 32);
            this.Titulo.TabIndex = 0;
            this.Titulo.Text = "Alergias";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Informações existentes:";
            // 
            // textAlergia
            // 
            this.textAlergia.Location = new System.Drawing.Point(20, 63);
            this.textAlergia.Name = "textAlergia";
            this.textAlergia.Size = new System.Drawing.Size(188, 26);
            this.textAlergia.TabIndex = 5;
            // 
            // AddAlergia
            // 
            this.AddAlergia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(156)))), ((int)(((byte)(180)))));
            this.AddAlergia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AddAlergia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddAlergia.ForeColor = System.Drawing.Color.White;
            this.AddAlergia.Location = new System.Drawing.Point(214, 63);
            this.AddAlergia.Name = "AddAlergia";
            this.AddAlergia.Size = new System.Drawing.Size(96, 26);
            this.AddAlergia.TabIndex = 6;
            this.AddAlergia.Text = "Adicionar";
            this.AddAlergia.UseVisualStyleBackColor = false;
            this.AddAlergia.Click += new System.EventHandler(this.AddAlergia_Click);
            // 
            // viewAlergias
            // 
            this.viewAlergias.AllowUserToAddRows = false;
            this.viewAlergias.AllowUserToDeleteRows = false;
            this.viewAlergias.AllowUserToResizeColumns = false;
            this.viewAlergias.AllowUserToResizeRows = false;
            this.viewAlergias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.viewAlergias.BackgroundColor = System.Drawing.Color.White;
            this.viewAlergias.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.viewAlergias.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.viewAlergias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewAlergias.ColumnHeadersVisible = false;
            this.viewAlergias.Enabled = false;
            this.viewAlergias.Location = new System.Drawing.Point(22, 136);
            this.viewAlergias.Name = "viewAlergias";
            this.viewAlergias.ReadOnly = true;
            this.viewAlergias.RowHeadersVisible = false;
            this.viewAlergias.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.viewAlergias.Size = new System.Drawing.Size(684, 348);
            this.viewAlergias.TabIndex = 7;
            // 
            // formAlergias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(732, 529);
            this.ControlBox = false;
            this.Controls.Add(this.viewAlergias);
            this.Controls.Add(this.AddAlergia);
            this.Controls.Add(this.textAlergia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Titulo);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formAlergias";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "formAlergias";
            this.Load += new System.EventHandler(this.formAlergias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewAlergias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textAlergia;
        private System.Windows.Forms.Button AddAlergia;
        private System.Windows.Forms.DataGridView viewAlergias;
    }
}