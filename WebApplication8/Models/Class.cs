namespace WebApplication8.Models
{
    public record Product
    {
        public int Id { get; set; } = default!;
        public string Name { get; set; } = default!;
        public int Price { get; set; } = default!;
        public DateTime CreatedDate { get; set; } = default!;
    }
}
