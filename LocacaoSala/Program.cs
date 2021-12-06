using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocacaoSala
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            List<Usuario> usuarios = new();

            //criando salas
            Sala s1 = new("102", true, 30);
            Sala s2 = new("103", true, 35);
            Sala s3 = new("101", true, 10);
            Sala s4 = new("104", true, 30);

            List<Sala> salas = new();
            salas.Add(s1);
            salas.Add(s2);
            salas.Add(s3);
            salas.Add(s4);

            //criando professores e alunos
            Professor p1 = new("Fulano", "111.111.111-11", "fulano@professor.com", "123", "(49)99999-9999", "312");
            Professor p2 = new("Fulana", "111.111.111-12", "fulana@professor.com", "1234", "(49)99999-9990", "334");
            Aluno a1 = new("João", "111.111.111-13", "joao@aluno.com", "12345", "(49)99999-9998", "10000");
            Aluno a2 = new("Ana", "111.111.111-14", "ana@aluno.com", "123456", "(49)99999-9992", "10001");

            a1.salas.Add(s1);
            a1.salas.Add(s2);
            a2.salas.Add(s3);
            a2.salas.Add(s4);

            usuarios.Add(p1);
            usuarios.Add(p2);
            usuarios.Add(a1);
            usuarios.Add(a2);

            Application.Run(new FormLogin(usuarios, salas));
        }
    }
}
