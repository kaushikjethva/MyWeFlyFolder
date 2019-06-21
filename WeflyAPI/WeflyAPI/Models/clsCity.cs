using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WeflyAPI.Repository;

namespace WeflyAPI.Models
{
    public class clsCity : BaseEntity
    {
      
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("cityCode")]
        public override string Id { get; set; }

        [Required(ErrorMessage ="CityName is required.")]
        public string CityName { get; set; }

        [Required(ErrorMessage = "AirportName is required.")]
        public string AirportName { get; set; }

        [Required(ErrorMessage = "AirportCode is required.")]
        public string AirportCode { get; set; }

        public string Longitude { get; set; }

        public string Lattitude { get; set; }
        
    }
}
