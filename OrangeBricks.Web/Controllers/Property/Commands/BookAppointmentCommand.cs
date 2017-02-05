using System;

namespace OrangeBricks.Web.Controllers.Property.Commands
{
    public class BookAppointmentCommand
    {
        public int PropertyId { get; set; }

        public DateTime ViewingDateTime { get; set; }

        public string BuyerId { get; set; }
    }
}