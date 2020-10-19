using System;
using System.Collections.Generic;
using ColecoesHashComoTestamIgualdade.Entities;

namespace ColecoesHashComoTestamIgualdade
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            * Como as coleções Hash testam igualdade?
            - Se GetHashCode e Equals estiverem implementados:
                - Primeiro GetHashCode. Se der igual, usa Equals para confirmar.
             */

            HashSet<string> set = new HashSet<string>();
            set.Add("Maria");
            set.Add("Alex");

            Console.Write("Exemplo simples: O nome (Maria) existe na coleção set: ");
            Console.WriteLine(set.Contains("Maria")); //A função .Contains irá testar o GetHashCode conforme explicado acima

            /*
             - Se GetHashCode e Equals NÃO estiverem implementados:
                - Tipos referência: compara as referências dos objetos
                - Tipos valor: comparar os valores dos atributos
             */

            //Tipos referência: Sem a implementação do GetHashCode e Equals na classe Product1. Irá comparar as referências.
            HashSet<Product1> a = new HashSet<Product1>();
            a.Add(new Product1("TV", 900.0));
            a.Add(new Product1("Notebook", 1200.0));

            Product1 prod1 = new Product1("Notebook", 1200.0);

            Console.WriteLine();
            Console.WriteLine("Sem a implementação do GetHashCode e Equals na classe: ");
            Console.WriteLine("Os objetos são iguais: " + a.Contains(prod1)); //Nesse caso o .Contains iá considerar para comparação as referências dos objetos e não seu conteúdo, por isso que mesmo os dados sendo totalmente iguais o resultado será "false", pois as referências dos objetos são realmente diferentes uma da outra.

            //Tipos Referência: Com a implementação do GetHashCode e Equals na classe Product2. Irá comparar agora o conteúdo(valores) dos objetos.
            HashSet<Product2> b = new HashSet<Product2>();
            b.Add(new Product2("TV", 900.0));
            b.Add(new Product2("Notebook", 1200.0));

            Product2 prod2 = new Product2("Notebook", 1200.0);

            Console.WriteLine();
            Console.WriteLine("Com a implementação do GetHashCode e Equals na classe: ");
            Console.WriteLine("Os objetos são iguais: " + b.Contains(prod2)); //Nesse caso o .Contains agora irá comparar os valores contidos nos objetos e não suas referência, então nesse caso o resultado será "True" pois realmente o conteúdo dos dois objetos são iguais.

            //Tipos Valor: Sempre comparará o conteúdo dos objetos e não suas referências.
            HashSet<Point> c = new HashSet<Point>();
            c.Add(new Point(3, 4));
            c.Add(new Point(5, 10));

            Point point = new Point(5, 10);

            Console.WriteLine();
            Console.WriteLine("Os pontos do Struct (Point) são iguais? " + c.Contains(point)); //No caso de um Struct sempre será comparado o seus valores(conteúdo) dos objetos e não suas referências, por isso nesse caso não é necessário implementar o GetHashCode e Equals dentro do Struct Point.
        }
    }
}
