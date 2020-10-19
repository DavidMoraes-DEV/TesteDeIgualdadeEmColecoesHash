namespace ColecoesHashComoTestamIgualdade.Entities
{
    class Product1 //Classe sem a implantação do GetHashCode e Equals
    {
        public string Name1 { get; set; }
        public double Price1 { get; set; }

        public Product1(string name, double price)
        {
            Name1 = name;
            Price1 = price;
        }
    }
}
