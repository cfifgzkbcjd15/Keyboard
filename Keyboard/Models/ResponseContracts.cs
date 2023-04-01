namespace Keyboard.Models
{
    public class ResponseContracts
    {
        public string Id { get; set; }
        public DateTime PublishDate { get; set; }
        public DateTime SignDate { get; set; }
        public Customer Customer { get; set; }
        public List<Product> Products { get; set; }
        public string Href { get; set; }
        public double Price { get; set; }
    }
}
