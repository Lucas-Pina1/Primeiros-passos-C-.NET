﻿using System;

namespace revisao
{
  class Program
  {
    static void Main(string[] args)
    {
      string opcaoUsuario = ObterOpcaoUsuario();

      while (opcaoUsuario.ToUpper() != "X")
      {
        switch (opcaoUsuario)
        {
          case "1":

            break;
          case "2":

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
