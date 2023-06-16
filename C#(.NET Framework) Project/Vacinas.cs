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
    public partial class Vacinas : Form
    {
        public List<Vacinacao> vacinas;
        public Vacinas()
        {
            InitializeComponent();
            vacinas = new List<Vacinacao>();
        }
        public void AddVacinas(string NomeVac, DateTime date)
        {
            vacinas.Add(
                new Vacinacao
                {
                    Nome = NomeVac,
                    Data = date
                }
            );
            AtualizarDataGridView();
        }
        public void AtualizarDataGridView()
        {
            vacinas = vacinas.OrderBy(p => p.Nome).ToList();

            this.viewVacinas.DataSource = null;
            this.viewVacinas.DataSource = vacinas;
            this.viewVacinas.ClearSelection();
        }
        private void Vacinas_Load(object sender, EventArgs e)
        {
            AtualizarDataGridView();
        }

        private void SaveVax_Click(object sender, EventArgs e)
        {
            AddVacinas(
                this.NomeVacina.Text,
                this.dateVacina.Value
            );
        }
    }
}
