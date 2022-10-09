using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hospedagem.Model
{
    public class Pessoa
    {
        private string? nome;
        public string Nome { 
            get => nome != null ? nome : "-";
            set {
                if (value == "") throw new ArgumentException("Nome inválido");
                nome = value;
            } 
        }
        private string? sobrenome;
        public string Sobrenome {
            get => sobrenome != null ? sobrenome : "-";
            set {
                if (value == "") throw new ArgumentException("Sobrenome inválido");
                sobrenome = value;
            }
        }

        // Construtor
        public Pessoa(string nome, string sobrenome) {
            Nome = nome;
            Sobrenome = sobrenome;
        }

        public override string ToString() => $"\t{Nome} {Sobrenome}\n";
    }
}