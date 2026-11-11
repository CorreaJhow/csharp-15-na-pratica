// Argumentos em collection expressions (C# 15): with(...) passa parâmetros
// pro construtor sem abandonar a sintaxe de colchetes.

string[] valores = ["Hello", "HELLO", "hello", "Olá"];

// Antes: tinha que voltar pro "new" pra passar o comparador.
var antes = new HashSet<string>(StringComparer.OrdinalIgnoreCase) { "Hello", "HELLO", "hello", "Olá" };

// Agora:
HashSet<string> agora = [with(StringComparer.OrdinalIgnoreCase), .. valores];
List<string> comCapacidade = [with(capacity: valores.Length * 2), .. valores];

Console.WriteLine($"Antes: {antes.Count} itens | Agora: {agora.Count} itens"); // 2 e 2
Console.WriteLine($"Lista: {comCapacidade.Count} itens, capacidade reservada {comCapacidade.Capacity}");
