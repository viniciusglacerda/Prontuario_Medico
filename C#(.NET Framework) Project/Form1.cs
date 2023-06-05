using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProntuarioMedico
{
    public partial class FormPrincipal : Form
    {
        private HistoricoMedico Historico;
        private bool isDragging = false;
        private Point lastMousePosition;

        delegate void ShowForms();

        public FormPrincipal()
        {
            InitializeComponent();
            Historico = new HistoricoMedico();
            this.LocationChanged += FormPrincipal_LocationChanged;
        }

        private void closeFormPrincipal_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            this.isDragging = true;
            this.lastMousePosition = e.Location;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                int deltaX = e.Location.X - lastMousePosition.X;
                int deltaY = e.Location.Y - lastMousePosition.Y;
                this.Location = new Point(this.Location.X + deltaX, this.Location.Y + deltaY);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            this.isDragging = false;
        }

        private void FormPrincipal_LocationChanged(object sender, EventArgs e)
        {
            if (Historico != null && !Historico.IsDisposed && Historico.Visible)
            {
                // Atualiza a posição do Form2 para acompanhar a movimentação do Form1
                Historico.Location = new Point(this.Location.X + 220, this.Location.Y + 40);
                Historico.BringToFront();
            }
        }

        private void showHistorico()
        {
            Historico.StartPosition = FormStartPosition.Manual;
            Historico.Location = new Point(this.Location.X+ 220, this.Location.Y+ 40);
            Historico.Size = new Size(this.Size.Width-235, this.Size.Height-55);
            //Historico.TopMost = true;
            Historico.BringToFront();
            Historico.WindowState = this.WindowState;
            Historico.Show();
        }

        private bool isActionExecuted = false;
        private void FormPrincipal_Activated(object sender, EventArgs e)
        {
        }

        private void FormPrincipal_Deactivate(object sender, EventArgs e)
        {
        }

        private void selected(ShowForms func, Label label){
            Label[] labels = { label1, label2, label3, label4, label5};

            foreach(Label lab in labels)
            {
                if (lab == label)
                {
                    lab.ForeColor = Color.FromArgb(69, 156, 180);
                }
                else
                {
                    lab.ForeColor = Color.FromArgb(64, 64, 64);
                }
            }
            func();
        }
        private void label1_Click(object sender, EventArgs e)
        {
            selected(showHistorico, label1);
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            selected(Historico.Hide, label2);
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void FormPrincipal_Leave(object sender, EventArgs e)
        {
            
        }

        private void FormPrincipal_Enter(object sender, EventArgs e)
        {
            
        }

       
    }
}
