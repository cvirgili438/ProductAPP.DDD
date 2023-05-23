namespace ProductAPP.DDD.MVC.Commands
{
    public record CreateProductCommand(
        string Name,
        decimal Price,
        int Stock,
        string Description)
    {

    }
}
