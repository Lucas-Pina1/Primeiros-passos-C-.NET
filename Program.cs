using System;

namespace revisao
{
  class Program
  {
    static void Main(string[] args)
    {
      Aluno[] alunos = new Aluno[5];
      var indeceAluno = 0;
      string opcaoUsuario = ObterOpcaoUsuario();

      while (opcaoUsuario.ToUpper() != "X")
      {
        switch (opcaoUsuario)
        {
          case "1":
            Console.WriteLine("Informe o nome do aluno:");
            var aluno = new Aluno();
            aluno.Nome = Console.ReadLine();

            Console.WriteLine("Informe a nota do aluno:");

            if (decimal.TryParse(Console.ReadLine(), out decimal nota)) 
            {
              aluno.Nota = nota;
            } 
            else 
            {
              throw new ArgumentException("Valor da nota deve ser decimal");
            } 

            alunos[indeceAluno] = aluno;
            indeceAluno++;

            break;
          case "2":
            foreach (var item in alunos)
            { 
              if (!string.IsNullOrEmpty(item.Nome)) 
              {
                 Console.WriteLine($"ALUNO: {item.Nome} - NOTA: {item.Nota}");
              }
            }
            break;
          case "3":

            break;
          default:
            throw new ArgumentOutOfRangeException();
        }
        opcaoUsuario = ObterOpcaoUsuario();
      }
    }

    private static string ObterOpcaoUsuario()
    {
      Console.WriteLine();
      Console.WriteLine("informe a opção desejada");
      Console.WriteLine("1- Inserir novo aluno");
      Console.WriteLine("2- Listar alunos");
      Console.WriteLine("3- Cacular média geral");
      Console.WriteLine("X - Sair");
      Console.WriteLine();

      string opcaoUsuario = Console.ReadLine();
      Console.WriteLine();
      return opcaoUsuario;
    }
  }
}
