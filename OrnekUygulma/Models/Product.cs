

namespace OrnekUygulma.Models
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }
    
        public string Description { get; set; }

        public int  Stock  { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public IList<Address> Address { get; set; }
    }
}
