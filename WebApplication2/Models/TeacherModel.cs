using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;                                      // ?
using System.Threading.Tasks;                           // ?
using System.ComponentModel.DataAnnotations;            //

namespace WebApplication2.Models
{
    public class TeacherModel
    {
        [Required(ErrorMessage = "You must enter Teacher Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "You must enter Teacher Department")]
        public string Class { get; set; }
    }
}