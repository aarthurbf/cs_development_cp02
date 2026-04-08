# Questão 4 - Sobrecarga e Sobrescrita

## Overloading

Overloading é quando você cria múltiplos métodos com o mesmo nome na mesma classe, mas com assinaturas diferentes.

```csharp
public class Calculadora
{
    public int Somar(int a, int b)
    {
        Console.WriteLine("Chamando Somar(int, int)");
        return a + b;
    }
    
    public int Somar(int a, int b, int c)
    {
        Console.WriteLine("Chamando Somar(int, int, int)");
        return a + b + c;
    }
    
    public double Somar(double a, double b)
    {
        Console.WriteLine("Chamando Somar(double, double)");
        return a + b;
    }
    
    public int Somar(int[] numeros)
    {
        Console.WriteLine("Chamando Somar(int[])");
        int soma = 0;
        foreach (int num in numeros)
        {
            soma += num;
        }
        return soma;
    }
    
    public string Somar(string a, string b)
    {
        Console.WriteLine("Chamando Somar(string, string)");
        return a + " " + b;
    }
}

class Program
{
    static void Main()
    {
        Calculadora calc = new Calculadora();
        
        Console.WriteLine($"Resultado: {calc.Somar(5, 3)}\n");           
        Console.WriteLine($"Resultado: {calc.Somar(5, 3, 2)}\n");     
        Console.WriteLine($"Resultado: {calc.Somar(5.5, 3.2)}\n");      
        Console.WriteLine($"Resultado: {calc.Somar(new int[] {1, 2, 3, 4, 5})}\n"); 
        Console.WriteLine($"Resultado: {calc.Somar("Olá", "Mundo")}\n"); 
    }
}
```
---

## Overriding

Overrding é quando uma classe filha fornece uma nova implementação para um método que já existe na classe pai. 

```csharp
public class Animal
{
    public string Nome { get; set; }
    
    public Animal(string nome)
    {
        Nome = nome;
    }

    public virtual void EmitirSom()
    {
        Console.WriteLine($"{Nome} faz algum som");
    }
    
    public virtual void Mover()
    {
        Console.WriteLine($"{Nome} está se movendo");
    }
    
    public void Dormir()
    {
        Console.WriteLine($"{Nome} está dormindo");
    }
}


public class Cachorro : Animal
{
    public Cachorro(string nome) : base(nome) { }
    
    public override void EmitirSom()
    {
        Console.WriteLine($"{Nome} faz: Au au!");
    }
    
    public override void Mover()
    {
        Console.WriteLine($"{Nome} está correndo");
    }
}

public class Gato : Animal
{
    public Gato(string nome) : base(nome) { }
    
    public override void EmitirSom()
    {
        Console.WriteLine($"{Nome} faz: Miau");
    }
    
    public override void Mover()
    {
        Console.WriteLine($"{Nome} está andando");
    }
}

class Program
{
    static void Main()
    {
        List<Animal> animais = new List<Animal>
        {
            new Cachorro("Rex"),
            new Gato("Mimi"),
            new Cachorro("Bob")
        };
        
        Console.WriteLine("=== Polimorfismo ===\n");
        
        foreach (Animal animal in animais)
        {
            animal.EmitirSom();  
            animal.Mover();     
            animal.Dormir();     
            Console.WriteLine();
        }
    }
}
```