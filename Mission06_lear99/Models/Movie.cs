using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission06_lear99.Models
{
    //this is the model that is used to build the database and temporarily store information as it's being moved into the database
    public class Movie
    {
        //each of the variables are error checked at this point
        [Key]
        [Required]
        public int MovieID { get; set; }
        
        
        
        [Required]
        public string Title { get; set; }

        [Required]
        public int Year { get; set; }

        [Required]
        public string Director { get; set; }

        [Required]
        public string Rating { get; set; }

        public bool Edited { get; set; }

        public string LentTo { get; set; }
        public string Notes { get; set; }


        //build foreign key
        public int CategoryID { get; set; }
        public Category Category { get; set; }
    }
}
