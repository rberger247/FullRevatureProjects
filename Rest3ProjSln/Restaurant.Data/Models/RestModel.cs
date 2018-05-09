using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Data.Models
{
    public class RestModel
    {

        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(25, ErrorMessage = "Restaurant Name must be less than 25 charachters")]
        [Display(Name = "Restaraunt Name")]
        public string Name { get; set; }
        public string Street1 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string phone { get; set; }
        [DataType(DataType.PostalCode)]

        public string Zipcode { get; set; }




        public virtual ICollection<Review> reviews { get; set; }

        //    [NotMapped]
        public int? AvgRating { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? Created
        {
            get
            {
                return this.Created.HasValue
                 ? this.Created.Value
                  : DateTime.Now;
            }
            set { this.Created = value; }
        }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? Modified { get; set; }

    }
}
