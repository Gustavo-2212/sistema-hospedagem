using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hospedagem.Model
{
    public class Suite
    {
        private readonly static Dictionary<string, ValorCapacidade> listaSuites = new Dictionary<string, ValorCapacidade>(){
            {"5 Estrelas", new ValorCapacidade(10, 520.63M)},
            {"4 Estrelas", new ValorCapacidade(8, 360.5M)},
            {"3 Estrelas", new ValorCapacidade(5, 120.6M)},
            {"Comum", new ValorCapacidade(3, 95.6M)}
        };
        private string? tipoSuite;
        public string TipoSuite
        {
            get { return tipoSuite != null ? tipoSuite : "-"; }
            set { 
                if(value == "") throw new ArgumentException("Tipo inválido");
                tipoSuite = value; 
            }
        }
        private int capacidade;
        public int Capacidade {
            get => capacidade;
            private set {
                capacidade = value;
            }
        }
        private decimal valorDiaria;
        public decimal ValorDiaria {
            get => valorDiaria;
            private set {
                valorDiaria = value;
            }
        }

        public Suite(string tipoSuite) {
            if (!listaSuites.ContainsKey(tipoSuite))
                throw new ArgumentException("Tipo de suíte inválido");

            TipoSuite = tipoSuite;
            ValorDiaria = listaSuites[tipoSuite].Valor;
            Capacidade = listaSuites[tipoSuite].Capacidade;
        }

        public override string ToString() => $"[Suite: {TipoSuite}, Capacidade: {Capacidade}," + " Valor/Dia: " + ValorDiaria.ToString("C2") + "]";
    }
}