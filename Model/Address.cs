using System.ComponentModel.DataAnnotations;

namespace BlazingPizza
{
    public class Address
    {
        public int Id { get; set; }

        [Required, MinLength(3), MaxLength(100)]
        public string Name { get; set; }

        [Required, MinLength(5), MaxLength(100)]
        public string Line1 { get; set; }

        [MaxLength(100)]
        public string Line2 { get; set; }

        [Required, MinLength(3), MaxLength(50)]
        public string City { get; set; }

        [Required, MinLength(3), MaxLength(20)]
        public string Region { get; set; }

        [Required, RegularExpression(@"^([0-9]{5})$")]
        public string PostalCode { get; set; }
    }
}
