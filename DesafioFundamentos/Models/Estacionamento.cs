using System;
using System.Collections.Generic;

namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            // Implementado!!!
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            veiculos.Add(Console.ReadLine());
        }
        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");
            
            // Implementado!!!
            string placa = "";
            placa=(Console.ReadLine());

            // Verifica se o veículo existedotnet run
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                // Implementado!!!
                int horas = int.Parse(Console.ReadLine());
                decimal valorTotal = 0;
                valorTotal =  precoInicial + (horas * precoPorHora);

                // Implementado!!!          
                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
                veiculos.Remove(placa);
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");

                // Implementado!!!
                foreach(string valor in veiculos)
                {
                    Console.WriteLine($"Placa do veiculo: {valor}");      
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
