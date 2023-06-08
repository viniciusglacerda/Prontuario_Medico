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
        private ExamesResultados Exames;
        private Vacinas Vacinas;
        private formAlergias Alergias;

        private bool isDragging = false;
        private Point lastMousePosition;

        delegate void ShowForms();

        public FormPrincipal()
        {
            InitializeComponent();

            Historico = new HistoricoMedico();
            Exames = new ExamesResultados();
            Vacinas = new Vacinas();
            Alergias = new formAlergias();

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
            Point point = new Point(this.Location.X + 220, this.Location.Y + 40);
            if (Historico != null && !Historico.IsDisposed && Historico.Visible)
            {
                Historico.Location = point;
                Historico.BringToFront();
            }
            if (Exames != null && !Exames.IsDisposed && Exames.Visible)
            {
                Exames.Location = point;
                Exames.BringToFront();
            }
            if (Vacinas != null && !Vacinas.IsDisposed && Vacinas.Visible){
                Vacinas.Location = point;
                Vacinas.BringToFront();
            }
            if (Alergias != null && !Alergias.IsDisposed && Alergias.Visible)
            {
                Alergias.Location = point;
                Alergias.BringToFront();
            }
        }
        
        private void showForms(Form form)
        {
            form.StartPosition = FormStartPosition.Manual;
            form.Location = new Point(this.Location.X + 220, this.Location.Y + 40);
            form.Size = new Size(this.Size.Width - 235, this.Size.Height - 55);
            //Historico.TopMost = true;
            form.BringToFront();
            form.WindowState = this.WindowState;
            form.Show();
        }

        private void selected(string name, ShowForms func, Label label){
            List<Form> listaFormularios = new List<Form>();

            foreach (Form form in Application.OpenForms)
            {
                listaFormularios.Add(form);
            }

            foreach (Form form in listaFormularios)
            {
                if(name != form.Name && form.Name != this.Name)
                {
                    form.Hide();
                }
            }

            Label[] labels = { LabelHistorico, LabelExames, LabelVacinas, LabelAlergia};

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
        private void LabelHistorico_Click(object sender, EventArgs e)
        {
            selected(Historico.Name, ()=>showForms(Historico), LabelHistorico);
        }
        private void LabelExames_Click(object sender, EventArgs e)
        {
            selected(Exames.Name, ()=>showForms(Exames), LabelExames);
        }
        private void LabelVacinas_Click(object sender, EventArgs e)
        {
            selected(Vacinas.Name, ()=>showForms(Vacinas), LabelVacinas);
        }
        private void LabelAlergia_Click(object sender, EventArgs e)
        {
            selected(Alergias.Name, ()=>showForms(Alergias), LabelAlergia);
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
        }
    }
}
