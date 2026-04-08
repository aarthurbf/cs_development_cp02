using System;
using System.Collections.Generic;

namespace Questao6
{
    public class Veiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }

        public Veiculo(string marca, string modelo, int ano)
        {
            Marca = marca;
            Modelo = modelo;
            Ano = ano;
        }

        public virtual void Acelerar()
        {
            Console.WriteLine("Veículo acelerando...");
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"Veículo: {Marca} {Modelo} ({Ano})");
        }
    }

    public class Carro : Veiculo
    {
        public int NumeroPortas { get; set; }

        public Carro(string marca, string modelo, int ano, int numeroPortas) 
            : base(marca, modelo, ano)
        {
            NumeroPortas = numeroPortas;
        }

        public override void Acelerar()
        {
            Console.WriteLine($"Carro {Marca} {Modelo} acelerando rapidamente na estrada!");
            Console.WriteLine("   Velocidade aumentando suavemente!");
        }
    }

    public class Caminhao : Veiculo
    {
        public double CapacidadeCarga { get; set; }

        public Caminhao(string marca, string modelo, int ano, double capacidadeCarga) 
            : base(marca, modelo, ano)
        {
            CapacidadeCarga = capacidadeCarga;
        }

        public override void Acelerar()
        {
            Console.WriteLine($"Caminhão {Marca} {Modelo} acelerando pesadamente");
            Console.WriteLine($"   Transportando {CapacidadeCarga} toneladas");
        }
    }

    public class Moto : Veiculo
    {
        public int Cilindradas { get; set; }

        public Moto(string marca, string modelo, int ano, int cilindradas) 
            : base(marca, modelo, ano)
        {
            Cilindradas = cilindradas;
        }

        public override void Acelerar()
        {
            Console.WriteLine($"Moto {Marca} {Modelo} acelerando rapidamente!");
            Console.WriteLine($"   {Cilindradas}cc Aceleração instantânea");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("== HIERARQUIA VEÍCULOS ===");

            List<Veiculo> veiculos = new List<Veiculo>
            {
                new Carro("Toyota", "Corolla", 2023, 4),
                new Caminhao("Scania", "R450", 2022, 25.5),
                new Moto("Honda", "CB 500", 2024, 500),
                new Carro("Ford", "Mustang", 2023, 2),
                new Moto("Yamaha", "MT-09", 2023, 900),
                new Caminhao("Volvo", "FH16", 2021, 30.0),
                new Carro("Chevrolet", "Onix", 2024, 4)
            };

            Console.WriteLine($"Total de veículos na garagem: {veiculos.Count}\n");
            Console.WriteLine(new string('═', 60));
            Console.WriteLine();
 
            for (int i = 0; i < veiculos.Count; i++)
            {
                Console.WriteLine($"[Veículo {i + 1}]");
                veiculos[i].ExibirInformacoes();
                
                veiculos[i].Acelerar();
                
                Console.WriteLine(new string('-', 60));
                Console.WriteLine();
            }

            Console.WriteLine("\n" + new string('═', 60));
            Console.WriteLine();

            int contador = 0;
            while (contador < veiculos.Count)
            {
                Veiculo veiculo = veiculos[contador];
                
                Console.WriteLine($"[Posição {contador}]");
                
                if (veiculo is Carro)
                {
                    Console.WriteLine("Tipo: CARRO");
                }
                else if (veiculo is Caminhao)
                {
                    Console.WriteLine("Tipo: CAMINHÃO");
                }
                else if (veiculo is Moto)
                {
                    Console.WriteLine("Tipo: MOTO");
                }
                
                veiculo.Acelerar();
                
                Console.WriteLine();
                contador++;
            }

            Console.WriteLine(new string('═', 60));
            Console.WriteLine();

            Console.WriteLine("FILTRANDO VEÍCULOS POR TIPO \n");
            
            Console.WriteLine("CARROS:");
            foreach (Veiculo v in veiculos)
            {
                if (v is Carro carro)
                {
                    Console.WriteLine($"   - {carro.Marca} {carro.Modelo} ({carro.NumeroPortas} portas)");
                }
            }
            
            Console.WriteLine("\n CAMINHÕES:");
            foreach (Veiculo v in veiculos)
            {
                if (v is Caminhao caminhao)
                {
                    Console.WriteLine($"   - {caminhao.Marca} {caminhao.Modelo} (Capacidade: {caminhao.CapacidadeCarga}t)");
                }
            }
            
            Console.WriteLine("\n MOTOS:");
            foreach (Veiculo v in veiculos)
            {
                if (v is Moto moto)
                {
                    Console.WriteLine($"   - {moto.Marca} {moto.Modelo} ({moto.Cilindradas}cc)");
                }
            }

            Console.WriteLine();
            Console.WriteLine(new string('═', 60));
            Console.WriteLine();

            Console.WriteLine("TESTANDO TODOS OS VEÍCULOS \n");
            
            foreach (Veiculo veiculo in veiculos)
            {
                TestarVeiculo(veiculo);
            }

            Console.WriteLine();
            Console.WriteLine("=== FIM ===");
        }

        static void TestarVeiculo(Veiculo veiculo)
        {
            Console.Write($"Testando {veiculo.Marca} {veiculo.Modelo}... ");
            veiculo.Acelerar();
        }
    }
}
