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
    public partial class ExamesResultados : Form
    {
        public List<ExameResultado> exameResultados;
        public ExamesResultados()
        {
            InitializeComponent();
            exameResultados = new List<ExameResultado>();
            this.viewData.DataSource = exameResultados;
        }
        private void ExamesResultados_Load(object sender, EventArgs e)
        {
            AtualizarDataGridView();
            /*
            DataGridViewButtonColumn colunaRemover = new DataGridViewButtonColumn();
            colunaRemover.HeaderText = "Remover";
            colunaRemover.Text = "Remover";
            colunaRemover.UseColumnTextForButtonValue = true;
            this.viewData.Columns.Add(colunaRemover);

            this.viewData.CellContentClick += (gridSender, gridEvent) =>
            {
                if (gridEvent.ColumnIndex == colunaRemover.Index && gridEvent.RowIndex >= 0)
                {
                    exameResultados.RemoveAt(gridEvent.RowIndex);
                    AtualizarDataGridView();
                }
            };*/
        }

        public void AddExames(DateTime date, string exame, string resultado)
        {
            exameResultados.Add(
                new ExameResultado
                {
                    Data = date,
                    Exame = exame,
                    Resultado = resultado
                }
            );
            AtualizarDataGridView();
        }
        public void AtualizarDataGridView()
        {
            this.viewData.DataSource = null;
            this.viewData.DataSource = exameResultados;
            this.viewData.ClearSelection();
        }

        private void registrarExames_Click(object sender, EventArgs e)
        {
            AddExames(
                this.dateExames.Value,
                this.nomeExames.Text,
                this.resultadoExames.Text
            );
            AtualizarDataGridView();
        }
    }
}
