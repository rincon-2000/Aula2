using System;

namespace ForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] alunos = { "Guilherme", "Romulo", "Jhony",
            //                  "Paulo", "Vinicius", "Fernando" };

            //foreach (var aluno in alunos)
            //{
            //    Console.WriteLine(aluno);
            //}
            string[] alunos = { "Guilherme", "Pomulo", "Jhony",
                              "Paulo", "Vinicius", "Pernando" };

            foreach (var aluno in alunos)
            {
                if (aluno.ToUpper().StartsWith("P"))
                {
                    Console.WriteLine("Aluno: " + aluno.ToUpper());
                }
            }
        }
    }
}
