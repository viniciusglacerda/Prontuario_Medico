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
    public partial class formAlergias : Form
    {
        public List<Alergias> alergias;
        public formAlergias()
        {
            InitializeComponent();
            alergias = new List<Alergias>();
        }
        public void AddAlergias(string Nome)
        {
            alergias.Add(
                new Alergias
                {
                    _Alergias = Nome,
                }
            );
            AtualizarDataGridView();
        }
        public void AtualizarDataGridView()
        {
            this.viewAlergias.DataSource = null;
            this.viewAlergias.DataSource = alergias;
            this.viewAlergias.ClearSelection();
        }

        private void formAlergias_Load(object sender, EventArgs e)
        {
            AtualizarDataGridView();
        }

        private void AddAlergia_Click(object sender, EventArgs e)
        {
            AddAlergias(
                this.textAlergia.Text
            );
            this.textAlergia.Clear();
        }
    }
}
