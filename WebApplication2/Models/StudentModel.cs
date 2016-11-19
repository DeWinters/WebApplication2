using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;                                      // ?
using System.Threading.Tasks;                           // ?
using System.ComponentModel.DataAnnotations;            //

namespace WebApplication2.Models
{
    public class StudentModel
    {
        [Required(ErrorMessage = "You must enter your Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "You must enter your Class")]
        public string Class { get; set; }

    }
}