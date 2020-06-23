using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Job
    {
        [Display(Name = "Id")]
        public int id { get; set; }



        [RegularExpression(@"^[A-Za-z ]+$"), Required, StringLength(30, MinimumLength = 5)]
        [Display(Name = "Job Title")]
        public string titulo { get; set; }


        [StringLength(80, MinimumLength = 5), Required]
        [Display(Name = "Description")]
        public string Descripcion { get; set; }


        //[Range(typeof(DateTime), "1/1/1966", "1/10/2020")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}")]
        [Display(Name = "Created At"), DataType(DataType.Date)]
        public DateTime FechaF { get; set; }


        //[Range(typeof(DateTime), "1/1/1966", "1/10/2020")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}")]
        [Display(Name = "Expires At"), DataType(DataType.Date)]
        public DateTime Fechai { get; set; }
    }
}
