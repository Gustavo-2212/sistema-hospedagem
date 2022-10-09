using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hospedagem.Model
{
    public struct ValorCapacidade
    {
        public int Capacidade { get; private set; }
        public decimal Valor { get; private set; }

        public ValorCapacidade(int capacidade, decimal valor) {
            Capacidade = capacidade;
            Valor = valor;
        }
    }
}