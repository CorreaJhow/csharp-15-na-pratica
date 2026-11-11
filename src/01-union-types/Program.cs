// Union types (C# 15): o método diz na assinatura tudo que pode devolver,
// e o compilador cobra que quem chama trate todos os casos.

var repositorio = new RepositorioUsuarios();

foreach (var id in new[] { 1, 2, 99 })
{
    ResultadoBusca resultado = repositorio.Buscar(id);

    // Sem "_ =>": o compilador sabe que só existem esses três casos.
    // Se alguém adicionar um quarto tipo no union, este switch para de compilar.
    string mensagem = resultado switch
    {
        Usuario u => $"Olá, {u.Nome}!",
        NaoEncontrado n => $"Usuário {n.Id} não existe.",
        Erro e => $"Falhou: {e.Mensagem}",
    };

    Console.WriteLine($"Buscar({id}) -> {mensagem}");
}

public record Usuario(int Id, string Nome);
public record NaoEncontrado(int Id);
public record Erro(string Mensagem);

public union ResultadoBusca(Usuario, NaoEncontrado, Erro);

public class RepositorioUsuarios
{
    private readonly Dictionary<int, Usuario> _usuarios = new()
    {
        [1] = new Usuario(1, "Jhow"),
    };

    public ResultadoBusca Buscar(int id)
    {
        if (id == 99) return new Erro("banco fora do ar (simulado)");
        return _usuarios.TryGetValue(id, out var usuario) ? usuario : new NaoEncontrado(id);
    }
}
