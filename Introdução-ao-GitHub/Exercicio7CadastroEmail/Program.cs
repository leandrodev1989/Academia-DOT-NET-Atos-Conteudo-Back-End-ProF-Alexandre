﻿/*Desafio: programa no VS, com menu, para cadastrar usuários no sistema e gerar seus emails
               automaticamente. Os usuários (nome completo e email) devem ser persistidos em arquivo.
               Além disso, é preciso mantê-los em uma lista dinâmica em memória, que é populada sempre que 
               o programa executa.

                Menu
                1 - Cadastrar usuário (só o nome completo)
                        -gerar o email 
                        - verificar se este email já foi gerado (na lista)
                        -caso não exista, colocar na lista e persistir no arquivo: nome completo; email
                2 - Listar os usuários(nome completo e email)
                        -mostrar ordenado(pode)
                3 - Sair
                Opção:

Observações: Classe Usuário(construtor, getters/ setters, gerarEmail); List; StreamWriter; StreamReader */

string opcao = "";

do
{
    Console.Clear();

    Console.WriteLine("MENU");
    Console.WriteLine("[SISTEMA CADASTRO DE USUÁRIO]");
    Console.WriteLine(" 1 - CADASTRAR USUARIO");
    Console.WriteLine(" 2 - LISTAR USUÁRIO");
    Console.WriteLine(" 3 - SAIR");
    Console.WriteLine(" OPÇÃO");
    opcao = Console.ReadLine();


    switch (opcao)
    {
        case "1":
            break;
        case "2":
            break;
        case "3":
            Console.WriteLine("Obrigado por usar o sistema");
            break;
        default:
            Console.WriteLine("Opção inválida!");
            break;


    }

    Console.Write("Pressione algo para continuar!");
    Console.ReadKey();

} while (opcao != "3");
