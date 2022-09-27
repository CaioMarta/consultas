using System;
using System.Collections.Generic;
using System.Text;

namespace Consultas
{
    class Paciente
    {
        // Declaração das variáveis
        private string planoSaude;
        private double valorExames;
        private Consulta consulta;


        // Construtor Sem Parâmetro
        public Paciente()
        {
            Console.WriteLine("\nExecutando o construtor de Paciente SEM parâmetros");
            planoSaude = null;
            valorExames = 0;
            // Instanciando o objeto consulta da Classe Consulta
            consulta = new Consulta(); // Executar o Construtor
        }

        // Metódos
        public void lerDadosPaciente()
        {
            var msg = "";

            try
            {
                consulta.lerDadosConsulta();

                Console.Write("Plano de saúde: ");
                planoSaude = Console.ReadLine();

                Console.Write("Valor do exame: ");
                valorExames = Convert.ToDouble(Console.ReadLine());

                msg = "Dados cadastrados com sucesso!";
            }
            catch (Exception ex) // Este campo pode aparacer várias vezes no programa
            {
                msg = "Informe os campos corretamente \n" + ex;
            }
            finally // Campo não obrigatório
            {
                Console.WriteLine(msg);
            }
        }
            public void mostrarDadosPaciente()
            {
                Console.WriteLine("DADOS DO PACIENTE");
                Console.WriteLine("Plano de saúde: " + planoSaude +
                    "\n Valor do Exame: " + valorExames);
            }
        public void calcularValorExamesqdeExames(int qdeExames)
        {
            valorExames = (consulta.precoConsulta * 0.1 + 75) * qdeExames;
        }
    }
}
