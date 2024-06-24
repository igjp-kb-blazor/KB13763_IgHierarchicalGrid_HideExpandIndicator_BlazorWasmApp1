namespace KB13763_BlazorWasmApp1.Data;

public class Category
{
    public int CategoryID { get; set; }
    public string CategoryName { get; set; } = String.Empty;
    public List<Product> Products { get; set; } = new List<Product>();
    public bool HasProducts { get { return this.Products.Count > 0; } }

    public Category()
    {
    }
}
