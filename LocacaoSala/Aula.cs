using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocacaoSala
{
    public class Aula : Sala
    {
        private DateTime horaInicio;
        private DateTime horaFim;

        public DateTime HoraInicio 
        { 
            get 
            { 
                return horaInicio; 
            } 
            set 
            { 
                horaInicio = value; 
            } 
        }
        public DateTime HoraFim 
        { 
            get 
            { 
                return horaFim;
            } 
            set 
            { 
                horaFim = value; 
            } 
        }

        /*
        public void VerificaHoraInicio (DateTime hora)
        {
            if (hora )
            {
                
            }
        }*/

        public Aula(string numero = default, Boolean disponibilidade = default, byte capMax = default, DateTime horaInicio = default, DateTime horaFim = default) : base(numero, disponibilidade, capMax)
        {
            this.horaInicio = horaInicio;
            this.horaFim = horaFim;
        }
    }
}
