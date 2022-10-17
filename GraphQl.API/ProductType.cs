namespace GraphQl.API
{
    public class ProductType:ObjectGraphType<Product>
    {
        public ProductType()
        {
            Field(x => x.id);
            Field(x => x.name);
            Field(x => x.quantity);
        }
    }
}
