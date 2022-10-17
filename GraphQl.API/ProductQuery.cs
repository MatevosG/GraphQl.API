using GraphQL;

namespace GraphQl.API
{
    public class ProductQuery:ObjectGraphType
    {
        public ProductQuery(IProductProvider productProvider)
        {
            Field<ListGraphType<ProductType>>(Name="products", resolve: x=> productProvider.GetProducts());
            Field<ProductType>(Name = "product",
                arguments: new QueryArguments(new QueryArgument<IntGraphType> { Name = "id" }),
                resolve: x => productProvider.GetProducts().FirstOrDefault(p => p.id == x.GetArgument<int>("id")));
        }
    }
}
