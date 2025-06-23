namespace ECommerceApplication.Models
{
    public class Item
    {
        public int Id { get; set; }
        public Product product { get; set; }
        public Item()
        {
            Id = 0;
            product = null;
        }

        public Item(int id, Product p)
        {
            Id = id;
            product = p;
        }
    }
}