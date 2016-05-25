using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace OneCityProject.Models
{
    public class User
    {
		[Key]
        public int ID { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }

        public string Permission { get; set; }

        public string Location { get; set; }

    }
}