using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WeflyAPI.Models
{
    public class clsFlightRoute : BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("routeId")]
        public override string Id { get; set; }
        public string fromCityCode { get; set; }
        public string fromCityName { get; set; }
        public string toCityCode { get; set; }
        public string toCityName { get; set; }
    }
}
