namespace GraphQl.API
{
    public class ProductProvider : IProductProvider
    {
        public List<Product> GetProducts() => new List<Product> 
        {
            new Product(1,"Laptop",20),
            new Product(2,"Mouse",30),
            new Product(3,"Keyboard",15),
            new Product(4,"Hracan",60),
            new Product(5,"Danak",8),
        };
    }
}
