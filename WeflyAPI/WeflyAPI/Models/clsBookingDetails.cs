using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WeflyAPI.Models
{
    public class clsBookingDetails:BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("customerId")]
        public override string Id { get; set; }

        [Required(ErrorMessage = "First Name is required.")]
        [DataType(dataType:DataType.Text)]
        public string firstName { get; set; }

        [Required(ErrorMessage = "Last Name is required.")]
        [DataType(dataType: DataType.Text)]
        public string laststName { get; set; }

        [Required(ErrorMessage = "Email ID is required.")]
        [DataType(dataType: DataType.EmailAddress)]
        public string emailId { get; set; }

        [Required(ErrorMessage = "PhoneNumber is required.")]
        [DataType(dataType: DataType.PhoneNumber)]
        public Int64 mobileNo { get; set; }

        [Required(ErrorMessage = "Address is required.")]
        [DataType(dataType: DataType.Text)]
        public string address { get; set; }

        [Required(ErrorMessage = "State is required.")]
        [DataType(dataType: DataType.Text)]
        public string state { get; set; }

        [Required(ErrorMessage = "City is required.")]
        [DataType(dataType: DataType.Text)]
        public string city { get; set; }

        [Required(ErrorMessage = "PinCode is required.")]
        [DataType(dataType: DataType.Text)]
        public string pinCode { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DataType(dataType: DataType.Text)]
        public int paymentId { get; set; }

        [Required(ErrorMessage = "Route ID is required.")]
        [DataType(dataType: DataType.Text)]
        public string routeId { get; set; }

        [Required(ErrorMessage = "Schedule ID is required.")]
        [DataType(dataType: DataType.Text)]
        public string scheduleId { get; set; }

        [Required(ErrorMessage = "Plane ID is required.")]
        [DataType(dataType: DataType.Text)]
        public string planeId { get; set; }

        [Required(ErrorMessage = "Ticket Price is required.")]
        [DataType(dataType: DataType.Text)]
        public long ticketPrice { get; set; }

        [Required(ErrorMessage = "Number of Seats bookd is required.")]
        [DataType(dataType: DataType.Text)]
        public int noSeatsBooked { get; set; }

        [Required(ErrorMessage = "Journey Time is required.")]
        [DataType(dataType: DataType.DateTime)]
        public DateTime journeyTime { get; set; }

        [Required(ErrorMessage = "Card Number is required.")]
        [DataType(dataType: DataType.Text)]
        public string cardNumber { get; set; }
    }
}
