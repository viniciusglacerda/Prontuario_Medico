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
    public partial class HistoricoMedico : Form
    {
        public Paciente paciente;
        public HistoricoMedico(string nome, int idade, double altura, double peso, string historico)
        {
            InitializeComponent();
            paciente = new Paciente {
                Nome = nome,
                Idade = idade,
                Altura = altura,
                Peso = peso,
                Historico = historico
            };
        }
        private void HistoricoMedico_Load(object sender, EventArgs e)
        {
            this.textBoxNome.Text = paciente.Nome;
            this.textBoxIdade.Text = (paciente.Idade).ToString();
            this.textBoxAltura.Text = (paciente.Altura).ToString();
            this.textBoxPeso.Text = (paciente.Peso).ToString();
            this.textBoxHistorico.Text = paciente.Historico;
        }
        private void salvarHistorico_Click(object sender, EventArgs e)
        {
            paciente.Nome = this.textBoxNome.Text;
            paciente.Idade = int.Parse(this.textBoxIdade.Text);
            paciente.Altura = double.Parse(this.textBoxAltura.Text);
            paciente.Peso = double.Parse(this.textBoxPeso.Text);
            paciente.Historico = this.textBoxHistorico.Text;

        }
    }
}
