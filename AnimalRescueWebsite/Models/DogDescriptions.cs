using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AnimalRescueWebsite.Models
{
    public class DogDescriptions
    {
        [Key]
        public int DescriptionId { get; set; }

        [ForeignKey(nameof(Dog))]
        [Display(Name = "Dog ID")]
        public int DogId { get; set; }

        public string Characteristics { get; set; }

        public string CoatLength { get; set; }

        public string Health { get; set; }

        public string GoodInHomeWith { get; set; }

        public double AdoptionFee { get; set; }

        public string LongDescription { get; set; }
    }
}
