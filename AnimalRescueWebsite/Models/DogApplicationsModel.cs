using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AnimalRescueWebsite.Models
{
    public class DogApplicationsModel
    {
        [Key]
        public int DogApplicationId { get; set; }

        [ForeignKey(nameof(Dog))]
        public virtual Dog DogKey { get; set; }

        [ForeignKey(nameof(Applicant))]
        public virtual Applicant ApplicantKey { get; set; } 
    }
}
