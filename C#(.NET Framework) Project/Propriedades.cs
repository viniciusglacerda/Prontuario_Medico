using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProntuarioMedico
{
    public class Alergias
    {
        public string _Alergias { get; set; }
    }
    public class ExameResultado
    {
        public DateTime Data { get; set; }
        public string Exame { get; set; }
        public string Resultado { get; set; }
    }
    public class Paciente
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public double Altura { get; set; }
        public double Peso { get; set; }
        public string Historico { get; set; }

        public Paciente()
        {
            Nome = string.Empty;
            Idade = 0;
            Altura = 0;
            Peso = 0;
            Historico = string.Empty;
        }

    }
    public class Vacinacao
    {
        public string Nome { get; set; }
        public DateTime Data { get; set; }
    }
}
