using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace OrangeBricks.Web.Controllers.Property.ViewModels
{
    public class BookAppointmentViewModel
    {
        public string PropertyType { get; set; }
        public string StreetName { get; set; }
        public int PropertyId { get; set; }

        [DisplayName("Viewing Date/Time")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime ViewingDateTime { get; set; }
    }
}