using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AnimalRescueWebsite.Models
{
    /// <summary>
    /// This class represents an applicant for an adoptable dog
    /// </summary>
    public class Applicant
    {
        /// <summary>
        /// The unique identifier for each application
        /// </summary>
        [Key]
        public int ApplicationId { get; set; }

        /// <summary>
        /// The first name of the applicant
        /// </summary>
        public string ApplicantFirstName { get; set; }

        /// <summary>
        /// The last name of the applicant
        /// </summary>
        public string ApplicantLastName { get; set; }

        /// <summary>
        /// The date of the application
        /// </summary>
        public DateTime DateOfApplication { get; set; }

        /// <summary>
        /// The street of the address the applicant resides in
        /// </summary>
        public string AddressStreet { get; set; }

        /// <summary>
        /// The city of the address the applicant resides in
        /// </summary>
        public string AddressCity { get; set; }

        /// <summary>
        /// The state of the address the applicant resides in
        /// </summary>
        public string AddressState { get; set; }

        /// <summary>
        /// The zip code of the address the applicant resides in
        /// </summary>        
        public string AddressZip { get; set; }

        /// <summary>
        /// The email of the applicant
        /// </summary>
        public string ApplicantEmail { get; set; }

        /// <summary>
        /// The primary phone number of the applicant 
        /// </summary>
        public string ApplicantPhone { get; set; }

        /// <summary>
        /// The occupation of the applicant
        /// </summary>
        public string ApplicantOccupation { get; set; }

        /// <summary>
        /// The number of children an applicant has
        /// </summary>
        public int NumberOfChildren { get; set; }

        [ForeignKey(nameof(Dog))]
        public virtual Dog dog { get; set; }
    }
}
