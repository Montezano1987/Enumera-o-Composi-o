using Enumeração_Composição.Entities;

namespace Enumeração_Composição.Entities

class Product
{
    public string Name { get; set; }
    public double Price { get; set; }

    public Product()
    {
    }

    public Product(string name, double price)
    {
        Name = name;
        Price = price;
    }
}
