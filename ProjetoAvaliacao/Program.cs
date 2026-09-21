class Program
{
    static void Main(string[] args)
    {
        // criando os alunos
        Aluno aluno1 = new Aluno("Joao", 15);
        Aluno aluno2 = new Aluno("Maria", 16);

        // criando os produtos
        Produto produto1 = new Produto("Caderno", 25);
        Produto produto2 = new Produto("Caneta", 5);

        // criando os funcionarios
        Funcionario funcionario1 = new Funcionario("Carlos", 2000);
        Funcionario funcionario2 = new Funcionario("Ana", 3000);

        // alterando alguns valores
        aluno1.Idade = 16;
        produto1.Preco = 30;
        funcionario1.Salario = 2500;

        // mostrando tudo na tela
        Console.WriteLine(aluno1);
        Console.WriteLine(aluno2);

        Console.WriteLine(produto1);
        Console.WriteLine(produto2);

        Console.WriteLine(funcionario1);
        Console.WriteLine(funcionario2);
    }
}