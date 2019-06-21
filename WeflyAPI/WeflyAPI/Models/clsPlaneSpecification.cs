using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WeflyAPI.Models
{
    public class clsPlaneSpecification : BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("planeId")]
        public override string Id { get; set; }
        public string planeManufacturer { get; set; }
        public string planeModel { get; set; }
        public int seats { get; set; }
        public long legSpace { get; set; }
        public bool isWifiAvailable { get; set; }
        public bool isFlightEntertainmentAvailable { get; set; }
    }
}
