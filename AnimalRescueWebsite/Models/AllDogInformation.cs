namespace AnimalRescueWebsite.Models
{
    /// <summary>
    /// The class that combines the dog and the dog description classes into one model
    /// </summary>
    public class AllDogInformation
    {
        /// <summary>
        /// The dog's information
        /// </summary>
        public Dog Dog { get; set; }

        /// <summary>
        /// The dogs description class
        /// </summary>
        public DogDescriptions DogDescriptions { get; set; }
    }
}
