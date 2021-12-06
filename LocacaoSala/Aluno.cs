using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocacaoSala
{
    class Aluno : Usuario
    {
        public string matricula;

        public List<Sala> salas = new();

        public Aluno(string nome = default, string cpf = default, string email = default, string senha = default, string telefone = default, string matricula = default) : base(nome, cpf, email, senha, telefone)
        {
            this.matricula = matricula;
        }
    }
}
