using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestSigtAPI.Models
{
    public class Experience
    {
        [Key]
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string DateOfDeparture { get; set; }
        public string EndDate { get; set; }
        public string Post { get; set; }
        public string NameProject { get; set; }
        public string DescriptionProject { get; set; }
        public int UserId { get; set; }




    }
}
