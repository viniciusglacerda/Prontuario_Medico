namespace ProntuarioMedico
{
    partial class ExamesResultados
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
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.dateExames = new System.Windows.Forms.DateTimePicker();
            this.registrarExames = new System.Windows.Forms.Button();
            this.nomeExames = new System.Windows.Forms.TextBox();
            this.resultadoExames = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.viewData = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.viewData)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(12, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(297, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "Exames e Resultados";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Registros:";
            // 
            // dateExames
            // 
            this.dateExames.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateExames.Location = new System.Drawing.Point(17, 78);
            this.dateExames.Name = "dateExames";
            this.dateExames.Size = new System.Drawing.Size(117, 26);
            this.dateExames.TabIndex = 5;
            this.dateExames.Value = new System.DateTime(2023, 6, 7, 0, 0, 0, 0);
            // 
            // registrarExames
            // 
            this.registrarExames.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(156)))), ((int)(((byte)(180)))));
            this.registrarExames.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.registrarExames.FlatAppearance.BorderSize = 0;
            this.registrarExames.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registrarExames.ForeColor = System.Drawing.Color.White;
            this.registrarExames.Location = new System.Drawing.Point(17, 110);
            this.registrarExames.Name = "registrarExames";
            this.registrarExames.Size = new System.Drawing.Size(84, 27);
            this.registrarExames.TabIndex = 6;
            this.registrarExames.Text = "Registrar";
            this.registrarExames.UseVisualStyleBackColor = false;
            this.registrarExames.Click += new System.EventHandler(this.registrarExames_Click);
            // 
            // nomeExames
            // 
            this.nomeExames.Location = new System.Drawing.Point(178, 78);
            this.nomeExames.Name = "nomeExames";
            this.nomeExames.Size = new System.Drawing.Size(152, 26);
            this.nomeExames.TabIndex = 7;
            // 
            // resultadoExames
            // 
            this.resultadoExames.Location = new System.Drawing.Point(363, 78);
            this.resultadoExames.Name = "resultadoExames";
            this.resultadoExames.Size = new System.Drawing.Size(266, 26);
            this.resultadoExames.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Data do Exame:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(175, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Nome do Exame:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(360, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 16);
            this.label8.TabIndex = 11;
            this.label8.Text = "Resultado do Exame:";
            // 
            // viewData
            // 
            this.viewData.AllowUserToAddRows = false;
            this.viewData.AllowUserToDeleteRows = false;
            this.viewData.AllowUserToResizeColumns = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.NullValue = null;
            this.viewData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.viewData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.viewData.BackgroundColor = System.Drawing.Color.White;
            this.viewData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.viewData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.viewData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.viewData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.viewData.ColumnHeadersHeight = 24;
            this.viewData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.viewData.Enabled = false;
            this.viewData.Location = new System.Drawing.Point(16, 194);
            this.viewData.Name = "viewData";
            this.viewData.ReadOnly = true;
            this.viewData.RowHeadersVisible = false;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewData.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.viewData.RowTemplate.ReadOnly = true;
            this.viewData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.viewData.Size = new System.Drawing.Size(612, 269);
            this.viewData.TabIndex = 12;
            // 
            // ExamesResultados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(651, 500);
            this.Controls.Add(this.viewData);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.resultadoExames);
            this.Controls.Add(this.nomeExames);
            this.Controls.Add(this.registrarExames);
            this.Controls.Add(this.dateExames);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ExamesResultados";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "ExamesResultados";
            this.Load += new System.EventHandler(this.ExamesResultados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateExames;
        private System.Windows.Forms.Button registrarExames;
        private System.Windows.Forms.TextBox nomeExames;
        private System.Windows.Forms.TextBox resultadoExames;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView viewData;
    }
}