using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocacaoSala
{
    public class Sala
    {
        public string numero;
        public Boolean disponibilidade;
        public byte capacidadeMaxima;
        public List<DateTime> horasInicio = new();
        public List<DateTime> horasFim = new();


        public Sala(string numero = default, Boolean disponibilidade = default, byte capMax = default)
        {
            this.numero = numero;
            this.disponibilidade = disponibilidade;
            this.capacidadeMaxima = capMax;
        }

        public override string ToString()
        {
            return $"SALA: {numero} - CAPACIDADE: {capacidadeMaxima}";
        }
    }
}
