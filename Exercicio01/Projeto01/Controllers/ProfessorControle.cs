using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto01.Entities;
using System.IO;

namespace Projeto01.Controllers
{
    public class ProfessorControle
    {
        public void ExportarParaTxt(Professor professor )
        {
            StreamWriter sw = new StreamWriter("c:\\temp\\professorinformação.txt", true);

            sw.WriteLine("IDPROFESSOR.........:"+ professor.IdProfessor);
            sw.WriteLine("NOME DO PROFESSOR...:" + professor.Nome);
            sw.WriteLine("Email...............:" + professor.Email);

            sw.Close();
        }

    }
}
