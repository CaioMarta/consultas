using System;

namespace Consultas
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaração
            int qtdExames;

            Paciente paciente1 = new Paciente();
            paciente1.lerDadosPaciente();
            Console.WriteLine("Informe a quantidade de exames: ");
            qtdExames = Convert.ToInt32(Console.ReadLine());
            paciente1.calcularValorExamesqdeExames(qtdExames);
            paciente1.mostrarDadosPaciente();

            Paciente paciente2 = new Paciente();
            paciente2.lerDadosPaciente();
            Console.WriteLine("Informe a quantidade de exames: ");
            qtdExames = Convert.ToInt32(Console.ReadLine());
            paciente2.calcularValorExamesqdeExames(qtdExames);
            paciente2.mostrarDadosPaciente();

        }
    }
}
