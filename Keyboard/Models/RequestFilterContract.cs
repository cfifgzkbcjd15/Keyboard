namespace Keyboard.Models
{
    public class RequestFilterContract
    {
        public int? MinPrice { get; set; } = 0;
        public int? MaxPrice { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; } = DateTime.Now;
        public string? ProductName { get; set; } = null;
        public string? FullNameCustomer { get; set; } = null;
        public int Page { get; set; }
    }
}
