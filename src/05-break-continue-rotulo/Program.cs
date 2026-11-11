// break e continue com rótulo (C# 15): sair do loop de fora sem variável de controle nem goto.

char[,] grade =
{
    { '.', '.', '#', '.' },
    { '.', '#', '.', '.' },
    { '.', '.', '.', 'X' },
};

var visitadas = 0;

linhas: for (int linha = 0; linha < grade.GetLength(0); linha++)
{
    for (int coluna = 0; coluna < grade.GetLength(1); coluna++)
    {
        if (grade[linha, coluna] == '#')
            continue linhas; // bloqueado: pula pra próxima LINHA

        visitadas++;

        if (grade[linha, coluna] == 'X')
        {
            Console.WriteLine($"Achei o X em ({linha}, {coluna}) depois de {visitadas} casas.");
            break linhas; // sai dos DOIS loops
        }
    }
}
