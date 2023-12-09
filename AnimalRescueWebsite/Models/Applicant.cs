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
        [Display(Name = "Applicantion ID")]
        public int ApplicantId { get; set; }

        /// <summary>
        /// The first name of the applicant
        /// </summary>
        [Display(Name = "First Name")]
        public string ApplicantFirstName { get; set; }

        /// <summary>
        /// The last name of the applicant
        /// </summary>
        [Display(Name = "Last Name")]
        public string ApplicantLastName { get; set; }

        /// <summary>
        /// The date of the application
        /// </summary>
        [Display(Name = "Date of Application")]
        public DateTime DateOfApplication { get; set; }

        /// <summary>
        /// The street of the address the applicant resides in
        /// </summary>
        [Display(Name = "Street")]
        public string AddressStreet { get; set; }

        /// <summary>
        /// The city of the address the applicant resides in
        /// </summary>
        [Display(Name = "City")]
        public string AddressCity { get; set; }

        /// <summary>
        /// The state of the address the applicant resides in
        /// </summary>
        [Display(Name = "State")]
        public string AddressState { get; set; }

        /// <summary>
        /// The zip code of the address the applicant resides in
        /// </summary>        
        [Display(Name = "Zip Code")]
        public string AddressZip { get; set; }

        /// <summary>
        /// The email of the applicant
        /// </summary>
        [Display(Name = "Email")]
        public string ApplicantEmail { get; set; }

        /// <summary>
        /// The primary phone number of the applicant 
        /// </summary>
        [Display(Name = "Phone Number")]
        public string ApplicantPhone { get; set; }

        /// <summary>
        /// The occupation of the applicant
        /// </summary>
        [Display(Name = "Occupation")]
        public string ApplicantOccupation { get; set; }

        /// <summary>
        /// The number of children an applicant has
        /// </summary>
        [Display(Name = "Number of Children")]
        public int NumberOfChildren { get; set; }

        /// <summary>
        /// The dog id of the dog the applicant is applying for
        /// </summary>
        [ForeignKey(nameof(Dog))]
        [Display(Name = "Dog Id")]
        public int dog { get; set; }
    }
}
