namespace OrnekUygulma.Models
{
    public class Address
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Content { get; set; }

        public string Province { get; set; }

        public string PostCode { get; set; }

        public virtual Product Product { get; set; }


    }
}
