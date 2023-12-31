namespace ASP_.Net_Core_API_CRUD.Models
{
    public class Brand
    {
        public int ID { get; set; }
        // ? : Artinya sebuah property akan menjadi Null
        public string? Name { get; set; }
        public string? Category { get; set; }
        public int IsActive { get; set; }
    }
}
