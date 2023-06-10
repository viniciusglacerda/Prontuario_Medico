using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ProntuarioMedico
{
    internal class Prontuario
    {
        public Paciente HistoricoMedico;
        public List<ExameResultado> ExamesResultados;
        public List<Vacinacao> Vacinacoes;
        public List<Alergias> Alergias;

        public Prontuario()
        {
            HistoricoMedico = new Paciente();
            ExamesResultados = new List<ExameResultado>();
            Vacinacoes = new List<Vacinacao>();
            Alergias = new List<Alergias>();
        }
        public void SalvarXml(string arquivo)
        {
            XElement xml = new XElement("Prontuario",
            new XElement("HistoricoMedico",
                new XElement("Nome", HistoricoMedico.Nome),
                new XElement("Idade", HistoricoMedico.Idade),
                new XElement("Altura", HistoricoMedico.Altura),
                new XElement("Peso", HistoricoMedico.Peso),
                new XElement("Historico", HistoricoMedico.Historico)
                )
            );

            if (ExamesResultados.Count > 0)
            {
                XElement examesElement = new XElement("ExamesResultados");
                foreach (var exame in ExamesResultados)
                {
                    XElement exameElement = new XElement("Exame",
                        new XElement("Data", exame.Data),
                        new XElement("Nome", exame.Exame),
                        new XElement("Resultado", exame.Resultado)
                    );
                    examesElement.Add(exameElement);
                }
                xml.Add(examesElement);
            }

            if (Vacinacoes.Count > 0)
            {
                XElement vacinasElement = new XElement("Vacinacoes");
                foreach (var vacina in Vacinacoes)
                {
                    XElement vacinaElement = new XElement("Vacina",
                        new XElement("Nome", vacina.Nome),
                        new XElement("Data", vacina.Data)
                    );
                    vacinasElement.Add(vacinaElement);
                }
                xml.Add(vacinasElement);
            }

            if (Alergias.Count > 0)
            {
                XElement alergiasElement = new XElement("Alergias");
                foreach (var alergia in Alergias)
                {
                    XElement alergiaElement = new XElement("Alergia", alergia._Alergias);
                    alergiasElement.Add(alergiaElement);
                }
                xml.Add(alergiasElement);
            }

            xml.Save(arquivo);
        }

        public void LerDeXML(string arquivo)
        {
            try
            {
                XElement xml = XElement.Load(arquivo);

                HistoricoMedico = new Paciente
                {
                    Nome = xml.Element("HistoricoMedico")?.Element("Nome")?.Value,
                    Idade = Convert.ToInt32(xml.Element("HistoricoMedico")?.Element("Idade")?.Value),
                    Altura = Convert.ToDouble(xml.Element("HistoricoMedico")?.Element("Altura")?.Value),
                    Peso = Convert.ToDouble(xml.Element("HistoricoMedico")?.Element("Peso")?.Value),
                    Historico = xml.Element("HistoricoMedico")?.Element("Historico")?.Value
                };

                ExamesResultados = new List<ExameResultado>();
                foreach (var exameElement in xml.Element("ExamesResultados")?.Elements("Exame") ?? Enumerable.Empty<XElement>())
                {
                    ExameResultado exame = new ExameResultado
                    {
                        Data = Convert.ToDateTime(exameElement.Element("Data")?.Value),
                        Exame = exameElement.Element("Nome")?.Value,
                        Resultado = exameElement.Element("Resultado")?.Value
                    };
                    ExamesResultados.Add(exame);
                }

                Vacinacoes = new List<Vacinacao>();
                foreach (var vacinaElement in xml.Element("Vacinacoes")?.Elements("Vacina") ?? Enumerable.Empty<XElement>())
                {
                    Vacinacao vacina = new Vacinacao
                    {
                        Nome = vacinaElement.Element("Nome")?.Value,
                        Data = Convert.ToDateTime(vacinaElement.Element("Data")?.Value)
                    };
                    Vacinacoes.Add(vacina);
                }

                Alergias = new List<Alergias>();
                foreach (var alergiaElement in xml.Element("Alergias")?.Elements("Alergia") ?? Enumerable.Empty<XElement>())
                {
                    Alergias alergia = new Alergias
                    {
                        _Alergias = alergiaElement.Value
                    };
                    Alergias.Add(alergia);
                }
            }
            catch (System.IO.FileNotFoundException)
            {
                // Arquivo XML não encontrado, criar um novo arquivo XML vazio
                XElement novoXml = new XElement("Prontuario");
                novoXml.Save(arquivo);
            }
        }
    }
}
