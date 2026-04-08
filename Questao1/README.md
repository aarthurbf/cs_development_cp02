# Questão 1 - Conceitos Fundamentais de Orientação a Objetos

### 1. Encapsulamento

O encapsulamento consiste em esconder os detalhes internos de implementação de uma classe, expondo apenas o que é necessário através de uma interface pública. 

```csharp
public class ContaBancaria
{
    private decimal saldo;

    public decimal Saldo 
    { 
        get { return saldo; }
        private set { saldo = value; }
    }
    
    public ContaBancaria(decimal saldoInicial)
    {
        saldo = saldoInicial;
    }
    
    public void Depositar(decimal valor)
    {
        if (valor > 0)
        {
            saldo += valor;
            Console.WriteLine($"Depósito de R$ {valor:F2} realizado com sucesso!");
        }
        else
        {
            Console.WriteLine("Valor de depósito inválido!");
        }
    }
    
    public void Sacar(decimal valor)
    {
        if (valor > 0 && valor <= saldo)
        {
            saldo -= valor;
            Console.WriteLine($"Saque de R$ {valor:F2} realizado com sucesso!");
        }
        else
        {
            Console.WriteLine("Saldo insuficiente ou valor inválido!");
        }
    }
}

```
---

### 2. Herança

A herança permite que uma classe herde características de outra classe (classe base ou pai). Isso possibilita a reutilização de código e estabelece uma relação "é um" entre as classes.

```csharp
public class Animal
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    
    public Animal(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }
    
    public void Comer()
    {
        Console.WriteLine($"{Nome} está comendo");
    }
    
    public void Dormir()
    {
        Console.WriteLine($"{Nome} está dormindo");
    }
}

public class Cachorro : Animal
{
    public string Raca { get; set; }
    
    public Cachorro(string nome, int idade, string raca) : base(nome, idade)
    {
        Raca = raca;
    }
    
    public void Latir()
    {
        Console.WriteLine($"{Nome} está latindo");
    }
}
```
---

### 3. Polimorfismo

Basicamente o polimorfismo permite que objetos de diferentes classes sejam tratados através de uma interface comum, o mesmo método pode ter comportamentos diferentes dependendo do objeto que o executa.

```csharp
public class Forma
{
    public virtual void Desenhar()
    {
        Console.WriteLine("Desenhando uma forma genérica");
    }
    
    public virtual double CalcularArea()
    {
        return 0;
    }
}

public class Circulo : Forma
{
    public double Raio { get; set; }
    
    public Circulo(double raio)
    {
        Raio = raio;
    }
    
    public override void Desenhar()
    {
        Console.WriteLine("Desenhando um círculo ()");
    }
    
    public override double CalcularArea()
    {
        return Math.PI * Raio * Raio;
    }
}

public class Retangulo : Forma
{
    public double Largura { get; set; }
    public double Altura { get; set; }
    
    public Retangulo(double largura, double altura)
    {
        Largura = largura;
        Altura = altura;
    }
    
    public override void Desenhar()
    {
        Console.WriteLine("Desenhando um retângulo -");
    }
    
    public override double CalcularArea()
    {
        return Largura * Altura;
    }
}
```
---

### 4. Abstração

A abstração é o processo que identifica as características essenciais de um objeto, ignorando os detalhes irrelevantes. 

```csharp
public abstract class Veiculo
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
    
    public abstract void Ligar();
    
    public abstract void Desligar();
    
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
    
    public override void Ligar()
    {
        Console.WriteLine("Girando a chave, Carro ligado!");
    }
    
    public override void Desligar()
    {
        Console.WriteLine("Desligando o carro, Motor desligado.");
    }
}

public class Moto : Veiculo
{
    public bool TemCarenagem { get; set; }
    
    public Moto(string marca, string modelo, int ano, bool temCarenagem) 
        : base(marca, modelo, ano)
    {
        TemCarenagem = temCarenagem;
    }
    
    public override void Ligar()
    {
        Console.WriteLine("Apertando o botão, Moto ligada!");
    }
    
    public override void Desligar()
    {
        Console.WriteLine("Desligando a moto, Motor desligado.");
    }
}
```