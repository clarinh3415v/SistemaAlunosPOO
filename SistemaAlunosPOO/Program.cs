using System.Diagnostics.CodeAnalysis;

namespace SistemaAlunosPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Alunos> alunos = new List<Alunos>();
        bool executar = true;

            while (executar) 
            {
                Console.WriteLine(" MENU DE OPÇÕES");
                Console.WriteLine("1. Cadastrar Aluno");
                Console.WriteLine("2. Listar Alunos");
                Console.WriteLine("3. Alterar Aluno");
                Console.WriteLine("4. Remover Aluno");
                Console.WriteLine("5. Sair");
                Console.Write("Escolha uma opção: ");
                string opcao = Console.ReadLine();


                switch (opcao)
                {
                    case "1":

                        Alunos novoAluno = new Alunos();

                        Console.WriteLine("Digite o RA do aluno:");
                        novoAluno.RA = Console.ReadLine();

                    case "2":

                        Console.WriteLine("---- Lista de Alunos");                }

        }

    }
}
