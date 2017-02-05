using System;
using System.ComponentModel.DataAnnotations;

namespace OrangeBricks.Web.Models
{
    public class BookAppointment
    {
        [Key]
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime BookAppointmentDate { get; set; }
        public string BuyerId { get; set; }
        public int PropertyId { get; set; }
        public bool Accepted { get; set; }

    }
}