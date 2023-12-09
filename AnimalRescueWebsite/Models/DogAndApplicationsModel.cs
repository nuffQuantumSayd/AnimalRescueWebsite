namespace AnimalRescueWebsite.Models
{
    /// <summary>
    /// The class that combines the dog and the applicant classes into one model
    /// </summary>
    public class DogAndApplicationsModel
    {
        /// <summary>
        /// Returns a list of dogs
        /// </summary>
        public List<Dog>? Dogs { get; set; }

        /// <summary>
        /// Returns a list of applicants
        /// </summary>
        public List<Applicant>? Applicants { get; set; } 

    }
}
