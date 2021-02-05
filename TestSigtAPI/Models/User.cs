using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestSigtAPI.Models
{
    public class User 
    {
        [Key]
        public int Id { get; set; }
        public string  FirstName { get; set; }
        public string  LastName { get; set; }
        public string Age { get; set; }
        public string Mail { get; set; }
        public string Tel { get; set; }
        public string Title { get; set; }
        public int NumberOfYearsOfExperience { get; set; }
        public virtual ICollection<Experience> Experiences { get; set; }


    }
}
