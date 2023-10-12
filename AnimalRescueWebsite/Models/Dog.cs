using System.ComponentModel.DataAnnotations;
#nullable disable

namespace AnimalRescueWebsite.Models
{
    /// <summary>
    /// This class represents an adoptable dog
    /// </summary>
    public class Dog
    {
        /// <summary>
        /// The unique identifier for each dog
        /// </summary>
        [Key]
        public int DogId { get; set; }

        /// <summary>
        /// The name of the dog
        /// </summary>
        public string DogName { get; set; }

        /// <summary>
        /// The age of the dog
        /// </summary>
        [Required]
        public byte DogAge { get; set; }

        /// <summary>
        /// The size of the dog in lbs
        /// </summary>
        [Required]
        public double DogSize { get; set; }

        /// <summary>
        /// The breed of the dog
        /// </summary>
        [Required]
        public string DogBreed { get; set; }

        /// <summary>
        /// Is the dog male or female
        /// </summary>
        [Required]
        public string DogGender { get; set; }

        /// <summary>
        /// A description of the dog
        /// </summary>
        public string DogDescription { get; set; }

    }
}
