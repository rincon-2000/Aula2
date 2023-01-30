using System;

namespace EstruturasControle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new String('-', 40));
            Console.WriteLine("Swicth case");
            Console.Write("Digite um valor: ");
            string diaSemana = Console.ReadLine();
            string resultado = "";

            if (diaSemana.Trim() == "")
            {
                return;
            }
            switch (diaSemana)
            {
                //case "1":
                //    resultado = "Domingo";
                //    break;
                //case "2":
                //    resultado = "Segunda-Feira";
                //    break;
                //case "3":
                //    resultado = "Terça-Feira";
                //    break;
                //case "4":
                //    resultado = "Quarta-Feira";
                //    break;
                //case "5":
                //    resultado = "Quinta-Feira";
                //    break;
                //case "6":
                //    resultado = "Sexta-Feira";
                //    break;
                //case "7":
                //    resultado = "Sabado";
                //    break;
                //default:
                //    Console.WriteLine(" Valor fora da faixa de 1 até 7");
                //    break;

                case "1":
                    resultado = "Domingo";
                        break;
                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                    resultado = "Dia Útil";
                        break;
                case "7":
                    resultado = "Sábado";
                        break;
                        default:
                    Console.WriteLine("Valor fora da faixa de 1 até 7");
                        break;
                    }
                    Console.WriteLine("Dia da semana: " + resultado);
        }
}
}
