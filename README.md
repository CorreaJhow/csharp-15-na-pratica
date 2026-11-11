# C# 15 na prática

[![build](https://github.com/CorreaJhow/csharp-15-na-pratica/actions/workflows/build.yml/badge.svg)](https://github.com/CorreaJhow/csharp-15-na-pratica/actions/workflows/build.yml)

Exemplos curtos que **compilam e rodam** de cada novidade do C# 15 / .NET 11, em português e com cenário do dia a dia (busca de usuário, Pix/cartão/boleto) no lugar de `Foo` e `Bar`.

Cada pasta acompanha um post meu no [LinkedIn](https://www.linkedin.com/in/jhonatas-r-correa/). Leu o post e quer ver rodando? É aqui.

| # | Novidade | Em uma frase |
|---|---|---|
| [01](src/01-union-types/Program.cs) | Union types | `union ResultadoBusca(Usuario, NaoEncontrado, Erro)`: a assinatura conta a verdade e o switch é checado no build |
| [02](src/02-closed-hierarchies/Program.cs) | Closed hierarchies | `closed record Pagamento`: mesma checagem, mantendo herança |
| [03](src/03-collection-with/Program.cs) | `with(...)` em collection expressions | Comparador e capacidade sem sair dos colchetes |
| [04](src/04-extension-indexers/Program.cs) | Extension indexers | `numeros[2]` num `IEnumerable<int>` |
| [05](src/05-break-continue-rotulo/Program.cs) | `break`/`continue` com rótulo | Sai do loop de fora sem variável `achou` |

## Rodar

Precisa do [SDK do .NET 11](https://dotnet.microsoft.com/download/dotnet/11.0).

```bash
dotnet run --project src/01-union-types
```

O projeto liga `TreatWarningsAsErrors`: tire um caso de qualquer `switch` dos exemplos 01 ou 02 e veja o build quebrar. É o melhor jeito de entender o ganho.

## Fontes

- [O que há de novo no C# 15](https://learn.microsoft.com/dotnet/csharp/whats-new/csharp-15)
- [Notas do ASP.NET Core 11](https://learn.microsoft.com/aspnet/core/release-notes/aspnetcore-11) (union funciona no corpo JSON, não em rota, query, header ou form)

Achou erro ou quer um exemplo de outra novidade? Abre uma issue.

## Licença

MIT
