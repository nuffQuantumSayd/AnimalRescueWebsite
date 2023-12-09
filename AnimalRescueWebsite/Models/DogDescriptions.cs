using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AnimalRescueWebsite.Models
{
    /// <summary>
    /// This class represents a more in depth description of a dog
    /// </summary>
    public class DogDescriptions
    {
        /// <summary>
        /// The unique identifier for each description
        /// </summary>
        [Key]
        public int DescriptionId { get; set; }

        /// <summary>
        /// The dog that the description belongs to
        /// </summary>
        [ForeignKey(nameof(Dog))]
        [Display(Name = "Dog ID")]
        public int DogId { get; set; }

        /// <summary>
        /// The characteristics of the dog
        /// </summary>
        public string Characteristics { get; set; }

        /// <summary>
        /// The dogs coat length
        /// </summary>
        [Display(Name = "Coat Length")]
        public string CoatLength { get; set; }

        /// <summary>
        /// The overall health of the dog
        /// </summary>
        public string Health { get; set; }

        /// <summary>
        /// The dogs housetraining status
        /// </summary>
        [Display(Name = "Good In A Home With")]
        public string GoodInHomeWith { get; set; }

        /// <summary>
        /// The adoption fee for the dog
        /// </summary>
        [Display(Name = "Adoption Fee")]
        public double AdoptionFee { get; set; }

        /// <summary>
        /// The long description of the dog
        /// </summary>
        [Display(Name ="Meet")]
        public string LongDescription { get; set; }
    }
}
