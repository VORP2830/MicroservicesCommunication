namespace Products_API.DTOs
{
    public class ProductDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public SupplierDTO supplierDTO { get; set; }    
        public CategoryDTO categoryDTO { get; set; }
    }
}