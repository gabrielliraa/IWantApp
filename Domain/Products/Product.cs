﻿namespace IWantApp.Domain.Products;

public class Product : Entity
{

    public string Description { get; set; }

    public string Category { get; set; }

    public int CategoryId { get; set; }

    public bool HasStok { get; set; }

}
