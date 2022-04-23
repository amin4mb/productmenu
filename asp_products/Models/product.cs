namespace asp_products.Models
{
    public class product
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public int Count { get; set; }  
    }
}
