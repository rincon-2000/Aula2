using System;

namespace SwitchExpressions
{
    class Program
    {

        //Da erro pq a versão é 2017, esse tipo de código funciona na versão 2022
    
        enum Periodo
        {
            M,T,N
        }
        static void Main(string[] args)
        {
            Periodo periodo = Periodo.M;
            string descricao;
            _ = periodo switch
                { 
            Periodo.M => descricao = "Manhã",
                Periodo.T => descricao = "Tarde",
                Periodo.N => descricao = "Noite",
                _ => descricao = "Período Inválido"
                });
        Console.WriteLine("Periodo Informado: " + descricao);

        }
    }
}
