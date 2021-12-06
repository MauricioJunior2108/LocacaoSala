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
    public partial class FormLogin : Form
    {
        List<Usuario> usuarios = new();
        public List<Sala> salas = new();

        public FormLogin(List<Usuario> usuarios, List<Sala> salas)
        {
            this.usuarios = usuarios;
            this.salas = salas;

            InitializeComponent();
        }

        private void buttonEntrar_Click(object sender, EventArgs e)
        {
            foreach(var elemento in usuarios)
            {
                if(elemento.Email == textBoxEmail.Text)
                {
                    if (elemento.Senha == textBoxSenha.Text)
                    {
                        if (elemento.GetType() == typeof(Professor))
                        {
                            FormExibir telaCad = new FormExibir(elemento, salas);

                            telaCad.ShowDialog();
                        }
                        else if (elemento.GetType() == typeof(Aluno))
                        {
                            FormExibir telaExibir = new(elemento);

                            telaExibir.ShowDialog();
                        }
                    }
                }

            }
        }
    }
}
