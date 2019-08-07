using Aula1;
using System;

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
            
            Console.WriteLine("Idade da pessoa é:" + p.Idade);
            Console.ReadKey();

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
            Usuario novoUsuario;
        }
    }
}
