using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto01.Controllers;
using Projeto01.Entities;

namespace Projeto01
{
    class Program
    {
        static void Main(string[] args)
        {
            Professor professor = new Professor();
            Console.WriteLine("\nDADOS DO PROFESSOR:\n");

            Console.WriteLine("IdProfessor:");
            professor.IdProfessor = int.Parse(Console.ReadLine());

            Console.WriteLine("Nome Professor:");
            professor.Nome = Console.ReadLine();

            Console.WriteLine("Email do professor:");
            professor.Email = Console.ReadLine();


            ProfessorControle professorControle = new ProfessorControle();
            professorControle.ExportarParaTxt(professor);

            Console.WriteLine("Dados gravados");

            Console.ReadKey();

        }

        
    }
}
