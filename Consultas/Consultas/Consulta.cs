using System;
using System.Collections.Generic;
using System.Text;

namespace Consultas
{
    class Consulta
    {
        // declaração dos atributos
        private string data;
        private string hora;
        public double precoConsulta;

        // Metódos
        public void lerDadosConsulta()
        {
            Console.Write("\n    Informe a data:  ");
            data = Console.ReadLine();
            Console.Write("\n    Horário:  ");
            hora = Console.ReadLine();
            Console.Write("\n    Informe o preço:  ");
            precoConsulta = Convert.ToDouble(Console.ReadLine());
        }

        public void mostrarDadosConsulta() => Console.WriteLine("\n ---- Dados da Consulta ----" +
               "\n Data: " + data +
               "\n Horário: " + hora +
               "\n Preço da consulta: " + precoConsulta);
    }
}
