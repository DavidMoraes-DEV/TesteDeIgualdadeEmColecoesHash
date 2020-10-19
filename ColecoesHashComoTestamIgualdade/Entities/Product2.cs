using System;
using System.Collections.Generic;
using System.Text;

namespace ColecoesHashComoTestamIgualdade.Entities
{
    class Product2 //Classe com a implementação do GetHashCode e Equals
    {
        public string Name2 { get; set; }
        public double Price2 { get; set; }

        public Product2(string name, double price)
        {
            Name2 = name;
            Price2 = price;
        }

        public override int GetHashCode() //Implementação do GetHashCode para ver se o HashCode de dois produtos são iguais.
        {
            return Name2.GetHashCode() + Price2.GetHashCode();
        }

        public override bool Equals(object obj) //Implementação do Equals para comparar e confirmar o GetHashCode entre dois objetos.
        {
            if (!(obj is Product2))
            {
                return false;
            }
            Product2 other = obj as Product2;
            return Name2.Equals(other.Name2) && Price2.Equals(other.Price2);
        }
    }
}
