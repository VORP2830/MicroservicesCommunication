namespace Products_API.Entities
{
    public class Product : Base
    {
        public string Name { get; set; }
        public Supplier supplier { get; set; }
        public Category category { get; set; }
    }
}