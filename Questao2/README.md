# Questão 2 - Classe vs. Objeto

**Classe**
É basicamente um molde que define os atributos e métodos que os objetos criados a partir dela terão.


**Objeto**
É uma instância concreta de uma classe. Cada objeto tem seus próprios valores para os atributos definidos na classe.

---

### Classe

```csharp
public class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    public string Email { get; set; }
    
    public Pessoa(string nome, int idade, string email)
    {
        Nome = nome;
        Idade = idade;
        Email = email;
    }
    
    public void Apresentar()
    {
        Console.WriteLine($"Olá! Meu nome é {Nome}, tenho {Idade} anos.");
        Console.WriteLine($"Meu email é: {Email}");
    }
    
    public void FazerAniversario()
    {
        Idade++;
        Console.WriteLine($"{Nome} fez aniversário! Agora tem {Idade} anos.");
    }
}
```

### Objeto

```csharp
class Program
{
    static void Main(string[] args)
    {
        Pessoa pessoa1 = new Pessoa("Arthur Bobadilla", 25, "arthur@gmail.com");
        
        Pessoa pessoa2 = new Pessoa("Jorge Luis", 30, "jorge@gmail.com");
        
        Pessoa pessoa3 = new Pessoa("Luan Orlandelli", 22, "luan@gmail.com");
        
        Console.WriteLine("=== Apresentações ===\n");
        
        pessoa1.Apresentar();
        Console.WriteLine();
        
        pessoa2.Apresentar();
        Console.WriteLine();
        
        pessoa3.Apresentar();
        Console.WriteLine();
        
        Console.WriteLine("=== Aniversários ===\n");
        pessoa1.FazerAniversario();
        pessoa3.FazerAniversario();
        
        Console.WriteLine();
        
        Console.WriteLine($"{pessoa1.Nome} agora tem {pessoa1.Idade} anos");
        Console.WriteLine($"{pessoa2.Nome} continua com {pessoa2.Idade} anos");
        Console.WriteLine($"{pessoa3.Nome} agora tem {pessoa3.Idade} anos");
    }
}
```