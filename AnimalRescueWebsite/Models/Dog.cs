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
        [Display(Name = "Dog ID")]
        public int DogId { get; set; }

        /// <summary>
        /// The name of the dog
        /// </summary>
        [Display(Name = "Name")]
        public string DogName { get; set; }

        /// <summary>
        /// The age of the dog
        /// </summary>
        [Required]
        [Display(Name = "Age")]
        public byte DogAge { get; set; }

        /// <summary>
        /// The size of the dog in lbs
        /// </summary>
        [Required]
        [Display(Name = "Weight (lbs)")]
        public double DogSize { get; set; }

        /// <summary>
        /// The breed of the dog
        /// </summary>
        [Required]
        [Display(Name = "Breed")]
        public string DogBreed { get; set; }

        /// <summary>
        /// Is the dog male or female
        /// </summary>
        [Required]
        [Display(Name = "Gender")]
        public string DogGender { get; set; }

        /// <summary>
        /// A description of the dog
        /// </summary>
        [Display(Name = "Description")]
        public string DogDescription { get; set; }

    }
}
