using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocacaoSala
{
    public class Usuario
    {
        public string nome;
        private string cpf;
        private string email;
        private string senha;
        private string telefone;

        public string Cpf { get { return cpf; } set { cpf = value; } }
        public string Email { get { return email; } set { email = value; } }
        public string Senha { get { return senha; } set { senha = value; } }
        public string Telefone { get { return telefone; } set { telefone = value; } }

        public Usuario(string nome = default, string cpf = default, string email = default, string senha = default, string telefone = default)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.email = email;
            this.senha = senha;
            this.telefone = telefone;
        }
    }
}
