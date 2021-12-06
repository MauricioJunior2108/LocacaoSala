using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocacaoSala
{
    class Professor : Usuario
    {
        private string ctps;
        public List<Diciplina> disciplinas = new();
             
        public string Ctps { get { return ctps; } set { ctps = value; } }

        public Professor(string nome = default, string cpf = default, string email = default, string senha = default, string telefone = default, string ctps = default) : base(nome, cpf, email, senha, telefone)
        {
            this.ctps = ctps;
        }
    }
}
