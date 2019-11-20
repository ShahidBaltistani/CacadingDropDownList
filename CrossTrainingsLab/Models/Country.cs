using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CrossTrainingsLab.Models
{
    public class Country
    {
        [Key]
        public int CountryId { get; set; }
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Please enter countryname"), MaxLength(30)]
        public string CountryName { get; set; }
        public virtual List<City> Cities { get; set; }

    }
}