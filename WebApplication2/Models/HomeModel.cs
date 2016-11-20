using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;            //

namespace WebApplication2.Models
{
    public class HomeModel
    {
        [Required(ErrorMessage = "Name Thy Player!!!")]
        public string PlayerName { get; set; }
    }


}