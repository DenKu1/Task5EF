namespace DataLevel
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual Category Category { get; set; }
        public virtual Provider Provider { get; set; }
        public decimal Price { get; set; }
    }
}
