﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CrossTrainingsLab.Models
{
    public class City
    {
        [Key]
        public int CityId { get; set; }
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Please enter cityname"), MaxLength(30)]
        public string CityName { get; set; }
        public int? CountryId { get; set; }
        public virtual Country Country { get; set; }

    }
}