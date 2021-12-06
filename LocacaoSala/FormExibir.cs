using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocacaoSala
{
    public partial class FormExibir : Form
    {
        public dynamic pessoa;
        public List<Sala> salas = new();

        public FormExibir(dynamic pessoa)
        {
            this.pessoa = pessoa;

            InitializeComponent();
        }
        public FormExibir(dynamic pessoa, List<Sala> salas)
        {
            this.pessoa = pessoa;
            this.salas = salas;

            InitializeComponent();
        }
        private void FormExibir_Load(object sender, EventArgs e)
        {
            if (pessoa.GetType() == typeof(Aluno))
            {
                panelCadastro.Visible = false;
                panelCadastro.Enabled = false;

                listBoxSala.DataSource = null;
                listBoxSala.DataSource = pessoa.salas;
            }
            else if(pessoa.GetType() == typeof(Professor))
            {
                listBoxSala.DataSource = null;
                listBoxSala.DataSource = salas;
                Sala aux = (Sala)listBoxSala.SelectedItem;

                listBoxHorario.DataSource = null;
                listBoxHorario.DataSource = aux.horasInicio;
            }

        }
        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            if (listBoxSala.SelectedItem != null)
            {
                Sala aux = (Sala)listBoxSala.SelectedItem;
                aux.horasInicio.Add(dateTimePickerHoraInicio.Value);

                aux.horasFim.Add(dateTimePickerHoraFim.Value);

                listBoxHorario.DataSource = null;
                listBoxHorario.DataSource = aux.horasInicio;

                listBoxHorasFim.DataSource = null;
                listBoxHorasFim.DataSource = aux.horasFim;
            }

            else if (listBoxHorario.SelectedItem != null)
            {

            }
        }

        private void listBoxSala_SelectedIndexChanged(object sender, EventArgs e)
        {
            Sala aux = (Sala)listBoxSala.SelectedItem;

            listBoxHorario.DataSource = null;
            listBoxHorario.DataSource = aux.horasInicio;

            listBoxHorasFim.DataSource = null;
            listBoxHorasFim.DataSource = aux.horasFim;
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            DateTime horaInicio = (DateTime)listBoxHorario.SelectedItem;
            DateTime horaFim = (DateTime)listBoxHorasFim.SelectedItem;

            Sala aux = (Sala)listBoxSala.SelectedItem;

            aux.horasInicio.Remove(horaInicio);
            aux.horasFim.Remove(horaFim);

            listBoxHorario.DataSource = null;
            listBoxHorario.DataSource = aux.horasInicio;

            listBoxHorasFim.DataSource = null;
            listBoxHorasFim.DataSource = aux.horasFim;
        }
    }
}
