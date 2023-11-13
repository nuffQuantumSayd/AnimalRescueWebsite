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

        [Display(Name = "Coat Length")]
        public string CoatLength { get; set; }

        public string Health { get; set; }

        [Display(Name = "Good In A Home With")]
        public string GoodInHomeWith { get; set; }

        [Display(Name = "Adoption Fee")]
        public double AdoptionFee { get; set; }

        [Display(Name ="Meet")]
        public string LongDescription { get; set; }
    }
}
