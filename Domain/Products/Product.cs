namespace IWantApp.Domain.Products;

public class Product : Entity
{
    public string Name { get; set; }
    public string Description { get; set; }

    public string Category { get; set; }

    public Guid CategoryId { get; set; }

    public bool HasStok { get; set; }

    public bool Active { get; set;}

}
