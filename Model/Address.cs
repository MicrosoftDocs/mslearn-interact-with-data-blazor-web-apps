using System.ComponentModel.DataAnnotations;

namespace BlazingPizza
{
    public class Address
    {
        public int Id { get; set; }

        [Required, MinLength(2, ErrorMessage = "Please use a Name bigger than 2 letters."), MaxLength(150, ErrorMessage = "Please use a Name less than 150 letters.")]
        public string Name { get; set; }

        [Required, MinLength(5, ErrorMessage = "Please use an Address bigger than 5 letters."), MaxLength(100, ErrorMessage = "Please use an Address less than 100 letters.")]
        public string Line1 { get; set; }

        [MaxLength(100)]
        public string Line2 { get; set; }

        [Required, MinLength(3, ErrorMessage = "Please use a City bigger than 3 letters."), MaxLength(50, ErrorMessage = "Please use a City less than 50 letters.")]
        public string City { get; set; }

        [Required, MinLength(3, ErrorMessage = "Please use a Region bigger than 3 letters."), MaxLength(30, ErrorMessage = "Please use a Region less than 30 letters.")]
        public string Region { get; set; }

        [Required, RegularExpression(@"([Gg][Ii][Rr] 0[Aa]{2})|((([A-Za-z][0-9]{1,2})|(([A-Za-z][A-Ha-hJ-Yj-y][0-9]{1,2})|(([A-Za-z][0-9][A-Za-z])|([A-Za-z][A-Ha-hJ-Yj-y][0-9][A-Za-z]?))))\s?[0-9][A-Za-z]{2})", ErrorMessage = "Please use a valid Postal Code")]
        public string PostalCode { get; set; }
    }
}
