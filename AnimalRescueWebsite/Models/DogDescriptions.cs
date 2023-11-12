using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AnimalRescueWebsite.Models
{
    public class DogDescriptions
    {
        [ForeignKey(nameof(Dog))]
        public int DescriptionId { get; set; }

        public string Characteristics { get; set; }

        public string CoatLength { get; set; }

        public string Health { get; set; }

        public string GoodInHomeWith { get; set; }

        public double AdoptionFee { get; set; }

        public string LongDescription { get; set; }
    }
}
