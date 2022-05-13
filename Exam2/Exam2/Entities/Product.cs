namespace Exam2.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public DateTime CreateDate { get; set; }
        public int UserId { get; set; }
        public int CategoryId { get; set; }
    }
}
