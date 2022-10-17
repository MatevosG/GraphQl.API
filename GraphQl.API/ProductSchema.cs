namespace GraphQl.API
{
    public class ProductSchema:Schema
    {
        public ProductSchema(IServiceProvider serviceProvider) : base(serviceProvider)
        {
            Query = serviceProvider.GetRequiredService<ProductQuery>();
        }
    }
}
