// Extension indexers (C# 15): além de métodos (C# 3) e propriedades (C# 14),
// agora dá pra adicionar o [ ] a um tipo que não é seu.

IEnumerable<int> numeros = Enumerable.Range(10, 5); // 10, 11, 12, 13, 14

Console.WriteLine($"Terceiro item: {numeros[2]}");   // 12, mesmo sendo IEnumerable
Console.WriteLine($"Está vazio? {numeros.EstaVazio}"); // propriedade de extensão (C# 14)

public static class ExtensoesSequencia
{
    extension(IEnumerable<int> sequencia)
    {
        public int this[int indice] => sequencia.ElementAt(indice);

        public bool EstaVazio => !sequencia.Any();
    }
}
