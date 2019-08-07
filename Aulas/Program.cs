using Aula1;
using System;
using System.Collections.Generic;

namespace Aulas
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10; // armazenado na memória stack de forma direta // Quando tem muita coisa na memória stack, dá stackoverflow

            Pessoa p; // Tipo de "p" é Pessoa

            p = new Pessoa(); // p está recebendo uma nova pessoa (referenciando)
            p.Idade = 10; // atribuindo o valor 10; // salvo na memoria head, como referencia/endereço. Quando não coloca a referencia, dá o erro null pointer exception
            p.Nome = "Ana";
            
            //Console.WriteLine("Idade da pessoa é:" + p.Idade);
            //Console.ReadKey();

            Chefe b = new Chefe();
            b.Idade = 30;
            b.Nome = "Boss";
            b.SalarioAstronomico = decimal.MaxValue;

            //pedir login

            Console.WriteLine("entre com login");
            string login = Console.ReadLine();

            // pedir senha
            Console.WriteLine("entre com senha");
            string senha = Console.ReadLine();

            //criar usuario
            Usuario novoUsuario = new Usuario();
            novoUsuario.Login = login;
            novoUsuario.Senha = senha;

            
            // cadastrar usuario
            ListaDeUsuarios.Add(novoUsuario);

            // exibe informações
            Console.WriteLine("usuario cadastrado");
            Console.WriteLine("login: " + novoUsuario.Login);
            Console.ReadKey();
            Console.WriteLine("Quantidade de usuários cadastrados: " + ListaDeUsuarios.Count);
            Console.ReadKey();

            // pedir informações de login
            Console.WriteLine("Entre com login: ");
            string LoginParaEntrar = Console.ReadLine();

            // pedir informações de senha
            Console.WriteLine("Entre com senha: ");
            string SenhaParaEntrar = Console.ReadLine();

            // descobrir se esta cadastrado

            foreach ( Usuario usuario in ListaDeUsuarios)
            {
                if(usuario.Login == LoginParaEntrar)
                {
                    if(usuario.Senha == SenhaParaEntrar)
                    {
                        // redirecionar para uma pagina dentro do sistema
                        Console.WriteLine("Entra ae");
                    }
                    else
                    {
                        Console.WriteLine("Login ou senha inválidos");
                    }
                }
                else
                {
                    Console.WriteLine("Login ou senha inválidos");
                }
            }
            Console.ReadKey();
        }
        static List<Usuario> ListaDeUsuarios = new List<Usuario>();
        
    }
}
