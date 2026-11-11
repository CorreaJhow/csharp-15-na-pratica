// Closed hierarchies (C# 15): mesma checagem exaustiva do union,
// mas mantendo herança (dados em comum na classe base).

System.Globalization.CultureInfo.CurrentCulture = new("pt-BR"); // R$ e vírgula em qualquer máquina

Pagamento[] pagamentos =
[
    new Pix(120.50m, "jhow@exemplo.com"),
    new Cartao(89.90m, Parcelas: 3),
    new Boleto(250m, Vencimento: new DateOnly(2026, 11, 30)),
];

foreach (var p in pagamentos)
    Console.WriteLine(Descrever(p));

// Sem "_ =>": "closed" garante que ninguém de fora do projeto cria uma filha nova.
static string Descrever(Pagamento pagamento) => pagamento switch
{
    Pix pix => $"Pix de {pix.Valor:C} para {pix.Chave}",
    Cartao c => $"Cartão de {c.Valor:C} em {c.Parcelas}x",
    Boleto b => $"Boleto de {b.Valor:C} vence em {b.Vencimento:dd/MM}",
};

public closed record Pagamento(decimal Valor);
public record Pix(decimal Valor, string Chave) : Pagamento(Valor);
public record Cartao(decimal Valor, int Parcelas) : Pagamento(Valor);
public record Boleto(decimal Valor, DateOnly Vencimento) : Pagamento(Valor);
