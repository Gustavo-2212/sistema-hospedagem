using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hospedagem.Model
{
    public class Reserva
    {
        private List<Pessoa>? hospedes;
        public List<Pessoa> Hospedes { 
            get => hospedes;
            set {
                if (value == null || value.Count < 0) throw new ArgumentException("Entrada inválida");
                hospedes = value;
            } 
        } 

        private Suite? suite;
        public Suite SuiteProp {
            get => suite;
            set {
                if (value == null) throw new ArgumentException("Entrada inválida");
                suite = value;
            }
        }

        private int diasReservados;
        public int DiasReservados {
            get => diasReservados;
            set => diasReservados = value;
        }

        // Construtor
        public Reserva(int diasReservados) {
            DiasReservados = diasReservados;
            Hospedes = new List<Pessoa>();
        }

        // Métodos
        public void CadastrarHospedes(List<Pessoa> hospedes) {
            if (hospedes.Count <= SuiteProp.Capacidade)
                Hospedes = hospedes;
                return;

            throw new ArgumentException("Lista de hospedes maior que a capacidade do plano. Capacidade: " + SuiteProp.Capacidade + " Quantidade de Cadastros: " + hospedes.Count);
        }

        public void CadastrarSuite(Suite suite) {
            SuiteProp = suite;
        }

        public int ObterQuantidadeHospedes() => Hospedes.Count;

        public decimal ObterValorReserva() {
            decimal desconto = 1;
            if (DiasReservados > 10)
                desconto = 0.9M;
            return SuiteProp.ValorDiaria * DiasReservados * desconto;
        }

        private string HospedesString() {
            string hospedesString = "";
            foreach (var hospede in Hospedes)
            {
                hospedesString += hospede.ToString();
            }

            return hospedesString;
        }

        public override string ToString()
        {
            string hospedesString = HospedesString();

            return "{" + $"{SuiteProp.ToString()}\nDias Reservados: {DiasReservados}\nValor da Reserva: " + ObterValorReserva().ToString("C2") + "\nHospedes: [\n" + hospedesString + "]}";
        }
    }
}